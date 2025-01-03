using System.Collections.Generic;

namespace YgomSystem.Network
{
	public class Handle
	{
		private NetworkMain.RequestStructure m_Request;

		public Handle(NetworkMain.RequestStructure request)
		{
		}

		public Handle AddCompleteEvent(EventHandler e)
		{
			return null;
		}

		public Handle AddErrorEvent(EventHandler e)
		{
			return null;
		}

		public void ClearAllEvent()
		{
		}

		public Handle Chain(Handle hdl)
		{
			return null;
		}

		public bool Retry()
		{
			return false;
		}

		public bool IsCompleted()
		{
			return false;
		}

		public bool IsError()
		{
			return false;
		}

		public bool IsFatal()
		{
			return false;
		}

		public bool IsLongPolling()
		{
			return false;
		}

		public int GetCode()
		{
			return 0;
		}

		public void Finish()
		{
		}

		public string GetCommand()
		{
			return null;
		}

		public Dictionary<string, object> GetParam()
		{
			return null;
		}

		public int GetId()
		{
			return 0;
		}

		public void Abort()
		{
		}
	}
}
