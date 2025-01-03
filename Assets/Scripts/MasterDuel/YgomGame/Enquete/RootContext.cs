using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Enquete
{
	public class RootContext : ContextBase
	{
		public readonly GlobalTextData title;

		public readonly List<SheetContext> sheets;

		public bool isGuideMust;

		public override void Import(object jsonData)
		{
		}

		public override void SearchDependencieTextGroups(List<string> resultList)
		{
		}
	}
}
