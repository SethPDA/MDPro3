using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentH1 : MDMarkupContentBase, IMDMarkupContentGlobalText
	{
		[SerializeField]
		public GlobalTextData text;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		public MDMarkupContentH1()
		{
		}

		public MDMarkupContentH1(string rawText)
		{
		}

		public IReadOnlyList<string> GetTextGloups()
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
