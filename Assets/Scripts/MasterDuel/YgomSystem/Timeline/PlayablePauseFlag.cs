using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class PlayablePauseFlag : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsPause;

		public static bool GetPauseFlag(PlayableDirector director)
		{
			return false;
		}

		public static void SetPauseFlag(PlayableDirector director, bool value)
		{
		}
	}
}
