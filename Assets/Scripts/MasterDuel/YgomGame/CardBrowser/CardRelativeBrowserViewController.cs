using System.Collections;
using System.Collections.Generic;
using YgomGame.Duel;
using YgomGame.Menu;

namespace YgomGame.CardBrowser
{
	public class CardRelativeBrowserViewController : BaseMenuViewController, IBokeSupported
	{
		private const string k_ArgKey_Mrk = "mrk";

		internal const string k_ArgKeySwap = "swap";

		internal const string k_ArgKey_SkipSwapTransition = "SkipSwapTransition";

		private readonly string k_ELabelCloseButton;

		private readonly string k_ELabelContentRoot;

		private int m_Mrk;

		private IEnumerator m_InitRoutine;

		private CardInfoDetailPool.RelativeList m_RelativeList;

		protected override bool setSurfaceActiveOnInitialize => false;

		public static void Open(int mrk, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void ProgressUpdate()
		{
		}

		private IEnumerator yInitRoutine()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
