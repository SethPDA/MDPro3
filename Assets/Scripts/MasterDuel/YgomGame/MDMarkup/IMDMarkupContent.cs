namespace YgomGame.MDMarkup
{
	public interface IMDMarkupContent
	{
		MDMarkupDef.MarkupType markupType { get; }

		int contentIndent { get; }

		string ToJson();

		object ExportJsonObj();

		void ImportJsonObj(object jsonObj);
	}
}
