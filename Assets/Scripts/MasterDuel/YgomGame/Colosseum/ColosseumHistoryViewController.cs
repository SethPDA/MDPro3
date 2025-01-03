using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal abstract class ModeBehaviour
		{
			protected class Data
			{
				public int idx;

				public long did;

				public int mode;

				public long pcode;

				public int iconID;

				public int frameID;

				public int rank;

				public int tier;

				public string date;

				public string name;

				public Engine.ResultType result;

				public int turn;

				public int eventId;

				public long time;

				public bool isResistedPlatform;

				public bool isSamePlatform;

				public string platformName;

				public Data(int idx, long did, int mode, long pcode, int iconID, int frameID, int rank, int tier, string date, string name, Engine.ResultType result, int turn, int eventId, long time, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
				{
				}
			}

			protected readonly string IMG_RANK_LABEL;

			protected readonly string TMP_BTN_LABEL;

			protected readonly string TMP_IMG_ICON_LABEL;

			protected readonly string TMP_TXT_DATE_LABEL;

			protected readonly string TMP_TXT_OPPONENT_LABEL;

			protected readonly string TMP_TXT_RESULT_LABEL;

			protected readonly string TMP_TXT_TURN_LABEL;

			protected readonly string TMP_TXT_TITLE_LABEL;

			protected readonly string TMP_TITLE_TEXT_LABEL;

			protected readonly string TXT_TITLE_LABEL;

			protected readonly string TXT_NOTBOOKMARK_LABEL;

			protected readonly string PLATFORM_NAME_LABEL;

			protected readonly string PLATFORM_ICON_LABEL;

			protected readonly ColosseumHistoryViewController vc;

			protected readonly InfinityScrollView isv;

			protected readonly ElementObjectManager eom;

			protected readonly int id;

			protected readonly Util.GameMode duelUtilGameMode;

			protected List<Data> dataList;

			protected long limitTs;

			protected virtual string CWKEY_MYID => null;

			protected virtual string CWKEY_DID => null;

			protected virtual string CWKEY_ICON => null;

			protected virtual string CWKEY_ICONFRAME => null;

			protected virtual string CWKEY_DATE => null;

			protected virtual string CWKEY_PLAYER => null;

			protected virtual string CWKEY_PCODE => null;

			protected virtual string CWKEY_NAME => null;

			protected virtual string CWKEY_RANK => null;

			protected virtual string CWKEY_RATE => null;

			protected virtual string CWKEY_RES => null;

			protected virtual string CWKEY_TURN => null;

			protected virtual string CWKEY_TIME => null;

			protected virtual string CWKEY_ONLINEID => null;

			protected virtual string CWKEY_ISSAMEOS => null;

			protected virtual string CWKEY_MODE => null;

			protected virtual string CWKEY_EVENTID => null;

			protected virtual int ADJUST_ISV_INDEX => 0;

			protected ModeBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
			{
			}

			internal abstract void CallAPI();

			internal abstract string GetTitle();

			internal virtual void InitializeScroll()
			{
			}

			internal virtual void UpdateView(Dictionary<string, object> dictionary)
			{
			}

			internal virtual bool CanStartUpdateEntity(GameObject go, int dataIndex)
			{
				return false;
			}

			protected virtual void BindRankIcon(Data data, ElementObjectManager entityEom)
			{
			}

			protected virtual void OnClickButton(Data data)
			{
			}

			protected void OpenActionSheetFull(Data data)
			{
			}

			protected void OpenActionSheetFree(Data data)
			{
			}

			protected void OpenActionSheetCup(Data data)
			{
			}

			internal void OnSuccessAPI()
			{
			}

			internal void OnUpdateEntity(GameObject go, int dataIndex)
			{
			}

			internal virtual void CallAPISaveReplay(long did, int eid = 0)
			{
			}

			protected void UpdateScrollData(Dictionary<string, object> dictionary)
			{
			}

			protected Data SetData(KeyValuePair<string, object> kvp, Dictionary<string, object> dic)
			{
				return null;
			}

			protected bool CanPlayReplay(long id, long time)
			{
				return false;
			}

			protected void OpenReportDialog(long opponentId)
			{
			}

			protected void CallAPIPvPGetHistoryDeck(long did, int mode, int exid)
			{
			}
		}

		internal class StandardBehaviour : ModeBehaviour
		{
			private class DataRankHistory
			{
				public readonly int rank;

				public readonly int tier;

				public DataRankHistory(int rank, int tier)
				{
				}
			}

			protected readonly string IMG_OPEN_LABEL;

			private const int RECENT_RANK_DATA_INDEX = 0;

			private const int RECENT_RANK_TEMPLATE_INDEX = 1;

			private const int RANK_HISTORY_NUM = 6;

			private DataRankHistory[] dataRankHistorys;

			protected override string CWKEY_EVENTID => null;

			protected override int ADJUST_ISV_INDEX => 0;

			public StandardBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void InitializeScroll()
			{
			}

			internal override void UpdateView(Dictionary<string, object> dictionary)
			{
			}

			internal override bool CanStartUpdateEntity(GameObject go, int dataIndex)
			{
				return false;
			}

			internal override string GetTitle()
			{
				return null;
			}
		}

		internal class TournamentBehaviour : ModeBehaviour
		{
			protected override string CWKEY_EVENTID => null;

			public TournamentBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}
		}

		internal class ExhibitionBehaviour : ModeBehaviour
		{
			protected override string CWKEY_EVENTID => null;

			public ExhibitionBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}
		}

		internal class FreeBehaviour : ModeBehaviour
		{
			public FreeBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}

			protected override void OnClickButton(Data data)
			{
			}

			protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
			{
			}
		}

		internal class DuelistCupBehaviour : ModeBehaviour
		{
			public DuelistCupBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}

			protected override void OnClickButton(Data data)
			{
			}

			protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
			{
			}
		}

		internal class RankEventBehaviour : ModeBehaviour
		{
			protected override string CWKEY_EVENTID => null;

			protected override string CWKEY_RANK => null;

			protected override string CWKEY_RATE => null;

			public RankEventBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}

			protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
			{
			}
		}

		internal class DuelTrialBehaviour : ModeBehaviour
		{
			protected override string CWKEY_EVENTID => null;

			public DuelTrialBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}
		}

		internal class WCSBehaviour : ModeBehaviour
		{
			public WCSBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}

			protected override void OnClickButton(Data data)
			{
			}

			protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
			{
			}
		}

		internal class VersusBehaviour : ModeBehaviour
		{
			protected override string CWKEY_EVENTID => null;

			public VersusBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
				: base(null, null, null, 0, default(Util.GameMode))
			{
			}

			internal override void CallAPI()
			{
			}

			internal override string GetTitle()
			{
				return null;
			}
		}

		private readonly string SCROLL_REPLAY_LABEL;

		private readonly string TMP_RANK_LABEL;

		private ColosseumUtil.PlayMode mode;

		private ModeBehaviour modeBehaviour;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
