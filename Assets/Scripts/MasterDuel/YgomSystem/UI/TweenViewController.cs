using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenViewController : ViewController
	{
		public string PushLabel;

		public string PopLabel;

		public string CoverLabel;

		public string UncoverLabel;

		public string SwapInLabel;

		public string SwapOutLabel;

		private string m_LastTweenLabel;

		protected virtual GameObject m_TweenTarget => null;

		protected string k_SwapLabelAlphaFade => null;

		protected string k_SwapLabelFlip => null;

		protected void AddLabelSuffix(string suffix)
		{
		}

		public string GetTransitionType2Label(TransitionType type)
		{
			return null;
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}
	}
}
