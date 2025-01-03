using System;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupPagerContainer : MDMarkupContainerBase
	{
		public bool isLoop;

		[NonSerialized]
		public int startPage;

		public override MDMarkupDef.ContainerType containerType => default(MDMarkupDef.ContainerType);

		public override void Clear()
		{
		}

		public override object ExportJsonObj()
		{
			return null;
		}

		public override void ImportJsonObj(object jsonObj)
		{
		}
	}
}
