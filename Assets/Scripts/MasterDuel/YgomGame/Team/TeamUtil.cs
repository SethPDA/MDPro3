using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamUtil
	{
		public class RegulationSet
		{
			public string name
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int id
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] regulations
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		public enum MatchType
		{
			Null = 0,
			Normal = 1,
			Max = 2
		}

		private static string stringCrossPlatformPlay => null;

		public static bool IsForceLeaveError(TeamCode code)
		{
			return false;
		}

		public static bool IsFatalError(TeamCode code)
		{
			return false;
		}

		public static bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<TeamCode> onFailed, bool showDialog = true)
		{
			return false;
		}

		public static void OpenRegulationSelect(int[] regulationList, Action<int, string> onResult)
		{
		}

		public static void OpenDeckSelect(ViewControllerManager manager, int regulationID, int deckId)
		{
		}

		public static void CallAPI_DeckCheck(int regulationId, Action onEnd)
		{
		}

		public static void CallAPI_SetReulationSetID(int regSetId, Action<TeamCode> onEnd)
		{
		}

		public static void CallAPI_TeamEntry(int teamId, Action onSuccess)
		{
		}

		public static void CallAPI_TeamEntry(int teamId, int matchType, Action onSuccess, Action onFailed)
		{
		}

		public static void CallAPI_TeamEntryAndArrive(int teamId, int matchType, int tableNo, Action onSuccess, Action onFailed)
		{
		}

		public static string GetStringFromTextID(string text)
		{
			return null;
		}
	}
}
