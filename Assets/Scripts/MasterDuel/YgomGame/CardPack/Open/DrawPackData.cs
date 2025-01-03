using System.Collections.Generic;
using YgomGame.Card;

namespace YgomGame.CardPack.Open
{
	public class DrawPackData
	{
		public readonly List<DrawCardData> drawCardDatas;

		public string packImagePath;

		public CardCollectionInfo.Rarity packType;

		public CardCollectionInfo.Rarity packTypeUpgrade1;

		public CardCollectionInfo.Rarity packTypeUpgrade2;

		public int thunderType;

		public int cutType;
	}
}
