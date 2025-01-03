namespace YgomGame.Solo
{
	public class SoloModeUtil
	{
		public enum DialogType
		{
			DUEL = 0,
			SCENARIO = 1,
			LOCK = 2,
			REWARD = 3,
			TUTORIAL = 4
		}

		public enum DeckType
		{
			POSSESSION = 0,
			STORY = 1
		}

		public enum ChapterStatus
		{
			UNOPEN = -1,
			OPEN = 0,
			RENTAL_CLEAR = 1,
			MYDECK_CLEAR = 2,
			COMPLETE = 3
		}

		public enum RewardType
		{
			STORY_CLEAR = 1,
			MYDECK_CLEAR = 2
		}

		public enum UnlockType
		{
			USER_LEVEL = 1,
			CHAPTER_OR = 2,
			ITEM = 3,
			CHAPTER_AND = 4,
			HAS_ITEM = 5
		}

		public const int MAX_DIFFICULTY = 5;
	}
}
