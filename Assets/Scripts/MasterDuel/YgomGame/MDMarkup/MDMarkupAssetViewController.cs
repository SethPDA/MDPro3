using System;
using System.Collections.Generic;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	public class MDMarkupAssetViewController : BaseBlurOverlayViewController, IDynamicChangeDispHeaderSupported
	{
		private enum InitFlags
		{
			None = 0,
			LoadMarkupAsset = 1,
			InitializedMarkupFactory = 2,
			CreateViewStart = 4,
			CreateViewEnd = 8,
			MarkupTextLoad = 0x10,
			MarkupPreLoadStart = 0x20,
			MarkupPreLoadEnd = 0x40,
			MarkupOutputGraphStart = 0x80,
			MarkupOutputGraphEnd = 0x100
		}

		private const string k_PrefPath = "MDMarkupAsset";

		public const string k_ArgKeyOpenOnHome = "openOnHome";

		private const string k_ArgKeySourceAsset = "sourceAsset";

		private const string k_ArgKeySourceJson = "sourceJson";

		private const string k_ArgKeyCallback = "callback";

		public const string k_ArgKeyCloseButtonType = "closeButtonType";

		public const string k_ArgKeyTitle = "title";

		public const string k_ArgKeyOptionalText = "optionalText";

		public const string k_ArgKeyBadge = "badge";

		private readonly string k_ViewLabelBoard;

		private readonly string k_ViewLabelPager;

		private readonly string k_ViewLabelTabs;

		private readonly string k_ViewLabelBoardPager;

		private InitFlags m_InitStep;

		private MDMarkupAsset m_MDMarkupAsset;

		private MDMarkupGraphFactory m_MDMarkupGraphFactory;

		private IMDMarkupContainerWidget m_ContainerWidget;

		private List<string> m_LoadedTextGroups;

		protected override bool defaultBlurOverlay => false;

		public static void PushByContainer(ViewControllerManager vcm, IMDMarkupContainer container, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenByAsset(string assetPath, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public static void SwapOpenByAsset(ViewController target, string assetPath, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenByAsset(MDMarkupAsset asset, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public static void SwapOpenByAsset(ViewController target, MDMarkupAsset asset, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenByJson(string json, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnCreatedMDMarkupAsset()
		{
		}

		public override void ProgressUpdate()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
