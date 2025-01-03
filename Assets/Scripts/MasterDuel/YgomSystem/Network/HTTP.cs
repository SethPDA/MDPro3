using System.Collections;
using System.Collections.Generic;

namespace YgomSystem.Network
{
	public class HTTP : PvP.Implement
	{
		private Queue<PvP.Event> send_queue;

		private Queue<PvP.Event> app_queue;

		private int connection_id;

		private int[] members;

		private string entry_url;

		private string entry_ticket;

		private bool is_poll;

		private PvP.EventHandler completeHandler;

		private PvP.EventHandler errorHandler;

		private PvP.EventHandler fatalHandler;

		private PvP.EventHandler recvHandler;

		private uint received_serial;

		private List<PvP.Event> evlist;

		private bool closed;

		private byte[] pollData;

		private bool appQuitAbort;

		private int jobCount;

		private static readonly byte[] dummy_bytes;

		public override void Connect(string url, string ticket, int port)
		{
		}

		public override int GetConnectionID()
		{
			return 0;
		}

		public override int[] GetMembers()
		{
			return null;
		}

		public override void Send(PvP.Command cmd, byte[] bin, uint serial)
		{
		}

		public override void Send(PvP.Event ev)
		{
		}

		public override PvP.Event Recv()
		{
			return null;
		}

		public override void Close()
		{
		}

		public override bool IsQue()
		{
			return false;
		}

		public override bool IsPoll()
		{
			return false;
		}

		public override PvP.Event Dequeue()
		{
			return null;
		}

		public override IEnumerator Exec(PvP.Event val)
		{
			return null;
		}

		public override void AddCompleteHandler(PvP.EventHandler handler)
		{
		}

		public override void AddErrorHandler(PvP.EventHandler handler)
		{
		}

		public override void AddFatalHandler(PvP.EventHandler handler)
		{
		}

		public override void AddRecvHandler(PvP.EventHandler handler)
		{
		}

		public override void RemoveRecvHandler(PvP.EventHandler handler)
		{
		}

		public override void ClearHandler()
		{
		}

		public override void SetPollingData(byte[] data)
		{
		}

		public override void ApplicationQuitAbort()
		{
		}

		public override int GetJobCount()
		{
			return 0;
		}

		private void Complete(PvP.Event ev)
		{
		}

		private void Error(PvP.Event ev, PvPCode code = PvPCode.ERROR)
		{
		}

		private void Fatal(PvP.Event ev, PvPCode code = PvPCode.FATAL)
		{
		}

		private void Received(PvP.Event ev, PvPCode code = PvPCode.NONE)
		{
		}
	}
}
