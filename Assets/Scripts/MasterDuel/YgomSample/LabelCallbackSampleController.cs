using UnityEngine;
using YgomSystem.Timeline;

namespace YgomSample
{
	public class LabelCallbackSampleController : MonoBehaviour
	{
		[SerializeField]
		private float m_TimeScale;

		[SerializeField]
		private string m_Label;

		[SerializeField]
		private LabelDirectorWrapMode m_WrapMode;

		private LabeledPlayableController m_LabeledPlayableController;

		private void Start()
		{
		}

		public void Progress()
		{
		}

		private void OnTMLabelPaused(string label, LabeledPlayableController pd)
		{
		}

		private void OnTMLabelPlayed(string label, LabeledPlayableController pd)
		{
		}

		private void OnTMLabelStopped(string label, LabeledPlayableController pd)
		{
		}

		private void Play()
		{
		}

		private void PlayNextLabel()
		{
		}
	}
}
