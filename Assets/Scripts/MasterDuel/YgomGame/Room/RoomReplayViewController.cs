using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomReplayViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public enum BattleStatus
		{
			WIN = 1,
			LOSE = 2,
			DRAW = 3
		}

		internal class ReplayData
		{
			internal MemberData[] members;

			internal long did;

			public ReplayData(MemberData[] members, long did)
			{
			}
		}

		internal class MemberData
		{
			internal long pcode;

			internal string name;

			internal int iconID;

			internal int iconFrameID;

			internal BattleStatus batteStatus;

			internal bool isResistedPlatform;

			internal bool isSamePlatform;

			internal string platformName;
		}

		private readonly string SCROLL_LABEL;

		private readonly string TXT_WIN_LABEL;

		private readonly string TXT_LOSE_LABEL;

		private readonly string TXT_DRAW_LABEL;

		private readonly string IMG_ICON_LABEL;

		private readonly string PLATFORM_NAME_LABEL;

		private readonly string PLATFORM_ICON_LABEL;

		private readonly string TXT_EMPTY_LABEL;

		private InfinityScrollView isv;

		private List<ReplayData> dataList;

		private bool isReplay;

		protected override Type[] textIds => null;

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

		private void CallAPIRoomGetResultList(UnityAction onSuccess = null)
		{
		}
	}
}
