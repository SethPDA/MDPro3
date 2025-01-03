using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Shop
{
	//[CreateAssetMenu]
	public class ShopCardThumbSettings : ScriptableObject
	{
		[Serializable]
		public class ThumbSetting : IRawImageUVSetting
		{
			public int mrk;

			public Vector2 uvRectPos;

			public Vector2 uvRectSize;

			[NonSerialized]
			public float aspectRatio;

			public ThumbSetting(int mrk)
			{
			}

			public ThumbSetting(int mrk, ThumbSetting source)
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
		private class SettingMap
		{
			[SerializeField]
			private List<ThumbSetting> m_Settings;

			private Dictionary<int, ThumbSetting> m_SettingsMap;

			[SerializeField]
			private ThumbSetting m_DefaultSetting;

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
		}

		[Serializable]
		public class ImageThumbSetting : IRawImageUVSetting
		{
			public string path;

			public Vector2 uvRectPos;

			public Vector2 uvRectSize;

			[NonSerialized]
			public float aspectRatio;

			public ImageThumbSetting(string path)
			{
			}

			public ImageThumbSetting(string path, ImageThumbSetting source)
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
		private class ImageThumbSettingMap
		{
			[SerializeField]
			private List<ImageThumbSetting> m_Settings;

			private Dictionary<string, ImageThumbSetting> m_SettingsMap;

			[SerializeField]
			private ImageThumbSetting m_DefaultSetting;

			public ImageThumbSetting GetSetting(string path)
			{
				return null;
			}

			public bool IsExists(string path)
			{
				return false;
			}

			public void Import(string path, RawImage rawImage)
			{
			}
		}

		public enum Format
		{
			None = -1,
			SmallPack = 0,
			Large = 1,
			PickThumb = 2,
			PickWideTrimThumb = 3,
			Additional_1 = 10,
			Additional_2 = 11,
			Additional_3 = 12
		}

		private const string k_SettingPath = "Definition/Shop/CardThumbSettings";

		[SerializeField]
		private float m_LargeAspect;

		[SerializeField]
		private float m_SmallAspect;

		[SerializeField]
		private SettingMap m_LargeMap;

		[SerializeField]
		private SettingMap m_SmallPackMap;

		[SerializeField]
		private SettingMap m_PickMap;

		[SerializeField]
		private SettingMap m_PickWideTrimMap;

		[SerializeField]
		private SettingMap m_Additional_1_Map;

		[SerializeField]
		private SettingMap m_Additional_2_Map;

		[SerializeField]
		private SettingMap m_Additional_3_Map;

		[SerializeField]
		private ImageThumbSettingMap m_LargeImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_SmallImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_PickImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_PickWideTrimImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_Additional_1_ImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_Additional_2_ImageMap;

		[SerializeField]
		private ImageThumbSettingMap m_Additional_3_ImageMap;

		[SerializeField]
		private ThumbSetting m_NoneSetting;

		[SerializeField]
		private ImageThumbSetting m_NoneImageSetting;

		public ThumbSetting GetSetting(Format format, int mrk)
		{
			return null;
		}

		public ImageThumbSetting GetImageSetting(Format format, string path)
		{
			return null;
		}

		public bool IsExitsSetting(Format format, int mrk, string path = null)
		{
			return false;
		}

		public bool IsExitsImageSetting(Format format, string path)
		{
			return false;
		}

		public bool HasAspectRatioSetting(Format format)
		{
			return false;
		}

		public void ImportData(Format format, int mrk, RawImage rawImage)
		{
		}

		public void ImportImageData(Format format, string path, RawImage rawImage)
		{
		}

		public void ImportAspectRatio(Format format, RectTransform rectTransform)
		{
		}
	}
}
