using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class CardInfo : CardInfoBase
	{
		public enum ShowPos
		{
			Left = 0,
			Right = 1,
			Top = 2,
			Bottom = 3,
			None = 4,
			NoChange = 5
		}

		private const string HIGHLIGHTTAG_STYLE_0 = "<style=\"notice2\">";

		private const string HIGHLIGHTTAG_STYLE_1 = "</style>";

		private const string HIGHLIGHTTAG_COLOR_77 = "<color=#777777>";

		private const string HIGHLIGHTTAG_COLOR_FF = "<color=#FFFFFF>";

		private const string HIGHLIGHTTAG_COLOR_MY = "<color=#00AEEF>";

		private const string HIGHLIGHTTAG_COLOR_RIVAL = "<color=#FF00FF>";

		private const string HIGHLIGHTTAG_COLOR_YELLOW = "<color=#FFFF00>";

		private const string HIGHLIGHTTAG_COLOR_END = "</color>";

		protected const string LABEL_IMG_SWITCHCOUNTER = "SwitchCounterIcon";

		protected const string LABEL_TXT_SWITCHCOUNTER = "SwitchCounterText";

		protected const string LABEL_GO_SWITCHCOUNTER = "SwitchCounter";

		protected const string LABEL_TW_ZOOMIN = "ZoomIn";

		protected const string LABEL_TW_ZOOMOUT = "ZoomOut";

		protected ExtendedTextMeshProUGUI m_SwitchCounterText_Property;

		protected Image m_SwitchCounterIcon_Property;

		protected GameObject m_SwitchCounter_Property;

		protected ExtendedTextMeshProUGUI m_DspContentSub_Property;

		protected Tween m_TW_SwitchCounter_Property;

		protected const string PATH_PREFAB = "Prefabs/Duel/UI/CardInfo";

		protected const string PATH_PREFAB_MINI = "Prefabs/Duel/UI/CardInfoMini";

		protected const int MAXCOUNTERNUM = 1;

		private bool cardLock;

		private bool m_FromCardSelectionList;

		private Coroutine m_CurrentCoroutine;

		private DuelClient m_Host;

		private int m_HighlightRfxTableIndex;

		private List<int> efxNoList;

		private int m_CurrentCounterIndex;

		private bool m_IsSwitching;

		private float m_DeltaTime;

		public ShowPos currentMiniPos;

		private UiSwitchTweenAnimationController m_UISwitch_Property;

		protected ExtendedTextMeshProUGUI m_SwitchCounterText => null;

		protected Image m_SwitchCounterIcon => null;

		protected GameObject m_SwitchCounter => null;

		protected ExtendedTextMeshProUGUI m_DspContentSub => null;

		protected Tween m_TW_SwitchCounter => null;

		public bool isMini
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

		public UnityEvent onOpenEvent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnityEvent onCloseEvent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector2 windowSize => default(Vector2);

		private UiSwitchTweenAnimationController m_UISwitch => null;

		public static bool IsResourceLoaded(bool isMini)
		{
			return false;
		}

		public static void LoadResource(bool isMini)
		{
		}

		public static void UnloadResource(bool isMini)
		{
		}

		public static void LoadPrefab(bool isMini, UnityAction<GameObject> onFinished)
		{
		}

		public void Show(ShowPos miniPos)
		{
		}

		public void SetMiniPos(ShowPos miniPos)
		{
		}

		public void SetCardByUniqueId(int uniqueId, ShowPos miniPos, bool force = false, bool fromCardSelectionList = false, int highlightRfxTableIndex = -1)
		{
		}

		public void SetCardByCardId(int cardid, ShowPos miniPos, int styleid = 1, bool force = true, bool fromCardSelectionList = false, int player = -1, int highlightRfxTableIndex = -1)
		{
		}

		public void SetCardLock(bool cardLock)
		{
		}

		public void Close()
		{
		}

		public void Initialize(DuelClient host, bool isLeft, bool ismini)
		{
		}

		public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
		{
		}

		public void SetPos(ShowPos pos)
		{
		}

		protected void SetTitleArea()
		{
		}

		protected void SetTitleAreaByCardId()
		{
		}

		protected void ScrollReset()
		{
		}

		protected void SetCardArea()
		{
		}

		protected void SetParameterArea()
		{
		}

		private void SetSwitchCounter()
		{
		}

		private void UpdateCounter()
		{
		}

		private void SwitchToNextCounter()
		{
		}

		protected void SetDescriptionArea()
		{
		}

		protected void SetDspContent(int cardidorg, int effectid, int owner, bool isInField = false, bool isPdlPos = false, int effflag = 0)
		{
		}

		private void HighlightTextFromTable()
		{
		}

		private void HighlightProvess(string tohappentext, string happeningtext)
		{
		}

		private IEnumerator SetHighlightTextToFirstView()
		{
			return null;
		}

		private void SetActivatedIconFromActivatedCardEffectNoDict(int cardId, int owner)
		{
		}

		private void SetActivatedIconFromActivatedCardEffectNoList(List<int> effectNoList, int cardId, string ActivatedIconStr)
		{
		}

		private void SetupCardData()
		{
		}

		private void Update()
		{
		}
	}
}
