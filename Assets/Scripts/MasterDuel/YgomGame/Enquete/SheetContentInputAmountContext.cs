using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Enquete
{
	public class SheetContentInputAmountContext : SheetContentContextBase
	{
		public readonly GlobalTextData minText;

		public readonly GlobalTextData maxText;

		public int amountLength;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public override bool isInput => false;

		public SheetContentInputAmountContext(object jsonData, RootContext rootContext)
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
