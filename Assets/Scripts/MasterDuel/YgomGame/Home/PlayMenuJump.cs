using System;
using YgomGame.Home.PlayMenuJumpInternal;

namespace YgomGame.Home
{
	public class PlayMenuJump
	{
		public static void GotoStandardMenu(Action<bool> resultCallback = null)
		{
		}

		public static void GotoExhibitionMenu(int id, Action<bool> resultCallback = null)
		{
		}

		public static void GotoDuelistCupMenu(Action<bool> resultCallback = null)
		{
		}

		public static void GotoWCSMenu(Action<bool> resultCallback = null)
		{
		}

		public static void GotoDuelTrialMenu(int id, Action<bool> resultCallback = null)
		{
		}

		public static void GotoRankEventMenu(int id, Action<bool> resultCallback = null)
		{
		}

		private static void execute(PlayMenuJumperBase jumper, Action<bool> callback = null)
		{
		}
	}
}
