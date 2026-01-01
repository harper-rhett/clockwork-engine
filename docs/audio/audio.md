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

Some music player entities are additionally included, such as:
- `MusicPlayer`: Add to scene to play music.
- `MusicRepeater`: Repeats music, over and over.
- `MusicRepeater2Part`: Plays two audio files one after the other, and repeats the second one.