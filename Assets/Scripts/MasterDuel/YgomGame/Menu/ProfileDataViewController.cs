using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.TextIDs;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class ProfileDataViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class ProfileDataInfo
		{
			internal IDS_RECORD record;

			internal long value;

			public ProfileDataInfo(IDS_RECORD record, long value)
			{
			}
		}

		private readonly string SCROLL_DATA_LABEL;

		private readonly string BTN_CAUTION_LABEL;

		private readonly string TEXT_TITLE_LABEL;

		private readonly string TEXT_VALUE_LABEL;

		private InfinityScrollView isvData;

		private SelectionButton m_CautionButton;

		private SelectionButtonUntouchable m_DataAreaButton;

		private long totalPvP;

		private long pcode;

		private List<object> rankHistory;

		private List<ProfileDataInfo> dataInfos;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void UpdateProfileData(Dictionary<string, object> recordDict)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnGsvStanby()
		{
		}

		private void OpenCautionDialog()
		{
		}
	}
}
