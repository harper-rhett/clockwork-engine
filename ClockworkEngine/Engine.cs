using Clockwork.Graphics;
using Clockwork.Utilities;
using Clockwork.Windowing;
using Clockwork.Audio;
using Clockwork.Raylib.Graphics;
using System.Runtime.InteropServices;

namespace Clockwork;

public static class Engine
{
	// Input
	private static Game game;

	// General
	private static RenderTexture gameRenderTexture;
	public static IGraphicsBackend Graphics = new RaylibGraphicsBackend();

	// Game size
	public static Coordinate GameSize
	{
		get => new(GameWidth, GameHeight);
		set
		{
			GameWidth = value.X;
			GameHeight = value.Y;
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

	// Extra
	public static float FrameTime {  get; private set; }
	private static bool takeScreenshot;
	private static string screenshotFolderPath;
	public static bool IsScreenshotBursting { get; private set; }
	private static string screenshotBurstFolderPath;
	private static int screenshotBurstIndex;

	// Intialization is a separate step from "starting" because the game may require Engine initialization in its constructor
	public static void Initialize(string windowTitle, int gameWidth, int gameHeight)
	{
		// Create crash handler
		AppDomain.CurrentDomain.UnhandledException += HandleCrash;

		// Initialize window
		Window.Initialize(800, 800, windowTitle);
		TargetFPS = 60;

		// Initialize game
		AudioDevice.Initialize();
		GameSize = new(gameWidth, gameHeight);
	}

	private static void HandleCrash(object sender, UnhandledExceptionEventArgs arguments)
	{
		File.WriteAllText("crash-log.txt", arguments.ExceptionObject.ToString());
	}

	public static void Start(Game game)
	{
		// Initialization
		Engine.game = game;

		// Game loop
		while (!Window.ShouldClose())
		{
			MasterUpdate();
			MasterDraw();
		}
	}

	private static void MasterUpdate()
	{
		FrameTime = GetFrameTime();
		if (FrameTime > 0.1f) FrameTime = 0.1f;
		game.OnUpdate();
		Window.Renderer.Update(gameRenderTexture);
	}

	private static void MasterDraw()
	{
		RenderTexture.BeginDrawing(gameRenderTexture);
		game.OnDraw();
		RenderTexture.EndDrawing();

		if (takeScreenshot) TakeScreenshot();
		if (IsScreenshotBursting) BurstScreenshot();

		Drawing.Begin();
		Window.Renderer.Draw(gameRenderTexture);
		Drawing.End();
	}

	public static void DrawDebug(int fontSize, int spacing)
	{
		Text.Draw(FPS.ToString(), spacing, spacing, fontSize, Colors.White);
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

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFrameTime")]
	private static extern float GetFrameTime();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTargetFPS")]
	private static extern void SetTargetFPS(int fps);
	public static int TargetFPS { set => SetTargetFPS(value); }

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFPS")]
	private static extern float GetFPS();
	public static float FPS => GetFPS();

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
