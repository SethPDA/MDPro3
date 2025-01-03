using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Network
{
	public class NetworkMain : MonoBehaviour
	{
		public class RequestStructure
		{
			private static int s_RequestIdCount;

			private static byte[] s_NullArray;

			private int memId;

			private string memCmd;

			private Dictionary<string, object> memParam;

			private RequestStructure memChain;

			private bool memIsInnerChain;

			private Queue<RequestStructure> refRequestQue;

			public Handle handle;

			public Status status;

			public int code;

			public float timeOut;

			public bool deckext;

			public bool abort;

			public bool finished;

			public bool nofatal;

			public string Command => null;

			public Dictionary<string, object> Param => null;

			public int Id => 0;

			public RequestStructure Next => null;

			public bool IsInnerChain => false;

			public byte[] Body => null;

			public event EventHandler errorEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event EventHandler completeEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event EventHandler retryEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public RequestStructure(string command, Dictionary<string, object> param, Queue<RequestStructure> q)
			{
			}

			public void Entry()
			{
			}

			public void Remove()
			{
			}

			public void Chain(RequestStructure req)
			{
			}

			public void Complete()
			{
			}

			public void Error()
			{
			}

			public void Retry()
			{
			}

			public void ClearAllEvent()
			{
			}
		}

		private static Queue<RequestStructure> s_refRequestQue;

		private static List<RequestStructure> s_refExcList;

		private static bool s_suspend;

		private static string s_Version;

		private static string s_Session;

		private static string s_Lang;

		private static string s_UserAgent;

		private static float s_TouchSum;

		private Protocol m_Protocol;

		private Protocol m_ProtocolDeckExt;

		private static bool s_AbortPorotocol;

		private static Action s_ShutdownCallback;

		private static Action<Action> s_disconnectAction;

		public static NetworkReachability Reachability => default(NetworkReachability);

		public static string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string Session
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string Lang
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string UserAgent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static float TouchSum
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static void RequestShutdown(Action callback)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public static Handle Entry(string cmd, Dictionary<string, object> param, float timeout)
		{
			return null;
		}

		private void IEnumRequest(RequestStructure data)
		{
		}

		private void IPvPEnumRequest(PvP.Event val)
		{
		}

		public static void SetDisconnectAction(Action<Action> action)
		{
		}

		public static void ResetRequest()
		{
		}
	}
}
