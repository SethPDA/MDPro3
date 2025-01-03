using System;
using YgomGame.Duel;

namespace YgomDebug
{
	[Serializable]
	public struct LogDataSideForAnalysis
	{
		private int dataint;

		private byte boolbits;

		private byte databyte0;

		private byte databyte1;

		private byte datatype;

		private bool show => false;

		public bool isCardDataShow => false;

		public int cardid => 0;

		public int effectid => 0;

		public int position => 0;

		public int owner => 0;

		public bool turned => false;

		public bool insight => false;

		public bool face => false;

		public bool isoverlayunit => false;

		public bool isIconDataShow => false;

		public bool isDataValid => false;

		public int playerid => 0;

		//public LogDataSideForAnalysis(LogDataSide logDataSide)
		//{
		//}

		//public LogDataSideForAnalysis(byte datatype)
		//{
		//}

		//public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight, int effectid)
		//{
		//}

		//public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight)
		//{
		//}

		//public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, int index, bool turned, bool face, bool insight)
		//{
		//}

		//public LogDataSideForAnalysis(bool show, int playerid)
		//{
		//}

		public void AddEffectId(int effectid)
		{
		}

		public (int, byte, byte, bool, bool) GetCardData()
		{
			return default((int, byte, byte, bool, bool));
		}

		public (int, bool) GetIconData()
		{
			return default((int, bool));
		}
	}
}
