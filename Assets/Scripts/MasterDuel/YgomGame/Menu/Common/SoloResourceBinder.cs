using UnityEngine;
using YgomGame.Solo;

namespace YgomGame.Menu.Common
{
	public class SoloResourceBinder : ResourceBinderBase
	{
		private readonly string m_CardThumbSettingPath;

		private SoloCardThumbSettings m_CardThumbSettings;

		private int m_CardThumbRefCount;

		public SoloResourceBinder(string cardThumbSettingPath)
		{
		}

		public void LoadCardThumbSettings()
		{
		}

		public void UnloadCardThumbSettings()
		{
		}

		public void UnloadForce()
		{
		}

		public string GetSoloCardThumbDataPath()
		{
			return null;
		}

		public int GetSoloMrk(SoloCardThumbSettings.Format format, int id, int defaultValue = 0)
		{
			return 0;
		}

		public bool IsExistSetting(SoloCardThumbSettings.Format format, int id)
		{
			return false;
		}

		public BindingSoloCardThumb BindCardThumb(RectTransform target, int id, SoloCardThumbSettings.Format thumbFormat)
		{
			return null;
		}

		public BindingSoloCardThumb BindCardThumbOther(RectTransform target, int id, SoloCardThumbSettings.Format thumbFormat)
		{
			return null;
		}

		public BindingSoloCardThumb BindCardThumbLootSource(RectTransform target, int id)
		{
			return null;
		}
	}
}
