using System.Collections.Generic;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData
{
	public class MMAData_Header : MMAData_Text
	{
		internal new const string k_TP = "header";

		public MMAData_Header()
		{
		}

		public MMAData_Header(Dictionary<string, object> sourceDic)
		{
		}

		public override IMDMarkupContent OutputContent()
		{
			return null;
		}
	}
}
