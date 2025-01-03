using System;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveCategoryData : DuelLiveProductGroupTreeData<DuelLiveSubCategoryData>
	{
		public override bool IsMatchProduct(IProductContext product)
		{
			return false;
		}

		public DuelLiveCategoryData()
		{
			//((DuelLiveProductGroupTreeData<>)(object)this)._002Ector();
		}
	}
}
