using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Enquete
{
	public class SheetContentInputCheckBoxContext : SheetContentContextBase
	{
		public class ContentContext : ContextBase
		{
			public readonly GlobalTextData text;

			public ContentContext()
			{
			}

			public ContentContext(object jsonData)
			{
			}

			public override void Import(object jsonData)
			{
			}

			public override void SearchDependencieTextGroups(List<string> resultList)
			{
			}
		}

		public readonly List<ContentContext> contents;

		public int min;

		public int max;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public override bool isInput => false;

		public SheetContentInputCheckBoxContext(object jsonData, RootContext rootContext)
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
