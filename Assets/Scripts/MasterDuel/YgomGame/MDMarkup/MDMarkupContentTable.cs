using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentTable : MDMarkupContentBase, IMDMarkupContentGlobalText
	{
		[SerializeField]
		[MDMarkupIndent]
		public int indent;

		[SerializeField]
		public bool ignorePadding;

		[SerializeField]
		private TableSizeSetting setting;

		[SerializeField]
		public List<TableRow> rows;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		public TableSizeSetting sizeSetting => null;

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
