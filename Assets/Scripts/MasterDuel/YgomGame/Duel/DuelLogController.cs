using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelLogController : MonoBehaviour
	{
		public const int INVALIDCARDID = 0;

		public const string LABEL_SHOWTURN = "ShowTurn";

		public const string LABEL_SHOWACTION = "ShowAction";

		public const string LABEL_SHOWCHAIN = "ShowChain";

		public const string LABEL_SHOWTAG = "ShowTag";

		public const string LABEL_SHOWCARDNAME = "ShowCardName";

		public const string LABEL_SHOWTEXT = "ShowText";

		public const string LABEL_SHOWPHASE = "ShowPhase";

		public const string LABEL_SAPERATELINE = "SeparateLine";

		public const string LABEL_ROOT = "Root";

		public const string LABEL_SCROLLUP = "ScrollUp";

		public const string LABEL_SCROLLDOWN = "ScrollDown";

		public const string LABEL_SCROLLVIEW = "ScrollView";

		public const string LABEL_BG = "Bg";

		public const string LABEL_TWEEN_SHOWLOG = "ShowLog";

		public const string LABEL_TWEEN_HIDELOG = "HideLog";

		public const string LABEL_TWEEN_READY = "Ready";

		public const string SE_LOG_OPEN = "SE_LOG_OPEN";

		public const string SE_LOG_CLOSE = "SE_LOG_CLOSE";

		public SelectionButton m_DuelLogButton;

		protected ElementObjectManager m_EOManager;

		protected DuelLogScrollView m_ScrollView;

		protected Dictionary<string, int> m_DataTypeNumDict;

		protected Dictionary<Engine.ViewType, LogHandler> m_LogHandlerDict;

		protected Dictionary<string, LogItemHandler> m_UpdateItemDict;

		protected List<LogBaseData> m_LogBaseItemList;

		protected List<ShowTurnData> m_DataList_ShowTurn;

		protected List<ShowActionData> m_DataList_ShowAction;

		protected List<ShowChainData> m_DataList_ShowChain;

		protected List<ShowCardNameData> m_DataList_ShowCardName;

		protected List<ShowTextData> m_DataList_ShowText;

		protected List<ShowPhaseData> m_DataList_ShowPhase;

		protected List<ShowTagType> m_DataList_ShowTag;

		protected List<string> m_TemplateLabelList;

		protected Dictionary<int, Sprite> m_PlayerIconTable;

		protected Dictionary<int, Material> m_PlayerFrameTable;

		protected Dictionary<int, int> m_UidCardidTable;

		protected Queue<ShowActionData> m_CardMoveDataQueue;

		protected int m_ChainCount;

		protected bool m_IsEffectProcess;

		protected bool m_CloseTemprary;

		protected GameObject m_bgObj;

		protected DuelClient m_Host;

		private bool m_IsOpen;

		private SPSUMMONTYPE m_SpSummonFlag;

		private int m_SpSummonFlagCount;

		private string m_IconPath0;

		private string m_IconPath1;

		private string m_FramePath0;

		private string m_FramePath1;

		public bool isOpen => false;

		public Action<bool> onChangeOpenClose
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool m_IsIndent => false;

		public static void Create(Transform parent, DuelClient host, SelectionButton duelLogButton, Action<bool> onChangeOpenClose, Action<DuelLogController> onFinish)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void CloseTemprary()
		{
		}

		public void Resume()
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void SetAutoScroll(bool auto)
		{
		}

		public void SetShortkeyIconVisible(bool visible)
		{
		}

		public void AddLogData(Engine.ViewType viewType, int param1, int param2, int param3)
		{
		}

		public void AddLogText(int player, string text)
		{
		}

		protected void OnUpdateListItemBase(GameObject gob, int baseitemindex)
		{
		}

		protected void OnUpdateShowTurn(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowAction(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowChain(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowTag(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowCardName(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowText(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateShowPhase(GameObject eom, int dataindex)
		{
		}

		protected void OnUpdateSeparateLine(GameObject eom, int dataindex)
		{
		}

		protected void AfterAddLog(string label, int datalistcount)
		{
		}

		protected void AddDuelStartLog(int param1, int param2, int param3)
		{
		}

		protected void AddTurnChangeLog(int param1, int param2, int param3)
		{
		}

		protected void AddBattleAttackLog(int param1, int param2, int param3)
		{
		}

		protected void AddLifeDamageLog(int param1, int param2, int param3)
		{
		}

		protected void AddPhaseChange(int param1, int param2, int param3)
		{
		}

		protected void AddHandOpenLog(int param1, int param2, int param3)
		{
		}

		protected void AddDeckShuffleLog(int param1, int param2, int param3)
		{
		}

		protected void AddDeckFlipTopLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardLockonLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardMoveLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardSwapLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardFlipTurnLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardSetLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardBreakLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardExplosionLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardHappenLog(int param1, int param2, int param3)
		{
		}

		protected void AddCardDisableLog(int param1, int param2, int param3)
		{
		}

		protected void AddManaSetLog(int param1, int param2, int param3)
		{
		}

		protected void AddChainSetLog(int param1, int param2, int param3)
		{
		}

		protected void AddChainRunLog(int param1, int param2, int param3)
		{
		}

		protected void AddRunSummonLog(int param1, int param2, int param3)
		{
		}

		protected void AddRunSpSummonLog(int param1, int param2, int param3)
		{
		}

		protected void AddRunFusionLog(int param1, int param2, int param3)
		{
		}

		protected void AddRunCoinLog(int param1, int param2, int param3)
		{
		}

		protected void AddRunDiceLog(int param1, int param2, int param3)
		{
		}

		protected void AddChainEndLog(int param1, int param2, int param3)
		{
		}

		protected void AddShowTextLog(int param1, int param2, int param3)
		{
		}

		protected void AddSeparateLine()
		{
		}

		protected void AddChainTag(bool team, int cardid, int iNum, ShowChainData.ChainDataType type)
		{
		}

		private void Initialize()
		{
		}

		private void OnScrollViewReady()
		{
		}

		private void initializeComponent()
		{
		}

		private void InitializeDict()
		{
		}

		private LOGACTIONTYPE GetActionType(Engine.CardMoveType moveType, Engine.CardStatus stFrom, Engine.CardStatus stTo)
		{
			return default(LOGACTIONTYPE);
		}

		private void CheckSpSummon(ref LOGACTIONTYPE actiontype)
		{
		}

		public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
		{
		}

		public bool SetPlayerIcon(Image img, int playerid)
		{
			return false;
		}

		private bool CheckCardidValid(int cardid)
		{
			return false;
		}
	}
}
