using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class CardBase : MonoBehaviour
	{
		protected ElementObjectManager m_eom;

		protected const string LABEL_IMG_CARDIMAGE = "ImageCard";

		protected const string LABEL_IMG_NOCARD = "NoCard";

		protected const string LABEL_IMG_RENTALCARD = "RentalCard";

		public SelectionButton m_ImageCardButton;

		public Image m_ImageNoCard;

		public Image m_ImageRentalCard;

		protected RawImage m_CardImage;

		protected UnityAction m_OnClickAction;

		protected UnityAction m_OnSelectedAction;

		protected UnityAction m_OnDeselectedAction;

		protected UnityAction<bool> m_OnRightClickAction;

		protected UnityAction m_SelectedKeyL2Action;

		protected UnityAction<Vector2> m_DragBeginAction;

		protected UnityAction<Vector2> m_DragAction;

		protected UnityAction<Vector2> m_DragEndAction;

		private bool isIni;

		public CardBaseData m_BaseData
		{
			[CompilerGenerated]
			get
			{
				return default(CardBaseData);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected void InitializeElemnts()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual void SetData(CardBaseData data, int regulationID = -1)
		{
		}

		public void SetCardImage(Texture image)
		{
		}

		public void SetCardImageMaterial(Material mat)
		{
		}

		public void SetMonochrome(bool b)
		{
		}

		public void SetRentalImage(bool b)
		{
		}

		public void UnsetCardImagTexture()
		{
		}

		public void SetDisp(bool disp)
		{
		}

		public void SetOnSelectedCallback(UnityAction callback)
		{
		}

		public void SetOnDeselectedCallback(UnityAction callback)
		{
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		public void SetOnRightClickCallback(UnityAction<bool> callback)
		{
		}

		public void SetOnSelectedKeyL2Callback(UnityAction callback)
		{
		}

		public void SetDragBeginCallback(UnityAction<Vector2> callback)
		{
		}

		public void SetDragCallback(UnityAction<Vector2> callback)
		{
		}

		public void SetDragEndCallback(UnityAction<Vector2> callback)
		{
		}

		public void InvokeDragBeginCallback(Vector2 screenPoint)
		{
		}

		public void InvokeDragCallback(Vector2 screenPoint)
		{
		}

		public void InvokeDragEndCallback(Vector2 screenPoint)
		{
		}
	}
}
