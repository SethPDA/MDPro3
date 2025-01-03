using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class ProfileReplayViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class ProfileReplayInfo
		{
			internal long did;

			internal int mode;

			internal int iconID;

			internal int frameID;

			internal int rank;

			internal int tier;

			internal long timestamp;

			internal string dateTime;

			internal string name;

			internal Engine.ResultType result;

			internal string title;

			internal string turn;

			internal bool isOpen;

			internal int eventId;

			internal long pcode;

			internal bool isSameOS;

			internal string onlineId;

			internal int regulationId;

			public ProfileReplayInfo(long did, int mode, int iconID, int frameID, int rank, int tier, long timestamp, string dateTime, string name, Engine.ResultType result, string title, string turn, bool isOpen, int eventId, long pcode = 0L, bool isSameOS = false, string onlineId = null, int regulationId = 0)
			{
			}
		}

		private readonly string IMG_ICON_LABEL;

		private readonly string SCROLL_REPLAY_LABEL;

		private readonly string TXT_NOTBOOKMARK_LABEL;

		private readonly string TXT_TITLE_LABEL;

		private readonly string TMP_BTN_LABEL;

		private readonly string TMP_IMG_TITLE_LABEL;

		private readonly string TMP_IMG_OPEN_LABEL;

		private readonly string TMP_TXT_DATE_LABEL;

		private readonly string TMP_TXT_RESULT_LABEL;

		private readonly string TMP_TXT_TITLE_LABEL;

		private readonly string TMP_TXT_TURN_LABEL;

		private readonly string TMP_TXT_PLATFORM_NAME_LABEL;

		private readonly string TMP_TXT_PLATFORM_ICON_LABEL;

		private InfinityScrollView isv;

		private long pcode;

		private List<ProfileReplayInfo> replayInfos;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void DeleteReplayDialog(long did, string strDate)
		{
		}

		private void DeleteReplay(long did)
		{
		}

		private void PlayReplay(long did)
		{
		}

		private void SetReplayOpen(long did, bool isOpen)
		{
		}

		private void CheckOpponentDeck(long did, int regulationId = 0)
		{
		}

		private void UpdateProfileReplay(Dictionary<string, object> replayDic)
		{
		}

		private void SortReplayDate(bool descendingOrder = true)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnGsvStanby()
		{
		}

		private void OpenProfileCard(long pcode)
		{
		}
	}
}
