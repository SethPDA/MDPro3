using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Solo
{
	//[CreateAssetMenu]
	public class SoloCardThumbSettings : ScriptableObject
	{
		[Serializable]
		public class ThumbSetting
		{
			public int id;

			public int mrk;

			public Vector2 uvRectPos;

			public Vector2 uvRectSize;

			public Vector2 uvRectPosOther;

			public Vector2 uvRectSizeOther;

			public ThumbSetting(int id)
			{
			}

			public void ImportRawImage(RawImage rawImage)
			{
			}

			public void ImportRawImageOther(RawImage rawImage)
			{
			}

			public void ExportRawImage(RawImage rawImage)
			{
			}

			public void ExportRawImageOther(RawImage rawImage)
			{
			}
		}

		[Serializable]
		private class SettingMap
		{
			[SerializeField]
			private List<ThumbSetting> m_Settings;

			private Dictionary<int, ThumbSetting> m_SettingsMap;

			public ThumbSetting GetSetting(int id)
			{
				return null;
			}

			public bool IsExists(int id)
			{
				return false;
			}

			public void Import(int id, int mrk, RawImage rawImage, RawImage rawImageOther)
			{
			}

			public void RemoveData(int id)
			{
			}
		}

		public enum Format
		{
			Gate = 0,
			Chapter = 1,
			LootSource = 2
		}

		[SerializeField]
		private SettingMap m_GateMap;

		[SerializeField]
		private SettingMap m_ChapterMap;

		[SerializeField]
		private SettingMap m_LootSourceMap;

		public ThumbSetting GetSetting(Format format, int id)
		{
			return null;
		}

		public bool IsExitsSetting(Format format, int id)
		{
			return false;
		}

		public void ImportData(Format format, int id, int mrk, RawImage rawImage, RawImage rawImageOther)
		{
		}

		public void RemoveData(Format format, int id)
		{
		}
	}
}
