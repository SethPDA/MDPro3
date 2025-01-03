using System;
using System.Collections.Generic;
using YgomGame.Menu;

namespace YgomGame.Room
{
	public class RoomInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class Data
		{
			internal string label;

			internal string value;

			public Data(string label, string value)
			{
			}
		}

		private readonly string BTN_ROOM_COPY_LABEL;

		private readonly string BTN_SPECTOR_COPY_LABEL;

		private readonly string TXT_TITLE_LABEL;

		private readonly string TXT_ROOM_LABEL;

		private readonly string TXT_ROOM_MEMBER_LABEL;

		private readonly string TXT_SPECTOR_LABEL;

		private readonly string TXT_SPECTOR_MEMBER_LABEL;

		private readonly string TXT_ITEM_LABEL;

		private readonly string TXT_VALUE_LABEL;

		private readonly string ROOT_NORMAL_LABEL;

		private readonly string ROOT_SPECTOR_LABEL;

		private readonly string SCROLL_LABEL;

		private readonly string IMG_LINE_LABEL;

		private readonly string TXT_REGULATION_LABEL;

		private readonly string ICON_REGULATION_LABEL;

		private readonly string TXT_ROOM_DEADLINE;

		private const string KEY_ENTRY_MODE = "EntryMode";

		private const string KEY_ROOM_NAME = "RoomName";

		private const string KEY_ROOM_ID = "RoomID";

		private const string KEY_SPECTOR_ID = "SpectorID";

		private const string KEY_ROOM_MEMBER_CURRENT = "RoomMemberCurrent";

		private const string KEY_SPECTOR_MEMBER_CURRENT = "RoomSpectorCurrent";

		private const string KEY_ROOM_MEMBER_MAX = "RoomMemberMax";

		private const string KEY_PUBLIC = "IsPublic";

		private const string KEY_SPECTRAL = "IsSpectral";

		private const string KEY_SPECTER = "IsSpecter";

		private const string KEY_ROOM_COMMENT = "RoomComment";

		private const string KEY_BATTLE_TIME_ID = "BattleTimeId";

		private const string KEY_BATTLE_LP = "BattleLP";

		private const string KEY_REPLAY = "IsReplay";

		private const string KEY_REGNAME = "RegName";

		private const string KEY_REGID = "RegID";

		private List<Data> roomSettings;

		private RoomEntryViewController.Mode mode;

		private string roomName;

		private int roomID;

		private int roomMemberCurrent;

		private int roomMemberMax;

		private int spectorID;

		private int spectorMemberCurrent;

		private string regulationName;

		private int regulationID;

		private string roomDeadlineDate;

		protected override Type[] textIds => null;

		public static Dictionary<string, object> GetArgs(RoomEntryViewController.Mode mode, string roomName, int roomID, int roomMemberCurrent, int roomMemberMax, string isPublic, string isSpectral, string isSpecter, string roomComment, int battleTimeId, string battleLP, string isReplay, int spectorID, int spectorMemberCurrent, int regulationID, string regulationName)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
