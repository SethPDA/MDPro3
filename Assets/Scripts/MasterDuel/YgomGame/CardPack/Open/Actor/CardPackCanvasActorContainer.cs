using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.HeaderFooter;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackCanvasActorContainer : ActorContainerBase<CardPackCanvasActorContainer>
	{
		private readonly string k_ELabelTouchArea;

		private readonly string k_ELabelOpenLabel;

		private readonly string k_ELabelOpenAllCardButton;

		private readonly string k_ELabelNextLabel;

		private readonly string k_ELabelNextButton;

		private readonly string k_ELabelFinishLabel;

		private readonly string k_ELabelFinishButton;

		private readonly string k_ELabelSkipButton;

		private readonly string k_ELabelProgressText;

		private OutGameFooter m_Footer;

		private SelectionButton m_TouchArea;

		private SelectionButton m_OpenAllCardButton;

		private GameObject m_OpenLabel;

		private GameObject m_NextLabel;

		private GameObject m_FinishLabel;

		private SelectionButton m_SkipButton;

		public SelectionButton touchArea => null;

		public SelectionButton openAllCardButton => null;

		public bool skipButtonAble
		{
			set
			{
			}
		}

		public TMP_Text progressText
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

		public OutGameFooter footer => null;

		public event Action onDownTouchAreaEvent
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

		public event Action onUpTouchAreaEvent
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

		public event Action onClickTouchAreaEvent
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

		public event Action onInputAcceptEvent
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

		public event Action onInputAcceptKeyEvent
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

		public event Action onInputSub2KeyEvent
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

		public event Action<SelectionItem.DragStatus, Vector2> onDragEvent
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

		public event Action onInputSkipEvent
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

		public static CardPackCanvasActorContainer Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void AssignFooter(OutGameFooter footer)
		{
		}

		public void MoveParent(Transform newParent)
		{
		}

		public void SetLabelToOpen()
		{
		}

		public void SetLabelToNext()
		{
		}

		public void SetLabelToFinish()
		{
		}

		private void OnDownTouchArea()
		{
		}

		private void OnUpTouchArea()
		{
		}

		private void OnClickTouchArea()
		{
		}

		private void OnInputAcceptKey()
		{
		}

		private void OnInputSub2Key()
		{
		}

		private void OnClickSkipButton()
		{
		}

		public CardPackCanvasActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
