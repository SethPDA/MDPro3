using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupContainer
	{
		MDMarkupDef.ContainerType containerType { get; }

		GlobalTextData title { get; }

		List<IMDMarkupContent> contents { get; }

		void Clear();

		object ExportJsonObj();

		void ImportJsonObj(object jsonObj);

		void ImportJson(string json);

		IReadOnlyList<string> SearchUseTextGruops();
	}
}
