using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Card;
using YgomSystem;

namespace YgomGame
{
	//[CreateAssetMenu]
	public class CardPictureSetting : ScriptableObject
	{
		[Serializable]
		public struct FrameSprite
		{
			public Content.Frame frame;

			public Sprite sprite;
		}

		[Serializable]
		public struct FrameCardNameColor
		{
			public Content.Frame frame;

			[SerializeField]
			public Color color;
		}

		private static CardPictureSetting m_Instance;

		private const string PATH = "Card/ScriptableObjects/CardPictureSetting";

		[SerializeField]
		private Material m_MatNromalStyle;

		[SerializeField]
		private Material m_MatShineStyle;

		[SerializeField]
		private Material m_MatRoyalStyle;

		[SerializeField]
		private Texture m_FrameMask;

		[SerializeField]
		private Texture m_FrameMaskForPendulum;

		[SerializeField]
		private Texture m_FrameMaskForLink;

		[SerializeField]
		private Texture m_KiraMask;

		[SerializeField]
		private Texture m_KiraMaskForPendulum;

		[SerializeField]
		private Texture m_KiraMaskForLink;

		[SerializeField]
		private Texture m_NormalMask;

		[SerializeField]
		private Texture m_NormalMaskForPendulum;

		[SerializeField]
		private Texture m_NormalMaskForLink;

		[SerializeField]
		private FrameSprite[] m_FrameSpriteTable;

		[SerializeField]
		private FrameSprite[] m_LoadingSpriteTable;

		[SerializeField]
		private FrameCardNameColor[] m_FrameCardNameColorTableForShineFinish;

		[SerializeField]
		private Sprite[] m_LinkNumTexSet;

		private Dictionary<RubyRoot.Lang, TMP_FontAsset> m_FontAssetTable;

		protected static CardPictureSetting Instance => null;

		public static Texture FrameMask => null;

		public static Texture FrameMaskForPendulum => null;

		public static Texture FrameMaskForLink => null;

		public static Texture KiraMask => null;

		public static Texture KiraMaskForPendulum => null;

		public static Texture KiraMaskForLink => null;

		public static Texture NormalMask => null;

		public static Texture NormalMaskForPendulum => null;

		public static Texture NormalMaskForLink => null;

		public static Material GetCardMaterial(CardFinishSetting.FinishType finishType)
		{
			return null;
		}

		public static Sprite GetCardFrame(Content.Frame frame)
		{
			return null;
		}

		public static Sprite GetLoadingTex(Content.Frame frame)
		{
			return null;
		}

		public static Sprite GetLinkNumTex(int linknum)
		{
			return null;
		}

		public static Color GetCardNameColorForShineFinish(Content.Frame frame)
		{
			return default(Color);
		}

		public static TMP_FontAsset GetFontAsset(RubyRoot.Lang lang)
		{
			return null;
		}
	}
}
