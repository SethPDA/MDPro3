using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class RegulationIconBinder : ResourceBinderBase
	{
		private const string rarityLabelCommonFormat = "Limit{0}";

		public string GetRegulationIconLabel(CardCollectionInfo.Regulation reg)
		{
			return null;
		}

		public BindingSpriteContainer BindRegulationIcon(Image target, CardCollectionInfo.Regulation reg, bool async = true)
		{
			return null;
		}
	}
}
