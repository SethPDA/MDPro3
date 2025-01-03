using UnityEngine;

namespace YgomGame.DuelLive
{
	public class DuelLiveSettings
	{
		internal const string k_Path = "Definition/DuelLive/DuelLiveSettings";

		[SerializeField]
		private DuelLiveCategorySetting m_CategorySetting;

		[SerializeField]
		private string[] m_BGMonsterImgPaths;

		public DuelLiveCategoryShowcaseData categoryData => null;

		public DuelLiveShowcaseImportData replayData => null;

		public string[] bgMonsterImgPaths => null;

		public void InitDuelLiveSetting()
		{
		}

		public IDuelLiveProductGruopData GetProductGroupData(IProductContext product)
		{
			return null;
		}

		public DuelLiveCategoryData GetCategoryData(int categoryId)
		{
			return null;
		}

		public DuelLiveSubCategoryData GetSubCategoryData(IProductContext product)
		{
			return null;
		}

		public string GetCategoryLabel(int categoryId)
		{
			return null;
		}
	}
}
