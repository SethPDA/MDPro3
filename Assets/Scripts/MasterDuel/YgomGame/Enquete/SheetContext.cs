using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public class SheetContext : ContextBase
	{
		public readonly List<ISheetContentContext> contents;

		public readonly RootContext rootContext;

		public SheetContext()
		{
		}

		public SheetContext(object jsonData, RootContext rootContext)
		{
		}

		public override void Import(object jsonData)
		{
		}

		public override void SearchDependencieTextGroups(List<string> resultList)
		{
		}

		public bool ContainsMust()
		{
			return false;
		}
	}
}
