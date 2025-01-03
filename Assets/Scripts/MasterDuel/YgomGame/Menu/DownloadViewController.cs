using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Download;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class DownloadViewController : BaseMenuViewController
	{
		public static class CreateRandom
		{
			private static System.Random random;

			public static System.Random Create()
			{
				return null;
			}
		}

		private readonly string TXT_DL_LABEL;

		private readonly string TXT_DL_STATE_LABEL;

		private readonly string BTN_OK_LABEL;

		private readonly string IMG_PROGRESS_GAUGE;

		private readonly string FLIP_BUTTON_LABEL;

		private readonly string BACK_AREA_BUTTON_LABEL;

		private readonly string CARD_BUTTON_LABEL;

		private readonly string TEXT_NEXT_LABEL;

		private readonly string TEXT_DETAIL_LABEL;

		private readonly string IMAGE_LABEL;

		private readonly string CARDBROWSER;

		private readonly string FOOTER_SC_ICON_0;

		private readonly string FOOTER_SC_ICON_1;

		private readonly string ANDROID_BACK_KEY_LABEL;

		private readonly string FOOTER;

		private readonly string ROOT;

		private GameObject Root;

		private GameObject Footer;

		private TextMeshProUGUI DownloadingText;

		private TextMeshProUGUI DownloadingStateText;

		private SelectionButton btnOK;

		private Image progressGaugeImage;

		private TextMeshProUGUI textNext;

		private TextMeshProUGUI textDetail;

		private Image BGimage;

		private ShortcutIcon shortCutIcon0;

		private ShortcutIcon shortCutIcon1;

		private SelectionButtonUntouchable backBtn;

		private DownloadController downloadController;

		private bool isDownloading;

		private bool endFlag;

		private PlayableDirector downloadTransition;

		private EventPlayableAsset eventPlayableAsset;

		private double TIME_OPEN;

		private bool BGcardSetCompletedFlag;

		private int m_oldCardIndex;

		private int pickCount;

		private Renderer renderer0;

		private Renderer renderer1;

		private ElementObjectManager effEom;

		private ElementObjectManager eom;

		private ElementObject cardfront;

		private List<UnityAction<Texture2D>> onFinishList;

		private SelectionButton cardButton;

		private SelectionButton BackAreaButton;

		private CardIllustManager cardIllustManager;

		private int mrk;

		private List<int> mrkList;

		private bool startDownloadingFlag;

		private bool FlipCardActiveFlag;

		private bool timeLineStartFrag;

		private bool isCardBrowserOpen;

		private float flipTime;

		private bool flipingFlag;

		private bool openningCardBrowser;

		private List<int> avoidList;

		private int MIN_NUM;

		private int startNum;

		private int endNum;

		private int MAX_STARTNUM;

		private int MAX_ENDNUM;

		private int plusNum;

		private int mustStart;

		private int mustEnd;

		private bool skipDownload;

		private float autofliptime;

		private int flipCountNum;

		private bool isCancel;

		private bool rebootFlag;

		private bool errCheckBGCardFrag;

		private List<int> builtinList;

		private int SelectorGoThroughPriority;

		private ViewController cardBrowserVC;

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator WaitLoadCardData()
		{
			return null;
		}

		private void Update()
		{
		}

		private bool CheckCardBrowser()
		{
			return false;
		}

		private void ChangeCardBrowserUI()
		{
		}

		private void setFooter(bool set)
		{
		}

		private void clickBackAreaButton()
		{
		}

		private void AutoFlip()
		{
		}

		private void StartDownload()
		{
		}

		public void FlipCard()
		{
		}

		private void FadeCard()
		{
		}

		private void changeCardIDRange()
		{
		}

		private void ChangeOneBGCard()
		{
		}

		private void CardDetail(int mrk)
		{
		}

		private void endEvent()
		{
		}

		private void StartTimeLine()
		{
		}

		private void SetEventCallBackTimeLine()
		{
		}

		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}

		private IEnumerator AsyncNewCardCheck(int mrk)
		{
			return null;
		}

		private IEnumerator AsyncWaitAndStart()
		{
			return null;
		}

		private void setMrkList()
		{
		}

		private bool checkCardMrk(int id)
		{
			return false;
		}

		public string GetPathByCardId(int mrk)
		{
			return null;
		}

		private bool checkCardMrkTest(int id)
		{
			return false;
		}

		private bool checkAvoidCard(int id)
		{
			return false;
		}

		private int randomMRK(int start, int end)
		{
			return 0;
		}
	}
}
