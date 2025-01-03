using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenSE : Tween
	{
		[SerializeField]
		public string m_SoundLabel;

		[SerializeField]
		public bool m_PlayOnFinish;

		private int instanceId;

		private bool m_IsPlayInFrame;

		protected override void OnSetValue(float par)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
