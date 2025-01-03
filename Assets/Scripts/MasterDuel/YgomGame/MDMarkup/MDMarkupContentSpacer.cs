using System;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentSpacer : MDMarkupContentBase, IMDMarkupPrefabContent
	{
		[SerializeField]
		[MDMarkupIndent]
		public int indent;

		[SerializeField]
		public MDMarkupDef.SpacerSize size;

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
