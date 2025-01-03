using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Utility;

namespace YgomGame.Duel
{
	public class HandCardManager
	{
		public class HandInfo
		{
			public int m_Mrk;

			public int m_UniqueId;

			public bool m_IsHide;

			public int m_styleID;

			public int m_ViewIndex;
		}

		public enum ViewSortMode
		{
			EngineIndex = 0,
			Random = 1,
			Custom = 2
		}

		public enum DispMode
		{
			Full = 0,
			Small = 1
		}

		private List<HandInfo> nearHandInfoList;

		private List<HandInfo> farHandInfoList;

		public static DefinitionSetting handCardDefinision;

		private DispMode _nearHandDispMode;

		public bool nearAllOpen
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool farAllOpen
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DuelClient host
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isTerminated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DispMode nearHandDispMode
		{
			get
			{
				return default(DispMode);
			}
			set
			{
			}
		}

		public Action<DispMode> onNearHandDispModeChanged
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static HandCardManager Create(DuelClient host)
		{
			return null;
		}

		private void Initialize(DuelClient host)
		{
		}

		public void Terminate()
		{
		}

		public void AddNearHandCard(int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
		{
		}

		public void AddFarHandCard(int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
		{
		}

		private void AddHandCard(List<HandInfo> info_list, int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
		{
		}

		public void SetNearHandInfo(int index, int mrk)
		{
		}

		public void SetFarHandInfo(int index, int mrk)
		{
		}

		private void SetHandCardInfo(List<HandInfo> infoList, int index, int mrk)
		{
		}

		public void RemoveNearHandCard(int index)
		{
		}

		public void RemoveFarHandCard(int index)
		{
		}

		private void RemoveHandCard(List<HandInfo> info_list, int index)
		{
		}

		public int GetNearHandCardNum()
		{
			return 0;
		}

		public int GetFarHandCardNum()
		{
			return 0;
		}

		public bool SyncNearHandInfo(int[] uniqueIdList)
		{
			return false;
		}

		public bool SyncFarHandInfo(int[] uniqueIdList)
		{
			return false;
		}

		private bool SyncHandInfo(List<HandInfo> info_list, int[] uniqueIdList)
		{
			return false;
		}

		public HandInfo GetNearHandInfo(int index)
		{
			return null;
		}

		public HandInfo GetFarHandInfo(int index)
		{
			return null;
		}

		private HandInfo GetHandInfo(List<HandInfo> info_list, int index)
		{
			return null;
		}

		public void SetupNearViewIndex(ViewSortMode sortMode)
		{
		}

		public void SetupFarViewIndex(ViewSortMode sortMode)
		{
		}

		private void SetupViewIndex(List<HandInfo> infoList, ViewSortMode sortMode)
		{
		}

		private void SetupViewIndexEngineIndex(List<HandInfo> infoList)
		{
		}

		private void SetupViewIndexRandom(List<HandInfo> infoList)
		{
		}

		private void SetupViewIndexCustom(List<HandInfo> infoList)
		{
		}

		public void InsertNearViewIndex(int targetIndex, int insertViewIndex)
		{
		}

		public void InsertFarViewIndex(int targetIndex, int insertViewIndex)
		{
		}

		private void InsertViewIndex(List<HandInfo> infoList, int targetIndex, int insertViewIndex)
		{
		}

		public void InsertNearViewIndexIfOpen()
		{
		}

		public void InsertFarViewIndexIfOpen()
		{
		}

		private void InsertViewIndexIfOpen(List<HandInfo> infoList, int insertViewIndex)
		{
		}

		public int GetNearViewIndex(int index)
		{
			return 0;
		}

		public int GetFarViewIndex(int index)
		{
			return 0;
		}

		public int GetViewIndex(List<HandInfo> infoList, int index)
		{
			return 0;
		}

		public int GetNearIndexByViewIndex(int viewIndex)
		{
			return 0;
		}

		public int GetFarIndexByViewIndex(int viewIndex)
		{
			return 0;
		}

		private int GetIndexByViewIndex(List<HandInfo> infoList, int viewIndex)
		{
			return 0;
		}

		public int GetNearIndexByUniqueID(int uniqueID)
		{
			return 0;
		}

		public int GetFarIndexByUniqueID(int uniqueID)
		{
			return 0;
		}

		private int GetIndexByUniqueID(List<HandInfo> infoList, int uniqueID)
		{
			return 0;
		}

		public void SetNearHide(int index, bool hide)
		{
		}

		public void SetFarHide(int index, bool hide)
		{
		}

		private void SetHide(List<HandInfo> infoList, int index, bool hide)
		{
		}

		public void SetNearHideAll(bool hide)
		{
		}

		public void SetFarHideAll(bool hide)
		{
		}

		private void SetHideAll(List<HandInfo> infoList, bool hide)
		{
		}
	}
}
