using System.Collections.Generic;

namespace YgomGame.Common
{
	public abstract class JsonDeckAnalyzerBase
	{
		public int GetAccessoryBox(object deckData)
		{
			return 0;
		}

		public int GetAccessorySleeve(object deckData)
		{
			return 0;
		}

		public object GetFocusCards(object deckData)
		{
			return null;
		}

		public object GetMainCards(object deckData)
		{
			return null;
		}

		public object GetExtraCards(object deckData)
		{
			return null;
		}

		public object GetSideCards(object deckData)
		{
			return null;
		}

		public Dictionary<string, object> GetAccessories(object deckData)
		{
			return null;
		}

		public Dictionary<string, object> GetPickupCards(object deckData)
		{
			return null;
		}
	}
}
