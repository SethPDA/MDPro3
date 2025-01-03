using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Scenario
{
	public class ScenarioObjectContainerUI : ScenarioContainerBase
	{
		private readonly string k_ELabelRootUI;

		private readonly string k_ELabelClickAreaButton;

		private readonly string k_ELabelRootScreen;

		private readonly string k_ELabelTextArea;

		private readonly string k_ELabelScreenTextUnder;

		private readonly string k_ELabelScreenTextOver;

		private readonly string k_ELabelMenuButtonAcordion;

		private readonly string k_ELabelLogScreen;

		private readonly string k_ELabelInputBlocker;

		private readonly string k_ELabelInputBlockerButton;

		public readonly Selector inputBlocker;

		public readonly SelectionButton clickAreaButton;

		public readonly ScenarioRootScreen rootScreen;

		public readonly ScenarioTextContainer textContainer;

		public readonly ScenarioScreenContainer screenContainer;

		public readonly ScenarioMenuContainer menuContainer;

		public readonly ScenarioLogContainer logContainer;

		public GameObject rootUI => null;

		public event Action onClickAreaEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onClickInputBlockerEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ScenarioObjectContainerUI(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(ScenarioWork work)
		{
		}

		public bool OnBack()
		{
			return false;
		}
	}
}
