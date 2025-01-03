using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class PlayableLoopFlag : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsLoop;

		public static bool GetLoopFlag(PlayableDirector director)
		{
			return false;
		}

		public static void SetLoopFlag(PlayableDirector director, bool value)
		{
		}
	}
}
