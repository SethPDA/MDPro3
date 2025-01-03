using System;
using System.Collections.Generic;

namespace YgomGame.Tutorial
{
	public class TutorialManager
	{
		private enum Step
		{
			NOT_GET_DECK = 0,
			NO_INPUT_NAME = 1,
			NO_GUIDANCE = 2
		}

		public enum FirstVisitMenu
		{
			DUEL_STANDARD = 0,
			SHOP = 1,
			DECK_EDIT = 2,
			QUEST = 3,
			HOME_ENTER_ONCE = 4,
			RENTAL_CARD = 5,
			DUELLIVE = 6,
			SHOP_MONSTER_CUTIN = 7,
			RESERVED9 = 8,
			RESERVED10 = 9,
			RESERVED11 = 10,
			RESERVED12 = 11,
			RESERVED13 = 12,
			RESERVED14 = 13,
			RESERVED15 = 14,
			RESERVED16 = 15,
			RESERVED17 = 16,
			RESERVED18 = 17,
			RESERVED19 = 18,
			RESERVED20 = 19
		}

		private const string FIRSTVISIT_SAVEPATH = "Tutorial_FirstVisit";

		private static Dictionary<int, bool> s_FirstVisitFlag;

		public static bool IsHomeGuidancePassed()
		{
			return false;
		}

		public static void FetchInfo(Action onReceivedFunc = null)
		{
		}

		public static void CheckGoingTutorial(Action onGoingTutorial, Action onGoingStructDeckSelect, Action onGoingNameEntry, Action onGoingHome)
		{
		}

		public static bool IsFirstVisit(FirstVisitMenu menu)
		{
			return false;
		}

		public static void Visited(FirstVisitMenu menu)
		{
		}

		public static void ResetFirstVisitData(FirstVisitMenu menu)
		{
		}

		public static void ResetFirstVisitData()
		{
		}

		public static void LoadFirstVisitData()
		{
		}

		public static string GetTutorialDuelistName()
		{
			return null;
		}
	}
}
