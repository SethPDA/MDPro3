using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission
{
	public class MissionBulkRecieveDialogWidget : ContentWidgetBase<MissionBulkRecieveDialogWidget, EntryInsertWidgetData>, IContentWidgetAsyncLoader, IContentPostAllInsertedHandler, IContentWidgetDirectionalInputListener, IContentLifecycleHandler
	{
		public class ClearTabContext
		{
			public string tabLabel;

			public List<ClearInfoContext> clearInfos;

			public ClearTabContext(string tabLabel)
			{
			}
		}

		public class ClearInfoContext
		{
			public string missionName;

			public EntryItemListData.Context item;

			public int goalCnt;

			public int goalMax;

			public ClearInfoContext(string missionName, EntryItemListData.Context item, int goalCnt, int goalMax)
			{
			}
		}

		private readonly int k_TemplateItemIdx;

		private readonly int k_TemplateGroupNameIdx;

		private readonly int k_TemplateGroupBorderIdx;

		private readonly int k_TemplateMissionIdx;

		private readonly int k_TemplateItemBorderIdx;

		public List<EntryItemListData.Context> totalItems;

		public List<ClearTabContext> clearTabInfos;

		private InfinityScrollView m_ScrollView;

		//private ScrollRect m_ScrollRect;

		private Selector m_Selector;

		private List<object> m_ScrollDataList;

		private List<int> m_ScrollTemplateIdxList;

		private Dictionary<GameObject, CommonDialogItemListWidget.ItemLineWidget> m_ItemWidgetMap;

		private Dictionary<SelectionItem, GameObject> m_ItemButtonEntityMap;

		private Action m_OnCompleteCallback;

		public bool rebuildLayoutOnPostAllInserted => false;

		public static MissionBulkRecieveDialogWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void AsyncBinding(IEntryData entryData, Action onComplete)
		{
		}

		protected override void InnerBinding(EntryInsertWidgetData entryData)
		{
		}

		public void OnPostAllInserted()
		{
		}

		private void OnScrollInitialized()
		{
		}

		private void OnUpdatedEntityCallback(GameObject entity, int idx)
		{
		}

		private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		private bool OnFocusSelectEntity(GameObject entity, int dataIndex, bool isInitializeSelect = false)
		{
			return false;
		}

		private void InsertGroupName(string name)
		{
		}

		private void InsertGroupBorder()
		{
		}

		private void InsertItemEntity(EntryItemListData.Context itemContext)
		{
		}

		private void InsertMissionEntity(ClearInfoContext clearInfo)
		{
		}

		private void InsertEntityBorder()
		{
		}

		private void UpdateGroupName(GameObject entity, object data)
		{
		}

		private void UpdateItemEntity(GameObject entity, object data)
		{
		}

		private void UpdateMissionEntity(GameObject entity, object data)
		{
		}

		private bool TrySelectHeadItem(bool focus = false)
		{
			return false;
		}

		private void TrySelectBottomItem(bool focus = false)
		{
		}

		private bool TrySelectItem(int entityIdx, SelectionItem currentItem, bool focus = false)
		{
			return false;
		}

		private bool TrySelectItem(GameObject activeEntity, SelectionItem currentItem, bool focus = false)
		{
			return false;
		}

		private void CheckSelectOnAnalogInput(Vector2 dir)
		{
		}

		public void OnMainAnalogInput(Vector2 dir)
		{
		}

		public void OnSubAnalogInput(Vector2 dir)
		{
		}

		public void OnLeftInput()
		{
		}

		public void OnRightInput()
		{
		}

		public void OnUpInput()
		{
		}

		public void OnDownInput()
		{
		}

		public bool OnBack()
		{
			return false;
		}

		public MissionBulkRecieveDialogWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
