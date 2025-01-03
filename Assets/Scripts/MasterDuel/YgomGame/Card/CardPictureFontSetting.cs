using System;
using UnityEngine;

namespace YgomGame.Card
{
	//[CreateAssetMenu]
	public class CardPictureFontSetting : ScriptableObject
	{
		[Serializable]
		public struct CardidFontSizePairData
		{
			public short cardid;

			public float fontsize;

			//public CardidFontSizePairData(short cardid, float fontsize)
			//{
			//}
		}

		public string language;

		public CardidFontSizePairData[] m_CardidNormalFontSizePairDatas;

		public CardidFontSizePairData[] m_CardidPendulumFontSizePairDatas;
	}
}
