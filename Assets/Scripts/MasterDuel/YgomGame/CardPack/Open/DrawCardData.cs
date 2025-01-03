using YgomGame.Card;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open
{
	public class DrawCardData
	{
		public int mrk;

		public int premium;

		public int locatePos;

		public bool isNew;

		public int foundSecretNum;

		public ElementObjectManager cardPref;

		public bool isVisibleRarityFrame;

		public CardCollectionInfo.Rarity backSideRarity;

		public CardCollectionInfo.Rarity rarity => default(CardCollectionInfo.Rarity);
	}
}
