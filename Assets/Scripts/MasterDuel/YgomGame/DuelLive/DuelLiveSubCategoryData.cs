using System;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveSubCategoryData : DuelLiveProductGroupData
	{
		public override bool IsMatchProduct(IProductContext product)
		{
			return false;
		}
	}
}
