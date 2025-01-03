using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	public class GamePadIconUtil
	{
		public enum Variation
		{
			Var00 = 0,
			Var01 = 1
		}

		private const string atlasPath = "Images/GamePad/<_PLATFORM_>/ButtonIcon/GamePadAtlasVar{0:00}";

		private const string buttonIconName = "button{0:000}";

		private const string analogIconName = "analog{0:000}";

		private const string mouseIconName = "mouse{0:000}";

		private static Dictionary<Variation, SpriteAtlas> atlases;

		private static Dictionary<int, Sprite> buttonIconSprites;

		private static Dictionary<int, Sprite> analogIconSprites;

		private static Dictionary<int, Sprite> mouseIconSprites;

		public const int extraButtonID_AnyDirectionalKey = 104;

		public static bool isLoaded => false;

		public static void LoadAtlases(bool immediate)
		{
		}

		private static void LoadAtlas(Variation variation, bool immediate, Action<SpriteAtlas> onLoaded)
		{
		}

		private static string GetAtlasPath(Variation variation)
		{
			return null;
		}

		public static Sprite GetButtonIconSprite(int button_id, Variation variation = Variation.Var00)
		{
			return null;
		}

		public static bool GetButtonIconSprite(Action<Sprite> on_load, SelectorManager.KeyType keyType, Variation variation = Variation.Var00)
		{
			return false;
		}

		public static bool GetButtonIconSprite(Action<Sprite> on_load, int button_id, Variation variation = Variation.Var00)
		{
			return false;
		}

		private static string GetButtonIconName(int button_id)
		{
			return null;
		}

		private static string GetMouseIconName(int mouse_button)
		{
			return null;
		}

		private static string GetAnalogIconName(int analog_id)
		{
			return null;
		}

		public static Sprite GetAnalogIconSprite(int analog_id, Variation variation = Variation.Var00)
		{
			return null;
		}

		public static bool GetAnalogIconSprite(Action<Sprite> on_load, SelectorManager.AnalogType analogType, bool isHorizontal, Variation variation = Variation.Var00)
		{
			return false;
		}

		public static bool GetAnalogIconSprite(Action<Sprite> on_load, int analog_id, Variation variation = Variation.Var00)
		{
			return false;
		}

		public static Sprite GetMouseIconSprite(int mouse_button, Variation variation = Variation.Var00)
		{
			return null;
		}

		public static bool GetMouseIconSprite(Action<Sprite> on_load, SelectorManager.MouseType mouseType, Variation variation = Variation.Var00)
		{
			return false;
		}

		public static bool GetMouseIconSprite(Action<Sprite> on_load, int mouse_button, Variation variation = Variation.Var00)
		{
			return false;
		}
	}
}
