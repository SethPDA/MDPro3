using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using YgomGame.TextIDs;
using YgomSystem.Network;

namespace YgomGame.WCS.Portal
{
	public class Util
	{
		private static readonly string[] s_teamIconSmallPaths;

		private static readonly string[] s_teamIconLargePaths;

		private static readonly IDS_WCSPORTAL[] s_teamAreaIDs;

		public static void OpenPortal()
		{
		}

		public static void OpenPortalOnHome()
		{
		}

		public static void GoToVotePushOnHome()
		{
		}

		private static IEnumerator GoToVotePushOnHomeCoroutine()
		{
			return null;
		}

		public static void ShowExpiredDialog(Action callback = null)
		{
		}

		public static bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<WcsCode> onFailed, bool showDialog = true)
		{
			return false;
		}

		public static bool IsCampaignOpen()
		{
			return false;
		}

		public static Def.CampaignStatus GetCampaignStatus()
		{
			return default(Def.CampaignStatus);
		}

		public static int GetChampionTeamID()
		{
			return 0;
		}

		public static bool IsReceivableVoteReward()
		{
			return false;
		}

		public static Dictionary<string, object> GetCampaign()
		{
			return null;
		}

		public static Dictionary<string, object> GetCampaignMaster()
		{
			return null;
		}

		public static string GetTeamIconPathByIndex(int index, bool large)
		{
			return null;
		}

		public static string GetTeamIconPath(int teamID, bool isLarge)
		{
			return null;
		}

		public static string GetTeamAreaName(int teamID)
		{
			return null;
		}

		public static string GetTeamName(int teamID)
		{
			return null;
		}

		public static int GetTeamOrder(int teamID)
		{
			return 0;
		}

		public static Dictionary<string, object> GetTeamMaster(int teamID)
		{
			return null;
		}
	}
}
