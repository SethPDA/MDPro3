using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentText : MDMarkupContentBase, IMDMarkupContentGlobalText
	{
		[SerializeField]
		[MDMarkupIndent]
		public int indent;

		[SerializeField]
		public TextAlignmentOptions alignment;

		[SerializeField]
		public GlobalTextData text;

		[SerializeField]
		public bool ignorePadding;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		public MDMarkupContentText()
		{
		}

		public MDMarkupContentText(string rawText)
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
