using System.Collections.Generic;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData
{
	public class MMAData_PremireTable : MMADataBase
	{
		public class Data
		{
			public int premire;

			public string rate;
		}

		internal const string k_TP = "premiereTable";

		public Data[] datas;

		public MMAData_PremireTable()
		{
		}

		public MMAData_PremireTable(Dictionary<string, object> sourceDic)
		{
		}

		public override IMDMarkupContent OutputContent()
		{
			return null;
		}
	}
}
