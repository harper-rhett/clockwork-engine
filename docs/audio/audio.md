# Audio

> `using Clockwork.Audio;`

Sounds are incredibly simple:

```csharp
Sound explosionSound = Sound.Load("explosion.wav");
explosionSound.Volume = 0.5f;
explosionSound.Play();
```

With music being almost as simple:

```csharp
Music dreamMusic = Music.Load("dream.wav");
float duration = dreamMusic.Duration;
dreamMusic.Update(); // should be called in update...
dreamMusic.Position = 10; // sets the position to 10 seconds
```

Make sure to call `Dispose()` on these types when you are finished using them to release them from memory!

## Music Entities

Managing music playback manually can be tedious, so Clockwork includes entity wrappers that handle `Update()` calls for you:

- `MusicPlayer`: Plays a track once and removes itself when finished (unless `RemoveOnFinished` is set to `false`). Supports `Start()`, `Stop()`, `Pause()`, and `Resume()`.
- `MusicRepeater`: Loops a track indefinitely. Same playback controls as `MusicPlayer`.
- `MusicRepeater2Part`: Plays two audio files in sequence, then repeats the second one. Useful for intro-then-loop music patterns.

```csharp
Music bgm = Music.Load("overworld.ogg");
MusicRepeater repeater = scene.AddEntity(new MusicRepeater(bgm));
repeater.Start();
```