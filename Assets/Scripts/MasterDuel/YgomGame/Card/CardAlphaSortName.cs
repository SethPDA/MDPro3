using System.Collections.Generic;

namespace YgomGame.Card
{
	public class CardAlphaSortName
	{
		private class SortNameInfo
		{
			public int mrk;

			public string sortName;

			public string fixedSortName;
		}

		private Dictionary<int, SortNameInfo> m_sortNameInfos;

		public CardAlphaSortName(string assetPath)
		{
		}

		public void SetSortName(byte[] bindata)
		{
		}

		public string GetSortName(int mrk)
		{
			return null;
		}

		public string GetFixedSortName(int mrk)
		{
			return null;
		}
	}
}
