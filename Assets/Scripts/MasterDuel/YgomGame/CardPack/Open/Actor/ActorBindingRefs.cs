using System;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Card;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor
{
	[Serializable]
	public class ActorBindingRefs
	{
		[SerializeField]
		private PlayableAsset m_TmSeq01_PackEntry01;

		[SerializeField]
		private PlayableAsset m_TmSeq01_PackEntry10First;

		[SerializeField]
		private PlayableAsset m_TmSeq01_PackEntry10Next;

		[SerializeField]
		public PlayableAsset tmSeq02_PackThunder01;

		[SerializeField]
		public PlayableAsset tmSeq02_PackThunder02;

		[SerializeField]
		public PlayableAsset tmSeq02_PackThunder03;

		[SerializeField]
		private PlayableAsset m_TmSeq03_PackShakeUpgradeNToSR;

		[SerializeField]
		public PlayableAsset tmSeq03_PackShakeUpgradeNToUR;

		[SerializeField]
		private PlayableAsset m_TmSeq03_PackShakeUpgradeSRToUR;

		[SerializeField]
		public PlayableAsset tmSeq04_CutHope;

		[SerializeField]
		private PlayableAsset m_TmSeq05_PackOpen;

		[SerializeField]
		private PlayableAsset m_TmSeq05_PackOpenUpgrade;

		[SerializeField]
		private PlayableAsset m_TmSeq06_CardEntry;

		[SerializeField]
		private Material m_ScrollBgMatN;

		[SerializeField]
		private Material m_ScrollBgMatSR;

		[SerializeField]
		private Material m_ScrollBgMatUR;

		[SerializeField]
		private Sprite m_BottomBgSpriteSR;

		[SerializeField]
		private Sprite m_BottomBgSpriteUR;

		[SerializeField]
		private ElementObjectManager m_PackPrefDefault;

		[SerializeField]
		private ElementObjectManager m_PackPrefSR;

		[SerializeField]
		private ElementObjectManager m_PackPrefUR;

		[SerializeField]
		private ElementObjectManager m_CardPrefDefault;

		[SerializeField]
		private ElementObjectManager m_CardPrefSR;

		[SerializeField]
		private ElementObjectManager m_CardPrefUR;

		[SerializeField]
		private PlayableAsset m_TmCardOpenDefault;

		[SerializeField]
		private PlayableAsset m_TmCardOpenShake;

		[SerializeField]
		private PlayableAsset m_TmCardOpenSR;

		[SerializeField]
		private PlayableAsset m_TmCardOpenUR;

		[SerializeField]
		private PlayableAsset m_TmCardOpenPremium1;

		[SerializeField]
		private PlayableAsset m_TmCardOpenPremium2;

		[SerializeField]
		private Sprite[] m_InfoLabelBandSprites;

		public PlayableAsset tmSeq01_PackEntry01 => null;

		public PlayableAsset tmSeq01_PackEntry10First => null;

		public PlayableAsset tmSeq01_PackEntry10Next => null;

		public PlayableAsset tmSeq02_PackShakeUpgradeNToSR => null;

		public PlayableAsset tmSeq02_PackShakeUpgradeSRToUR => null;

		public PlayableAsset tmSeq03_PackOpen => null;

		public PlayableAsset tmSeq03_PackOpenUpgrade => null;

		public PlayableAsset tmSeq04_CardEntry => null;

		public Material scrollBgMatN => null;

		public Material scrollBgMatSR => null;

		public Material scrollBgMatUR => null;

		public Sprite bottomBgSpriteSR => null;

		public Sprite bottomBgSpriteUR => null;

		public ElementObjectManager packPrefDefault => null;

		public ElementObjectManager packPrefSR => null;

		public ElementObjectManager packPrefUR => null;

		public ElementObjectManager cardPrefDefault => null;

		public ElementObjectManager cardPrefSR => null;

		public ElementObjectManager cardPrefUR => null;

		public PlayableAsset tmCardOpenDefault => null;

		public PlayableAsset tmCardOpenShake => null;

		public PlayableAsset tmCardOpenSR => null;

		public PlayableAsset tmCardOpenUR => null;

		public PlayableAsset tmCardOpenPremium1 => null;

		public PlayableAsset tmCardOpenPremium2 => null;

		public Sprite[] infoLabelBandSprites => null;

		public PlayableAsset GetTmCardOnOpen(DrawCardData drawCardData)
		{
			return null;
		}

		public ElementObjectManager GetPackPref(CardCollectionInfo.Rarity packRarity)
		{
			return null;
		}
	}
}
