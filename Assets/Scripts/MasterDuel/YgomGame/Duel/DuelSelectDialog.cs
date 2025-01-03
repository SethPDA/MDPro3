using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelSelectDialog : DuelDialogBase
	{
		public struct Info
		{
			public string message;

			public bool isEnable;
		}

		private int result;

		private Action<int, bool> resultCallback;

		private TMP_Text textMessage;

		private TMP_Text textEffectMessage;

		private ExtendedScrollRect textScroll;

		private ContentSizeFitter contentFitter;

		private ContentSizeFitter textFitter;

		private ElementObjectManager tabTemplate;

		private RectTransform tabParent;

		private SelectionButton decideButton;

		private Image disableScreen;

		private List<ElementObjectManager> tabList;

		private List<Info> infoList;

		private const string prefabPath = "Prefabs/Duel/DuelSelectDialog";

		protected override bool useFieldView => false;

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelSelectDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		private void SetupTab(int tabNum)
		{
		}

		private bool DecideEffect(int index)
		{
			return false;
		}

		private void SetResult(int index)
		{
		}

		private void UpdateTab()
		{
		}

		private void UpdateMessage(int effectIndex)
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

		public void Open(string message, List<Info> infoList, Action<int, bool> resultCallback, Action openCallback)
		{
		}
	}
}
