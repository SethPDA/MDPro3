using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomEntryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public enum Mode
		{
			NORMAL = 0,
			SPECTER = 1
		}

		internal class Data
		{
			internal int id;

			internal string name;

			internal string regulation;

			internal int comment;

			internal int memberMax;

			internal int memberNum;

			internal string endDate;

			public Data(int id, string name, string regulation, int comment, int memberMax, int memberNum, string endDate)
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string BTN_RELOAD_LABEL;

		private readonly string INPUT_LABEL;

		private readonly string TXT_TITLE_LABEL;

		private readonly string TXT_PLACEHOLDER_LABEL;

		private InfinityScrollView isv;

		private List<Data> dataList;

		private Mode mode;

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

		private string GetIDKeyName(Mode mode)
		{
			return null;
		}

		private void CallAPIRoomEntry(int id, Mode mode)
		{
		}

		private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
		{
			return null;
		}

		private void CallAPIRoomGetRoomList(Action<bool> onEnd = null)
		{
		}

		private void CallAPIRoomGetRoomList2(Action<bool> onEnd)
		{
		}
	}
}
