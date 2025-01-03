using System;
using YgomGame.Duel;

namespace YgomDebug
{
	[Serializable]
	public struct ShowTurnDataForAnalysis
	{
		public ulong bitdata0;

		public uint bitdata1;

		public int restlpl;

		public int restlpr;

		public int playeridc => 0;

		public int turn => 0;

		public int playeridl => 0;

		public int playeridr => 0;

		//public ShowTurnDataForAnalysis(ShowTurnData showTurnData)
		//{
		//}
	}
}
