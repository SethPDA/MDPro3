using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Notification
{
	[Serializable]
	//[CreateAssetMenu]
	public class TopicsCardUVSetting : ScriptableObject
	{
		[Serializable]
		public class ThumbSetting
		{
			public int mrk;

			public Vector2 uvRectPos;

			public Vector2 uvRectSize;

			public ThumbSetting(int mrk)
			{
			}

			public void ImportRawImage(RawImage rawImage)
			{
			}

			public void ExportRawImage(RawImage rawImage)
			{
			}
		}

		[Serializable]
		public class SettingMap
		{
			[SerializeField]
			private List<ThumbSetting> m_Settings;

			private Dictionary<int, ThumbSetting> m_SettingsMap;

			public List<ThumbSetting> Settings
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			public ThumbSetting GetSetting(int mrk)
			{
				return null;
			}

			public bool IsExists(int mrk)
			{
				return false;
			}

			public void Import(int mrk, RawImage rawImage)
			{
			}

			public void Import(int mrk)
			{
			}

			public void Remove(int mrk)
			{
			}
		}

		[SerializeField]
		private SettingMap m_BannerMap;

		public SettingMap BannerMap => null;

		public ThumbSetting GetSetting(int mrk)
		{
			return null;
		}

		public bool IsExitsSetting(int mrk)
		{
			return false;
		}

		public void ImportData(int mrk, RawImage rawImage)
		{
		}

		public void ImportData(int mrk)
		{
		}

		public void RemoveData(int mrk)
		{
		}
	}
}
