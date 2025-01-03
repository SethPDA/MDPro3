using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Settings
{
	public class SettingMenuViewController : BaseMenuViewController
	{
		private enum Mode
		{
			Home = 0,
			DuelPlayer = 1,
			DuelAudience = 2,
			Title = 3
		}

		public enum Page
		{
			General = 0,
			Duel = 1,
			Audience = 2,
			CrossPlay = 3,
			Num = 4
		}

		private class PageInfo
		{
			public Page page;

			public ElementObjectManager root;

			public ElementObject buttonEO;

			public SelectionButton button;

			public GameObject on;

			public GameObject off;

			public GameObject menuGroup;

			public ExtendedScrollRect scroll;

			public LayoutGroup layout;

			public Dictionary<Menu, ElementObjectManager> menu;

			public Menu currentMenu;

			public SelectionItem preSelectedMenuItem;

			public void AddMenu(Menu menuType, bool leftBack, ElementObjectManager template, Transform parent, IDS_PREFERENCE titleText, bool showArrow)
			{
			}

			private void AddMenu(Menu menuType, ElementObjectManager ui, bool leftBack, IDS_PREFERENCE titleText, bool showArrow)
			{
			}

			public void SelectTopOrPreSelectedMenu()
			{
			}

			public void ShowPage()
			{
			}

			public void HidePage()
			{
			}

			public void ShowMenu(bool show)
			{
			}
		}

		public enum Menu
		{
			BGM = 0,
			SE = 1,
			Quality = 2,
			Power = 3,
			Resolution = 4,
			DisplayMode = 5,
			Language = 6,
			CardTextSize = 7,
			Vibration = 8,
			ShowOfficialIcon = 9,
			SelfChain = 10,
			ActivateConfirm = 11,
			AutoLocation = 12,
			AutoActivateOrder = 13,
			AutoCardInfo = 14,
			ShowSetCard = 15,
			ShowAudience = 16,
			ShowBattleStep = 17,
			CommandType = 18,
			SkipSummonEffect = 19,
			SkipMonsterCutin = 20,
			SkipCardRunEffect = 21,
			UseConsoleLayout = 22,
			CameraType = 23,
			ShowRivalName = 24,
			ShowCardReport = 25,
			ShowHappenedEffect = 26,
			AudienceAutoCardInfo = 27,
			AudienceShowSetCard = 28,
			AudienceShowAudience = 29,
			AudienceShowBattleStep = 30,
			AudienceSkipSummonEffect = 31,
			AudienceSkipMonsterCutin = 32,
			AudienceSkipCardRunEffect = 33,
			AudienceUseConsoleLayout = 34,
			AudienceCameraType = 35,
			AudienceShowRivalName = 36,
			AudienceShowCardReport = 37,
			AudienceShowHappenedEffect = 38,
			CrossPlay = 39,
			None = 40
		}

		private Dictionary<Page, PageInfo> pageInfo;

		private Page currentPage;

		private bool isDirty;

		private SettingsUtil.DuelParam duelParam;

		private SettingsUtil.BasicParam basicParam;

		private SettingsUtil.SoundParam soundParam;

		private SettingsUtil.SystemParam systemParam;

		private SettingsUtil.AudienceParam audienceParam;

		private Mode mode;

		private int selectorGroupPriority;

		private Action onSurrendered;

		private Action<SettingsUtil.DuelParam.MANUAL_TYPE> onChangeConfirm;

		private Action<bool> onChangeShowAudience;

		private Action<bool> onChangeShowBattleStep;

		private Action<bool> onChangeShowSetCard;

		private Action onClosed;

		private bool showSurrenderButton;

		private string surrenderButtonText;

		private string surrenderDialogText;

		private bool isDuelTutorial;

		private bool showHelpButton;

		private Action onHelp;

		private bool showRetryButton;

		private Action onRetry;

		public const string keyMode = "Mode";

		public const string keySelectorGroupPriority = "SelectorGroupPriority";

		public const string keyOnSurrenderedCallback = "OnSurrenderedCallback";

		public const string keyOnChangeConfirmCallback = "OnChangeConfirmCallback";

		public const string keyOnChangeShowAudienceCallback = "OnChangeShowAudienceCallback";

		public const string keyOnChangeShowBattleStepCallback = "OnChangeShowBattleStepCallback";

		public const string keyOnChangeShowSetCardCallback = "OnChangeShowSetCardCallback";

		public const string keyOnClosedCallback = "OnClosedCallback";

		public const string keyShowSurrenderButton = "ShowSurrenderButton";

		public const string keySurrenderButtonText = "SurrenderButtonText";

		public const string keySurrenderDialogText = "SurrenderDialogText";

		public const string keyIsDuelTutorial = "IsDuelTutorial";

		public const string keyShowHelpButton = "ShowHelpButton";

		public const string keyOnHelpCallback = "OnHelpCallback";

		public const string keyShowRetryButton = "ShowRetryButton";

		public const string keyOnRetryCallback = "OnRetryCallback";

		public const string keyViewStyleOVerride = "viewStyleOverride";

		public static Dictionary<string, object> GetHomeArgs(int selectorGroupPriority)
		{
			return null;
		}

		public static Dictionary<string, object> GetTitleArgs()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelPlayerArgs(int selectorGroupPriority, Action onClosed, Action onSurrenderedCallback, Action<SettingsUtil.DuelParam.MANUAL_TYPE> onChangeConfirm, Action<bool> onChangeShowAudience, Action<bool> onChangeShowSetCard, Action<bool> onChangeShowBattleStep, string surrenderButtonText, string surrenderDialogText, bool isDuelTutorial, bool showHelpButton, Action onHelp, bool showRetryButton = false, Action onRetry = null)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelAudienceArgs(int selectorGroupPriority, Action onClosed, Action onSurrenderedCallback, Action<bool> onChangeShowAudience, Action<bool> onChangeShowSetCard, Action<bool> onChangeShowBattleStep, string surrenderButtonText, string surrenderDialogText)
		{
			return null;
		}

		private void GetArgs()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void SetupUI()
		{
		}

		private IEnumerator ShowLangChangedDialog(string changeAlartText, string okText)
		{
			return null;
		}

		private void SetupMode(Mode mode)
		{
		}

		private ElementObjectManager GetMenu(Menu menu)
		{
			return null;
		}

		public override void NotificationStackRemove()
		{
		}

		private void LoadIDS()
		{
		}

		private void UnloadIDS()
		{
		}

		private void ShowPageMenu(Page page)
		{
		}

		private void OnCancel(bool pageBack)
		{
		}

		private void Close(bool playSE = true)
		{
		}

		private void OnSurrender()
		{
		}

		private void OnHelp()
		{
		}

		private void OnRetry()
		{
		}

		private void SetBGM(float volume)
		{
		}

		private void SetSE(float volume)
		{
		}

		private void SetQuality(SettingsUtil.BasicParam.QUALITY quality)
		{
		}

		private void SetPower(float volume)
		{
		}

		private void SetResolution(int index)
		{
		}

		private void SetDisplayMode(bool isFullScreen)
		{
		}

		private void SetCardTextSize(SettingsUtil.BasicParam.CARD_TEXT_SIZE type)
		{
		}

		private void SetVibration(bool active)
		{
		}

		private void SetShowOfficialIcon()
		{
		}

		private void SetCrossPlay()
		{
		}

		private void SetSelfChain(SettingsUtil.DuelParam.CHAIN_TYPE type)
		{
		}

		private void SetManualConfirm(SettingsUtil.DuelParam.MANUAL_TYPE type)
		{
		}

		private void SetLocateType(SettingsUtil.DuelParam.LOCATE_TYPE type)
		{
		}

		private void SetDecideActivateOrder(bool active)
		{
		}

		private void SetShowCardInfoType(int type)
		{
		}

		private void SetShowSetCard(bool active)
		{
		}

		private void SetShowAudienceInfo(bool active)
		{
		}

		private void SetShowBattleStep(bool active)
		{
		}

		private void SetCommandType(SettingsUtil.DuelParam.COMMAND_TYPE type)
		{
		}

		private void SetSkipSummonEffectType(SettingsUtil.DuelParam.SKIP_TYPE type)
		{
		}

		private void SetSkipMonsterCutinType(SettingsUtil.DuelParam.SKIP_TYPE type)
		{
		}

		private void SetSkipCardRunEffectType(SettingsUtil.DuelParam.SKIP_TYPE type)
		{
		}

		private void SetUseConsoleLayout(bool active)
		{
		}

		private void SetCameraType(SettingsUtil.DuelParam.CAMERA_TYPE type)
		{
		}

		private void SetShowRivalName(int type)
		{
		}

		private void SetShowCardReport(int type)
		{
		}

		private void SetShowHappenedEffectType(int type)
		{
		}

		private void SetAudienceShowCardInfoType(int type)
		{
		}

		private void SetAudienceShowSetCard(bool active)
		{
		}

		private void SetAudienceShowAudienceInfo(bool active)
		{
		}

		private void SetAudienceShowBattleStep(bool active)
		{
		}

		private void SetAudienceSkipSummonEffectType(SettingsUtil.AudienceParam.SKIP_TYPE type)
		{
		}

		private void SetAudienceSkipMonsterCutinType(SettingsUtil.AudienceParam.SKIP_TYPE type)
		{
		}

		private void SetAudienceSkipCardRunEffectType(SettingsUtil.AudienceParam.SKIP_TYPE type)
		{
		}

		private void SetAudienceUseConsoleLayout(bool active)
		{
		}

		private void SetAudienceCameraType(SettingsUtil.AudienceParam.CAMERA_TYPE type)
		{
		}

		private void SetAudienceShowRivalName(int type)
		{
		}

		private void SetAudienceShowCardReport(int type)
		{
		}

		private void Save()
		{
		}

		private static void ScrollToSelectingItem(RectTransform itemRect, ScrollRect scroll, LayoutGroup layout)
		{
		}

		private void SetAudienceShowHappenedEffectType(int type)
		{
		}
	}
}
