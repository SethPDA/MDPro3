using System;

namespace YgomGame.Credit
{
	[Serializable]
	public class CreditInfo
	{
		public string group;

		public string position;

		public string name;

		public string name2;

		public int nameNum;

		public CreditInfo()
		{
		}

		public CreditInfo(string group, string position, string name)
		{
		}

		public CreditInfo(string group, string position, string name, string name2)
		{
		}
	}
}
