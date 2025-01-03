using System.Collections.Generic;

namespace YgomGame.Common
{
	public class JsonStructureFirstAnalyzer : JsonObjectAanalyzerBase
	{
		public bool IsReceivable(object structureFirstData)
		{
			return false;
		}

		public IReadOnlyList<object> GetSelectIds(object structureFirstData)
		{
			return null;
		}
	}
}
