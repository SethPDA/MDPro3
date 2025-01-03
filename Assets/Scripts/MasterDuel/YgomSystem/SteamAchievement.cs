namespace YgomSystem
{
	public class SteamAchievement
	{
		public enum ID
		{
			jp_konami_masterduel_ach_001 = 0,
			jp_konami_masterduel_ach_002 = 1,
			jp_konami_masterduel_ach_003 = 2,
			jp_konami_masterduel_ach_004 = 3,
			jp_konami_masterduel_ach_005 = 4,
			jp_konami_masterduel_ach_006 = 5,
			jp_konami_masterduel_ach_007 = 6,
			jp_konami_masterduel_ach_008 = 7,
			jp_konami_masterduel_ach_009 = 8,
			jp_konami_masterduel_ach_010 = 9,
			jp_konami_masterduel_ach_011 = 10
		}

		private static bool enable_notificator;

		private static readonly string id_convert_format;

		public static void SetNotificator()
		{
		}

		public static void ReleaseNotificator()
		{
		}

		public static void OnAchievementDone(object value)
		{
		}

		public static void Store()
		{
		}

		public static void ShowUI()
		{
		}

		public static void Progress(string param, string id, uint cursor, uint max)
		{
		}

		public static void Unlock(string id)
		{
		}

		public static void Unlock(ID id)
		{
		}
	}
}
