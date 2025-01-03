using System;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentH2 : MDMarkupContentH1
	{
		public override MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public override int contentIndent => 0;

		public MDMarkupContentH2()
		{
		}

		public MDMarkupContentH2(string rawText)
		{
		}
	}
}
