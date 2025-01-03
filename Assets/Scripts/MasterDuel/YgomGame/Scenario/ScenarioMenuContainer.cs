using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario
{
	public class ScenarioMenuContainer : ElementWidgetBehaviourBase<ScenarioMenuContainer>
	{
		private readonly string k_ELabelRoot;

		private readonly string k_ELabelShrinkShortCutButton;

		private readonly string k_ELabelRootButton;

		private readonly string k_ELabelChildButtonGroup;

		private readonly string k_ELabelAutoButton;

		private readonly string k_ELabelLogButton;

		private readonly string k_ELabelSkipButton;

		private readonly string k_ELabelViewButton;

		private readonly string k_ELabelExpandedIcon;

		private readonly string k_ELabelShlinkedIcon;

		private readonly string k_TweenShow;

		private readonly string k_TweenHide;

		private readonly string k_TweenExpand;

		private readonly string k_TweenShrink;

		private readonly string k_TweenOnStartAuto;

		private readonly string k_TweenOnEndAuto;

		private GameObject m_Root;

		private GameObject m_ChildGroup;

		private Selector m_Selector;

		private LayoutGroup m_ChildGroupLayoutGroup;

		private SelectionButton m_RootButton;

		private ScenarioWork m_Work;

		private bool m_IsVisible;

		private bool m_IsExpanded;

		private bool m_IsPlayingExpandOrShrink;

		public Selector selector => null;

		public SelectionButton autoButton
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

		public SelectionButton logButton
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

		public SelectionButton skipButton
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

		public SelectionButton viewButton
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

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool expandIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool shrinkIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action onClickAnyButtonEvent
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

		public static ScenarioMenuContainer Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void Initialize(ScenarioWork work)
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void ToExpand(bool immediate = false)
		{
		}

		private void ToShrink(bool immediate = false)
		{
		}

		public void PlayHide(bool immediate = false)
		{
		}

		public void PlayShow(bool immediate = false)
		{
		}

		private void PlayOnAutoStart(bool immediate = false)
		{
		}

		private void PlayOnAutoEnd(bool immediate = false)
		{
		}

		public bool TryShrink(bool immediate = false)
		{
			return false;
		}

		private void OnClickCancelButton()
		{
		}

		private void OnClickRootButton()
		{
		}

		private void OnChangedAutoActive(bool isAuto)
		{
		}

		public bool OnBack()
		{
			return false;
		}

		public ScenarioMenuContainer()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
