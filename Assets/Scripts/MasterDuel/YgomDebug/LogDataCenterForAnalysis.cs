using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;

namespace YgomDebug
{
	[Serializable]
	public struct LogDataCenterForAnalysis
	{
		[SerializeField]
		private int dataint0;

		[SerializeField]
		private int dataint1;

		[SerializeField]
		private byte boolbits;

		[SerializeField]
		private byte databyte0;

		[SerializeField]
		private byte databyte1;

		[SerializeField]
		private byte datatype;

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

		//public LogDataCenterForAnalysis(LogDataCenter logDataCenter)
		//{
		//}

		//public LogDataCenterForAnalysis(bool show, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
		//{
		//}

		//public LogDataCenterForAnalysis(bool show, int efxbegin, int efxend, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
		//{
		//}

		//public LogDataCenterForAnalysis(bool show, int changevalue, int restLP, Engine.DamageType lpctype, bool isIndent, bool team)
		//{
		//}

		//public LogDataCenterForAnalysis(bool show, int numpre, int numaft, int countertype, bool isIndent, bool team)
		//{
		//}

		//public LogDataCenterForAnalysis(int coincount, int resultbits)
		//{
		//}

		//public LogDataCenterForAnalysis(int dicenum, bool team)
		//{
		//}

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
