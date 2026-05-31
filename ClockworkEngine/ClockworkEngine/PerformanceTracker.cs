using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Clockwork;

public class PerformanceTracker
{
	private Stopwatch stopwatch = new();
	private Queue<float> millisecondsTracked = new();

	public void Start()
	{
		stopwatch.Restart();
	}

	public void Stop()
	{
		stopwatch.Stop();
		millisecondsTracked.Enqueue(stopwatch.ElapsedMilliseconds);
		if (millisecondsTracked.Count > Profiler.FramesTracked) millisecondsTracked.Dequeue();
	}

	public float GetAverageTime()
	{
		return millisecondsTracked.Average();
	}
}
