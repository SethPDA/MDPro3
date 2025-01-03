using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class FieldResourceBinder : ResourceBinderBase//, IItemFieldBinder, IItemFieldObjBinder, IItemAvatarHomeBinder
	{
		[Serializable]
		public class FieldPathData
		{
			public ResourceBindingPathSetting.ItemPathData m_FieldIconPath;

			public ResourceBindingPathSetting.ItemPathData m_FieldObjIconPath;

			public ResourceBindingPathSetting.ItemPathData m_AvatarBaseIconPath;
		}

		private FieldPathData m_PathData;

		public void Initialize(FieldPathData pathData)
		{
		}

		public string GetFieldIconPath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldIcon(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public string GetFieldLargePath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldLarge(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public string GetFieldObjIconPath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldObjIcon(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public string GetFieldObjLargePath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldObjIconLarge(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public string GetFieldAvatarBaseIconPath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldAvatarBaseIcon(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public string GetFieldAvatarBaseIconLargePath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindFieldAvatarBaseIconLarge(Image target, int itemId, bool async = true)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemFieldBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemFieldObjBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarHomeBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemFieldBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemFieldObjBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarHomeBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}
	}
}
