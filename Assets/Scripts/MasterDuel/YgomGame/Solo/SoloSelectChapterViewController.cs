using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Solo
{
	public class SoloSelectChapterViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		internal abstract class AccessDialog
		{
			protected readonly string BTN_PLAY_LABEL;

			protected readonly string BTN_DECK_LABEL;

			protected readonly string BTN_ENEMY_DECK_LABEL;

			protected readonly string BTN_STORY_DECK_LABEL;

			protected readonly string BTN_STORY_CARD_LABEL;

			protected readonly string BTN_SKIP_LABEL;

			protected readonly string IMG_CHAPTER_LABEL;

			protected readonly string IMG_REWARD_LABEL;

			protected readonly string IMG_REWARD_GET_LABEL;

			protected readonly string IMG_DECK_LABEL;

			protected readonly string IMG_DECK_EMPTY_LABEL;

			protected readonly string IMG_DECK_DISABLED_LABEL;

			protected readonly string TXT_CHAPTER_NAME_LABEL;

			protected readonly string TXT_DECK_LABEL;

			protected readonly string TXT_OVERVIEW_LABEL;

			protected readonly string TXT_QUANTITY_LABEL;

			protected readonly string TXT_CLEAR_LABEL;

			protected readonly string TXT_COMPLETE_LABEL;

			protected readonly string OBJ_REWARD_CLEAR_LABEL;

			protected readonly string OBJ_REWARD_COMPLETE_LABEL;

			protected readonly string BTN_LABEL;

			internal ElementObjectManager eom;

			protected readonly ViewControllerManager manager;

			protected readonly AccessDialogManager adManager;

			protected readonly int selectorPriority;

			protected readonly DefinitionSetting soloDefine;

			protected AccessDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
			{
			}

			internal abstract void UpdateDisp(Chapter data);

			protected internal virtual void Open(Chapter data)
			{
			}

			internal abstract void Play(Chapter data);

			internal virtual void Close()
			{
			}

			protected void CallApiSoloStart(Chapter data)
			{
			}

			protected void OnClickRewardButton(int itemID, string numText = "1")
			{
			}
		}

		internal class ScenarioDialog : AccessDialog
		{
			public ScenarioDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
				: base(null, null, null, 0)
			{
			}

			internal override void UpdateDisp(Chapter data)
			{
			}

			internal override void Play(Chapter data)
			{
			}
		}

		internal class DuelDialog : AccessDialog
		{
			protected readonly string TAB_GROUP_LABEL;

			protected readonly string TAB_RENTAL_LABEL;

			protected readonly string TAB_MYDECK_LABEL;

			protected readonly string ROOT_RENTAL_LABEL;

			protected readonly string ROOT_MYDECK_LABEL;

			protected readonly string ROOT_LEVEL_LABEL;

			protected DirectionalToggleGroupWidget toggleGroup;

			protected ElementObjectManager rootRentalEom;

			protected ElementObjectManager rootMydeckEom;

			protected ElementObjectManager tabGroupEom;

			protected ElementObjectManager tabRentalEom;

			protected ElementObjectManager tabMydeckEom;

			public DuelDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
				: base(null, null, null, 0)
			{
			}

			protected internal override void Open(Chapter data)
			{
			}

			internal override void UpdateDisp(Chapter data)
			{
			}

			internal override void Play(Chapter data)
			{
			}

			protected void CallApiSoloSetUseDeckType(Chapter data, SoloModeUtil.DeckType deckType, UnityAction onSuccess = null)
			{
			}

			internal virtual void UpdateDeck(Chapter data, SoloModeUtil.DeckType deckType = SoloModeUtil.DeckType.POSSESSION)
			{
			}
		}

		internal class TutorialDialog : AccessDialog
		{
			private bool isWhileTutorial;

			protected readonly string ROOT_LEVEL_LABEL;

			public TutorialDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
				: base(null, null, null, 0)
			{
			}

			internal override void UpdateDisp(Chapter data)
			{
			}

			internal override void Play(Chapter data)
			{
			}

			internal void CallApiSoloSkip(Chapter data)
			{
			}

			protected void CallApiSoloSetUseDeckType(Chapter data, SoloModeUtil.DeckType deckType, UnityAction onSuccess = null)
			{
			}
		}

		internal class RewardDialog : AccessDialog
		{
			private readonly string TXT_PLAY_LABEL;

			public RewardDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
				: base(null, null, null, 0)
			{
			}

			internal override void UpdateDisp(Chapter data)
			{
			}

			internal override void Play(Chapter data)
			{
			}
		}

		internal class LockDialog : AccessDialog
		{
			private readonly string ROOT_UNLOCK_ITEM_LABEL;

			private readonly string ROOT_UNLOCK_HASITEM_LABEL;

			private readonly string TXT_PLAY_LABEL;

			private readonly string TXT_COST_LABEL;

			private readonly string TXT_HAVE_LABEL;

			private readonly string TXT_CATEGORY_LABEL;

			private readonly string TXT_NAME_LABEL;

			private readonly string OBJ_TEXTLABEL_LABEL;

			private readonly string OBJ_NOT_ENOUGH_LABEL;

			private readonly string IMG_LABEL;

			private readonly string IMG_LOCK_LABEL;

			private readonly string IMG_UNLOCK_LABEL;

			private List<GameObject> lockItems;

			private List<GameObject> lockHasItems;

			public LockDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
				: base(null, null, null, 0)
			{
			}

			protected internal override void Open(Chapter data)
			{
			}

			internal override void UpdateDisp(Chapter data)
			{
			}

			internal override void Play(Chapter data)
			{
			}
		}

		internal class AccessDialogManager
		{
			private readonly string BTN_BACK_LABEL;

			private readonly string OBJ_ACCESS_LABEL;

			private readonly string OBJ_DIALOG_SCENARIO_LABEL;

			private readonly string OBJ_DIALOG_DUEL_LABEL;

			private readonly string OBJ_DIALOG_REWARD_LABEL;

			private readonly string OBJ_DIALOG_LOCK_LABEL;

			private readonly string OBJ_DIALOG_TUTORIAL_LABEL;

			private readonly string OBJ_CLEAR_LABEL;

			public SoloSelectChapterViewController soloVC;

			private GameObject rootAccessDialog;

			private ElementObjectManager parentViewEom;

			private ScenarioDialog scenarioDialog;

			private DuelDialog duelDialog;

			private LockDialog lockDialog;

			private RewardDialog rewardDialog;

			private TutorialDialog tutorialDialog;

			private Chapter targetChapter;

			private List<Chapter> childChapters;

			private UnityAction<Chapter> openedCallback;

			private UnityAction<Chapter> closedCallback;

			private UnityAction refleshCallback;

			private int selectorPriority;

			private (int, SoloModeUtil.ChapterStatus) beforeIdStatus;

			internal bool isPlayingPerformance;

			internal AccessDialogManager(ElementObjectManager eom, int selectorPriority, ViewControllerManager manager, SoloSelectChapterViewController soloVC)
			{
			}

			private void DispCanvas(bool isDisp)
			{
			}

			internal void UpdateAccessDialog(Chapter chapter = null)
			{
			}

			internal void OpenAccessDialog(Chapter chapter = null, List<Chapter> childs = null)
			{
			}

			internal void CloseAccessDialog()
			{
			}

			internal void RefleshDialog()
			{
			}

			internal void InvokeRefleshCallback()
			{
			}

			internal void SetOpenedCallback(UnityAction<Chapter> callback)
			{
			}

			internal void SetClosedCallback(UnityAction<Chapter> callback)
			{
			}

			internal void SetRefleshCallback(UnityAction callback)
			{
			}

			internal void StartChapter()
			{
			}

			internal void SkipChapter()
			{
			}

			internal bool isOpen()
			{
				return false;
			}

			private AccessDialog GetAccessDialog(SoloModeUtil.DialogType type)
			{
				return null;
			}

			internal IEnumerator OpenRewardDialog(Action onComplete = null)
			{
				return null;
			}
		}

		internal class ChapterMap
		{
			protected readonly string BTN_LABEL;

			protected readonly string IMG_ACCESS_LABEL;

			protected readonly string SCROLL_LABEL;

			protected readonly string OBJ_CHAPTER_MAP_LABEL;

			protected readonly string TMP_GATE_LABEL;

			protected readonly string ROOT_GATE_LABEL;

			protected readonly string TXT_NAME_LABEL;

			private readonly string IMG_ICON_LABEL;

			private readonly string IMG_EDGE_LABEL;

			private readonly string ROOT_EDGES_LABEL;

			protected int currentChapterID;

			protected ElementObjectManager parentViewEom;

			protected Dictionary<int, Chapter> chapterDataDic;

			protected AccessDialogManager adManager;

			protected int gateID;

			protected GameObject gateGO;

			private readonly float PADING_X;

			private readonly float PADING_Y;

			protected Dictionary<Chapter, Node> chapterNodeMap;

			protected NodeMapCreater nodeMapCreater;

			private float defaultPositionX;

			private GameObject playerIconGo;

			private SoloSelectChapterViewController soloVC;

			internal ChapterMap(SoloSelectChapterViewController soloVC, ElementObjectManager parentViewEom, AccessDialogManager adManager, int gateID, float padingX = 300f, float padingY = 300f)
			{
			}

			internal void Create()
			{
			}

			internal void SetChaptersData()
			{
			}

			private void InitChapter(int chapterID, Dictionary<string, object> chapterData)
			{
			}

			internal void OnClickChapter(SelectionButton sb, Chapter data)
			{
			}

			internal void UpdateMap()
			{
			}

			internal void SelectedChapter(int x)
			{
			}

			internal void ZoomChapter(SelectionItem si)
			{
			}

			internal void ResetZoom()
			{
			}

			private void SetTransition(Chapter chapter, PadInputDirection direction, SelectionButton settingBtn)
			{
			}

			private NodeMapCreater CreateNodeMap()
			{
				return null;
			}

			private int TransYtoMapY(int y)
			{
				return 0;
			}
		}

		internal abstract class Chapter
		{
			protected readonly string TXT_CLEAR_LABEL;

			protected readonly string TXT_COMPLETE_LABEL;

			protected readonly string IMG_LOCK_LABEL;

			protected readonly string IMG_UNLOCK_LABEL;

			protected readonly string IMG_UNOPEN_LABEL;

			protected readonly string IMG_ICON_LABEL;

			internal int id;

			internal string strChapter;

			internal string strExplanation;

			internal int parentID;

			internal SoloModeUtil.ChapterStatus status;

			internal SoloModeUtil.DialogType dType;

			internal GameObject go;

			internal int myDeckSetID;

			internal int setID;

			internal int unlockID;

			internal int npcID;

			internal string scenarioName;

			protected Chapter()
			{
			}

			public Chapter(int chapterID, SoloSelectChapterViewController soloVC)
			{
			}

			internal abstract string GetElementLabel();

			internal abstract void Update(Chapter parent);

			internal virtual bool IsCleared()
			{
				return false;
			}

			internal virtual bool IsCompleted()
			{
				return false;
			}

			internal virtual void SetData(Dictionary<string, object> chapterData)
			{
			}

			internal void SetIcon(GameObject gameObject)
			{
			}
		}

		internal class ChapterDuel : Chapter, IChapterLevel
		{
			private int level;

			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterDuel(int chapterID, SoloSelectChapterViewController soloVC)
			{
			}

			internal override void Update(Chapter parent)
			{
			}

			internal override void SetData(Dictionary<string, object> chapterData)
			{
			}

			public int GetChapterLevel()
			{
				return 0;
			}
		}

		internal class ChapterPractice : ChapterDuel
		{
			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterPractice(int chapterID, SoloSelectChapterViewController soloVC)
				: base(0, null)
			{
			}
		}

		internal class ChapterScenario : Chapter
		{
			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterScenario(int chapterID, SoloSelectChapterViewController soloVC)
			{
			}

			internal override void Update(Chapter parent)
			{
			}

			internal override void SetData(Dictionary<string, object> chapterData)
			{
			}
		}

		internal class ChapterReward : Chapter
		{
			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterReward(int chapterID, SoloSelectChapterViewController soloVC)
			{
			}

			internal override void Update(Chapter parent)
			{
			}

			internal override void SetData(Dictionary<string, object> chapterData)
			{
			}
		}

		internal class ChapterLock : Chapter
		{
			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterLock(int chapterID)
			{
			}

			internal override void Update(Chapter parent)
			{
			}

			internal override void SetData(Dictionary<string, object> chapterData)
			{
			}
		}

		internal class ChapterGoal : Chapter, IChapterLevel
		{
			private int level;

			internal override string GetElementLabel()
			{
				return null;
			}

			public ChapterGoal(int chapterID, SoloSelectChapterViewController soloVC)
			{
			}

			internal override void Update(Chapter parent)
			{
			}

			internal override void SetData(Dictionary<string, object> chapterData)
			{
			}

			public int GetChapterLevel()
			{
				return 0;
			}
		}

		internal interface IChapterLevel
		{
			int GetChapterLevel();
		}

		internal class NodeMapCreater
		{
			private Dictionary<int, int> map;

			internal int maxX;

			internal int maxY;

			internal void SortPositionPostOrder(Node node, int x = 0, bool isFirstChild = false)
			{
			}
		}

		internal class Node
		{
			private Node parent;

			public int id;

			public List<Node> childs;

			public int x;

			public int y;

			public bool isRelatedGoal;

			public Node(int id)
			{
			}

			internal Node GetParent()
			{
				return null;
			}

			internal void SetParent(Node parent)
			{
			}

			internal void SetChild(Node child)
			{
			}

			internal void SetIsRelatedGoal()
			{
			}

			internal void SlideY(int y)
			{
			}
		}

		[SerializeField]
		private float chapterSpaceX;

		[SerializeField]
		private float chapterSpaceY;

		[SerializeField]
		private float chapterSpaceMobileX;

		[SerializeField]
		private float chapterSpaceMobileY;

		private readonly string TXT_TITLE_LABEL;

		private readonly string OBJ_ORB_PLATE_LABEL;

		private readonly string ROOT_GATE_LABEL;

		private DefinitionSetting soloDefine;

		private GameObject rootGate;

		private AccessDialogManager adManager;

		private ChapterMap chapterMap;

		private OrbPlateWidget orbPlate;

		private bool isWhileTutorial;

		private string soloBGMLabel;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		protected override bool setProgressOnInitialize => false;

		public string SoloBGMLabel
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

		public override void NotificationStackRemove()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void InitDefine()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void CallAPISoloGateEntry(int gateID)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public Color FadeColor(TransitionType type)
		{
			return default(Color);
		}

		public SystemProgress.ProgressType FadeType(TransitionType type)
		{
			return default(SystemProgress.ProgressType);
		}

		public static void RetryDuel(ViewControllerManager manager, ViewController swapTarget, int chapterId, bool isRental)
		{
		}
	}
}
