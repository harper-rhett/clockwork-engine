global using HarpEngine.Animation;
global using HarpEngine.Graphics;
global using HarpEngine.Utilities;
global using HarpEngine.Windowing;
global using HarpEngine.Audio;
global using HarpEngine.Input;
global using HarpEngine.Shapes;
global using HarpEngine.Tiles;
global using System.Numerics;
global using System.Runtime.InteropServices;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;

	// General
	private static RenderTexture gameRenderTexture;

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

	// Intialization is a separate step from "starting" because the game may require Engine initialization in its constructor
	public static void Initialize(string windowTitle, int gameWidth, int gameHeight)
	{
		// Initialize window
		Window.Initialize(800, 800, windowTitle);

		// Initialize game
		AudioDevice.Initialize();
		GameSize = new(gameWidth, gameHeight);
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

		Drawing.Begin();
		Window.Renderer.Draw(gameRenderTexture);
		Drawing.End();
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFrameTime")]
	private static extern float GetFrameTime();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTargetFPS")]
	public static extern void SetTargetFPS(int fps);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TakeScreenshot")]
	public static extern void TakeScreenshot(string fileName);
}
