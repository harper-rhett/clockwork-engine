using Clockwork.Graphics;
using Clockwork.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork;

public static class Profiler
{
	private static Dictionary<string, PerformanceTracker> trackers = new();
	private static bool isActive = true;
	public static bool IsActive
	{
		get => isActive;
		set
		{
			isActive = value;
			foreach (PerformanceTracker tracker in trackers.Values) tracker.IsActive = isActive;
		}
	}
	public static bool TrackUpdateLoop;
	public static bool TrackDrawLoop;

	public static void StartOrResumeTracking(string key)
	{
		if (trackers.TryGetValue(key, out PerformanceTracker tracker)) tracker.StartOrResume();
		else
		{
			PerformanceTracker newTracker = new();
			trackers[key] = newTracker;
			newTracker.StartOrResume();
		}
	}

	public static void PauseTracking(string key)
	{
		if (!isActive) return;
		if (trackers.TryGetValue(key, out PerformanceTracker tracker)) tracker.Pause();
		else throw new InvalidOperationException("Must start tracking first.");
	}

	public static void FinishTracking(string key)
	{
		if (!isActive) return;
		if (trackers.TryGetValue(key, out PerformanceTracker tracker)) tracker.Finish();
		else throw new InvalidOperationException("Must start tracking first.");
	}

	public static void DrawDebug(int fontSize, Color color)
	{
		string[] logs = trackers.Keys.Select(valueName => $"{valueName}: {trackers[valueName].GetAverageTime():F2}ms").ToArray();
		Text.DrawDebug(fontSize, color, logs);
	}
}
