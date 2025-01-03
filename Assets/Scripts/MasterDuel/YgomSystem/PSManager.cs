using System;
using UnityEngine;

namespace YgomSystem
{
	public class PSManager : MonoBehaviour
	{
		public const int ICON_CENTER = 0;

		public const int ICON_LEFT = 1;

		public const int ICON_RIGHT = 2;

		private const float premiumFeatureIntervalVal = 2f;

		public static void StartPSPremiumCheck(bool IsSpectating, Action<bool> callback, bool openPlusDialog = false)
		{
		}

		public static void EndPSPremiumCheck()
		{
		}

		public static void ShowPsStoreIcon(bool state, int postion = 0)
		{
		}

		public static void CheckCommunicationRestriction(Action<bool> callback)
		{
		}

		public static void StartTutorialActivity()
		{
		}

		public static void EndTutorialActivity()
		{
		}

		public static void StartMatchActivity()
		{
		}

		public static void EndMatchActivity()
		{
		}

		public static void StartTeamMatchActivity()
		{
		}

		public static void EndTeamMatchActivity()
		{
		}

		public static bool IsPSPlatform()
		{
			return false;
		}

		public static bool IsMultiPlayOK()
		{
			return false;
		}

		public static void ShowMultiPlayNGMessage()
		{
		}

		public static string GetPushContextId(bool isInvite = false)
		{
			return null;
		}

		public static void ShowEmptyStoreMessage()
		{
		}
	}
}
