using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomMemberViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class Data
		{
			internal long pcode;

			internal string name;

			internal int win;

			internal int lose;

			internal int draw;

			internal int iconID;

			internal int iconFrameID;

			internal bool isResistedPlatform;

			internal bool isSamePlatform;

			internal string platformName;

			public Data(long pcode, string name, int win, int lose, int draw, int iconID, int iconFrameID, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string TXT_WIN_NUM_LABEL;

		private readonly string TXT_LOSE_NUM_LABEL;

		private readonly string TXT_DRAW_NUM_LABEL;

		private readonly string IMG_ICON_LABEL;

		private readonly string PLATFORM_NAME_LABEL;

		private readonly string PLATFORM_ICON_LABEL;

		private InfinityScrollView isv;

		private List<Data> dataList;

		private float pastSec;

		private bool isCallingAPI;

		protected override Type[] textIds => null;

		private void Update()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void UpdateEntity(GameObject gob, int index)
		{
		}

		private void SetData()
		{
		}

		private void CallAPIRoomTablePoling()
		{
		}

		private void OnErrorCallAPI(RoomCode roomCode)
		{
		}
	}
}
