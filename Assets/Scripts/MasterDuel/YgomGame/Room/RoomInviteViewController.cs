using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Friend;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomInviteViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class Data
		{
			internal long pcode;

			internal object playerInfo;

			internal bool isOnline;

			internal bool isSelected;

			public Data(long pcode, object playerInfo, bool isOnline, bool isSelected = false)
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string BTN_INVITE_LABEL;

		private readonly string INPUT_LABEL;

		private readonly string TXT_EMPTY_LABEL;

		private readonly string TXT_INVITE_COUNT_LABEL;

		private InfinityScrollView isv;

		private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

		private List<Data> dataList;

		private int currentInvite;

		private int maxInvite;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void CallAPIFriendGetList(UnityAction onSuccess = null)
		{
		}

		private void OnCreatedEntity(GameObject gob)
		{
		}

		private void UpdateEntity(GameObject gob, int index)
		{
		}

		private void SetData()
		{
		}

		private int CompareData(Data a, Data b)
		{
			return 0;
		}

		private void CallAPIRoomInvite(long[] pcodes)
		{
		}

		private Handle APIRoomFriendInvite(long[] _invite_list_)
		{
			return null;
		}
	}
}
