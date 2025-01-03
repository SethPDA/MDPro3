using System;
using System.Collections;
using UnityEngine.Events;
using YgomSystem.Network;

namespace YgomGame.Room
{
	public class RoomUtil
	{
		public enum LPType
		{
			LP_8000 = 1,
			LP_4000 = 2
		}

		public static string GetSettingTextLP(LPType type)
		{
			return null;
		}

		public static string MakeDuelDurationString(string name, int duration)
		{
			return null;
		}

		public static bool HandleResultCode(Handle handle, UnityAction onSuccess = null, UnityAction<RoomCode> onFailed = null)
		{
			return false;
		}

		public static void CallGetDeckList(int deckId, Action<bool> onEnd)
		{
		}

		public static void CallReplayAPIForRoom(long did, long pcode, Action<PvPCode> onResult = null)
		{
		}

		public static void CallSaveReplayAPI(long did, int eid, Action<PvPCode> onResult = null)
		{
		}

		public static void CloseAllDialogs()
		{
		}

		private static IEnumerator CloseAllDialogsRoutine()
		{
			return null;
		}
	}
}
