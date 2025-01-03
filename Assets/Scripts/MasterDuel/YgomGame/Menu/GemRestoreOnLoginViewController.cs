using System;
using System.Collections;
using System.Collections.Generic;
using YgomGame.GemShop;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class GemRestoreOnLoginViewController : BaseMenuViewController
	{
		private const string VC_PATH = "GemRestoreOnLogin/GemRestoreOnLogin";

		private const string ARG_KEY_NOREBOOT = "NoRebootMode";

		private const string ARG_KEY_ONEND = "OnEnd";

		private static IEnumerator s_Routine;

		private YgomSystem.Network.EventHandler _onNetworkErrorHandler;

		private bool _isNoRebootMode;

		private Action _onEnd;

		private JsonGemShopAnalyzer _pdAnalyzer;

		public static void GoFromTestScene()
		{
		}

		public static void Go(ViewControllerManager manager, Action onEnd)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator ProcessGemRestoring()
		{
			return null;
		}

		private IEnumerator CallNetworkAPI(Handle handle, Action<int> callback)
		{
			return null;
		}

		private Dictionary<string, string> AnalyzeAndGetProductInfos()
		{
			return null;
		}
	}
}
