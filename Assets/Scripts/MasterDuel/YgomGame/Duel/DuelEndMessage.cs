using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelEndMessage : MonoBehaviour
	{
		private SelectionButton nextButton;

		private TMP_Text nextButtonText;

		private GameObject messageBase;

		private ExtendedTextMeshProUGUI messageText;

		private ExtendedTextMeshProUGUI player0Name;

		private ExtendedTextMeshProUGUI player1Name;

		private Transform player0Icon;

		private Transform player1Icon;

		private SelectionButton profileCard0Button;

		private SelectionButton profileCard1Button;

		private GameObject player0PlatformRoot;

		private GameObject player1PlatformRoot;

		private Image player0PlatformIcon;

		private Image player1PlatformIcon;

		private TMP_Text player0PlatformID;

		private TMP_Text player1PlatformID;

		private SelectionButton retryButton;

		private GameObject player0WinIcon;

		private GameObject player1WinIcon;

		private GameObject autoGoNextMessageRoot;

		private TMP_Text autoGoNextMessageText;

		private DuelClient host;

		private Dictionary<string, object> profileDataMyself;

		private Dictionary<string, object> profileDataRival;

		private const string currentPlatformIconPath = "Images/PlatformIcon/<_PLATFORM_>/CurrentPlatformS";

		public GameObject profileCardObj
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

		public static bool IsNextButtonClicked
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

		public void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public bool IsShowing()
		{
			return false;
		}

		public void Play(string label)
		{
		}

		public bool IsPlaying(string label)
		{
			return false;
		}

		private void OnNextButton()
		{
		}

		private void OnRetryButton()
		{
		}

		private void OnClickProfileCardButton(Dictionary<string, object> profileData)
		{
		}

		public void Setup(DuelClient host, string message, bool dispProfileCard, bool isOnlineMode, bool isReplayMode, string userNameMyself, int iconIDMyself, int frameIDMyself, string onlineIDMyself, bool isSameOSMyself, Dictionary<string, object> profileDataMyself, bool winMyself, string userNameRival, int iconIDRival, int frameIDRival, string onlineIDRival, bool isSameOSRival, Dictionary<string, object> profileDataRival, bool winRival, bool disp, bool showRetryButton, int playeridMyself, int playeridRival, bool showAutoGoNext, bool hidePlayerID)
		{
		}

		private void SetMessage(string message, bool disp = true)
		{
		}

		public void UpdateAutoGoNextMessage(float currentTime)
		{
		}

		public void SelectEndMessageBtn()
		{
		}

		private void SelectNearestBtnImpl()
		{
		}

		private void SetDispMessage(bool disp)
		{
		}
	}
}
