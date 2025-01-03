using System.Runtime.CompilerServices;

namespace YgomGame.Enquete
{
	public abstract class SheetContentContextBase : ContextBase, ISheetContentContext, IContext
	{
		public readonly RootContext m_RootContext;

		public abstract SheetContentType sheetContentType { get; }

		public RootContext rootContext => null;

		public SheetContentGroupContext groupContext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual bool isInput => false;

		public SheetContentContextBase(RootContext rootContext)
		{
		}

		public SheetContentContextBase(object jsonData, RootContext rootContext)
		{
		}

		public static ISheetContentContext CreateByJsonData(object jsonData, RootContext rootContext)
		{
			return null;
		}
	}
}
