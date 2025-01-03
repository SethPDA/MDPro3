namespace YgomGame.Enquete
{
	public interface ISheetContentContext : IContext
	{
		SheetContentType sheetContentType { get; }

		RootContext rootContext { get; }

		SheetContentGroupContext groupContext { get; set; }

		bool isInput { get; }
	}
}
