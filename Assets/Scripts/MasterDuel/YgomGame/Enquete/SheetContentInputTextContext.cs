using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public class SheetContentInputTextContext : SheetContentContextBase
	{
		public override SheetContentType sheetContentType => default(SheetContentType);

		public override bool isInput => false;

		public SheetContentInputTextContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentInputTextContext(object jsonData, RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentInputTextContext Copy()
		{
			return null;
		}

		public override void Import(object jsonData)
		{
		}

		public override void SearchDependencieTextGroups(List<string> resultList)
		{
		}
	}
}
