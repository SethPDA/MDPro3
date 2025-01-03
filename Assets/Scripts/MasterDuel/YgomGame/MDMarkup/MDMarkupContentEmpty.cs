using System;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentEmpty : MDMarkupContentBase, IMDMarkupContent
	{
		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		protected override object OnExportJsonObj(object jsonObj)
		{
			return null;
		}

		protected override void OnImportJsonObj(object jsonObj)
		{
		}
	}
}
