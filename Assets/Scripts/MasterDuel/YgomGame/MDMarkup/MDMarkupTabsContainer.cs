using System;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupTabsContainer : MDMarkupContainerBase
	{
		[NonSerialized]
		public int startTab;

		public override MDMarkupDef.ContainerType containerType => default(MDMarkupDef.ContainerType);

		public override object ExportJsonObj()
		{
			return null;
		}

		public override void ImportJsonObj(object jsonObj)
		{
		}
	}
}
