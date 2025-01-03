using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomGame.CardPack.Open.Widget;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackRootActorContainer : ActorContainerBase<CardPackRootActorContainer>
	{
		private readonly string k_ELabelBgRoot;

		private const string k_ELabelInfoGrp = "InfoGrp";

		private readonly string k_ELabelPackGrp;

		private readonly string k_ELabelCardGrp;

		private readonly string k_ELabelReflectionRenderCanvas;

		private readonly string k_ELabelReflectionRenderImage;

		private readonly string k_ELabelFoundKeyTotal;

		[SerializeField]
		private ActorBindingRefs m_ActorBindingRefs;

		private PlayableDirector m_Playable;

		private ElementObjectManager m_Root3DEom;

		private ElementObjectManager m_RootUIEom;

		public PlayableDirector playable => null;

		public ActorBindingRefs bindingRefs => null;

		public CardPackBgActorContainer bgContainer
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

		public CardPackInfoActorContainer infoContainer
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

		public CardPackPackActorContainer packContainer
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

		public CardPackCardActorContainer cardContainer
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

		public CardPackFoundKeyWidget foundKeyWidget
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

		public CardPackCanvasActorContainer canvasContainer
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

		public bool isPlaingPlayable => false;

		public bool isLoopPlayable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPausePlayable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Canvas reflectionRenderCanvas => null;

		public RawImage reflectionRenderImage => null;

		public static CardPackRootActorContainer Create(ElementObjectManager rootEom, ElementObjectManager root3DEom, ElementObjectManager rootUIEom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void Hide()
		{
		}

		public void Show()
		{
		}

		public void PlayPlayable(PlayableAsset playableAsset)
		{
		}

		public CardPackRootActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
