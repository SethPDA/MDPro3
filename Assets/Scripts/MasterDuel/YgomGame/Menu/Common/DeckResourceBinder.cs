using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu.Common
{
	public class DeckResourceBinder : ResourceBinderBase//, IItemDeckCaseBinder, IItemStructureBinder, IItemDeckLimitBinder
	{
		[Serializable]
		public class DeckPathData
		{
			public ResourceBindingPathSetting.ItemPathData m_DeckCasePath;

			public ResourceBindingPathSetting.ItemPathData m_OpenCasePath;

			public ResourceBindingPathSetting.ItemPathData m_DeckLimitPath;
		}

		private DeckPathData m_Data;

		public void Initialize(DeckPathData data)
		{
		}

		public int GetDeckIconNumberFromStructureId(int structureId)
		{
			return 0;
		}

		public string GetStructureBoxIconPath(int structureId)
		{
			return null;
		}

		public string GetStructureBoxOpenIconPath(int structureId)
		{
			return null;
		}

		public StructureBoxWidget BindStructureBoxWidget(ElementObjectManager eom, int structureId, Sprite deckSprite = null, Sprite openedDeckSprite = null, Sprite[] monsterSprites = null)
		{
			return null;
		}

		public BindingImageEx BindStructureBoxIcon(Image target, int id, bool async = true)
		{
			return null;
		}

		public BindingImageEx BindStructureBoxIcon(GameObject target, int id, bool async = true)
		{
			return null;
		}

		public BindingImageEx BindStructureBoxOpenIcon(Image target, int id, bool async = true)
		{
			return null;
		}

		private int caseIDtoIconNumber(int caseID)
		{
			return 0;
		}

		public string GetDeckCaseIconPath(int caseID, bool isLarge = false, bool isReverse = false)
		{
			return null;
		}

		public string GetDeckCaseOpenIconPath(int caseID, bool isLarge = false)
		{
			return null;
		}

		public BindingImageEx BindDeckCaseIcon(Image target, int id, bool async = true, bool isLarge = false, bool isReverse = false)
		{
			return null;
		}

		public BindingImageEx BindDeckCaseOpenIcon(Image target, int id, bool async = true, bool isLarge = false)
		{
			return null;
		}

		public BindingImageEx BindDeckCaseIcon(GameObject target, int id, bool async = true, bool isLarge = false, bool isReverse = false)
		{
			return null;
		}

		public DeckCaseWidget BindDeckCaseWidget(GameObject rootObj, int caseId, int protectorId, string deckName, int[] pickupCards, int[] pickupDecos, bool opened, bool isLarge = false, bool isDestroyTweens = false)
		{
			return null;
		}

		public PublicDeckCaseWidget BindPublicDeckCaseWidget(GameObject rootObj, int caseId, int pickupCard)
		{
			return null;
		}

		public SearchCategoryWidget BindSearchCategoryWidget(GameObject rootObj, int categoryId, string categoryName)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemDeckCaseBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemDeckCaseBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemStructureBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemDeckLimitBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemDeckLimitBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}
	}
}
