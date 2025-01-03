using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Duelpass
{
	public class DuelpassRewardPanelWidget
	{
		private InfinityScrollView infinityScroll;

		private ScrollRect scrollRect;

		private Dictionary<GameObject, DuelpassRewardColumnWidget> templateToWidgetDict;

		private GameObject lockedIcon;

		private SelectionButton backButton;

		private SelectionButton nextButton;

		private SelectionButton toDuelResultButton;

		private float snapDurationTime;

		private int attentionEntityIdx;

		private int currentGrade;

		private int achievedGrade;

		private int duelpassScrollentityNum;

		private int attentionEntityIdxMax;

		private int target;

		private bool isFirstChangeGrade;

		private bool isReceivable;

		private bool isLockedPageButton;

		private List<DuelpassRewardColumnContext> entityContextList;

		private Dictionary<int, DuelpassRewardColumnWidget> gradeToWidgetDict;

		private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

		private bool isPlayingAnimation;

		public DuelpassRewardPanelWidget(ElementObjectManager duelpassUIeom, SelectionButton okButton = null)
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		public void ReceiveFunctionOff()
		{
		}

		public void MoveToGradeBeforeDuel()
		{
		}

		public void MoveToAchievedGrade()
		{
		}

		public void OnGradeUp(int grade)
		{
		}

		private int GetAttentionEntityIdx(int grade)
		{
			return 0;
		}

		public void UpdateContents()
		{
		}

		private void MakeScrollEntityList()
		{
		}

		private void OnEntityCreate(GameObject duplicatedTemplate)
		{
		}

		private void OnEntityUpdate(GameObject duplicatedTemplate, int entityIdx)
		{
		}

		private void OnClickBackButton()
		{
		}

		private void OnClickNextButton()
		{
		}

		private void SnapPage(int dir)
		{
		}

		private IEnumerator SnapCoroutine(int snapSpan, Action onCompleteAction = null)
		{
			return null;
		}

		public void UnLockGoldPass()
		{
		}

		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectSelectionItemsFunc(GameObject go)
		{
			return null;
		}

		private bool IsSelectableDataIndexFunc(int idx)
		{
			return false;
		}

		private int CalcLeftEdge()
		{
			return 0;
		}

		private void OnScrollValueChanged()
		{
		}

		public void StartProgress()
		{
		}

		public void EndProgress()
		{
		}

		private void UpdatePageButton()
		{
		}

		private int CalcRelativeIdx(int x)
		{
			return 0;
		}

		private void FocusRelativePos(int diff, int y)
		{
		}

		private (int, int) CheckCurrentButtonPos()
		{
			return default((int, int));
		}
	}
}
