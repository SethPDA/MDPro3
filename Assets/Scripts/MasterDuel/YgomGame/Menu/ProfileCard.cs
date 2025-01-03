using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ProfileCard
	{
		public const string IMG_ICON_LABEL = "ImageIcon";

		public const string IMG_LEVELGAUGE_LABEL = "LevelGauge";

		public const string IMG_RANK_LABEL = "ImageRank";

		public const string IMG_AVATAR_LABEL = "ImageAvatar";

		public const string IMG_WALLPAPER_LABEL = "ImageWallPaper";

		public const string IMG_BACK_BG_LABEL = "BackBG";

		public const string TXT_FOLLOW_LABEL = "TextFollow";

		public const string TXT_FOLLOWER_LABEL = "TextFollower";

		public const string TXT_ID_LABEL = "TextID";

		public const string TXT_LEVEL_LABEL = "TextLevel";

		private readonly string TXT_PLATFORM_NAME_LABEL;

		private readonly string TXT_PLATFORM_ICON_LABEL;

		public const string ArgsKey_Name = "name";

		public const string ArgsKey_PlayerCode = "pcode";

		public const string ArgsKey_FollowNum = "follow_num";

		public const string ArgsKey_FollowerNum = "follower_num";

		public const string ArgsKey_Level = "level";

		public const string ArgsKey_Rank = "rank";

		public const string ArgsKey_Rate = "rate";

		public const string ArgsKey_IconID = "icon_id";

		public const string ArgsKey_FrameID = "icon_frame_id";

		public const string ArgsKey_TagID = "tag";

		public const string ArgsKey_AvatarID = "avatar_id";

		public const string ArgsKey_WallPaperID = "wallpaper";

		public const string ArgsKey_Exp = "exp";

		public const string ArgsKey_ExpNeed = "need_exp";

		public const string ArgsKey_OnlineId = "online_id";

		public const string ArgsKey_IsSameOS = "is_same_os";

		public const string ArgsKey_Xuid = "xuid";

		public const string ArgsKey_Edit = "edit";

		public const string ArgsKey_RankEvent = "rank_event";

		public const string ArgsKey_Official = "official";

		public BindingGameObjectEx bgoEX;

		public ElementObjectManager eom;

		private readonly string k_ELabelButtonGamerCard;

		private SelectionButton m_ButtonGamerCard;

		private bool isMine;

		private ulong xuid;

		private Selector m_Selector;

		private bool isEditButtonActive;

		private TextGroupLoadHolder m_TextGroupLoadHolder;

		private Dictionary<string, object> m_ProfileDic;

		public Selector selector => null;

		public ProfileCard(GameObject parent, Dictionary<string, object> args, bool playTween = true, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		public ProfileCard(GameObject parent, long pcode, bool playTween = true)
		{
		}

		public void UpdateProfile(Dictionary<string, object> profileDic)
		{
		}

		public void SetName(string name, string platformName = null, bool isSamePlatform = false)
		{
		}

		public void SetOfficialIcon(int iconType)
		{
		}

		public void HidePcode()
		{
		}

		public void SetProfileIcon(int baseId, int frameId)
		{
		}

		public void SetIconFrame(int id)
		{
		}

		public void SetIconBase(int id)
		{
		}

		public void SetTag(List<object> list)
		{
		}

		public void SetAvatar(int id)
		{
		}

		public void SetWallPaper(int id)
		{
		}

		public void OpenGamerCard()
		{
		}
	}
}
