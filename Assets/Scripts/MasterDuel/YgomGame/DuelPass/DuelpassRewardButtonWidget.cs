using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Duelpass
{
	public class DuelpassRewardButtonWidget : ElementWidgetBase
	{
		private TMP_Text countText;

		private GameObject rewardThumbHolder;

		private GameObject completedOutline;

		private GameObject progressOutline;

		private GameObject recievableOutline;

		private TMP_Text rewardNumText;

		private GameObject recievedIcon;

		private GameObject completedShadow;

		private GameObject reward;

		private GameObject body;

		private GameObject blankLine;

		private RectTransform rewardThumbHolderRT;

		private Vector2 originalOffsetMin;

		private Vector2 originalOffsetMax;

		public SelectionButton Button
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

		public int RewardId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsReceivable
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

		public DuelpassRewardButtonWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Init(int rewardId)
		{
		}

		public void Off()
		{
		}

		private void OnClick()
		{
		}

		private void UpdateButtonState(DuelpassRewardContext context)
		{
		}

		private void Update()
		{
		}

		public bool isReceivedCondi()
		{
			return false;
		}
	}
}
