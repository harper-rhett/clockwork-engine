using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Clockwork;

public class PerformanceTracker
{
	private Stopwatch stopwatch = new();
	private Queue<float> millisecondsTracked = new();
	public static int FramesTracked = 600;

	private bool isActive = true;
	public bool IsActive
	{
		get => isActive;
		set
		{
			isActive = value;
			if (!isActive)
			{
				millisecondsTracked.Clear();
				stopwatch.Reset();
			}
		}
	}

	public void StartOrResume()
	{
		if (!isActive) return;
		stopwatch.Start();
	}

	public void Pause()
	{
		if (!isActive) return;
		stopwatch.Stop();
	}

	public void Finish()
	{
		if (!isActive) return;
		stopwatch.Stop();
		millisecondsTracked.Enqueue(stopwatch.ElapsedMilliseconds);
		if (millisecondsTracked.Count > FramesTracked) millisecondsTracked.Dequeue();
		stopwatch.Reset();
	}

	public float GetAverageTime()
	{
		return millisecondsTracked.Count == 0 ? 0 : millisecondsTracked.Average();
	}
}
