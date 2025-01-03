using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public struct LogDataSide
	{
		public int dataint
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte boolbits
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte databyte0
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte databyte1
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte datatype
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

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

		public LogDataSide(byte datatype)
		{
		}

		public LogDataSide(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight, int effectid)
		{
		}

		public LogDataSide(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight)
		{
		}

		public LogDataSide(bool show, int cardid, int owner, int position, int index, bool turned, bool face, bool insight)
		{
		}

		public LogDataSide(bool show, int playerid)
		{
		}

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
