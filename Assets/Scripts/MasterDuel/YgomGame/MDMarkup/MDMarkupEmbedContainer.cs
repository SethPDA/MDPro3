using System;
using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupEmbedContainer : IMDMarkupContainer
	{
		public MDMarkupContentEmbedContainerTab embedContent;

		public MDMarkupDef.ContainerType containerType => default(MDMarkupDef.ContainerType);

		public GlobalTextData title => null;

		public List<IMDMarkupContent> contents => null;

		public void Clear()
		{
		}

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJson(string json)
		{
		}

		public void ImportJsonObj(object jsonObj)
		{
		}

		public IReadOnlyList<string> SearchUseTextGruops()
		{
			return null;
		}
	}
}
