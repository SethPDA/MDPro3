using UnityEngine;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.Utility;

namespace YgomSystem.UI
{
	public class UISystem : MonoBehaviour
	{
		private static UISystem s_Instance;

		[SerializeField]
		private InputBlocker m_InputBlocker;

		[SerializeField]
		private UINetworkHandler m_UINetworkHandler;

		[SerializeField]
		private SystemProgress m_SystemProgress;

		[SerializeField]
		private SystemDialog m_SystemDialog;

		[SerializeField]
		private HoldIndicator m_HoldIndicator;

		[SerializeField]
		private AssetReferer m_AssetReferer;

		[SerializeField]
		private ResourceBindingPathSetting m_ResourceBindingPathSetting;

		private ResourceBindingPathSetting m_CurrentResourceBindingPathSetting;

		public static ResourceBindingPathSetting resourceBindingPathSetting
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool isReady => false;

		public static InputBlocker inputBlocker => null;

		public static UINetworkHandler uiNetworkHandler => null;

		public static SystemProgress systemProgress => null;

		public static SystemDialog systemDialog => null;

		public static HoldIndicator holdIndicator => null;

		public static Sprite invisibleSprite => null;

		public static void OnDownloadedAssets()
		{
		}

		public static void Initialize()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
