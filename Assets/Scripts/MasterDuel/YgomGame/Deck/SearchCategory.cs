using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class SearchCategory : MonoBehaviour
	{
		private ElementObjectManager m_eom;

		private GameObject m_ImageOn;

		private GameObject m_ImageOff;

		private SelectionButton m_button;

		private GameObject m_templateObj;

		private UnityAction m_OnClickAction;

		private SearchCategoryWidget m_SearchCategoryWidget;

		public SearchCategoryWidget searchCategoryWidget => null;

		private void Awake()
		{
		}

		public IAsyncProgressContainer SetParams(int id, string name, bool isSelected)
		{
			return null;
		}

		private IAsyncProgressContainer SetData(int id, string name)
		{
			return null;
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		public bool OnClick()
		{
			return false;
		}

		private void Start()
		{
		}
	}
}
