namespace YgomGame.WCS.Portal
{
	public class Def
	{
		public enum CampaignStatus
		{
			Off = 0,
			Prepare = 1,
			Primary = 2,
			PreSemifinal = 3,
			Semifinal = 4,
			PreFinal = 5,
			Final = 6,
			Result = 7
		}

		public class CWPath
		{
			public static readonly string WcsfCampaign;

			public static readonly string MasterWcsfCampaign;

			public static readonly string MasterWcsfTeam;

			public static readonly string WcsfCampaign_room_info;

			public static readonly string WcsfCampaign_table_info;

			public static readonly string WcsfCampaign_room_member;

			public static readonly string WcsfCampaign_tournament_score;
		}

		public static class MMAAssetPath
		{
			public static readonly string DUEL_RULE;
		}
	}
}
