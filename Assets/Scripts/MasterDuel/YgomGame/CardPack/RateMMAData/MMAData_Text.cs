using System.Collections.Generic;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData
{
	public class MMAData_Text : MMADataBase
	{
		public class Data
		{
			public string textId;

			public object[] args;

			public Data()
			{
			}

			public Data(Dictionary<string, object> sourceDic)
			{
			}

			public string OutputText()
			{
				return null;
			}
		}

		internal const string k_TP = "text";

		public Data[] datas;

		public MMAData_Text()
		{
		}

		public MMAData_Text(Dictionary<string, object> sourceDic)
		{
		}

		public override IMDMarkupContent OutputContent()
		{
			return null;
		}

		protected string OutputText()
		{
			return null;
		}
	}
}
