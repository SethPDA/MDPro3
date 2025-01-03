using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.OpenResult
{
	public class CardWidget : YgomGame.CardPack.CardWidget
	{
		private readonly string k_ELabelSecretPulldown;

		public readonly SecretPulldownWidget secretPulldownWidget;

		public Action<CardWidget> onClickCardCallback;

		public Action<CardWidget> onClickPulldownCallback;

		public Action<CardWidget> onSelectedCardCallback;

		public Action<CardWidget> onDeselectedCardCallback;

		public Action<CardWidget> onSelectedPulldownCallback;

		public Action<CardWidget> onDeselectedPulldownCallback;

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

		public int idx
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

		public CardWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Binding(int mrk, int idx, int pRareType, IReadOnlyList<int> shopIds, bool isExpand = false)
		{
		}

		protected override void OnClick()
		{
		}
	}
}
