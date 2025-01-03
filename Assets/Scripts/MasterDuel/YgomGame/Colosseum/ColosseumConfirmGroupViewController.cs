using System;
using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumConfirmGroupViewController : ColosseumConfirmViewControllerBase
	{
		private int currentIndex;

		private List<(int, string)> regionList;

		public static void PushView(ViewControllerManager vcm, int logoId, int identifier = 0, Action onSuccess = null)
		{
		}

		protected override void UpdateView()
		{
		}

		private void CallAPIWcsSetRegion(int regionId)
		{
		}
	}
}
