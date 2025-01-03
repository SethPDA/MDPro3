using YgomGame.Card;

namespace YgomGame.Common
{
	public class JsonPackDrawAnalyzer : JsonObjectAanalyzerBase
	{
		public int GetMrk(object drawData)
		{
			return 0;
		}

		public int GetPremium(object drawData)
		{
			return 0;
		}

		public bool IsNew(object drawData)
		{
			return false;
		}

		public CardCollectionInfo.Rarity BackSideRarity(object drawData)
		{
			return default(CardCollectionInfo.Rarity);
		}

		public int[] GetFoundedSecrets(object drawData)
		{
			return null;
		}

		public bool IsFoundedSecrets(object drawData)
		{
			return false;
		}

		public int[] GetExtendedSecrets(object drawData)
		{
			return null;
		}

		public bool IsExtendedSecrets(object drawData)
		{
			return false;
		}
	}
}
