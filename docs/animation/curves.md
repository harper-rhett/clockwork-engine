# Curves

> `using Clockwork.Animation`

The `Curves` class has a large range of linear curves to choose from for tweening values (like when animating). A few places in Clockwork use these curves, such as the `Easer` class. They represent delegates, so when using a class such as `Easer` you may supplement it with your own custom curve. Here's a simple example:

```csharp
public static float Cubic(float x)
{
	return x * x * x;
}
```