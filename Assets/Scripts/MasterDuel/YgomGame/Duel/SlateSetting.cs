using System;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class SlateSetting : ScriptableObject
	{
		[Serializable]
		public struct FrameColorPalette
		{
			public Content.Frame frame;

			public Color topCol;

			public Color bottomCol;

			public Texture topTex;

			public Texture bottomTex;
		}

		[Serializable]
		public struct AttributeColorPalette
		{
			public Content.Attribute attr;

			public Color color;

			public Texture texture;

			public string text;
		}

		[Serializable]
		public struct MagicIcon
		{
			public Content.Icon icon;

			public Texture texture;
		}

		private static SlateSetting m_Instance;

		private const string PATH = "Duel/ScriptableObject/SlateSetting";

		[SerializeField]
		private FrameColorPalette[] FieldCardframeColor;

		[SerializeField]
		private AttributeColorPalette[] attributeBaseColorPalettes;

		[SerializeField]
		private MagicIcon[] magicIcons;

		[SerializeField]
		private Color levelBaseColor;

		[SerializeField]
		private Color rankBaseColor;

		[SerializeField]
		private Color linkBaseColor;

		[SerializeField]
		private Color fontColorNormal;

		[SerializeField]
		private Color fontColorChanged;

		protected static SlateSetting Instance => null;

		public static Color LevelBaseColor => default(Color);

		public static Color RankBaseColor => default(Color);

		public static Color LinkBaseColor => default(Color);

		public static Color FontColorNormal => default(Color);

		public static Color FontColorChanged => default(Color);

		public static (Color, Color, Texture, Texture) GetFrameColor(Content.Frame frame)
		{
			return default((Color, Color, Texture, Texture));
		}

		public static (Color, Texture, string) GetAttributeBaseColor(Content.Attribute attr)
		{
			return default((Color, Texture, string));
		}

		public static Texture GetIconTexture(Content.Icon icon)
		{
			return null;
		}
	}
}
