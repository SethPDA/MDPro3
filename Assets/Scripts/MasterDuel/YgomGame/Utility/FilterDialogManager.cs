using System;
using System.Collections;
using System.Collections.Generic;
using YgomGame.Deck;

namespace YgomGame.Utility
{
	public class FilterDialogManager
	{
		private SearchFilter.Setting m_Setting;

		private SearchFilter.Setting m_DefaultSetting;

		private List<FilterDialog.FilterGroupType> m_FilterGroupTypes;

		public bool IsFiltered()
		{
			return false;
		}

		private bool CheckDiff(BitArray ba1, BitArray ba2)
		{
			return false;
		}

		private static bool checkAny(BitArray ba)
		{
			return false;
		}

		public void OpenFilterDialog(int regID = -1, Action resultCallback = null)
		{
		}

		private List<CardBaseData> GetCardBaseDataList(List<int> mrks)
		{
			return null;
		}

		public List<int> GetFilteredList(List<int> mrks)
		{
			return null;
		}

		public void SetDefaultSetting(SearchFilter.Setting setting)
		{
		}

		public void SetFilterGroupTypes(List<FilterDialog.FilterGroupType> filterGroupTypes)
		{
		}

		private void CopyDefaultSetting()
		{
		}
	}
}
