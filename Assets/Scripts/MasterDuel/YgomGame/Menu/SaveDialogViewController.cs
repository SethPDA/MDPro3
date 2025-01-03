using System;
using UnityEngine;

namespace YgomGame.Menu
{
	public class SaveDialogViewController : DialogViewControllerBase, IBokeSupported
	{
		private static GameObject prefab;

		private static bool LoadPrefab()
		{
			return false;
		}

		public static void Open(string title, string message, string button1Label, Action button1Action, string button2Label, Action button2Action, string button3Label, Action button3Action)
		{
		}

		private void Start()
		{
		}

		private void SetupUI()
		{
		}

		public override void NotificationStackEntry()
		{
		}
	}
}
