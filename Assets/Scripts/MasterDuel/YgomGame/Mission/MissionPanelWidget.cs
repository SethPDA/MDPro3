using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionPanelWidget : ElementWidgetBase
	{
		private const string k_ELabelFocusEffect = "FocusEffect";

		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelInfoGroup;

		private readonly string k_ELabelLimitDateGroup;

		private readonly string k_ELabelLimitDateText;

		private readonly string k_ELabelHintGroup;

		private readonly string k_ELabelHintButton;

		private readonly string k_ELabelHintShortcutIconGroup;

		private readonly string k_ELabelGoalsPager;

		private readonly string k_ELabelLockedFilter;

		private readonly string k_ELabelLockedIcon;

		private readonly string k_ELabelBadge;

		private readonly string k_ELabelSecretIcon;

		private const string k_TLabelIn = "in";

		private const string k_TLabelOut = "out";

		public int missionId;

		public readonly LabeledPlayableController m_LabeledPlayableControlelr;

		public readonly PlayableDirector playableDirector;

		public readonly MissionGoalsPagerWidget goalsPager;

		public readonly SelectionItem selectionItem;

		public readonly GameObject titleBase;

		public readonly TMP_Text titleText;

		public readonly GameObject InfoGroup;

		public readonly GameObject limitDateGroup;

		public readonly TMP_Text limitDateText;

		public readonly SelectionButton hintButton;

		public readonly GameObject lockedFilter;

		public readonly GameObject lockedIcon;

		public readonly GameObject badge;

		public readonly GameObject secretIcon;

		public PlayableAsset tmCompleteMission;

		public PlayableAsset tmHideMission;

		public PlayableAsset tmNewMission;

		public PlayableAsset tmFocusMission;

		private GameObject focusEffect => null;

		public GameObject hintGroup => null;

		public ShortcutIcon hintShortcutIconGroup => null;

		public MissionPanelWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public bool ValidSetSpeed()
		{
			return false;
		}

		public void SetPlayableSpeed(double speed)
		{
		}

		public void PlayFocusEffect()
		{
		}

		public bool IsPlayingFocusEffect()
		{
			return false;
		}

		public void SetFocusEffect()
		{
		}

		public void ClearFocusEffect()
		{
		}

		public void PlayCompleteEffectIn(bool isSkip)
		{
		}

		public bool IsPlayingCompleteEffectIn()
		{
			return false;
		}

		public void PlayCompleteEffectOut(bool isSkip)
		{
		}

		public void SetCompleteEffect()
		{
		}

		public void ClearCompleteEffect()
		{
		}

		public bool IsPlayingCompleteEffectOut()
		{
			return false;
		}

		public void ForceEndCompleteEffectOut()
		{
		}

		public void PlayEntryEffect()
		{
		}

		public bool IsPlayingEntryEffect()
		{
			return false;
		}

		public void ForceEndEntryEffect()
		{
		}

		public void SetEntryEffect()
		{
		}

		private void PlayTM(PlayableAsset playableAsset, string label = "in")
		{
		}

		private void PlayTMWithSkipSwitch(PlayableAsset playableAsset, string label, bool skipOn)
		{
		}

		private bool IsPlayingTM(PlayableAsset playableAsset, string label = "in")
		{
			return false;
		}

		private void EvaluateHeadTM(PlayableAsset playableAsset, string label = "in")
		{
		}

		private void EvaluateTailTM(PlayableAsset playableAsset, string label = "in")
		{
		}
	}
}
