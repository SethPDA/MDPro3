using System;

namespace YgomGame.Duel
{
	public class ReplayStream : ReplayBase
	{
		public static ReplayStream s_instance;

		public void Destroy()
		{
		}

		public override void InitReplay()
		{
		}

		public bool IsQueued()
		{
			return false;
		}

		public void Add(byte[] data)
		{
		}

		public static IntPtr NowRecord()
		{
			return (IntPtr)0;
		}

		public static void RecordNext()
		{
		}

		public static void RecordBegin()
		{
		}

		public static int IsRecordEnd()
		{
			return 0;
		}
	}
}
