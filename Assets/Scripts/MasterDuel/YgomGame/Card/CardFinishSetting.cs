using System;
using UnityEngine;

namespace YgomGame.Card
{
	//[CreateAssetMenu]
	public class CardFinishSetting : ScriptableObject
	{
		public enum FinishType
		{
			Normal = 0,
			Shine = 1,
			Royal = 2,
			SP1 = 3,
			SP2 = 4,
			SP3 = 5
		}

		[Serializable]
		public struct CardFinishData
		{
			public int cardid;

			public int finishid;

			public FinishType finsihtype;
		}

		private static CardFinishSetting m_Instance;

		private const string PATH = "Duel/ScriptableObject/CardFinishSetting";

		[SerializeField]
		private CardFinishData[] cardFinishData;

		protected static CardFinishSetting Instance => null;

		public static FinishType GetCardFisnishData(int cardid, int finishid)
		{
			return default(FinishType);
		}
	}
}
