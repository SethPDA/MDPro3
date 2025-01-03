using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame
{
	public class SoundTestLauncher : ViewController
	{
		private class TestPlayerInfo
		{
			public GameObject player;

			public string soundLabel;

			public bool oneShot;

			public RectTransform label3d;
		}

		[SerializeField]
		private GameObject prefabUI;

		[SerializeField]
		private GameObject prefabPlayer;

		private ElementObjectManager ui;

		private ElementObjectManager infoTemplate;

		private Transform infoListParent;

		private RectTransform label3dParent;

		private List<TestPlayerInfo> playerList;

		private int createCounter;

		public override void NotificationStackEntry()
		{
		}

		private void SetupScrollToSelectingItem(SelectionItem item, RectTransform itemRootRect)
		{
		}

		private void SetupAnalogInputShortcut(SelectionItem item, Transform player, InputField inputX, InputField inputY, InputField inputZ)
		{
		}

		private void SetupPlayShortcut(SelectionItem item, TestPlayerInfo info)
		{
		}

		private void Update()
		{
		}
	}
}
