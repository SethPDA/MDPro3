using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Enquete
{
	public class SheetContentTextContext : SheetContentContextBase
	{
		public readonly GlobalTextData text;

		public bool isLabel;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public SheetContentTextContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentTextContext(object jsonData, RootContext rootContext)
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
