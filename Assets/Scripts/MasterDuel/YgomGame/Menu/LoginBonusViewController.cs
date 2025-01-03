using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu
{
	public class LoginBonusViewController : BaseMenuViewController
	{
		public enum Mode
		{
			View = 0,
			Obtain = 1
		}

		private class Button
		{
			private SelectionButton _btn;

			private bool _enable;

			internal UnityAction onSelected
			{
				set
				{
				}
			}

			internal Button(SelectionButton btn, bool enable = false)
			{
			}

			internal void SetData(Dictionary<string, object> src)
			{
			}

			internal void Activate()
			{
			}
		}

		private const string VC_PATH = "LoginBonus/LoginBonus";

		private const string k_ArgKeyMode = "mode";

		internal const string k_ArgKeyLaunchId = "id";

		internal const string k_ArgKeyCallback = "callback";

		private const string k_ArgKeyGetListAPICalling = "get_list_api_calling";

		private const string k_ELabelMapLocator = "MapLocator";

		private const string k_ELabelOKButton = "OKButton";

		private const string k_ELabelButton1 = "Button1";

		private const string k_ELabelButton2 = "Button2";

		private const string MAP_DATA_PATH = "Prefabs/LoginBonus/Maps/LoginBonusMapData";

		private static bool c_IsTextLoadedExternal;

		private Mode m_Mode;

		private int m_LaunchId;

		private GameObject m_MapPref;

		private LoginBonusMapWidet m_MapWidget;

		private Dictionary<string, object> m_SourceData;

		private Button m_OKButton;

		private Button m_Button1;

		private Button m_Button2;

		private Action m_Callback;

		private AssetLinkContainer _mapAssetInfo;

		protected override Type[] textIds => null;

		public static void Open(ViewControllerManager manager, Mode mode, Dictionary<string, object> args)
		{
		}

		private static void RequestServer(Mode mode, int loginBonusID, Action<Handle, LoginBonusCode> onEnd)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator ObtainRewards()
		{
			return null;
		}

		private void LoadDataAsync()
		{
		}

		private void SetupButtons()
		{
		}
	}
}
