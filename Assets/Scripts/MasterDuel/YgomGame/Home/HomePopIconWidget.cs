using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;

namespace YgomGame.Home
{
	public class HomePopIconWidget
	{
		public enum PopIconType
		{
			StartingMission = 1
		}

		private readonly string k_TLabel_PopIn;

		private readonly string k_TLabel_PopOut;

		private readonly Dictionary<PopIconType, GameObject> m_HolderMap;

		private readonly Dictionary<PopIconType, bool> m_ActiveMap;

		private readonly Dictionary<PopIconType, bool> m_LoadingStateMap;

		private bool m_Activate;

		private Coroutine m_TransitionRoutine;

		public bool enabled => false;

		public void Assign(PopIconType iconType, GameObject iconHolder)
		{
		}

		public bool IsReady()
		{
			return false;
		}

		public void UpdateActive(PopIconType iconType, bool activeFlag)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void TryPlayPopIn(HomeViewController hvc)
		{
		}

		private IEnumerator yPlayPopIn(HomeViewController hvc)
		{
			return null;
		}

		public void TryPlayPopOut(HomeViewController hvc)
		{
		}

		private IEnumerator yPlayPopOut(HomeViewController hvc)
		{
			return null;
		}
	}
}
