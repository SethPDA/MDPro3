using System.Collections;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionGoalWidget : ElementWidgetBase
	{
		public enum GoalType
		{
			None = 0,
			InProgress = 1,
			Recievable = 2,
			Complete = 3
		}

		private readonly string k_ELabelCountText;

		private readonly string k_ELabelRewardThumbHolder;

		private readonly string k_ELabelRewardNumText;

		private const string k_ELabelRecievedIcon = "RecievedIcon";

		private const string k_TLabelOnRecieveBetweenWait = "OnRecieveBetweenWait";

		private const string k_TLabelOnRecieved = "OnRecieved";

		public readonly GoalType goalType;

		private bool existsRecievedIcon => false;

		private GameObject recievedIcon => null;

		public TMP_Text countText => null;

		public GameObject rewardThumbHolder => null;

		public TMP_Text rewardNumText => null;

		public MissionGoalWidget(ElementObjectManager eom, GoalType goalType)
			: base(null)
		{
		}

		public void SetRecieveBetweenWaitSpeed(float speed)
		{
		}

		public bool IsPlayingRecieveBetweenWait()
		{
			return false;
		}

		public IEnumerator yPlayRecieveBetweenWait()
		{
			return null;
		}

		public void SetRecievedSpeed(float speed)
		{
		}

		public void PlayRecieved()
		{
		}

		private IEnumerator yPlayRecieved()
		{
			return null;
		}

		public bool IsPlayingRecieved()
		{
			return false;
		}

		public void SetRecieved()
		{
		}

		public void ClearRecieved()
		{
		}
	}
}
