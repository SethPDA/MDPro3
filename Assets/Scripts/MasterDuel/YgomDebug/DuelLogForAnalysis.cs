using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class DuelLogForAnalysis : MonoBehaviour
	{
		[Serializable]
		public class SerializableList<T>
		{
			public List<T> list;
		}

		[Serializable]
		public class DuelLogData
		{
			[SerializeField]
			public SerializableList<LogBaseDataForAnalysis> m_LogBaseItemList;

			[SerializeField]
			public SerializableList<ShowTurnDataForAnalysis> m_DataList_ShowTurn;

			[SerializeField]
			public SerializableList<ShowActionDataForAnalysis> m_DataList_ShowAction;

			[SerializeField]
			public SerializableList<ShowChainDataForAnalysis> m_DataList_ShowChain;

			[SerializeField]
			public SerializableList<ShowCardNameDataForAnalysis> m_DataList_ShowCardName;

			[SerializeField]
			public SerializableList<ShowTextDataForAnalysis> m_DataList_ShowText;

			[SerializeField]
			public SerializableList<ShowPhaseDataForAnalysis> m_DataList_ShowPhase;

			[SerializeField]
			public SerializableList<ShowTagTypeForAnalysis> m_DataList_ShowTag;

			[SerializeField]
			public SerializableList<string> m_DataLabelList;

			[SerializeField]
			public SerializableList<string> m_TextTable;

			public static DuelLogData CreateFromJson(string json)
			{
				return null;
			}

			public static DuelLogData CreateFromDuelLogControllerData(string json)
			{
				return null;
			}

			public void SetDataFromDuelLogData(List<LogBaseData> logBaseDatas, List<ShowTurnData> showTurnDatas, List<ShowActionData> showActionDatas, List<ShowChainData> showChainDatas, List<ShowCardNameData> showCardNameDatas, List<ShowTextData> showTextDatas, List<ShowPhaseData> showPhaseDatas, List<ShowTagType> showTagTypes, List<string> dataLabelList, List<string> textTable)
			{
			}
		}

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

		private const string PREFAB_NAME = "Prefabs/VC/Debug/DuelLogForAnalysis";

		public DuelLogData m_DuelLogData;

		protected ElementObjectManager m_EOManager;

		protected DuelLogScrollViewForAnalysis m_ScrollView;

		protected Dictionary<string, int> m_DataTypeNumDict;

		protected Dictionary<Engine.ViewType, LogHandler> m_LogHandlerDict;

		protected Dictionary<string, LogItemHandler> m_UpdateItemDict;

		protected List<string> m_TemplateLabelList;

		protected Dictionary<int, Sprite> m_PlayerIconTable;

		protected Dictionary<int, Material> m_PlayerFrameTable;

		protected bool m_CloseTemprary;

		protected GameObject m_bgObj;

		private bool m_IsOpen;

		private SPSUMMONTYPE m_SpSummonFlag;

		private int m_SpSummonFlagCount;

		private int m_ChainCount;

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

		private List<LogBaseDataForAnalysis> m_LogBaseItemList => null;

		private List<ShowTurnDataForAnalysis> m_DataList_ShowTurn => null;

		private List<ShowActionDataForAnalysis> m_DataList_ShowAction => null;

		private List<ShowChainDataForAnalysis> m_DataList_ShowChain => null;

		private List<ShowCardNameDataForAnalysis> m_DataList_ShowCardName => null;

		private List<ShowTextDataForAnalysis> m_DataList_ShowText => null;

		private List<ShowPhaseDataForAnalysis> m_DataList_ShowPhase => null;

		private List<ShowTagTypeForAnalysis> m_DataList_ShowTag => null;

		public static DuelLogForAnalysis Create(Transform parent)
		{
			return null;
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

		public void UpdateLogData(DuelLogData duelLogData)
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
