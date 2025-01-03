using System.Collections.Generic;

namespace YgomSystem.Utility
{
	public class MockSettingLoader
	{
		private MockSetting setting;

		private Dictionary<string, Mock> mocks;

		public static MockSettingLoader load(SelectEnvSetting envSetting = null)
		{
			return null;
		}

		private MockSettingLoader(MockSetting setting)
		{
		}

		public (bool, string) getBtnAttr(RuntimeEnvironment.ServerType serverType)
		{
			return default((bool, string));
		}

		public (string, string) getUrl(RuntimeEnvironment.ServerType serverType)
		{
			return default((string, string));
		}
	}
}
