using System;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Colosseum;

namespace YgomGame.Menu.Common
{
	public class EventLogoResourceBinder : ResourceBinderBase
	{
		[Serializable]
		public class EventLogoPathData
		{
			public ResourceBindingPathSetting.ItemPathData m_EventLogoPath;

			public string m_EventDeckSelectBGPath;

			public string m_EventBGPath;

			public string m_DCBGPath;

			public string m_DCDeckSelectBGPath;

			public string k_EventLogoMonsterPrefabPath;
		}

		private EventLogoPathData m_PathData;

		public void Initialize(EventLogoPathData pathData)
		{
		}

		public string GetLogoPath(int id, bool isLarge)
		{
			return null;
		}

		public BindingEventLogo BindEventLogo(Image target, int id, bool isLarge = false)
		{
			return null;
		}

		public BindingEventLogo BindEventLogo(GameObject target, object json)
		{
			return null;
		}

		public BindingEventLogo BindEventLogo(GameObject target, BindingEventLogo.Context context)
		{
			return null;
		}

		public string GetLogoBGPath(int id)
		{
			return null;
		}

		public BindingImageEx BindEventLogoBG(Image target, int id, bool async = true)
		{
			return null;
		}

		public BindingImageEx BindEventLogoBG(Image target, string path, bool async = true)
		{
			return null;
		}

		public string GetBGPath(int id, int stage)
		{
			return null;
		}

		public BindingImageEx BindEventBG(Image target, int id, int stage = 0, bool async = true)
		{
			return null;
		}

		public string GetTemplateBGPath(int id, int stage)
		{
			return null;
		}

		public BindingImageEx BindEventTemplateBG(Image target, int id, int stage = 0, bool async = true)
		{
			return null;
		}

		public string GetEventLogoMonsterPrefabPath()
		{
			return null;
		}
	}
}
