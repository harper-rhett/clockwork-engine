using Clockwork.Graphics;
using Clockwork.Windowing;
using Clockwork.Audio;
using System.Runtime.InteropServices;
using Clockwork.Graphics.Text;
using System.Collections.Generic;
using System;
using System.IO;
using System.Numerics;
using Clockwork.Input;

namespace Clockwork;

public static class Engine
{
	// Input
	private static Game game;

	// General
	private static RenderTexture gameRenderTexture;
	public static float GlobalFrameTime {  get; private set; }
	private static bool isInitialized;
	internal const string raylibLibraryName = "raylib";

	// Game size
	public static Vector2 GameSize
	{
		get => new(GameWidth, GameHeight);
		set
		{
			GameWidth = (int)value.X;
			GameHeight = (int)value.Y;
			HalfGameWidth = GameWidth / 2;
			HalfGameHeight = GameHeight / 2;
			if (gameRenderTexture.IsValid) gameRenderTexture.Dispose();
			gameRenderTexture = RenderTexture.Load(GameWidth, GameHeight);
			GameResized?.Invoke(GameWidth, GameHeight);
		}
	}
	public static int GameWidth { get; private set; }
	public static int GameHeight { get; private set; }
	public static int HalfGameWidth { get; private set; }
	public static int HalfGameHeight { get; private set; }
	public static bool ScreenshotCommands;
	public delegate void OnResized(int width, int height);
	public static event OnResized GameResized;

	// Screen shots
	private static bool takeScreenshot;
	private static string screenshotFolderPath;
	public static bool IsScreenshotBursting { get; private set; }
	private static string screenshotBurstFolderPath;
	private static int screenshotBurstIndex;

	static Engine()
	{
		// Create crash handler
		AppDomain.CurrentDomain.UnhandledException += HandleCrash;
		TargetFPS = 60;
	}

	// Intialization is a separate step from "starting" because the game may require Engine initialization in its constructor
	public static void Initialize(string windowTitle, int gameWidth, int gameHeight)
	{
		// Initialize window
		Window.Initialize(gameWidth, gameHeight, windowTitle);

		// Initialize game
		AudioDevice.Initialize();
		GameSize = new(gameWidth, gameHeight);
		isInitialized = true;
	}

	private static void HandleCrash(object sender, UnhandledExceptionEventArgs arguments)
	{
		File.WriteAllText("crash-log.txt", arguments.ExceptionObject.ToString());
	}

	public static void Start(Game game)
	{
		if (!isInitialized) throw new Exception("Initialize must be called before Start.");
		Engine.game = game;
		while (!Window.ShouldClose()) MasterLoop();
		Window.Close();
		AudioDevice.Close();
		isInitialized = false;
	}

	public static void Start(Scene scene)
	{
		Start(new SimpleGame(scene));
	}

	public static void Start(IEnumerable<Entity> entities)
	{
		Start(new Scene(entities));
	}

	private static void MasterLoop()
	{
		MasterUpdate();
		MasterDraw();
	}

	private static void MasterUpdate()
	{
		if (Profiler.TrackUpdateLoop) Profiler.StartOrResumeTracking("update");

		GlobalFrameTime = GetFrameTime();
		if (GlobalFrameTime > 0.1f) GlobalFrameTime = 0.1f;
		game.OnUpdate();
		WindowRenderer.Current.Update(gameRenderTexture);

		if (Profiler.TrackUpdateLoop) Profiler.FinishTracking("update");
	}

	private static void MasterDraw()
	{
		if (Profiler.TrackDrawLoop) Profiler.StartOrResumeTracking("draw & frame-sleep");

		Window.PollResized();
		RenderTexture.BeginDrawing(gameRenderTexture);
		game.OnDraw();
		RenderTexture.EndDrawing();

		if (ScreenshotCommands)
		{
			if (Keyboard.IsKeyPressed(KeyboardKey.Equal)) TakeScreenshot("screenshots");
			else if (Keyboard.IsKeyPressed(KeyboardKey.LeftBracket)) StartScreenshotBurst("burst-screenshots");
			else if (Keyboard.IsKeyPressed(KeyboardKey.RightBracket)) StopScreenshotBurst();
		}
		if (takeScreenshot) TakeScreenshot();
		if (IsScreenshotBursting) BurstScreenshot();

		Drawing.Begin();
		WindowRenderer.Current.Draw(gameRenderTexture);
		game.OnDrawGUI();
		Drawing.End();

		// Note: Instead of tracking frame sleep, we could remove Raylib's sleep implementation
		// and replace it with our own. For instance, we would calculate frame time from TargetFPS
		// and add our own frame sleeping after all update loops are complete.

		// This way profiling draw time would be much simpler.

		if (Profiler.TrackDrawLoop) Profiler.FinishTracking("draw & frame-sleep");
	}

	public static void DrawDebug(int fontSize, Color color, params string[] extraLogs)
	{
		string[] defaultLogs = [ $"{ActualFPS} FPS" ];
		string[] combinedLogs = new string[defaultLogs.Length + extraLogs.Length];
		Array.Copy(defaultLogs, combinedLogs, defaultLogs.Length);
		Array.Copy(extraLogs, 0, combinedLogs, defaultLogs.Length, extraLogs.Length);
		Text.DrawDebug(fontSize, color, combinedLogs);
	}

	private static void TakeScreenshot()
	{
		Image gameImage = Image.Load(gameRenderTexture.Texture);
		gameImage.FlipVertical();
		string fileName = $"{DateTime.Now.ToString("yy-MM-dd_HH-mm-ss")}.png";
		string filePath = Path.Combine(screenshotFolderPath, fileName);
		gameImage.Export(filePath, out bool success);
		gameImage.Dispose();
		takeScreenshot = false;
	}

	private static void BurstScreenshot()
	{
		Image gameImage = Image.Load(gameRenderTexture.Texture);
		gameImage.FlipVertical();
		string fileName = $"burst-{screenshotBurstIndex:D5}.png";
		string filePath = Path.Combine(screenshotBurstFolderPath, fileName);
		gameImage.Export(filePath, out bool success);
		gameImage.Dispose();
		screenshotBurstIndex++;
	}

	[DllImport(raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFrameTime")]
	private static extern float GetFrameTime();

	[DllImport(raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTargetFPS")]
	private static extern void SetTargetFPS(int fps);
	public static int TargetFPS { set => SetTargetFPS(value); }

	[DllImport(raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFPS")]
	private static extern float GetFPS();
	public static float ActualFPS => GetFPS();

	public static void TakeScreenshot(string folderPath)
	{
		screenshotFolderPath = folderPath;
		Directory.CreateDirectory(folderPath);
		takeScreenshot = true;
	}

	public static void StartScreenshotBurst(string folderPath)
	{
		screenshotBurstFolderPath = folderPath;
		Directory.CreateDirectory(folderPath);
		screenshotBurstIndex = 0;
		IsScreenshotBursting = true;
	}

	public static void StopScreenshotBurst()
	{
		screenshotBurstFolderPath = null;
		IsScreenshotBursting = false;
	}

	[DllImport(raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsFileDropped")]
	private static extern bool IsItemPathDropped();
	public static bool ItemPathDropped => IsItemPathDropped();

	[DllImport(raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadDroppedFiles")]
	private static extern ItemPathList LoadDroppedItemPaths();
	public static string[] GetDroppedItemPaths()
	{
		ItemPathList itemPaths = LoadDroppedItemPaths();
		return itemPaths.ToArray();
	}
}
