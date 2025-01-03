using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	public class MDMarkupPrefabsFactory : MDMarkupWidgetFactoryBase
	{
		private readonly Dictionary<string, GameObject> m_TemplateMap;

		public IReadOnlyDictionary<string, GameObject> templateMap => null;

		public MDMarkupPrefabsFactory(Dictionary<string, GameObject> templateMap)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
