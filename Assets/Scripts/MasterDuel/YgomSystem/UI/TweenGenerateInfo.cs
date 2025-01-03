namespace YgomSystem.UI
{
	public abstract class TweenGenerateInfo : TweenInfo
	{
		public string label;

		public Tween.Easing easing;

		public Tween.Style style;

		[SecField]
		public float duration;

		[SecField]
		public float startDelay;

		public bool ignoreTimeScale;
	}
}
