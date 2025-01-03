using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Friend;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Team
{
	public class TeamInviteViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class Data
		{
			internal long pcode;

			internal object playerInfo;

			internal bool isOnline;

			internal bool isSelected;

			public Data(long pcode, object playerInfo, bool isOnline, bool isSelected = false)
			{
			}
		}

		private static readonly string VC_PATH;

		private static readonly string SCROLL_LABEL;

		private static readonly string BTN_INVITE_LABEL;

		private static readonly string TXT_EMPTY_LABEL;

		private static readonly string TXT_INVITE_COUNT_LABEL;

		private InfinityScrollView isv;

		private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

		private List<Data> dataList;

		private int currentInvite;

		private int maxInvite;

		protected override Type[] textIds => null;

		public static void Open(ViewControllerManager manager)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void CallAPIFriendGetList(UnityAction onSuccess = null)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
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

		private void CallAPITeamInvite(long[] pcodes)
		{
		}
	}
}
