using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentFullTextPage : MDMarkupContentPageBase, IMDMarkupContentGlobalText
	{
		[SerializeField]
		public GlobalTextData caption;

		[SerializeField]
		public GlobalTextData text;

		[SerializeField]
		public List<URLSchemeButton> buttons;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public virtual IReadOnlyList<string> GetTextGloups()
		{
			return null;
		}

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
