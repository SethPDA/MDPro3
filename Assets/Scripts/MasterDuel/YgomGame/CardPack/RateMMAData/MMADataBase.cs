using System.Collections.Generic;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData
{
	public abstract class MMADataBase : IMMAData
	{
		public int indent;

		public MMADataBase()
		{
		}

		public MMADataBase(Dictionary<string, object> sourceDic)
		{
		}

		public abstract IMDMarkupContent OutputContent();
	}
}
