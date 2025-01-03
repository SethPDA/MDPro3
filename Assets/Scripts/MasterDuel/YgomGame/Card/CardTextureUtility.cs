using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomGame.Card
{
	public static class CardTextureUtility
	{
		public const int DUMMYCARDID = 0;

		private const float FADETIME = 0.1f;

		private static CardIllustManager cardIllustManager;

		private static CardMaterialManager cardMaterialManager;

		private static CardPictureManager cardPictureManager;

		private static CardMaskManager cardMaskManager;

		private static bool initialized;

		public static void Initialize()
		{
		}

		public static void SetCardQuality(CardQuality quality)
		{
		}

		public static void IgnoreCardIllust(bool enable)
		{
		}

		public static void SetCardIllustAsync(this RawImage rawImage, int cardid, UnityAction onFinish = null, bool isAutoRelease = false, bool immediateOnReuse = false)
		{
		}

		public static void SetCardMaterialAsync(this RawImage rawImage, int cardid, int finishid = 1, UnityAction onFinish = null, bool isResetParent = true)
		{
		}

		public static void SetCardPictureAsync(this GameObject gob, List<int> cardidList, List<UnityAction<Texture2D>> onFinishList = null, UnityAction onFinishAll = null)
		{
		}

		public static void SetCardPictureAsync(this GameObject gob, int cardid, UnityAction<Texture2D> onFinish = null)
		{
		}

		public static void SetCardMaterialAsync(this MeshRenderer meshRenderer, int matid, int cardid, int finishid = 1, UnityAction onFinish = null, bool isResetParent = true)
		{
		}

		public static void ClearAllCache()
		{
		}

		public static void ResetAll()
		{
		}

		public static void SetCacheActive(bool enable)
		{
		}

		public static void SetCardIllustAspectRatio(this AspectRatioFitter aspectRatioFitter, int cardid)
		{
		}

		public static bool PreLoadCardPictureAsync(int cardid, bool force = false)
		{
			return false;
		}

		public static void ReleaseCardMaterial(Material mat)
		{
		}

		public static bool IsCardCreating()
		{
			return false;
		}

		private static void AddTweenShaderFloat(GameObject gob)
		{
		}

		public static string GetTextureInfo()
		{
			return null;
		}
	}
}
