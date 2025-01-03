using System.Collections.Generic;

namespace YgomGame.Duel
{
	public struct CardInfoData
	{
		public bool hasinstance;

		public int cardid;

		public int uniqueid;

		public int player;

		public int owner;

		public int position;

		public int index;

		public int cardattribute;

		public int styleid;

		public int orglevel;

		public int orgrank;

		public int orgtype;

		public int effectflag;

		public int overlaynum;

		public int orgscale;

		public int scale;

		public int turncounter;

		public bool isfightableoneffect;

		public bool istuner;

		public Engine.BasicVal basicval;

		public List<KeyValuePair<Engine.CounterType, int>> countertable;
	}
}
