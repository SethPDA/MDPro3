using UnityEngine;
using YgomSystem.Timeline;

namespace YgomSample
{
	public class LabeledTimelineSampleController : MonoBehaviour
	{
		[SerializeField]
		private string m_PlayLabel;

		[SerializeField]
		private LabelDirectorWrapMode m_WrapMode;

		private LabeledPlayableController m_LabeledPlayableController;

		private void Start()
		{
		}

		public void Play()
		{
		}
	}
}
