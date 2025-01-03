using UnityEngine;

namespace YgomSystem.UI
{
	public class OutGameBGSetter : MonoBehaviour
	{
		public const string k_EmptyWallpaperPath = "EmptyWallpaper";

		[SerializeField]
		private string m_PrefBackPath;

		private bool isSet;

		public float duration;

		public bool async;

		public string prefBackPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public void SetBG()
		{
		}

		public void ResetBG()
		{
		}
	}
}
