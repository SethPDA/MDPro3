using System.Collections.Generic;

namespace YgomGame.Mission
{
	public class TabAllContext : TabContext
	{
		public TabAllContext()
			: base(default(MissionTabType), 0, 0L)
		{
		}

		public void ApplyContexts(List<TabContextImportable> tabs)
		{
		}
	}
}
