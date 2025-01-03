namespace YgomGame.Duel
{
	public class ListCardData
	{
		public enum DataSource
		{
			FromPosSelectList = 0,
			FromGetCommandMask = 1,
			FromRunList = 2,
			FromLocalCollection = 3
		}

		public bool selectted;

		public bool forceinsgiht;

		public bool extraExcludeFlag;

		public bool targetted;

		public byte styleid;

		public byte chainnum;

		public int cardid;

		public int badgeindex;

		public int listIndexForEngine;

		public int dataindex;

		public int textid;

		public int targetUid;

		public Engine.CardStatus cardstatus;

		public Engine.BasicVal basicval;

		public DataSource dataSource;

		public bool hasInstance => false;

		public int uniqueid => 0;

		public bool insight => false;

		public bool isknown => false;

		public ListCardData(int cardid, int styleid, Engine.BasicVal basicval, Engine.CardStatus cardstatus, bool forceinsgiht, int listIndexForEngine, int chainnum, DataSource dataSource, int textid = 0, int targetUid = -1, bool extraExcludeFlag = false)
		{
		}

		public ListCardData(int cardid, int listIndexForEngine)
		{
		}
	}
}
