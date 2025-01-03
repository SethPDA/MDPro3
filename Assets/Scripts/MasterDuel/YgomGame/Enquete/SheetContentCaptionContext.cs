using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Enquete
{
	public class SheetContentCaptionContext : SheetContentContextBase
	{
		public readonly GlobalTextData text;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public SheetContentCaptionContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentCaptionContext(object jsonData, RootContext rootContext)
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
