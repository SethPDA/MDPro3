using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public class SheetContentInputTextConfirmContext : SheetContentContextBase
	{
		public string text;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public SheetContentInputTextConfirmContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentInputTextConfirmContext(object jsonData, RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentInputTextConfirmContext Copy()
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
