using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Menu.Common
{
	public class OutGameBGResourceBinder : ResourceBinderBase
	{
		public readonly string m_FrontBGPath;

		public readonly string m_BackBGPath;

		public const string k_EmptyWallpaperPath = "EmptyWallpaper";

		private OutGameBGManager m_BGManager;

		public OutGameBGResourceBinder(string frontBGPath, string backBGPath)
		{
		}

		public BindingGameObjectEx BindWallpaper(GameObject target, int id, bool async = true, UnityAction<GameObject> onCreated = null)
		{
			return null;
		}

		public string GetFrontBGPath(int id)
		{
			return null;
		}

		public string GetBackBGPath(int id)
		{
			return null;
		}
	}
}
