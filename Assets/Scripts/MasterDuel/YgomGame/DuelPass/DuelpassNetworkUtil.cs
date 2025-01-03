using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomSystem.Network;

namespace YgomGame.Duelpass
{
	public static class DuelpassNetworkUtil
	{
		public static Action onUpdate;

		public static List<DuelpassRewardContext> Contexts
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void RequestReceiveInfo(Action onComplete = null)
		{
		}

		public static void Init()
		{
		}

		public static void Update()
		{
		}

		public static bool WithinThePeriod()
		{
			return false;
		}

		public static bool ResultExists()
		{
			return false;
		}

		public static List<DuelpassRewardContext> GetDuelpassRewardContextList()
		{
			return null;
		}

		public static int GetCurrentGrade()
		{
			return 0;
		}

		public static DuelpassProgressBarContext GetProgressBarContext()
		{
			return null;
		}

		public static DuelpassResultProgressBarContext GetResultProgressBarContext()
		{
			return null;
		}

		public static int GetReceiveableRewardNum()
		{
			return 0;
		}

		public static int GetLatestAchievedGrade()
		{
			return 0;
		}

		public static int GetSeasonId()
		{
			return 0;
		}

		public static string GetStartTime()
		{
			return null;
		}

		public static string GetEndTime()
		{
			return null;
		}

		public static int GetEndTimeStamp()
		{
			return 0;
		}

		public static bool HasGoldpass()
		{
			return false;
		}

		public static DuelpassRewardContext GetContext(int rewardId)
		{
			return null;
		}

		private static void OnCompleteRecieve(Handle h, Action onSuccess, Action onFaild)
		{
		}

		public static void ItemDialog(int rewardId)
		{
		}

		public static void Receive(int id, Action onSuccess = null, Action onFaild = null)
		{
		}

		public static void SingleReceive(int rewardId)
		{
		}

		private static void OnSuccessSingleReceive(DuelpassRewardContext context)
		{
		}

		private static void OnFaildSingleReceive()
		{
		}

		public static void BulkReceive(int seasonId = -1, List<DuelpassRewardContext> contexts = null)
		{
		}

		private static void OnSuccessBulkReceive()
		{
		}

		private static void OnFaildBulkReceive()
		{
		}

		public static int GetShopId()
		{
			return 0;
		}

		public static void CheckReceivedItem()
		{
		}
	}
}
