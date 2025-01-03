using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class DeckBox : MonoBehaviour
	{
		protected ElementObjectManager m_eom;

		protected ElementObjectManager m_body;

		protected TextMeshProUGUI m_DeckNameText;

		protected GameObject m_CreateDeckIcon;

		protected GameObject m_DisabledIcon;

		protected GameObject m_CurrentDeckIcon;

		protected SelectionButton m_button;

		private ElementObjectManager m_SelectionToggle;

		private GameObject m_ToggleOn;

		public Image m_regImage;

		protected GameObject m_deckCaseObj;

		protected UnityAction m_OnClickAction;

		protected int m_deckID;

		public Action onSelectedTweenCallback;

		public Action onDeSelectedTweenCallback;

		protected string m_deckName;

		protected DeckCaseWidget m_deckCaseWidget;

		public bool m_isSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string SoundLabelClick
		{
			set
			{
			}
		}

		public int deckID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SelectionButton button => null;

		public string deckName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeckCaseWidget deckCaseWidget => null;

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

		public void Initialize()
		{
		}

		protected void SetTweenCallback()
		{
		}

		public IAsyncProgressContainer SetAsCreateButton()
		{
			return null;
		}

		public IAsyncProgressContainer SetAsDeck(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, bool opened = false, bool setAsNewButton = false, bool isDeletemode = false, bool isSelected = false)
		{
			return null;
		}

		private IAsyncProgressContainer SetData(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, bool opened = false, bool setAsNewButton = false, bool isDeletemode = false, bool isSelected = false)
		{
			return null;
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		public void SetCurrentDeckIcon(bool disp)
		{
		}

		public bool GetCurrentDeckIconDisp()
		{
			return false;
		}

		public void SetDisableDeckIcon(bool disp)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
