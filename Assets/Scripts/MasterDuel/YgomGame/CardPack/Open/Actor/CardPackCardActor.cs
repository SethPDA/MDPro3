using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackCardActor : ActorBase<CardPackCardActor>
	{
		private readonly string k_ELabelBackModel;

		private readonly string k_ELabelFrontModel;

		private readonly string k_ELabelFrontPremiereModel;

		private readonly string k_ELabelRareIconSprite;

		private readonly string k_ELabelNewIcon;

		private readonly string k_ELabelPickupIcon;

		private readonly string k_ELabelRarityFrame;

		private readonly string k_ELabelSelectCursor;

		private readonly string k_ELabelSelectCursorFront;

		private readonly string k_ELabelSelectCursorBack;

		private ActorBindingRefs m_BindingRefs;

		private PlayableDirector m_Playable;

		private SelectionButton m_Button;

		private MeshRenderer m_BackRenderer;

		private MeshRenderer m_FrontRenderer;

		private MeshRenderer m_FrontPremireRenderer;

		private SpriteRenderer m_RareIconRenderer;

		private SpriteRenderer m_NewIconRenderer;

		private SpriteRenderer m_PIckupIconRenderer;

		private GameObject m_RarityFrame;

		private GameObject m_SelectCursorBack;

		private GameObject m_SelectCursorFront;

		private int m_LoadingCnt;

		public int mrk
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int premium
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPlayingPlayable
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlayableAsset currentPlayableAsset => null;

		public bool isReady => false;

		public bool newIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool pickupIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool frontCursorVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool backCursorVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool rarityFrameVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SelectionButton button => null;

		public event Action<CardPackCardActor> onAcceptKeyEvent
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

		public event Action<CardPackCardActor> onDetailKeyEvent
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

		public event Action<CardPackCardActor, SelectionItem.DragStatus, Vector2> onDragEvent
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

		public event Action<CardPackCardActor> onPointerDownEvent
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

		public event Action<CardPackCardActor> onPointerUpEvent
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

		public event Action<CardPackCardActor> onPointerClickEvent
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

		public static CardPackCardActor Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void Binding(int mrk, int premium)
		{
		}

		public void PlayPlayable(PlayableAsset playableAsset, DirectorWrapMode wrapMode = DirectorWrapMode.None)
		{
		}

		private void OnBeginPlayable(PlayableDirector playable)
		{
		}

		private void OnEndPlayable(PlayableDirector playable)
		{
		}

		public CardPackCardActor()
		{
			//((ActorBase<>)(object)this)._002Ector();
		}
	}
}
