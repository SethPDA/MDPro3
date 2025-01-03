using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class PublicDeckBox : MonoBehaviour
	{
		private ElementObjectManager m_eom;

		private ElementObjectManager m_body;

		private GameObject m_CardImage;

		private GameObject m_DeckImage;

		private SelectionButton m_button;

		private GameObject m_publicDeckCaseObj;

		private UnityAction m_OnClickAction;

		private int m_deckID;

		private PublicDeckCaseWidget m_publicDeckCaseWidget;

		public int DeckID => 0;

		public PublicDeckCaseWidget publicDeckCaseWidget => null;

		public DeckSelectViewController2.DeckCondition m_Condition
		{
			[CompilerGenerated]
			get
			{
				return default(DeckSelectViewController2.DeckCondition);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public IAsyncProgressContainer SetParams(int id, int pickup_id, int caseId)
		{
			return null;
		}

		private IAsyncProgressContainer SetData(int id, int pickup_id, int caseId)
		{
			return null;
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		private void Start()
		{
		}
	}
}
