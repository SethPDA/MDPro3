using System;

namespace YgomGame.Menu
{
	public class ProfileUtil
	{
		private const string AVATARICON_PATH = "Images/Menu/AvatarIcon/{0}";

		private const string WALLPAPER_THUMB_PATH = "Images/WallPaper/WallPaper{0:D4}/WallPaperThumb{1}";

		public const int MYTAG_QUANTITY = 4;

		public static void CallFriendFollow(long pcode, int delete, Action endAction = null, Action errorAction = null)
		{
		}

		public static string GetAvatarIconPath(int id)
		{
			return null;
		}

		public static string GetWallPaperThumbPath(int id)
		{
			return null;
		}

		public static void PushProfileViewPlayer(int player)
		{
		}

		public static void PushProfileViewPcode(long pcode)
		{
		}

		public static void CallBlockAPI(long pcode, int delete, Action endAction = null, Action errorAction = null)
		{
		}

		public static bool CheckFriendIsBlock(long pcode)
		{
			return false;
		}
	}
}
