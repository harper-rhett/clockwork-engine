using Clockwork.Graphics;
using Clockwork.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork;

public static class Profiler
{
	private static Dictionary<string, PerformanceTracker> trackers = new();
	public static int FramesTracked = 300;

	public static void StartTracking(string key)
	{
		if (trackers.TryGetValue(key, out PerformanceTracker tracker)) tracker.Start();
		else
		{
			PerformanceTracker newTracker = new();
			newTracker.Start();
			trackers[key] = newTracker;
		}
	}

	public static void StopTracking(string key)
	{
		if (trackers.TryGetValue(key, out PerformanceTracker tracker)) tracker.Stop();
		else throw new InvalidOperationException("Must start tracking first.");
	}

	public static void DrawDebug(int fontSize, Color color)
	{
		string[] logs = trackers.Keys.Select(valueName => $"{valueName}: {trackers[valueName].GetAverageTime():F2}ms").ToArray();
		Text.DrawDebug(fontSize, color, logs);
	}
}
