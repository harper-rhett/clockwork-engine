namespace Clockwork.Utilities;

public record struct Coordinate
{
	public int X;
	public int Y;

	public Coordinate(int x, int y)
	{
		X = x;
		Y = y;
	}
}
