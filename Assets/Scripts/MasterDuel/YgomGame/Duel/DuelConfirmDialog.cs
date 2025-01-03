using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelConfirmDialog : DuelDialogBase
	{
		public enum Result
		{
			Left = 0,
			Right = 1
		}

		private Result result;

		private Action<Result, bool> resultCallback;

		private ExtendedTextMeshProUGUI textMessage;

		private ExtendedTextMeshProUGUI textLeftButton;

		private ExtendedTextMeshProUGUI textRightButton;

		private ContentSizeFitter dialogFitter;

		private RectTransform rightButtonRectTransform;

		private SelectionButton rightButton;

		private bool useFieldViewFlag;

		private const string prefabPath = "Prefabs/Duel/DuelConfirmDialog";

		protected override bool useFieldView => false;

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelConfirmDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		private void OnDecide(Result result)
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

		public void Open(string message, string rightButtonText, string leftButtonText, Action<Result, bool> resultCallback, Action openCallback, bool useFieldView = true)
		{
		}

		public void Open(string message, Action<Result, bool> resultCallback, Action openCallback, bool useFieldView = true)
		{
		}
	}
}
