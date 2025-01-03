using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Credit
{
	public class CreditBGTimeline
	{
		private readonly string k_timelinePath;

		private ElementObjectManager m_effEom;

		private List<UnityAction<Texture2D>> m_onFinishList;

		private PlayableDirector m_playableDirector;

		private List<int> m_favoriteIds;

		public void SetTimeline()
		{
		}

		private void StartTimeline(bool result)
		{
		}

		public void StopTimeline()
		{
		}
	}
}
