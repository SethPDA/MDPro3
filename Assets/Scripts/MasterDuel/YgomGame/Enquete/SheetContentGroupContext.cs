using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Enquete
{
	public class SheetContentGroupContext : SheetContentContextBase
	{
		public readonly List<ISheetContentContext> contents;

		public override SheetContentType sheetContentType => default(SheetContentType);

		public bool isMust
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override bool isInput => false;

		public SheetContentGroupContext(RootContext rootContext)
			: base(null)
		{
		}

		public SheetContentGroupContext(object jsonData, RootContext rootContext)
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
