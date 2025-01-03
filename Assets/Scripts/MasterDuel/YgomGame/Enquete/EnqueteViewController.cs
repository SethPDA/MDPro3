using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Enquete
{
	public class EnqueteViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		private enum Mode
		{
			Input = 0,
			FreeWordConfirm = 1,
			Decided = 2
		}

		public const string k_BoardImageSPath = "Images/Enquete/EnqueteBoard_S";

		public const string k_BoardImageMPath = "Images/Enquete/EnqueteBoard_M";

		private const string k_ArgKeySourceJsonLinkerLabel = "sourceJsonLabel";

		private const string k_ArgKeySourceJson = "sourceJson";

		private const string k_ArgKeyCallback = "callback";

		private const string k_ArgKeyCloseOnFinish = "closeOnFinish";

		private const string k_ArgKeyDispHeader = "dispHeader";

		private Selector m_FooterSelector;

		private RootContext m_RootContext;

		private List<string> m_LoadTextGroups;

		private RectTransform m_SheetTemplate;

		private SheetWidgetFactory m_SheetWidgetFactory;

		private int m_PageLength;

		private int m_CurrentPage;

		private ExtendedScrollRect m_ScrollRect;

		private TMP_Text m_PageText;

		private SelectionButton m_BackPageButton;

		private SelectionButton m_NextPageButton;

		private SelectionButton m_BackEditButton;

		private SelectionButton m_DecideButton;

		private SheetWidget[] m_SheetWidgets;

		private SheetWidget m_FreeWordConfirmSheetWidget;

		private Coroutine m_ConfirmInputValuesRoutine;

		private Dictionary<string, object> m_InputValues;

		private List<string> m_ReplacedInputKeys;

		private Mode m_Mode;

		private GameObject m_BackKeyShortcut;

		private Selector m_ScrollSelector;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public static void OpenEnquete(int enqueteId, Action<Dictionary<string, object>> callback = null, bool openThanksOnFinish = true, bool closeOnFinish = true, Action onLaunchCallback = null, bool openOnHome = false)
		{
		}

		private static void InnerOpenEnquete(int enqueteId, Action<Dictionary<string, object>> callback = null, bool openThanksOnFinish = true, bool closeOnFinish = true, Action onLaunchCallback = null, bool openOnHome = false)
		{
		}

		public static void PushFirstEnquete(ViewControllerManager manager, Action<Dictionary<string, object>> callback, bool closeOnFinish = true)
		{
		}

		private static void ProgressResultSequence(Dictionary<string, object> result, Action<Dictionary<string, object>> callback = null, bool openReward = true, bool openThanksOnFinish = true, bool closeOnFinish = true)
		{
		}

		private static void OnFailedAnswers(Dictionary<string, object> result, Action<Dictionary<string, object>> callback = null, bool closeOnFinish = true)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void ImportJsonStr(string jsonStr)
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void UpdatePage(int page, bool forceUpdate = false)
		{
		}

		private void UpdateNextButton()
		{
		}

		private IEnumerator ConfirmInputValues(Action<bool> onComplete)
		{
			return null;
		}

		private void ApplyViewMode()
		{
		}

		private void ToDecide()
		{
		}

		private bool TryFocusScroll(MonoBehaviour target)
		{
			return false;
		}

		private bool TryFocusScroll(RectTransform target)
		{
			return false;
		}

		private void OnInputUp()
		{
		}

		private void OnInputDown()
		{
		}

		private void OnInputLeft()
		{
		}

		private void OnInputRight()
		{
		}

		private void OnClickBackPage()
		{
		}

		private void OnClickNextPage()
		{
		}

		private void OnClickBackEdit()
		{
		}

		private void OnClickDecide()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
