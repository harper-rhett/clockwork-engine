namespace HarpEngine.Animation;

public class TextureAnimationManager<AnimationState> where AnimationState : Enum
{
	private Dictionary<AnimationState, TextureAnimation> animations = new();
	public AnimationState State;
	public TextureAnimation CurrentAnimation => animations[State];

	public void RegisterAnimation(TextureAnimation animation, AnimationState id)
	{
		animations.Add(id, animation);
	}

	public void Draw(Vector2 position, Vector2 direction, Color color)
	{
		TextureAnimation animation = animations[State];
		animation.Draw(position, direction, color);
	}
}
