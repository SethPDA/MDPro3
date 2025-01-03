using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class PresentBoxViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class Data
		{
			internal int pID;

			internal int itemCategory;

			internal int itemID;

			internal int quantity;

			internal string message;

			internal string limitDate;

			internal bool isPeriod;

			public Data(int pID, int itemCategory, int itemID, int quantity, string message, string limitDate, bool isPeriod)
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string TXT_EMPTY_LABEL;

		private readonly string TXT_MESSAGE_LABEL;

		private readonly string TXT_NAME_LABEL;

		private readonly string BTN_ALL_LABEL;

		private readonly string BTN_LABEL;

		private readonly string TXT_DATE_LABEL;

		private readonly string IMG_ICON_LABEL;

		private InfinityScrollView infinityScroll;

		private List<Data> dataList;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void CallAPIPresentBoxReceive(int presentBoxID, int isAll)
		{
		}

		private string SetDialogMessage(string beforeStr, string addStr)
		{
			return null;
		}

		private void UpdateData()
		{
		}

		private void UpdateScrollDataCount(int count)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}
	}
}
