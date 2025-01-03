using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioLogContainer : ScenarioContainerBase
	{
		private readonly string k_ELabelScrollArea;

		private readonly string k_ELabelTextMeshTemplate;

		private readonly string k_ELabelCloseButton;

		private readonly string k_TweenShow;

		private readonly string k_TweenHide;

		private readonly ScrollRect m_ScrollArea;

		private readonly TextMeshProUGUI m_TextMeshTemplate;

		private int m_CreatedLogCnt;

		public Action onClickCloseCallback;

		public ScenarioLogContainer(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(int selectorPriority)
		{
		}

		public void Show(IReadOnlyList<IScenarioLogBehavior> logBehaviors)
		{
		}

		public void Hide()
		{
		}

		private void CheckLogsInsert(IReadOnlyList<IScenarioLogBehavior> logBehaviors)
		{
		}

		public void InsertLogText(IScenarioLogTextBehavior logText)
		{
		}

		private void OnTweenOpenStart()
		{
		}

		private void OnTweenCloseFinished()
		{
		}
	}
}
