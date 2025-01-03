using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duelpass
{
	public class DuelpassMateWidget
	{
		private Transform mateTransform;

		private SelectionButton mateButton;

		private List<int> mateIds;

		private Character2D chara;

		public DuelpassMateWidget(ElementObjectManager eom)
		{
		}

		~DuelpassMateWidget()
		{
		}

		private IEnumerator MateSwapCoroutine()
		{
			return null;
		}

		private void SetMate(int id)
		{
		}
	}
}
