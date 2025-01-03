using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack
{
	public class CardWidget : ElementWidgetBase
	{
		private readonly string k_ECardLabelButton;

		private readonly string k_ECardLabelHighlight;

		private readonly string k_ECardLabelIconRarity;

		private readonly string k_ECardLabelLimitIcon;

		private readonly string k_ECardLabelNumTextArea;

		private readonly string k_ECardLabelNumText;

		private readonly string k_ECardLabelNewIcon;

		private int m_Mrk;

		private int m_StyleId;

		private readonly RawImage m_CardRawImage;

		private BindingCardMaterial m_BindingCardMaterial;

		public int regurationId;

		public bool highlightVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool newIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool limitIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Image limitIconImage => null;

		public GameObject innerTextArea => null;

		public TMP_Text innerText => null;

		public SelectionButton button => null;

		public BindingCardMaterial bindingCardMaterial => null;

		public static CardWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		public CardWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public virtual void Binding(int mrk, int styleId = 1)
		{
		}

		protected virtual void OnClick()
		{
		}

		public void OpenDetail()
		{
		}
	}
}
