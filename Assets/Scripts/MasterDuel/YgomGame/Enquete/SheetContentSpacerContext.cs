using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public class SheetContentSpacerContext : SheetContentContextBase
	{
		public override SheetContentType sheetContentType => default(SheetContentType);

		public SheetContentSpacerContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentSpacerContext(object jsonData, RootContext rootContext)
			: base(null)
		{
		}

		public override void Import(object jsonData)
		{
		}

		public override void SearchDependencieTextGroups(List<string> resultList)
		{
		}
	}
}
