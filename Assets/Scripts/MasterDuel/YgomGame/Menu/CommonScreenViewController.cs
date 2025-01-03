using System;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public abstract class CommonScreenViewController : BaseMenuViewController
	{
		private const string DecisionButtonLabel = "ButtonNext";

		private const string BackButtonLabel = "ButtonBack";

		private SelectionButton m_decisionButton;

		private SelectionButton m_backButton;

		private Action m_decisionCallback;

		private Action m_backCallback;

		private MDText m_decisionButtonText;

		protected void SetTitleText(string text)
		{
		}

		protected void SetDecisionText(string text)
		{
		}

		protected void SetDecisionCallback(Action callback)
		{
		}

		protected void SetBackCallback(Action callback)
		{
		}

		protected void SetEnableDecisionButton(bool enable)
		{
		}

		protected void ShowDecisionButton(bool enable)
		{
		}

		protected void ShowBackButton(bool enable)
		{
		}

		private void Awake()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
