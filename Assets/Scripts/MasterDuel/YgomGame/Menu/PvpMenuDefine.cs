namespace YgomGame.Menu
{
	public class PvpMenuDefine
	{
		public enum MatchingType
		{
			UNKNOWN = 0,
			FREE = 1,
			RANK = 2,
			TOURNAMENT = 3,
			WATCH = 4,
			ROOM = 5,
			EXHIBITION = 6,
			DUELISTCUP = 7,
			RANKEVENT = 8,
			TEAM = 9,
			DUELTRIAL = 10,
			WCS = 11,
			VERSUS = 12,
			WCS_FINAL = 13,
			MAX = 14
		}

		public const string ARGNAME_MATCH = "match";

		public const string ARGNAME_PARAM = "param";

		public const string ARGNAME_DPARAM = "dparam";

		public const string ARGNAME_TYPE = "type";

		public const string ARGNAME_OTHER = "other";

		public const string ARGNAME_RANK_EVENT_ID = "rank_event_id";

		public const string ARGNAME_GAMEMODE = "GameMode";

		public const string ARGNAME_MODE = "mode";

		public const string ARGNAME_RESEARCH = "research";

		public const string ARGNAME_RESEARCHTIME = "researchTime";

		public const string ARGNAME_PS_ONLINE_ID = "ps_online_id";

		public const string ARGNAME_XBOX_ONLINE_ID = "xbox_online_id";

		public const string ARGNAME_TID = "tid";

		public const string ARGNAME_EXHID = "exhid";

		public const string ARGNAME_CID = "cid";

		public const string ARGNAME_WCS_ID = "wcs_id";

		public const string ARGNAME_DUEL_TRIAL_ID = "duel_trial_id";

		public const string ARGNAME_VERSUS_ID = "versus_id";

		public const string ARGNAME_RENTAL_STATE = "rental_state";

		public const string ARGNAME_SEASON_ID = "season_id";

		public const string ARGNAME_IS_TEAM_LEADER = "is_team_leader";

		public const string ARGNAME_OPP_TEAM_ID = "opp_team_id";

		public const string ARGNAME_MATCHING_KEY = "matching_key";
	}
}
