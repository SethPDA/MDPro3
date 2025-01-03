using System.Collections;

namespace YgomSystem.Network
{
	public class PvP
	{
		public enum Command
		{
			ENTRY = 0,
			INIT = 1,
			WAIT = 2,
			READY = 3,
			COMMAND = 4,
			EFFECT = 5,
			CANCEL = 6,
			RESULT = 7,
			DBGCMD = 8,
			CHEATCARD = 9,
			CHAT = 10,
			LIST = 11,
			PHASE = 12,
			SKILL = 13,
			LEAVE = 14,
			EXIT = 15,
			RECOVERY = 16,
			WATCH = 17,
			SURRENDER = 18,
			LATENCY = 19,
			SEND = 20,
			RECV = 21,
			TIME = 22,
			TURN = 23,
			DATA = 50,
			REPLAY = 60,
			TIMEUP = 97,
			FINISH = 98,
			POLL = 99,
			ERROR = 100,
			FATAL = 900,
			CONNECT = 1000,
			RECONNECT = 1001,
			CLOSE = 1003,
			PING = 1004,
			PONG = 1005,
			MATCH = 1006,
			DROP = 1007,
			MATCH_UPDATE = 1010,
			MATCH_LIST = 1011,
			INFO = 1012
		}

		public class KeyDef
		{
			public const string CMD = "c";

			public const string BODY = "b";

			public const string TICKET = "t";

			public const string TOKEN = "token";

			public const string SERIAL = "s";

			public const string USERAGENT = "ua";

			public const string DATA = "d";

			public const string ID = "id";

			public const string INFO = "in";

			public const string FROM = "f";

			public const string HOST = "h";

			public const string TIME = "tm";

			public const string COND = "cn";

			public const string MODE = "m";

			public const string PROF = "p";

			public const string ERROR = "e";
		}

		public class Event
		{
			private Command memCmd;

			private byte[] memBody;

			private uint memSerial;

			public Command Cmd => default(Command);

			public byte[] Body => null;

			public uint Serial => 0u;

			public Event(Command cmd, byte[] body, uint serial = 0u)
			{
			}
		}

		public abstract class Implement
		{
			public abstract void Connect(string url, string ticket, int port);

			public virtual bool IsQue()
			{
				return false;
			}

			public virtual bool IsPoll()
			{
				return false;
			}

			public abstract Event Dequeue();

			public abstract IEnumerator Exec(Event val);

			public virtual void Close()
			{
			}

			public abstract int GetConnectionID();

			public abstract int[] GetMembers();

			public abstract void Send(Command cmd, byte[] bin, uint serial);

			public abstract void Send(Event ev);

			public abstract Event Recv();

			public abstract void AddCompleteHandler(EventHandler handler);

			public abstract void AddErrorHandler(EventHandler handler);

			public abstract void AddFatalHandler(EventHandler handler);

			public abstract void AddRecvHandler(EventHandler handler);

			public abstract void RemoveRecvHandler(EventHandler handler);

			public abstract void ClearHandler();

			public abstract void SetPollingData(byte[] data);

			public abstract void ApplicationQuitAbort();

			public abstract int GetJobCount();
		}

		public delegate void EventHandler(Event val, int code = 0);

		private static Implement s_refPvP;

		public static void Connect(string url, string ticket, int port = 80)
		{
		}

		public static void Send(Command cmd, byte[] bin, uint serial)
		{
		}

		public static void Send(Event ev)
		{
		}

		public static Event Recv()
		{
			return null;
		}

		public static void Close()
		{
		}

		public static bool IsActive()
		{
			return false;
		}

		public static bool IsQue()
		{
			return false;
		}

		public static bool IsPoll()
		{
			return false;
		}

		public static Event Dequeue()
		{
			return null;
		}

		public static IEnumerator Exec(Event val)
		{
			return null;
		}

		public static void AddCompleteHandler(EventHandler handler)
		{
		}

		public static void AddErrorHandler(EventHandler handler)
		{
		}

		public static void AddFatalHandler(EventHandler handler)
		{
		}

		public static void AddRecvHandler(EventHandler handler)
		{
		}

		public static void RemoveRecvHandler(EventHandler handler)
		{
		}

		public static void ClearHandler()
		{
		}

		public static void SetPollingData(byte[] data)
		{
		}

		public static void ApplicationQuitAbort()
		{
		}

		public static int GetJobCount()
		{
			return 0;
		}
	}
}
