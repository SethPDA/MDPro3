using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class ListCard : MonoBehaviour
	{
		[SerializeField]
		private Color m_ColorMyself;

		[SerializeField]
		private Color m_ColorRIval;

		[SerializeField]
		private Color m_ColorDefault;

		private ListCardData m_CardData;

		private ElementObjectManager m_EOManager;

		private RawImage m_CardPicture;

		private RawImage m_DarkMask;

		private GameObject m_LinkMarker;

		private GameObject m_CardMask;

		private GameObject m_Badge;

		private GameObject m_PendulumInfo;

		private Image m_BgPanel;

		private Image m_SelectedEffect;

		private Image m_Star;

		private Image m_TargettedIcon;

		private Image m_ChainIcon;

		private Image m_FromExtraIcon;

		private ExtendedTextMeshProUGUI m_BadgeIndex;

		private ExtendedTextMeshProUGUI m_LvRkLkNum;

		private ExtendedTextMeshProUGUI m_ChainNum;

		private ExtendedTextMeshProUGUI m_PendulumScaleNum;

		private SelectionButton m_SelectionButton;

		private bool m_DarkMode;

		private Color m_OwnerColor => default(Color);

		public int RunListIndex => 0;

		public int DataIndex => 0;

		public bool Isknown => false;

		public bool HoldInstance => false;

		public int CardId => 0;

		public int UniqueID => 0;

		public int TargetUid => 0;

		public int Badge
		{
			set
			{
			}
		}

		public int textid => 0;

		public bool Selected
		{
			set
			{
			}
		}

		public bool Targeted
		{
			set
			{
			}
		}

		public bool DarkMode
		{
			set
			{
			}
		}

		public int Player => 0;

		public int Position => 0;

		public bool Face => false;

		public int highlightEffectTableIndex => 0;

		private void InitComponent()
		{
		}

		public void Initialize()
		{
		}

		public void SetDecideButton(bool use_decide_button, SelectionButton decide_button = null)
		{
		}

		public void SetData(ListCardData data)
		{
		}

		public void UpdateListCard()
		{
		}

		public void SetGroupPos(int index)
		{
		}

		private void SetCardArea()
		{
		}

		private void SetInfoArea()
		{
		}

		private void SetLevelRankLink()
		{
		}

		private void SetPendulumScale()
		{
		}

		private void SetCardPicture()
		{
		}

		public void SetOnClick(UnityAction<ListCard> onClick)
		{
		}

		public void SetOnDoubleClick(UnityAction<ListCard> onDoubleClick)
		{
		}

		public void SetOnHold(UnityAction<ListCard> onHold)
		{
		}

		public void SetSelectionCursor()
		{
		}

		public Transform GetCardPictureTransform()
		{
			return null;
		}
	}
}
