using UnityEngine;

namespace YgomGame.DuelLive
{
	public class DuelLiveCategorySetting
	{
		[SerializeField]
		private DuelLiveCategoryShowcaseData m_ShowcaseData;

		[SerializeField]
		private DuelLiveCategoryShowcaseData m_CategoryData;

		[SerializeField]
		private DuelLiveShowcaseImportData m_replayData;

		public DuelLiveCategoryShowcaseData categoryData => null;

		public DuelLiveShowcaseImportData replayData => null;

		public void InitDuelLiveCategorySetting()
		{
		}

		public DuelLiveCategoryData GetCategoryData(int categoryId)
		{
			return null;
		}
	}
}
