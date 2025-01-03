using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public struct LogDataCenter
	{
		public int dataint0
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

		public int dataint1
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

		public bool isActDataShow => false;

		public bool isIndent => false;

		public bool team => false;

		public bool extendinfo => false;

		public LOGACTIONTYPE acttype => default(LOGACTIONTYPE);

		public int efxbegin => 0;

		public int efxend => 0;

		public bool isLPCDataShow => false;

		public int changevalue => 0;

		public int restLP => 0;

		public Engine.DamageType lpctype => default(Engine.DamageType);

		public bool isCCDataShow => false;

		public int numpre => 0;

		public int numaft => 0;

		public Engine.CounterType countertype => default(Engine.CounterType);

		public bool isDiceDataShow => false;

		public bool isCoinDataShow => false;

		public LogDataCenter(bool show, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
		{
		}

		public LogDataCenter(bool show, int efxbegin, int efxend, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
		{
		}

		public LogDataCenter(bool show, int changevalue, int restLP, Engine.DamageType lpctype, bool isIndent, bool team)
		{
		}

		public LogDataCenter(bool show, int numpre, int numaft, int countertype, bool isIndent, bool team)
		{
		}

		public LogDataCenter(int coincount, int resultbits)
		{
		}

		public LogDataCenter(int dicenum, bool team)
		{
		}

		public void AddEfxNoInfo(int efxbegin, int efxend)
		{
		}

		public (LOGACTIONTYPE, bool) GetActionData()
		{
			return default((LOGACTIONTYPE, bool));
		}

		public (int, int, Engine.DamageType, bool) GetLPChangeData()
		{
			return default((int, int, Engine.DamageType, bool));
		}

		public (int, int, Engine.CounterType, bool) GetCounterChangeData()
		{
			return default((int, int, Engine.CounterType, bool));
		}

		public void SetBmgVisible()
		{
		}

		public (bool, int) GetDiceData()
		{
			return default((bool, int));
		}

		public List<bool> GetCoinResults()
		{
			return null;
		}
	}
}
