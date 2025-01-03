using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Colosseum
{
	public class ColosseumRankingDuelistCupViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public enum regionType
		{
			REGION_JAPAN = 1,
			REGION_ASIA = 2,
			REGION_NORTH_AMERICA = 3,
			REGION_LATIN_AMERICA = 4,
			REGION_EUROPE_OTHER = 5
		}

		protected class RankingDuelistCupTemplate
		{
			public readonly int dp;

			public readonly long pcode;

			public readonly string name;

			public readonly string order;

			public readonly int iconID;

			public readonly int frameID;

			public readonly int is_same_os;

			public readonly int online_id;

			public readonly bool isResistedPlatform;

			public readonly bool isSamePlatform;

			public readonly string platformName;

			private RankingDuelistCupTemplate(long pcode, string name, string order, int iconID, int frameID, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}

			public RankingDuelistCupTemplate(long pcode, string name, string order, int iconID, int frameID, int dp, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}
		}

		protected readonly string ROOT_MYORDER_LABEL;

		protected readonly string ROOT_RANK1_LABEL;

		protected readonly string ROOT_RANK2_LABEL;

		protected readonly string ROOT_RANK3_LABEL;

		protected readonly string SCROLL_RANKING_LABEL;

		protected readonly string BUTTON_LABEL;

		protected readonly string IMG_ICON_LABEL;

		protected readonly string IMG_RANK_LABEL;

		protected readonly string IMG_ARROW_LABEL;

		protected readonly string PLATFORM_NAME_LABEL;

		protected readonly string PLATFORM_ICON_LABEL;

		protected readonly string TXT_ORDER_LABEL;

		protected readonly string TXT_SCORE_LABEL;

		protected readonly string TXT_AGGREGATE_MY_TEXT;

		protected readonly string TXT_AGGREGATE_TEXT;

		protected readonly string TXT_CAUTION_TEXT;

		protected readonly string ROOT_WCS_MYORDER_LABEL;

		protected readonly string TXT_WCS_SCORE_NAME_LABEL;

		protected readonly string TXT_WCS_SCORE_LABEL;

		protected readonly string TXT_WCS_ORDER_NAME_LABEL;

		protected readonly string TXT_WCS_REGION_ORDER_NAME_LABEL;

		protected readonly string TXT_WCS_ORDER_LABEL;

		protected readonly string TXT_WCS_REGION_ORDER_LABEL;

		protected readonly string TXT_TITLE;

		protected readonly string FOOTER_LABEL;

		protected readonly string EOM_BUTTON_CAHNGE_AREA_LABEL;

		protected int TOP_RANK;

		protected InfinityScrollView isv;

		protected ElementObjectManager rootMyOrder;

		protected ElementObjectManager wcsRootMyOrder;

		protected List<ElementObjectManager> rootRanks;

		protected int tid;

		protected int cid;

		protected ColosseumUtil.RankingType type;

		protected Util.GameMode mode;

		protected List<RankingDuelistCupTemplate> rankingTemplates;

		protected List<string> rankingAreaList;

		protected string currentArea;

		protected int currentAreaIdx;

		private ExtendedTextMeshProUGUI TitleText;

		private long myPcode;

		private int myIconId;

		private int myFrameId;

		private int DefaultThresholdNum;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void CallAPIDuelistCupRanking(int cid)
		{
		}

		private void CallAPI_WCSRanking(int wcs_id)
		{
		}

		private void SetActiveFooterArea(bool active)
		{
		}

		private void InitRanking()
		{
		}

		private void setFooterAreaCallBack()
		{
		}

		private void OnClickChangeArea()
		{
		}

		private void UpdateMyRanking()
		{
		}

		private void UpdateRanking(Dictionary<string, object> rankingList, bool isChangeRegion = false)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnGsvStanby()
		{
		}

		protected string GetWinLoseText(Dictionary<string, object> dic)
		{
			return null;
		}

		protected string GetWinLoseText(string win, string lose, string draw)
		{
			return null;
		}

		protected string GetWinLoseTextFromNum(int win, int lose, int draw)
		{
			return null;
		}
	}
}
