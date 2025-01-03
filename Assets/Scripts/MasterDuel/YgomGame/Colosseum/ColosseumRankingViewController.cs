using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumRankingViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		protected class RankingTemplate
		{
			public readonly long pcode;

			public readonly string name;

			public readonly int order;

			public readonly int iconID;

			public readonly int frameID;

			public readonly int rank;

			public readonly int tier;

			public readonly int score;

			public readonly int win;

			public readonly int lose;

			public readonly int draw;

			public readonly bool isResistedPlatform;

			public readonly bool isSamePlatform;

			public readonly string platformName;

			private RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}

			public RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, int score, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}

			public RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, int win, int lose, int draw, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
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

		protected readonly string TXT_LOW_RANK_LABEL;

		protected int TOP_RANK;

		protected InfinityScrollView isv;

		protected ElementObjectManager rootMyOrder;

		protected List<ElementObjectManager> rootRanks;

		protected int tid;

		protected ColosseumUtil.RankingType type;

		protected Util.GameMode mode;

		protected List<RankingTemplate> rankingTemplates;

		private long myPcode;

		private int myIconId;

		private int myFrameId;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void CallAPIChallengeRanking()
		{
		}

		private void CallAPITournamentRanking()
		{
		}

		private void InitRanking()
		{
		}

		private void UpdateRanking(List<object> rankingList)
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
