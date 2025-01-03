using System;
using System.Collections.Generic;
using YgomSystem.Utility;

namespace YgomSystem
{
	[Serializable]
	public class SelectEnvSetting
	{
		public string title;

		public List<RuntimeEnvironment.ServerType> envList;
	}
}
