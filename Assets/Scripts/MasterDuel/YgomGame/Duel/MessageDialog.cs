using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class MessageDialog : MonoBehaviour
	{
		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private ExtendedTextMeshProUGUI msgText;

		private Image icon;

		private const string prefabPathNoResponse = "Prefabs/Duel/MessageDialogNoResponse";

		private const string prefabPathNoOperation = "Prefabs/Duel/MessageDialogNoOperation";

		public bool isShowing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void CreateNoResponse(Transform parent, Action<MessageDialog> onLoaded)
		{
		}

		public static void CreateNoOperation(Transform parent, Action<MessageDialog> onLoaded)
		{
		}

		public static void Create(string prefabPath, Transform parent, Action<MessageDialog> onLoaded)
		{
		}

		private void Initialize()
		{
		}

		public void Open()
		{
		}

		public void Close(bool force = false)
		{
		}

		public void SetMessage(string msg)
		{
		}

		public void SetIcon(bool disp, Sprite icon = null)
		{
		}
	}
}
