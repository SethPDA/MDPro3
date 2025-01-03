using System.Runtime.CompilerServices;

namespace YgomGame.Duelpass
{
	public class DuelpassRewardContext
	{
		public bool IsPeriod
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ItemCategory
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ItemId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ItemCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsRecommend
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Grade
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int RewardId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsReceived
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PASS_TYPE PassType
		{
			[CompilerGenerated]
			get
			{
				return default(PASS_TYPE);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsAchieved
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasGoldPass
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelpassRewardContext(object master, int rewardId, bool isRecieved, bool isAchieved, bool hasGoldPass)
		{
		}

		public DuelpassRewardContext(object master, int grade, int rewardId, bool isReceived, bool isAchieved, PASS_TYPE passType, bool hasGoldPass)
		{
		}

		public void Receive()
		{
		}

		public bool CanReceive()
		{
			return false;
		}
	}
}
