# Profiler

When a game starts to chug, you need to know *where* the time is going. The `Profiler` is a lightweight, built-in way to measure how long sections of your code take, averaged over recent frames.

It lives in the root `Clockwork` namespace, so no extra `using` is needed beyond `using Clockwork;`.

## Tracking Sections

Wrap the code you want to measure in a matching `StartOrResumeTracking` / `FinishTracking` pair, identified by a string key:

```csharp
public override void OnUpdate()
{
	Profiler.StartOrResumeTracking("pathfinding");
	UpdatePathfinding();
	Profiler.FinishTracking("pathfinding");
}
```

You can track as many sections as you like, each with its own key. Because tracking resumes, you can also profile a section that's split across multiple calls in a frame by pausing in between:

```csharp
Profiler.StartOrResumeTracking("ai");
// ...part of the work...
Profiler.PauseTracking("ai");
// ...something else...
Profiler.StartOrResumeTracking("ai");
// ...the rest...
Profiler.FinishTracking("ai");
```

## Viewing Results

`Profiler.DrawDebug` draws every tracked section and its average time as an overlay. Call it from a draw loop, ideally `OnDrawGUI` so it isn't affected by the camera:

```csharp
public override void OnDrawGUI()
{
	Profiler.DrawDebug(16, Colors.Lime);
}
```

Averages are computed over the most recent frames, so the numbers stay readable instead of flickering every frame.

## Toggling

Profiling has overhead, so you'll usually want it off in shipping builds. The `Profiler.IsActive` flag turns all tracking on or off globally:

```csharp
Profiler.IsActive = buildConfiguration.IsDebug;
```

When inactive, the tracking calls become cheap no-ops, so you can leave them in your code.

## PerformanceTracker

`Profiler` is built on `PerformanceTracker`, which you can also use directly if you want to own a single timer rather than a keyed collection:

```csharp
PerformanceTracker tracker = new();

tracker.StartOrResume();
DoExpensiveWork();
tracker.Finish();

float average = tracker.GetAverageTime();
```

Like `Profiler`, it supports `Pause` for splitting work across a frame, has an `IsActive` toggle, and averages over a rolling window. The static `PerformanceTracker.FramesTracked` field controls how many frames that window spans (default `600`).
