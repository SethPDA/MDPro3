using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelInfoDialog : DuelInfoDialogBase
	{
		private class InfoDialogOperationInfo : OperationInfo
		{
			public static OperationInfo OpenOperation(DuelInfoDialog dialog, string message, Place place, bool cancelable, Action cancelCallback, Action closeCallback = null, bool decidable = false, Action decisionCallback = null, Action actCallback = null)
			{
				return null;
			}
		}

		private const string prefabPath = "Prefabs/Duel/DuelInfoDialog";

		public void ReqOpen(string message, Place place, bool cancelable, Action cancelCallback, Action closeCallback = null, bool decidable = false, Action decisionCallback = null, Action actCallback = null)
		{
		}

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelInfoDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}
	}
}
