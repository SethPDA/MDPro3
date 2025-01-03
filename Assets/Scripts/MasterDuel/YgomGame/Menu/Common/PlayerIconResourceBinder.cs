using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu.Common
{
	public class PlayerIconResourceBinder : ResourceBinderBase//, IItemIconBinder, IItemIconFrameBinder
	{
		[Serializable]
		public class PlayerIconPathData
		{
			public ResourceBindingPathSetting.ItemPathData m_PlayerIconBasePath;

			public ResourceBindingPathSetting.ItemPathData m_PlayerFramePath;

			public string m_PlayerFrameMatPath;

			public string m_RankIconPath;

			public string m_RankIconBGPath;

			public string m_EventRankIconPath;

			public string m_PlayerIconBlankPath;

			public string m_PlayerFrameMatDefaultPath;
		}

		public enum Size
		{
			SMALL = 0,
			LARGE = 1
		}

		private PlayerIconPathData m_PathData;

		public void Initialize(PlayerIconPathData pathData)
		{
		}

		public string GetPlayerIconBasePath(int id, bool isLarge = false)
		{
			return null;
		}

		public string GetPlayerIconFramePath(int id, bool isLarge = false)
		{
			return null;
		}

		public string GetPlayerIconFrameMatPath(int id)
		{
			return null;
		}

		public string GetPlayerIconRankPath(int id, Size size = Size.SMALL)
		{
			return null;
		}

		public string GetPlayerIconEventRankPath(int id, Size size = Size.SMALL)
		{
			return null;
		}

		public string GetPlayerIconRankBGPath(int id)
		{
			return null;
		}

		public BindingProfileFrameIcon BindPlayerIcon(GameObject target, int baseID, int frameID, bool fitParentSize = false, bool async = true)
		{
			return null;
		}

		public BindingProfileFrameIcon BindPlayerIconBase(GameObject target, int baseID, bool fitParentSize = false, bool async = true)
		{
			return null;
		}

		public BindingProfileFrameIcon BindPlayerIconFrame(GameObject target, int frameID, bool async = true, bool isLarge = false)
		{
			return null;
		}

		public BindingProfileFrameIcon BindPlayerIconBaseLarge(Image target, int baseID, bool async = true, bool isLarge = false)
		{
			return null;
		}

		public BindingProfileFrameIcon BindPlayerIconFrameLarge(Image target, int frameID, bool async = true, bool isLarge = false)
		{
			return null;
		}

		public BindingGameObjectEx BindPlayerIconRank(GameObject target, int rank, int tier, bool async = true, Size size = Size.SMALL, bool fitPrefabScale = true)
		{
			return null;
		}

		public BindingImageEx BindPlayerIconRankBG(Image target, int id, bool async = true)
		{
			return null;
		}

		public BindingGameObjectEx BindPlayerIconEventRank(GameObject target, int rank, int tier, bool async = true, Size size = Size.SMALL, bool fitPrefabScale = true)
		{
			return null;
		}

		private void SetEventTier(int tier, ElementObjectManager eom)
		{
		}

		private void SetTier(int tier, ElementObjectManager eom)
		{
		}

		private void ResetAnchor(RectTransform rt)
		{
		}

		private void FitPrefabScale(GameObject parent, GameObject go)
		{
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemIconBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemIconFrameBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemIconBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemIconFrameBinder_002EBindItemLarge(GameObject target, int itemID)
		{
			return null;
		}
	}
}
