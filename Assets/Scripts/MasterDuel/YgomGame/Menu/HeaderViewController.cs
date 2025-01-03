using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu
{
	public class HeaderViewController : ViewController
	{
		[Flags]
		public enum IsDispHeader
		{
			BACK = 1,
			GEM_QUANTITY = 2,
			FRIEND = 4,
			CONFIG = 8,
			PRESENT = 0x10,
			NOTICE = 0x20,
			MISSION = 0x40,
			GEM_QUANTITY_TEXT = 0x80,
			BORDER = 0x100,
			DUELLIVE = 0x200
		}

		public enum Part
		{
			ALL = 0,
			TOP = 1
		}

		private class FrontGroup
		{
			private readonly Part part;

			private Dictionary<IsDispHeader, GameObject> fronts;

			public FrontGroup(Part part)
			{
			}

			public void SetFront(IsDispHeader isDispHeader, GameObject gameObject)
			{
			}

			public GameObject GetFront(IsDispHeader isDispHeader)
			{
				return null;
			}

			public void InitTween()
			{
			}
		}

		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private readonly string ROOT_LABEL;

		private readonly string ROOT_TOP_LABEL;

		private readonly string BTN_BACK_LABEL;

		private readonly string BTN_CONFIG_LABEL;

		private readonly string BTN_FRIEND_LABEL;

		private readonly string BTN_NOTICE_LABEL;

		private readonly string BTN_PRESENT_LABEL;

		private readonly string BTN_MISSION_LABEL;

		private readonly string BTN_GEM_LABEL;

		private readonly string BTN_DUELLIVE;

		private readonly string TXT_GEM_LABEL;

		private readonly string TXT_LABEL;

		private readonly string IMG_BORDER_LABEL;

		private readonly string ROOT_TWEEN_LABEL;

		private readonly string STATE_NOTICE_PATH;

		private ElementObjectManager topEOM;

		private Selector topSelector;

		private GameObject root;

		private GameObject topRoot;

		private FrontGroup topFronts;

		private bool isDispTop;

		private ExtendedTextMeshProUGUI gemButtonText;

		private ExtendedTextMeshProUGUI gemText;

		private ViewControllerManager content;

		private ViewController crntViewController;

		private bool isDirty;

		private bool shouldResetShortCutBack;

		private IsDispHeader isDisp;

		public static HeaderViewController instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void InitHeader()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Start()
		{
		}

		private void SetAnimBtnHideCallback(string label)
		{
		}

		private void Update()
		{
		}

		public void OnBackButton()
		{
		}

		private void OnCommonButton(IsDispHeader isDispHeader, Action onClick)
		{
		}

		private bool IsReadyClickAction(IsDispHeader isDispHeader)
		{
			return false;
		}

		public void SetDirty()
		{
		}

		public void HideButton()
		{
		}

		public void ShowButtonTemp()
		{
		}

		public void HideButtonTemp()
		{
		}

		public void SetInteractableAllContents(bool interactable)
		{
		}

		public void SetShortCutBackButton(bool isSet)
		{
		}

		public void SwapBeforeParent(ViewController vc, bool isEntry)
		{
		}

		public GameObject GetTopFrontGameObject(IsDispHeader isDispHeader)
		{
			return null;
		}

		private void ResetOption()
		{
		}

		private void StateChange(ViewController vc, bool forceHide = false)
		{
		}

		private void doHome()
		{
		}

		private bool IsSupportedView(ViewController vc)
		{
			return false;
		}

		private void SetIsDisp(IsDispHeader disp, bool flag)
		{
		}

		private void UpdateDispPart(Part part)
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		private void SetDispAllContents(bool flag)
		{
		}

		private bool IsDispAnyContent(Part part = Part.ALL)
		{
			return false;
		}

		private void StateNotificator(object mes)
		{
		}

		private void NotifyTransition(TransitionType tt, ViewController vc, ViewController preVc)
		{
		}

		private void OnBackEvent(ViewControllerManager vcm)
		{
		}

		private void InitializeSelector()
		{
		}

		private void FinalizeSelector()
		{
		}

		private void SetSelectorEnabled(bool enabled)
		{
		}

		private ViewControllerManager GetContentManager()
		{
			return null;
		}
	}
}
