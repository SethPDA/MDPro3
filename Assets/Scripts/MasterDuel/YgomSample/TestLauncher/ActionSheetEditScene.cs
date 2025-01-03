using UnityEngine;
using YgomGame.Menu;

namespace YgomSample.TestLauncher
{
	public class ActionSheetEditScene : MonoBehaviour
	{
		[SerializeField]
		private GameObject m_CustomPositiveButton;

		[SerializeField]
		private GameObject m_CustomDestructiveButton;

		[SerializeField]
		private GameObject m_CustomDisableButton;

		[SerializeField]
		private GameObject m_EmbedGameObject;

		[SerializeField]
		private string m_Title;

		[SerializeField]
		private string m_Messages;

		[SerializeField]
		private string[] m_EntryTexts;

		[SerializeField]
		private int m_DestructiveLength;

		[SerializeField]
		private ActionSheetViewController.EntryData[] m_EntryDatas;

		public void OpenWithEmbedObject()
		{
		}

		public void OpenEntitys()
		{
		}

		public void OpenCustomSheet()
		{
		}
	}
}
