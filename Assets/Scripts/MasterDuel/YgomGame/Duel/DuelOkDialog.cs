using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelOkDialog : DuelDialogBase
	{
		private Action<bool> resultCallback;

		private ExtendedTextMeshProUGUI textMessage;

		private ExtendedTextMeshProUGUI textButton;

		private ContentSizeFitter dialogFitter;

		private const string prefabPath = "Prefabs/Duel/DuelOkDialog";

		protected override bool useFieldView => false;

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelOkDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		private void OnClickOk()
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

		public void Open(string message, string buttonText, Action<bool> resultCallback, Action openCallback)
		{
		}

		public void Open(string message, Action<bool> resultCallback, Action openCallback)
		{
		}
	}
}
