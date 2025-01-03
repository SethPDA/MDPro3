using System;
using System.Collections.Generic;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData
{
	public class MMAData_RarityTable : MMADataBase
	{
		[Serializable]
		public class Data
		{
			public int rare;

			public string rate;

			public int num;
		}

		internal const string k_TP = "rarityTable";

		public Data[] datas;

		public MMAData_RarityTable()
		{
		}

		public MMAData_RarityTable(Dictionary<string, object> sourceDic)
		{
		}

		public override IMDMarkupContent OutputContent()
		{
			return null;
		}
	}
}
