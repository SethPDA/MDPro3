using System;

namespace YgomGame.Duel
{
	public class ReplayBase
	{
		protected const int ParamSize = 8;

		protected IntPtr recordPtr;

		protected BlockingQueue<byte[]> replayQueue;

		protected BlockingQueue<byte[]> recordQueue;

		protected int recordSize;

		protected bool isEndReplay;

		protected bool dataEnd;

		public virtual void InitReplay()
		{
		}

		public void InitRecord()
		{
		}

		public void SetRecord(byte[] dat = null)
		{
		}

		public void EndData()
		{
		}

		public void Finish()
		{
		}

		public byte[] GetData()
		{
			return null;
		}

		protected void AllocMemory()
		{
		}

		protected void ReleaseMemory()
		{
		}

		protected void ReleaseRecordQueue()
		{
		}

		protected void ReleaseReplayQueue()
		{
		}

		protected bool AddQueueFromData(byte[] data)
		{
			return false;
		}

		protected void AddRecordImpl(IntPtr ptr, int size)
		{
		}

		protected IntPtr NowRecordImpl()
		{
			return (IntPtr)0;
		}

		protected void RecordNextImpl()
		{
		}

		protected void RecordBeginImpl()
		{
		}

		protected int IsRecordEndImpl()
		{
			return 0;
		}
	}
}
