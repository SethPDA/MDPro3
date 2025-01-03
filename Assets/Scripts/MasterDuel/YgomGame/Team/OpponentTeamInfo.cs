using System.Runtime.CompilerServices;

namespace YgomGame.Team
{
	public class OpponentTeamInfo
	{
		public static readonly string CW_PATH;

		private const string CW_PATH_DURATIONID = "duel_time";

		private const string CW_PATH_TEAM_ID = "opp_team_id";

		private const string CW_PATH_MRK = "opp_team_mrk";

		private const string CW_PATH_MATCHING_KEY = "matching_key";

		public int duelDurationId
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

		public int teamId
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

		public int mrk
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

		public string matchKey
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

		public bool isValid => false;

		private OpponentTeamInfo()
		{
		}

		public static OpponentTeamInfo AcquireFromCW()
		{
			return null;
		}

		public static OpponentTeamInfo LoadFromCW(object root)
		{
			return null;
		}

		public static bool IsOpponentFixed()
		{
			return false;
		}
	}
}
