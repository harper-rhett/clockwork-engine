using Clockwork.Graphics;
using Clockwork.Utilities;
using Clockwork.Windowing;
using Clockwork.Audio;
using System.Runtime.InteropServices;
using Clockwork.Graphics.Text;
using System.Collections.Generic;
using System;
using System.IO;
using System.Numerics;
using System.Diagnostics;

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
		}
	}
	public static int GameWidth { get; private set; }
	public static int GameHeight { get; private set; }
	public static int HalfGameWidth { get; private set; }
	public static int HalfGameHeight { get; private set; }

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
		GlobalFrameTime = GetFrameTime();
		if (GlobalFrameTime > 0.1f) GlobalFrameTime = 0.1f;
		game.OnUpdate();
		WindowRenderer.Current.Update(gameRenderTexture);
	}

	private static void MasterDraw()
	{
		RenderTexture.BeginDrawing(gameRenderTexture);
		game.OnDraw();
		RenderTexture.EndDrawing();

		if (takeScreenshot) TakeScreenshot();
		if (IsScreenshotBursting) BurstScreenshot();

		Drawing.Begin();
		WindowRenderer.Current.Draw(gameRenderTexture);
		game.OnDrawGUI();
		Drawing.End();
	}

	public static void DrawDebug(int fontSize, int spacing)
	{
		Text.Draw($"{ActualFPS} FPS", spacing, spacing, fontSize, Colors.White);
	}

	private static void TakeScreenshot()
	{
		Image gameImage = Image.Load(gameRenderTexture.Texture);
		string fileName = $"{DateTime.Now.ToString("yy-MM-dd_HH-mm-ss")}.png";
		string filePath = Path.Combine(screenshotFolderPath, fileName);
		gameImage.Export(filePath, out bool success);
		takeScreenshot = false;
	}

	private static void BurstScreenshot()
	{
		Image gameImage = Image.Load(gameRenderTexture.Texture);
		string fileName = $"burst-{screenshotBurstIndex.ToString("D5")}.png";
		string filePath = Path.Combine(screenshotBurstFolderPath, fileName);
		gameImage.Export(filePath, out bool success);
		screenshotBurstIndex++;
	}

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFrameTime")]
	private static extern float GetFrameTime();

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTargetFPS")]
	private static extern void SetTargetFPS(int fps);
	public static int TargetFPS { set => SetTargetFPS(value); }

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFPS")]
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
}
