namespace YgomGame.Duel
{
	public struct ShowTurnData
	{
		public ulong bitdata0;

		public uint bitdata1;

		public int restlpl;

		public int restlpr;

		public int playeridc => 0;

		public int turn => 0;

		public int playeridl => 0;

		public int playeridr => 0;

		//public ShowTurnData(int playeridl, int playeridr, int restlpl, int restlpr, int turn, int playerid)
		//{
		//}
	}
}
