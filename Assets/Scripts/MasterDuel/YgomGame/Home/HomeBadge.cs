using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomGame.Home
{
	public class HomeBadge
	{
		public enum Badge
		{
			MISSION = 1,
			FRIEND = 2,
			DUEL = 3,
			SHOP = 4,
			PRESENT = 5,
			NOTICE = 6,
			QUEST = 7,
			DUELPASS = 8,
			DECK = 100,
			SUBMENU = 101,
			DUELLIVE = 102
		}

		private readonly string IMG_NUMBADGE_LABEL;

		private readonly string IMG_NEWBADGE_LABEL;

		private readonly string TXT_BADGE_LABEL;

		private Dictionary<Badge, ElementObjectManager> badgeMap;

		public void InitBadge(Badge badge, ElementObjectManager buttonEom)
		{
		}

		public void SetBadge(Badge badge, int count = 0)
		{
		}
	}
}
