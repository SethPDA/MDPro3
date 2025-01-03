using System;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class RegulationLogoResourceBinder : ResourceBinderBase
	{
		[Serializable]
		public class RegulationLogoPathData
		{
			public string m_RegulationLogoPath;
		}

		private RegulationLogoPathData m_PathData;

		public void Initialize(RegulationLogoPathData pathData)
		{
		}

		public string GetLogoPath(int id)
		{
			return null;
		}

		public BindingImageEx BindEventLogo(Image target, int id, bool async = true)
		{
			return null;
		}
	}
}
