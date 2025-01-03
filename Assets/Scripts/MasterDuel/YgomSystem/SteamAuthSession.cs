using System;
using System.Collections.Generic;
//using Steamworks;

namespace YgomSystem
{
	public class SteamAuthSession
	{
		public enum DIALOG_TYPE
		{
			NO_STEAMMANAGER_INITIALIZE = 0,
			NEED_REAUTH_REBOOT = 1
		}

		private string steam_auth_session;

		//private HAuthTicket m_HAuthTicket;

		private uint m_pcbTicket;

		private const int m_tokenLength = 1024;

		private byte[] m_token;

		//private Callback<GetAuthSessionTicketResponse_t> m_SessionTicketResponse;

		private Action<string> m_callback;

		private Dictionary<DIALOG_TYPE, Dictionary<string, object>> dialogParam;

		[Obsolete]
		public string GetSession()
		{
			return null;
		}

		public bool RequestSession(Action<string> callback)
		{
			return false;
		}

		public void CancelSession()
		{
		}

		public Dictionary<string, object> GetDialogParam(DIALOG_TYPE type)
		{
			return null;
		}

		private void GetSessionTicket()
		{
		}

		private bool RequestSessionTicket(Action<string> callback)
		{
			return false;
		}

		//private void RequestSessionTicketResponseCallback(GetAuthSessionTicketResponse_t r)
		//{
		//}
	}
}
