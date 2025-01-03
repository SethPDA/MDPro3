using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class EndlessScrollView : MonoBehaviour
	{
		[SerializeField]
		protected string templateLabel;

		[SerializeField]
		protected string contentLabel;

		[SerializeField]
		protected string viewportLabel;

		[SerializeField]
		protected ScrollMode m_ScrollMode;

		protected Rect m_ScrollViewRT;

		protected GridLayoutGroup m_GridLayoutGroup_org;

		[SerializeField]
		protected RectOffset m_Padding;

		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		protected TextAnchor m_ChildAlignment;

		protected UnityEvent onBlockBiasUpdate;

		protected UnityEvent onDataBiasUpdate;

		protected UnityEvent onDataNumChanged;

		protected UnityEvent onPaddingChanged;

		public Func<int> getDataNum;

		public Action<GameObject> onItemInitialize;

		public Action<GameObject, int> onItemUpdate;

		protected Vector2 m_ItemBias;

		protected Vector2 m_DataBias;

		protected Vector2 m_PosTrans;

		protected TweenPosition m_TweenMove;

		protected List<RectTransform> m_ItemRTList;

		protected int m_DataNum_Old;

		protected Vector2 m_ItemBias_Old;

		protected Vector2 m_DataBias_Old;

		protected Vector2 m_BlockBias_Old;

		protected Vector2 m_ContentPos_Old;

		protected RectOffset m_Padding_Old;

		protected bool m_Isinitialized;

		protected RectTransform m_ContentRT => null;

		protected int m_ItemNum => 0;

		protected GridLayoutGroup m_GridLayoutGroup => null;

		public int viewItemRow => 0;

		public int viewItemColumn => 0;

		public Vector2 dataBias
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 itemBias
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool isInitialized => false;

		protected Vector2 m_BlockBias => default(Vector2);

		public Vector2 unitSize => default(Vector2);

		public Vector2 blockSize => default(Vector2);

		public ScrollMode endlessMode
		{
			get
			{
				return default(ScrollMode);
			}
			set
			{
			}
		}

		public bool isOnTop => false;

		public bool isOnBottom => false;

		protected bool m_DataNumChangedFlag => false;

		protected bool m_DataBiasChangedFlag => false;

		protected bool m_ItemBiasChangedFlag => false;

		protected bool m_BlockBiasChangedFlag => false;

		protected bool m_ContentPosChangedFlag => false;

		protected bool m_PaddingChangedFlag => false;

		protected ScrollRect m_ScrollRect => null;

		protected int m_DataNum => 0;

		protected int m_DataLineCount => 0;

		protected int m_ItemNumPerLine => 0;

		protected int m_DataBiasIndex => 0;

		public virtual void Initialize(Func<int> getDataNum, Action<GameObject, int> onItemUpdate, Action<GameObject> onItemInitialize = null)
		{
		}

		public void ForceUpdateContent()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void Instantiation()
		{
		}

		protected void SetViewSize()
		{
		}

		protected void AttachTween()
		{
		}

		protected void SetLayout()
		{
		}

		protected void UpdateItemData()
		{
		}

		private void SetItemVisibility(int itemIndex, bool visibility)
		{
		}

		public void UpdateDataBias()
		{
		}

		public void UpdatePadding()
		{
		}

		public void MoveContent(Vector2 move)
		{
		}

		public void IncreaseLine(bool loop = false, float lineNum = 1f)
		{
		}

		public void DecreaseLine(bool loop = false, float lineNum = 1f)
		{
		}

		public RectTransform GetItemByDataIndex(int dataIndex)
		{
			return null;
		}

		public Vector2 GetItemPosByDataIndex(int dataIndex, Vector2 pivot = default(Vector2))
		{
			return default(Vector2);
		}

		public int GetItemIdByDataIndex(int dataIndex)
		{
			return 0;
		}

		public int GetDataIdByItemIndex(int itemIndex)
		{
			return 0;
		}

		public bool CheckItemIndex(int itemIndex)
		{
			return false;
		}

		public int DataIndexCorrection(int dataIndex)
		{
			return 0;
		}
	}
}
