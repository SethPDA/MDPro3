using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomSystem.Network
{
	public class Request
	{
		private static Dictionary<string, EventHandler> s_commandHandle;

		private static event EventHandler s_commonStartHandle
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

		private static event EventHandler s_commonCompleteHandle
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

		private static event EventHandler s_commonErrorHandle
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

		public static Handle SetCommonHandler(Handle handle)
		{
			return null;
		}

		public static void InvokeCommonStartHandle(Handle handle)
		{
		}

		public static void AddCommonStartEvent(EventHandler e)
		{
		}

		public static void AddCommonCompleteEvent(EventHandler e)
		{
		}

		public static void AddCommonErrorEvent(EventHandler e)
		{
		}

		public static void RemoveCommonStartEvent(EventHandler e)
		{
		}

		public static void RemoveCommonCompleteEvent(EventHandler e)
		{
		}

		public static void RemoveCommonErrorEvent(EventHandler e)
		{
		}

		public static void AddCommandEvent(string command, EventHandler e)
		{
		}

		public static void DelCommandEvent(string command, EventHandler e)
		{
		}

		public static Handle Entry(string command, Dictionary<string, object> param = null, float timeOut = 30f)
		{
			return null;
		}

		public static void CommandEvent(string command, Handle handle)
		{
		}
	}
}
