using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelCoinDialog : DuelDialogBase
	{
		public enum Result
		{
			Back = 0,
			Front = 1,
			None = 2
		}

		private class CoinInfo
		{
			public ElementObjectManager coin;

			public int index;

			public Result result;
		}

		private Action<Result, bool> resultCallback;

		private Result result;

		private ExtendedTextMeshProUGUI textMessage;

		private List<CoinInfo> coinList;

		private SelectionButton decideButton;

		private const string prefabPath = "Prefabs/Duel/DuelCoinDialog";

		protected override bool useFieldView => false;

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelCoinDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		private void SelectItem(Result result)
		{
		}

		private void SelectDecideButton()
		{
		}

		private void SetResult(Result result)
		{
		}

		private void CancelResult()
		{
		}

		private void UpdateCoinList()
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

		public void Open(string message, Action<Result, bool> resultCallback, Action openCallback)
		{
		}
	}
}
