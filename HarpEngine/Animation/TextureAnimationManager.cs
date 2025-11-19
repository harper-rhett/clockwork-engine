namespace HarpEngine.Animation;

public class TextureAnimationManager<AnimationID> where AnimationID : Enum
{
	private Dictionary<AnimationID, TextureAnimation> animations = new();
	public AnimationID CurrentID;
	public TextureAnimation CurrentAnimation => animations[CurrentID];

	public void RegisterAnimation(TextureAnimation animation, AnimationID id)
	{
		animations.Add(id, animation);
	}

	public void Draw(Vector2 position, Vector2 direction, float frameTime, Color color)
	{
		TextureAnimation animation = animations[CurrentID];
		animation.Draw(position, direction, frameTime, color);
	}
}
