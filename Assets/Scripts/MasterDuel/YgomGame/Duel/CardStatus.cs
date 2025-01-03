using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardStatus
	{
		private List<CardStatusEffect> dynamicAnchorEffs;

		private CardStatusEffect chainOrderEff;

		private CardStatusEffect sacrificeTgtEff;

		private CardStatusLabel3D statusLabel3d;

		public bool IsShowing
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

		public bool ShowFullStatus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isTerminated => false;

		public CardRoot cardRoot
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

		private DuelEffectPool pool => null;

		private ICardStatusIconAnchor dynamicAnchor => null;

		private ICardStatusIconAnchor cardAnchor => null;

		public static CardStatus Create(CardRoot cardRoot)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public void Update()
		{
		}

		private void UpdateStatusLabel3d()
		{
		}

		private Vector2 World2ScreenPos(Vector3 pos)
		{
			return default(Vector2);
		}

		public void StartStatusLabel3D(bool immediate = false)
		{
		}

		public void EndStatusLabel3D(bool immediate = false)
		{
		}

		public void InitParameters()
		{
		}

		public void AtkToDefEffect()
		{
		}

		public void DefToAtkEffect()
		{
		}
	}
}
