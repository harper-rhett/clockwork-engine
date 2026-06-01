# Input

> `using Clockwork.Input;`

Input is as simple as any game developer could hope for! Check out a keyboard pressed check:

```csharp
if (Keyboard.IsKeyPressed(KeyboardKey.Space)) Jump();
```

Ah... so simple! Mouse input is roughly the same, though there are several coordinate spaces to choose from:

```csharp
int mouseWindowX = Mouse.WindowX;          // mouse x relative to the window
int mouseGameX = Mouse.GameX;              // mouse x relative to the game viewport
float mouseWorldX = camera.GetMouseWorldX(); // mouse x relative to the world (via Camera2D)
```

There's also `Mouse.WindowPosition`, `Mouse.GamePosition`, `Mouse.Delta`, and `Mouse.WheelDelta` for common mouse queries. You can check whether the cursor is on screen with `Mouse.IsOnScreen`.

And gamepads are actual objects:

```csharp
Gamepad gamepadOne = Gamepad.GetGamepad(0);
bool jumpPressed = gamepadOne.IsButtonPressed(GamepadButton.RightFaceDown); // A button on Xbox, X on Playstation
float forwardAxis = gamepadOne.GetAxis(GamepadAxis.LeftStickY);
```