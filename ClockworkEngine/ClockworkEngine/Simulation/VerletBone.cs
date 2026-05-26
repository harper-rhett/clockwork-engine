using Clockwork.Graphics;
using Clockwork.Utilities;
using System.Numerics;
using Clockwork.Shapes;

namespace Clockwork.Simulation;

public class VerletBone : LineShape
{
	// Connections
	public VerletJoint FirstJoint { get; private set; }
	public VerletJoint SecondJoint { get; private set; }
	public override Vector2 StartPosition
	{
		get => FirstJoint.Transform.WorldPosition;
		protected set => FirstJoint.Transform.WorldPosition = value;
	}
	public override Vector2 EndPosition
	{
		get => SecondJoint.Transform.WorldPosition;
		protected set => SecondJoint.Transform.WorldPosition = value;
	}

	// General
	private float desiredLength;
	public float DesiredLength
	{
		get => desiredLength;
		private set
		{
			desiredLength = value;
			HalfDesiredLength = value / 2f;
		}
	}
	public float HalfDesiredLength;
	public Vector2 CenterPosition => VectorExtensions.Averaged(StartPosition, EndPosition);
	private float tolerance;

	public VerletBone(VerletJoint firstJoint, VerletJoint secondJoint, float tolerance, float thickness, Color color) : base(thickness, color)
	{
		FirstJoint = firstJoint;
		SecondJoint = secondJoint;
		DesiredLength = (EndPosition - StartPosition).Length();
		this.tolerance = tolerance;
	}

	public void Tighten()
	{
		// Check if need to tighten
		Vector2 difference = EndPosition - StartPosition;
		if (float.Abs(DesiredLength - difference.Length()) < tolerance) return;

		// Update desired positions
		Vector2 direction = Vector2.Normalize(difference);
		Vector2 centerPosition = CenterPosition;
		Vector2 desiredStartPosition = centerPosition - direction * HalfDesiredLength;
		Vector2 desiredEndPosition = centerPosition + direction * HalfDesiredLength;

		// Apply
		StartPosition = VectorExtensions.Averaged(StartPosition, desiredStartPosition);
		EndPosition = VectorExtensions.Averaged(EndPosition, desiredEndPosition);
	}
}
