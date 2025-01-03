using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentSeparator : MDMarkupContentBase, IMDMarkupPrefabContent
	{
		public const string k_PrefKey = "separator";

		[SerializeField]
		[MDMarkupIndent]
		public int indent;

		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}

		public string GetPrefabLabel()
		{
			return null;
		}
	}
}
