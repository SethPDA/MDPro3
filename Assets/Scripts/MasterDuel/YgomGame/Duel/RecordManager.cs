using System;

namespace YgomGame.Duel
{
	public class RecordManager : ReplayBase
	{
		public static RecordManager instance;

		public void Destroy()
		{
		}

		public override void InitReplay()
		{
		}

		public void SetReplay(byte[] data)
		{
		}

		public static void AddRecord(IntPtr ptr, int size)
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
