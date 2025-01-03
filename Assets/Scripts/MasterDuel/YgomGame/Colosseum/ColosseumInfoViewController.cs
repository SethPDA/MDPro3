using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		protected class DuelTrialBehaviour : ModeBehaviour
		{
			private class RewardData
			{
				public int win;

				public int itemCategory;

				public int itemId;

				public int num;

				public bool isPeriod;

				public bool existsItem;

				public bool received;

				public int shopId;

				public RewardData(int win, int itemCategory, int itemId, int num, bool isPeriod, bool existsItem, bool received, int shopId)
				{
				}

				public RewardData(int win, bool existsItem, bool received)
				{
				}
			}

			private readonly string BTN_PREV;

			private readonly string BTN_NEXT;

			private readonly string REWARD_ROOT;

			private readonly string REWARD_NONE;

			private readonly string REWARD_NORMAL;

			private readonly string REWARD_PICKUP;

			private readonly string REWARD_DEFAULT;

			private readonly string REWARD_IMAGE;

			private readonly string REWARD_RECIEVED_FRAME;

			private readonly string REWARD_RECIEVED_ICON;

			private readonly string REWARD_WIN;

			private readonly string REWARD_NUM;

			private readonly string E_Gauge;

			private readonly string REWARD_GAUGE_EXTENDED_HEAD;

			private readonly string REWARD_GAUGE_EXTENDED_TAIL;

			private readonly string E_GaugeExtendHeadFill;

			private readonly string E_GaugeExtendTailFill;

			private readonly string SCROLL_LABEL;

			private readonly string ANALOG_DIRECTION_ITEM;

			private readonly string ICON_L;

			private readonly string ICON_R;

			private const int REWARD_NUM_PER_PAGE = 3;

			private int duel_trial_id;

			private int nameRegId;

			private int logoId;

			private string titleStr;

			private ColosseumUtil.StatusDuelTrial status;

			private ColosseumDeckWidget colosseumDeckWidget;

			private InfinityScrollView isv;

			private ElementObjectManager scrollEom;

			private SlidePagerWidget slidePagerWidget;

			private List<RewardData> rewardList;

			private int rewardPageNum;

			private int rewardSpaceNum;

			public DuelTrialBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int duel_trial_id)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void SetDuelButton(ElementObjectManager menuEOM)
			{
			}

			protected override bool IsDispPerformance()
			{
				return false;
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			private void SetShortcutLRReward(bool isSet)
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnTransitionEnd(TransitionType type)
			{
			}

			private void MovePageNextReward()
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			private void UpdateReward(int currentWin)
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}

			private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
			{
				return false;
			}

			private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
			{
			}

			internal override void SetDeck(int tid)
			{
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
			{
				return null;
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> MTdic, Dictionary<string, object> tInfoDic)
			{
				return null;
			}

			private void DispReward()
			{
			}

			private void CheckPack()
			{
			}

			private void CallAPIOpenCampaignPack(int item_id, int num, Action onSuccess = null)
			{
			}
		}

		protected class DuelistCupBehaviour : ModeBehaviour
		{
			private class Data1stReward
			{
				public int itemCategory;

				public int itemId;

				public int num;

				public bool isPeriod;

				public int needDlv;

				public bool focus;

				public bool received;

				public Data1stReward(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received)
				{
				}
			}

			private readonly string SCROLL_LABEL;

			private readonly string VIEW_1ST_LABEL;

			private readonly string VIEW_2ND_LABEL;

			private readonly string ROOT_VIEW_1ST_LABEL;

			private readonly string ROOT_VIEW_2ND_LABEL;

			private readonly string TXT_DLV_LABEL;

			private readonly string ANALOG_DIRECTION_ITEM;

			private readonly string REWARD_ROOT;

			private readonly string REWARD_NORMAL;

			private readonly string REWARD_PICKUP;

			private readonly string REWARD_DEFAULT;

			private readonly string REWARD_IMAGE;

			private readonly string REWARD_RECIEVED_FRAME;

			private readonly string REWARD_RECIEVED_ICON;

			private readonly string REWARD_NUM;

			private readonly string REWARD_DLV;

			private readonly string REWARD_GAUGE_EXTENDED_HEAD;

			private readonly string REWARD_GAUGE_EXTENDED_TAIL;

			private readonly string BTN_PREV;

			private readonly string BTN_NEXT;

			private readonly string BTN_PICKUP;

			private readonly string PICKUP_ICON;

			private readonly string PICKUP_IMAGE;

			private readonly string PICKUP_DLV;

			private readonly string PICKUP_NUM;

			private const int REWARD_NUM_PER_PAGE = 5;

			protected string titleStr;

			protected int cid;

			protected ColosseumUtil.PlayMode playMode;

			protected PvpMenuDefine.MatchingType matchingType;

			private int nameRegId;

			protected int logoId;

			private int matchingTime2nd;

			private int stage;

			protected int dispStage;

			private int maxDlv;

			private int rewardPageNum;

			private int rewardSpaceNum;

			protected ColosseumUtil.StatusDuelistCup status;

			protected ColosseumDeckManager deckManager;

			private ElementObjectManager rankingBtnEom;

			private InfinityScrollView isv;

			private ElementObjectManager scrollEom;

			private ElementObjectManager pickupEom;

			private SlidePagerWidget slidePagerWidget;

			private int popWallPaperCount;

			private List<Data1stReward> rewardList;

			public DuelistCupBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int cid)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			protected override bool IsDispPerformance()
			{
				return false;
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			internal override void UpdateDisp()
			{
			}

			protected virtual void ChangeDispDecideBtn(bool isSetDeck, bool checkedValid, bool checkedPossession)
			{
			}

			private void UpdateDisp1stStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
			{
			}

			private string GetDlvString(int dlv)
			{
				return null;
			}

			protected virtual void UpdateDisp2ndStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
			{
			}

			private void UpdateRankingButton()
			{
			}

			protected virtual string GetNorankingText()
			{
				return null;
			}

			protected virtual Dictionary<string, object> GetRankingViewArgs()
			{
				return null;
			}

			protected virtual int GetBGId()
			{
				return 0;
			}

			protected virtual string GetLogoPath()
			{
				return null;
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void PushAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnTransitionStart(TransitionType type)
			{
			}

			internal override void OnTransitionEnd(TransitionType type)
			{
			}

			protected void MovePageNextReward()
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			protected void DispReward()
			{
			}

			protected void DispAward()
			{
			}

			protected virtual Dictionary<string, object> GetResultArgs(int ranking, ColosseumResultViewController.AwardType awardType, Action dispRewardCallback)
			{
				return null;
			}

			protected virtual string GetResultPrefPath()
			{
				return null;
			}

			protected virtual void OnClickInfo()
			{
			}

			internal override void SetDeck(int cid)
			{
			}

			private void OnClickDeck(ViewControllerManager manager)
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}

			private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
			{
				return false;
			}

			private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
			{
			}
		}

		protected class ExhibitionBehaviour : ModeBehaviour
		{
			private class RewardData
			{
				public int itemCategory;

				public int itemId;

				public int num;

				public bool isPeriod;

				public int needToken;

				public bool focus;

				public bool received;

				public RewardData(int itemCategory, int itemId, int num, bool isPeriod, int needToken, bool focus, bool received)
				{
				}
			}

			protected readonly string OBJ_REWARD_LABEL;

			protected readonly string IMG_GAUGE_LABEL;

			protected readonly string IMG_RECEIVED_LABEL;

			protected readonly string IMG_DEFAULT_FRAME_LABEL;

			protected readonly string IMG_RECEIVED_FRAME_LABEL;

			protected readonly string IMG_EVENT_CATEGORY;

			protected readonly string TXT_NEEDTOKEN_LABEL;

			protected readonly string TXT_DECK_LABEL;

			protected readonly string TXT_PLAY_LABEL;

			protected readonly string TXT_ITEM_NUM_LABEL;

			protected readonly string TAB_GROUP_LABEL;

			protected readonly string TAB_RENTAL_LABEL;

			protected readonly string TAB_MYDECK_LABEL;

			protected readonly string ROOT_RENTAL_LABEL;

			protected readonly string ROOT_MYDECK_LABEL;

			protected readonly string TMP_DECK_RENTAL_LABEL;

			protected readonly string BTN_PLAY_LABEL;

			protected readonly string BTN_DECK_LABEL;

			private readonly string SCROLL_LABEL;

			private readonly string ANALOG_DIRECTION_ITEM;

			private readonly string REWARD_ROOT;

			private readonly string REWARD_NORMAL;

			private readonly string REWARD_PICKUP;

			private readonly string REWARD_DEFAULT;

			private readonly string REWARD_IMAGE;

			private readonly string REWARD_RECIEVED_FRAME;

			private readonly string REWARD_RECIEVED_ICON;

			private readonly string REWARD_NUM;

			private readonly string REWARD_DLV;

			private readonly string REWARD_GAUGE_EXTENDED_HEAD;

			private readonly string REWARD_GAUGE_EXTENDED_TAIL;

			private readonly string BTN_PREV;

			private readonly string BTN_NEXT;

			private readonly string ICON_L;

			private readonly string ICON_R;

			private readonly string BTN_PICKUP;

			private readonly string PICKUP_ICON;

			private readonly string PICKUP_IMAGE;

			private readonly string PICKUP_DLV;

			private readonly string PICKUP_NUM;

			private const int REWARD_NUM_PER_PAGE = 5;

			private int exhid;

			private int nameRegId;

			private int logoId;

			private ColosseumUtil.StatusExhibition status;

			private ColosseumDeckWidget colosseumDeckWidget;

			private InfinityScrollView isv;

			private ElementObjectManager scrollEom;

			private ElementObjectManager pickupEom;

			private SlidePagerWidget slidePagerWidget;

			private List<RewardData> rewardList;

			private int rewardPageNum;

			private int rewardSpaceNum;

			public ExhibitionBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int exhid)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void SetDuelButton(ElementObjectManager menuEOM)
			{
			}

			protected override bool IsDispPerformance()
			{
				return false;
			}

			private void DispReward()
			{
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			private void SetShortcutLRReward(bool isSet)
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnTransitionEnd(TransitionType type)
			{
			}

			private void MovePageNextReward()
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			private void UpdateReward(int token)
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}

			private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
			{
				return false;
			}

			private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
			{
			}

			internal override void SetDeck(int tid)
			{
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
			{
				return null;
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> MTdic, Dictionary<string, object> tInfoDic)
			{
				return null;
			}
		}

		protected class FreeBehaviour : ModeBehaviour
		{
			protected readonly string E_LogoFree;

			private int deckId;

			private bool checkedValid;

			private bool checkedPossession;

			public FreeBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void SetDeck(int did)
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			private void OnClickDeck(ViewControllerManager manager)
			{
			}

			protected GameObject CreateEmbedObj(int deckId)
			{
				return null;
			}
		}

		protected abstract class ModeBehaviour
		{
			protected readonly string IMG_LABEL;

			protected readonly string IMG_BG_LABEL;

			protected readonly string IMG_RANK_LABEL;

			protected readonly string TXT_CAUTION_LABEL;

			protected readonly string TXT_DATE_LABEL;

			protected readonly string TXT_STATUS_LABEL;

			protected readonly string TXT_SUB1_LABEL;

			protected readonly string TXT_SUB1_TITLE_LABEL;

			protected readonly string TXT_SUB2_LABEL;

			protected readonly string TXT_SUB2_TITLE_LABEL;

			protected readonly string TXT_OVERVIEW_LABEL;

			protected readonly string TXT_TITLE_LABEL;

			protected readonly string TXT_DUEL_NAME_LABEL;

			protected readonly string TXT_NAME_LABEL;

			protected readonly string IMG_DECK_LABEL;

			protected readonly string IMG_DECK_EMPTY_LABEL;

			protected readonly string IMG_DECK_DISABLED_LABEL;

			protected readonly string TXT_LABEL;

			protected readonly string BTN_LABEL;

			protected readonly string TMP_BTN_DECK_LABEL;

			protected readonly string TMP_BTN_NORMAL_LABEL;

			protected readonly string TXT_DECIDE_LABEL;

			protected readonly string BTN_DECIDE_LABEL;

			internal readonly ViewControllerManager manager;

			internal readonly ColosseumInfoViewController vc;

			internal readonly ElementObjectManager parentEOM;

			internal readonly ElementObjectManager menuEOM;

			internal readonly ElementObjectManager overviewEOM;

			protected ElementObjectManager deckBtnEOM;

			protected bool isSetDeck;

			protected DeckCaseWidget deckCase;

			protected ElementObjectManager viewEOM;

			protected bool isSetRentalDeck;

			protected string startDate;

			protected string endDate;

			protected string startDateReward;

			protected string endDateReward;

			protected int matchingTime;

			protected ModeBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM)
			{
			}

			internal abstract void OnClickDuel();

			internal abstract void CallAPI();

			internal abstract void SetMenu();

			internal abstract void InitDisp();

			internal abstract void UpdateDisp();

			internal abstract void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry);

			internal abstract void SetDeck(int did);

			internal abstract void CallAPIGetDeckList(int id, Action onSuccess);

			internal abstract Dictionary<string, object> GetDeckArgs(int identifier, bool isScratch);

			internal virtual void PushAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal virtual void OnTransitionStart(TransitionType type)
			{
			}

			internal virtual void OnTransitionEnd(TransitionType type)
			{
			}

			internal virtual ElementObjectManager CreateTmpBtnDeck(UnityAction clickAction = null)
			{
				return null;
			}

			internal virtual ElementObjectManager CreateTmpBtnNormal(string name, UnityAction clickAction = null)
			{
				return null;
			}

			internal virtual void SetDeckDisabled(bool activeImage)
			{
			}

			internal virtual void SetDuelButton(ElementObjectManager menuEOM)
			{
			}

			protected virtual bool IsDispPerformance()
			{
				return false;
			}

			protected void OpenEditDeck(int id, bool isScratch = false)
			{
			}

			protected void StartPerformance(ColosseumStartViewController.PrefabType prefabType, string tournamentName = "", int logoId = 0, int identifier = 0, Action onFinish = null)
			{
			}

			private bool CheckStartPerformance()
			{
				return false;
			}
		}

		protected class RankEventBehaviour : ModeBehaviour
		{
			private readonly string TXT_CON_WIN;

			private readonly string IMG_EVENT_RANK;

			private int rank_event_id;

			private int nameRegId;

			private int logoId;

			private ColosseumUtil.StatusRankEvent status;

			private ColosseumDeckManager deckManager;

			public RankEventBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int rank_event_id)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			protected override bool IsDispPerformance()
			{
				return false;
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			internal override void SetDeck(int tid)
			{
			}

			private void OnClickDeck(ViewControllerManager manager)
			{
			}

			private (int, int) GetRank(string label)
			{
				return default((int, int));
			}

			private string GetNextRankText(int rank, int tier)
			{
				return null;
			}

			private void DispReward()
			{
			}
		}

		protected class StandardBehaviour : ModeBehaviour
		{
			private int seasonId;

			private int deckId;

			private bool checkedValid;

			private bool checkedPossession;

			private readonly string TXT_CON_WIN;

			private readonly string E_RootRankIconEf;

			private readonly string E_RankIconEf;

			private readonly string E_RootUpRankIconEf;

			private readonly string E_UpRankIconEf;

			private string mmaPath;

			public StandardBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			protected override bool IsDispPerformance()
			{
				return false;
			}

			internal override void OnClickDuel()
			{
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void SetDeck(int did)
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			private (int, int) GetRank(string label)
			{
				return default((int, int));
			}

			private string GetNextRankText(int rank, int tier)
			{
				return null;
			}

			private void OnClickDeck(ViewControllerManager manager)
			{
			}

			protected GameObject CreateEmbedObj(int deckId)
			{
				return null;
			}
		}

		protected class TournamentBehaviour : ModeBehaviour
		{
			protected readonly string IMG_EVENT_CATEGORY;

			private int tid;

			private int nameRegId;

			private int logoId;

			private string titleStr;

			private bool checkedValid;

			private bool checkedPossession;

			private ColosseumUtil.StatusTournament status;

			private ColosseumDeckManager deckManager;

			public TournamentBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int tid)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			internal override void SetDeck(int tid)
			{
			}

			private void OnClickDeck(ViewControllerManager manager)
			{
			}

			private void DispReward()
			{
			}
		}

		protected class VersusBehaviour : ModeBehaviour
		{
			private class RewardData
			{
				public int itemCategory;

				public int itemId;

				public int num;

				public bool isPeriod;

				public int needToken;

				public bool focus;

				public bool received;

				public RewardData(int itemCategory, int itemId, int num, bool isPeriod, int needToken, bool focus, bool received)
				{
				}
			}

			private readonly string BTN_PREV;

			private readonly string BTN_NEXT;

			private readonly string REWARD_ROOT;

			private readonly string REWARD_NORMAL;

			private readonly string REWARD_PICKUP;

			private readonly string REWARD_DEFAULT;

			private readonly string REWARD_IMAGE;

			private readonly string REWARD_RECIEVED_FRAME;

			private readonly string REWARD_RECIEVED_ICON;

			private readonly string REWARD_DLV;

			private readonly string REWARD_NUM;

			private readonly string REWARD_GAUGE_EXTENDED_HEAD;

			private readonly string REWARD_GAUGE_EXTENDED_TAIL;

			private readonly string SCROLL_LABEL;

			private readonly string ANALOG_DIRECTION_ITEM;

			private readonly string ICON_L;

			private readonly string ICON_R;

			private readonly string BTN_PICKUP;

			private readonly string PICKUP_ICON;

			private readonly string PICKUP_IMAGE;

			private readonly string PICKUP_DLV;

			private readonly string PICKUP_NUM;

			private readonly string E_RootGroup;

			private readonly string E_ImageParticipate;

			private readonly string E_Text;

			private readonly string E_TextParticipate;

			private readonly string E_InformButtonGroup;

			private readonly string E_Template;

			private readonly string E_TemplateSmall;

			private readonly string E_TemplateSmallMB;

			private readonly string E_TextMyPoint;

			private readonly string E_TextMyPointLabel;

			private readonly string E_TextTotalPoint;

			private readonly string E_TextTotalPointLabel;

			private const int REWARD_NUM_PER_PAGE = 5;

			private int versus_id;

			private int nameRegId;

			private int logoId;

			private string titleStr;

			private ColosseumUtil.StatusVersus status;

			private ColosseumDeckWidget colosseumDeckWidget;

			private InfinityScrollView isv;

			private ElementObjectManager scrollEom;

			private ElementObjectManager pickupEom;

			private SlidePagerWidget slidePagerWidget;

			private List<RewardData> rewardList;

			private int rewardPageNum;

			private int rewardSpaceNum;

			private (bool, int) currentGroup;

			private bool isCalledDetailAPI;

			private string mmaPath;

			public VersusBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int versus_id, int group_id, bool isCalledDetailAPI)
				: base(null, null, null, null, null, null)
			{
			}

			internal override void CallAPI()
			{
			}

			internal override void SetDuelButton(ElementObjectManager menuEOM)
			{
			}

			internal override void SetMenu()
			{
			}

			internal override void InitDisp()
			{
			}

			private void SetShortcutLRReward(bool isSet)
			{
			}

			internal override void UpdateDisp()
			{
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void OnTransitionEnd(TransitionType type)
			{
			}

			private void MovePageNextReward()
			{
			}

			internal override void OnClickDuel()
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
			{
				return null;
			}

			private void UpdateReward(int token)
			{
			}

			private void OnUpdateEntity(GameObject go, int index)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}

			private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
			{
				return false;
			}

			private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
			{
			}

			internal override void SetDeck(int tid)
			{
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
			{
				return null;
			}

			private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> MTdic, Dictionary<string, object> tInfoDic)
			{
				return null;
			}

			private void DispReward()
			{
			}

			private void CallAPIOpenCampaignPack(int item_id, int num, Action onSuccess = null)
			{
			}

			private void SetGroup(int groupNo)
			{
			}

			private void DispResult(UnityAction OnFinished = null)
			{
			}
		}

		protected class WCSBehaviour : DuelistCupBehaviour
		{
			private readonly string E_TextGroupName;

			private readonly string E_ButtonEntry;

			private readonly string E_TextEntry;

			public WCSBehaviour(ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, ElementObjectManager overviewEOM, int cid)
				: base(null, null, null, null, null, null, 0)
			{
			}

			internal override void CallAPI()
			{
			}

			protected override string GetNorankingText()
			{
				return null;
			}

			protected override Dictionary<string, object> GetRankingViewArgs()
			{
				return null;
			}

			protected override Dictionary<string, object> GetResultArgs(int ranking, ColosseumResultViewController.AwardType awardType, Action dispRewardCallback)
			{
				return null;
			}

			protected override void OnClickInfo()
			{
			}

			protected override string GetResultPrefPath()
			{
				return null;
			}

			protected override string GetLogoPath()
			{
				return null;
			}

			protected override int GetBGId()
			{
				return 0;
			}

			internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
			{
			}

			internal override void CallAPIGetDeckList(int id, Action onSuccess)
			{
			}

			protected override void UpdateDisp2ndStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
			{
			}

			protected override void ChangeDispDecideBtn(bool isSetDeck, bool checkedValid, bool checkedPossession)
			{
			}

			internal override void SetDuelButton(ElementObjectManager menuEOM)
			{
			}

			internal override void OnClickDuel()
			{
			}
		}

		protected readonly string ROOT_MENU_LABEL;

		protected readonly string VIEW_STANDARD_LABEL;

		protected readonly string VIEW_TOURNAMENT_LABEL;

		protected readonly string VIEW_EXHIBITION_LABEL;

		protected readonly string VIEW_FREE_LABEL;

		protected readonly string VIEW_DUELISTCUP_LABEL;

		protected readonly string VIEW_RANKEVENT_LABEL;

		protected readonly string VIEW_LABEL;

		protected readonly string BTN_DECIDE_LABEL;

		protected ColosseumUtil.PlayMode mode;

		protected ModeBehaviour modeBehaviour;

		[SerializeField]
		protected ElementObjectManager DeckOverviewPrefab;

		private string colosseumBGMLabel;

		protected override Type[] textIds => null;

		public string ColosseumBGMLabel
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}
	}
}
