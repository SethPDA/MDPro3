using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelPullDownDialog : DuelDialogBase
	{
		private Action<List<int>, bool> resultCallback;

		private int selectNum;

		private List<int> result;

		private Selector scrollSelector;

		private List<string> selectionList;

		private InfinityScrollView scroll;

		private ExtendedTextMeshProUGUI textMessage;

		private SelectionButton decideButton;

		private GameObject counterArea;

		private ExtendedTextMeshProUGUI textCounter;

		private const string prefabPath = "Prefabs/Duel/DuelPullDownDialog";

		private int currentResultIndex => 0;

		protected override bool useFieldView => false;

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelPullDownDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		private void InitializeScroll()
		{
		}

		private void OnCreateEntity(GameObject obj)
		{
		}

		private void OnUpdateEntity(GameObject item, int index)
		{
		}

		private void Select(int index)
		{
		}

		private void SelectItem(int index)
		{
		}

		private void SelectDecideButton()
		{
		}

		private void SetResult(int result, int index)
		{
		}

		private void CancelLastResult()
		{
		}

		private void CancelResult(int result)
		{
		}

		private void UpdateCounter()
		{
		}

		private void UpdateDecideButton()
		{
		}

		protected override void OnClosed()
		{
		}

		protected override void ShowUI()
		{
		}

		protected override void HideUI()
		{
		}

		public override void Abort()
		{
		}

		public override void OnCancel()
		{
		}

		protected override void FinishFieldView(bool isAbort)
		{
		}

		public void Open(string message, List<string> selectionList, int selectNum, Action<List<int>, bool> resultCallback, Action openCallback)
		{
		}
	}
}
