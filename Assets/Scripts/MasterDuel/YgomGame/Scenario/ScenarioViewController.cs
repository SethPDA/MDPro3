using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Scenario
{
	public class ScenarioViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		public const string k_PrefabPath = "Scenario/Scenario";

		public const string k_ScenarioAssetPathFormat = "Scenarios/Gates/ScenarioAseets/{0}";

		public const string k_ELabelBackKey = "BackKeyShortcutButton";

		public const string k_ELabelLogBackKey = "LogScreen/LogBackKeyShortcutButton";

		public const string k_ELabelBlockerBackKey = "BlockerBackKeyShortcutButton";

		private readonly string k_TweenLabelPopSkip;

		public const string k_ArgKeyName = "name";

		private const string k_ArgKeyData = "data";

		public const string k_ArgKeyOnComplete = "oncomplete";

		private const string k_ArgKeyDemoMode = "demomode";

		private string m_ScenarioName;

		private List<object> m_ScenarioData;

		private ScenarioWork m_Work;

		private ScenarioLoadGroupContainer m_LoadGroupContainer;

		private ScenarioObjectContainer m_ObjectContainer;

		private ScenarioController m_ScenarioController;

		private string m_BeforeBgm;

		private int m_TransitionStep;

		private bool m_IsUnlockedInput;

		private float m_CowntdownAutoHideSec;

		private bool m_ClickedInputBlocker;

		private bool m_DemoSkipEnable;

		private bool m_DemoSkipRequest;

		private bool m_IsSkipped;

		private bool m_Ready;

		private bool m_IsReleased;

		private Coroutine m_yCloseFadeOut;

		private bool m_ClickedBlockInputFlame;

		private bool m_ToFullScreenFrame;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public static void Open(string scenarioName, Action<bool> onCompleteCallback = null)
		{
		}

		public static void OpenDemo(string scenarioName, Action<bool> onCompleteCallback = null)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public override void NotificationStackEntry()
		{
		}

		public override float Progress()
		{
			return 0f;
		}

		private bool OnLoadCompleted()
		{
			return false;
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		private void Update()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Release()
		{
		}

		private void OnDestroy()
		{
		}

		public void Suspend()
		{
		}

		public void Resume()
		{
		}

		private void UpdateAutoHideCount()
		{
		}

		public void HideUI()
		{
		}

		public void ShowUI()
		{
		}

		public void OpenLog()
		{
		}

		public void CloseLog()
		{
		}

		private void PlayCloseFadeOut()
		{
		}

		private IEnumerator yPlayCloseFadeOut()
		{
			return null;
		}

		private void OnChangedAutoActive(bool isAuto)
		{
		}

		public void OnClick()
		{
		}

		private void OnClickInputBlocker()
		{
		}

		private void OnClickMenuAnyButton()
		{
		}

		private void OnClickAuto()
		{
		}

		private void OnClickLog()
		{
		}

		private void OnClickSkip()
		{
		}

		private void OnClickView()
		{
		}

		private void OnClickLogClose()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
