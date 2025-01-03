using System;
using System.Collections.Generic;

namespace YgomGame.SubMenu
{
	public class DeckEditSubMenuViewController : SubMenuViewController
	{
		private const string argKeyOnClickMassDismantle = "OnClickMassDismantle";

		private const string argKeyOnClickMultiDismantle = "OnClickMultiDismantle";

		private const string argKeyOnClickTrialDraw = "OnClickTrialDraw";

		private const string argKeyOnClickMultiCreate = "OnClickMultiCreate";

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public static void Open(Action onClickMassDiamangle, Action onClickMultiDismantle, Action onClickTrialDraw, Action onClickMultiCreate)
		{
		}

		private static Dictionary<string, object> CreateArgs(Action onClickMassDiamangle, Action onClickMultiDismantle, Action onClickTrialDraw, Action onClickMultiCreate)
		{
			return null;
		}
	}
}
