using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Graphics.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Clockwork.Graphs;

public class ScatterPlot : Entity, ICollection<Vector2>
{
	// General
	public Vector2 Position = Vector2.Zero;
	public float PointRadius = 5;
	public int FontSize = 25;

	// Size
	private int width;
	public int Width
	{
		get => width;
		set
		{
			width = value;
			renderTexture = RenderTexture.Load(width, height);
			shouldUpdate = true;
		}
	}
	private int height;
	public int Height
	{
		get => height;
		set
		{
			height = value;
			renderTexture = RenderTexture.Load(width, height);
			shouldUpdate = true;
		}
	}
	private string horizontalAxisName;
	private string verticalAxisName;

	// Points
	private List<Vector2> points = new();
	public float MinXPoint { get; private set; }
	public float MaxXPoint { get; private set; }
	public float HorizontalRange { get; private set; }
	public float MinYPoint { get; private set; }
	public float MaxYPoint { get; private set; }
	public float VerticalRange { get; private set; }

	// Rendering
	private RenderTexture renderTexture;
	private Rectangle sourceRectangle;
	private bool shouldUpdate = false;

	public ScatterPlot(string horizontalAxisName, string verticalAxisName)
	{
		this.horizontalAxisName = horizontalAxisName;
		this.verticalAxisName = verticalAxisName;
		width = Engine.GameWidth;
		height = Engine.GameHeight;
		renderTexture = RenderTexture.Load(width, height);
		shouldUpdate = true;
	}

	public int Count => points.Count;
	public bool IsReadOnly => false;
	public bool Contains(Vector2 point) => points.Contains(point);
	public void CopyTo(Vector2[] array, int arrayIndex) => points.CopyTo(array, arrayIndex);
	public IEnumerator<Vector2> GetEnumerator() => points.GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public void Add(Vector2 point)
	{
		if (points.Count > 0)
		{
			// Update X bounds
			if (point.X > MaxXPoint)
			{
				MaxXPoint = point.X;
				UpdateHorizontalRange();
			}
			else if (point.X < MinXPoint)
			{
				MinXPoint = point.X;
				UpdateHorizontalRange();
			}

			// Update Y bounds
			if (point.Y > MaxYPoint)
			{
				MaxYPoint = point.Y;
				UpdateVerticalRange();
			}
			else if (point.Y < MinYPoint)
			{
				MinYPoint = point.Y;
				UpdateVerticalRange();
			}
		}
		else
		{
			MinXPoint = point.X; MaxXPoint = point.X; MinYPoint = point.Y; MaxYPoint = point.Y;
			UpdateHorizontalRange();
			UpdateVerticalRange();
		}

		points.Add(point);
		shouldUpdate = true;
	}

	public void Clear()
	{
		points.Clear();
		ResetBounds();
		shouldUpdate = true;
	}

	public bool Remove(Vector2 point)
	{
		bool doesExist = points.Remove(point);
		if (doesExist)
		{
			if (points.Count == 0)
			{
				ResetBounds();
				shouldUpdate = true;
				return true;
			}

			if (point.X == MinXPoint)
			{
				MinXPoint = points.Min(pointCandidate => pointCandidate.X);
				UpdateHorizontalRange();
			}
			if (point.X == MaxXPoint)
			{
				MaxXPoint = points.Max(pointCandidate => pointCandidate.X);
				UpdateHorizontalRange();
			}
			if (point.Y == MinYPoint)
			{
				MinYPoint = points.Min(pointCandidate => pointCandidate.Y);
				UpdateVerticalRange();
			}
			if (point.Y == MaxYPoint)
			{
				MaxYPoint = points.Max(pointCandidate => pointCandidate.Y);
				UpdateVerticalRange();
			}

			shouldUpdate = true;
			return true;
		}
		else return false;
	}

	private void UpdateHorizontalRange()
	{
		HorizontalRange = MaxXPoint - MinXPoint;
	}

	private void UpdateVerticalRange()
	{
		VerticalRange = MaxYPoint - MinYPoint;
	}

	private void ResetBounds()
	{
		MinXPoint = 0; MaxXPoint = 0; MinYPoint = 0; MaxYPoint = 0;
		HorizontalRange = 0; VerticalRange = 0;
	}

	public override void OnUpdate()
	{
		if (shouldUpdate) Update();
	}

	// NOTE: Re-renders the entire graph when it really just has to re-render the points that have changed
	private void Update()
	{
		RenderTexture.BeginDrawing(renderTexture);
		Drawing.Clear(Colors.Black);

		foreach (Vector2 point in points)
		{
			float xNormal = (point.X - MinXPoint) / HorizontalRange;
			float yNormal = (point.Y - MinYPoint) / VerticalRange;
			float xPlot = xNormal * width;
			float yPlot = yNormal * height;
			Primitives2D.DrawCircle(new Vector2(xPlot, yPlot), PointRadius, Colors.SkyBlue);
		}

		float fontSpacing = FontSize / 10f;

		Vector2 horizontalNameSize = Text.MeasureSize(Font.Default, horizontalAxisName, FontSize, fontSpacing);
		float horizontalX = Position.X + width / 2f - horizontalNameSize.X / 2f;
		float horizontalY = Position.Y + height - horizontalNameSize.Y * 2;
		Text.Draw(horizontalAxisName, new(horizontalX, horizontalY), FontSize, Colors.White);

		Vector2 verticalNameSize = Text.MeasureSize(Font.Default, verticalAxisName, FontSize, 0);
		float verticalX = Position.X + verticalNameSize.Y;
		float verticalY = Position.Y + height / 2f + verticalNameSize.X / 2f;
		Text.Draw(Font.Default, verticalAxisName, new(verticalX, verticalY), Vector2.Zero, -90, FontSize, fontSpacing, Colors.White);

		RenderTexture.EndDrawing();

		sourceRectangle = new(Vector2.Zero, width, -height);
		shouldUpdate = false;
	}

	public override void OnDraw()
	{
		renderTexture.Texture.Draw(sourceRectangle, Position, Colors.White);
	}
}
