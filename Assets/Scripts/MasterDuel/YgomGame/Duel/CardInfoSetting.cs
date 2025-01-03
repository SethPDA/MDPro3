using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Settings;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class CardInfoSetting : ScriptableObject
	{
		[Serializable]
		private struct SettingData
		{
			public int FontSize_S;

			public int FontSize_M;

			public int FontSize_L;

			public int FontSizeMobile_S;

			public int FontSizeMobile_M;

			public int FontSizeMobile_L;

			public float LineSpacing;

			public float ParagraphSpace;
		}

		private enum LanguageScope
		{
			Generic = 0,
			Japanese = 1,
			English = 2,
			French = 3,
			German = 4,
			Spanish = 5,
			Portuguese = 6,
			Korean = 7,
			Italian = 8,
			SCH = 9,
			TCH = 10
		}

		[Serializable]
		private struct SettingDataStringPair
		{
			public LanguageScope language;

			public SettingData setting;
		}

		[Serializable]
		public struct FrameColorPalette
		{
			public Content.Frame frame;

			public Color BgColor0;

			public Color BgColor1;
		}

		private static CardInfoSetting m_Instance;

		private const string PATH = "Duel/ScriptableObject/CardInfoSetting";

		[SerializeField]
		private SettingDataStringPair[] m_SettingDataTable;

		private SettingData m_CurrentSettingData;

		private Dictionary<string, LanguageScope> m_LanguageScopeTable;

		private Dictionary<LanguageScope, SettingData> m_LanguageSettingTable;

		[SerializeField]
		public FrameColorPalette[] m_CardInfoframeColor;

		[SerializeField]
		public Color m_FontColorNormal;

		[SerializeField]
		public Color m_FontColorChanged;

		[SerializeField]
		public Material m_FrameMaterialSrc;

		protected static CardInfoSetting Instance => null;

		public static int FontSize_S => 0;

		public static int FontSize_M => 0;

		public static int FontSize_L => 0;

		public static float ParaGraphSpace => 0f;

		public static float LineSpace => 0f;

		public static void SetFrameColor(Material mat, Content.Frame frame)
		{
		}

		public static Material GetFrameMaterial()
		{
			return null;
		}

		public static Color GetFontColor(bool changed)
		{
			return default(Color);
		}

		public static int GetFontSize(SettingsUtil.BasicParam.CARD_TEXT_SIZE size)
		{
			return 0;
		}

		public static void ResetLanguage()
		{
		}

		private void Initializer()
		{
		}

		public void SetFrameColorImpl(Material mat, Content.Frame frame)
		{
		}

		public Material GetFrameMaterialImpl()
		{
			return null;
		}

		public Color GetFontColorImpl(bool changed)
		{
			return default(Color);
		}

		public int GetFontSizeImpl(SettingsUtil.BasicParam.CARD_TEXT_SIZE size)
		{
			return 0;
		}
	}
}
