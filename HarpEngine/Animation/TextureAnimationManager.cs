namespace HarpEngine.Animation;

public class TextureAnimationManager<AnimationID> where AnimationID : Enum
{
	private Dictionary<AnimationID, TextureAnimation> animations = new();
	public AnimationID CurrentAnimationID;
	public TextureAnimation CurrentAnimation => animations[CurrentAnimationID];

	public void RegisterAnimation(TextureAnimation animation, AnimationID id)
	{
		animations.Add(id, animation);
	}

	public void Draw(Vector2 position, Vector2 direction, Color color)
	{
		TextureAnimation animation = animations[CurrentAnimationID];
		animation.Draw(position, direction, color);
	}
}
