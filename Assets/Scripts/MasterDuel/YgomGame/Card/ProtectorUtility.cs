using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomGame.Card
{
	public static class ProtectorUtility
	{
		public const int DEFAULTPROTECTORID = 1;

		private const string LABEL_SD_SHOWCARD = "SHOWCARD_ON";

		private const string LABEL_SD_CARDPICTURE = "_CardPicture";

		private const string LABEL_SD_ZWRITE = "_ZWrite";

		private static ProtectorManager protectorManager3D;

		private static ProtectorManager protectorManagerUI;

		public static void Initialize()
		{
		}

		public static void Reset()
		{
		}

		public static void SetProtectorAsync(this RawImage rawImage, int protectorId, UnityAction onFinish = null)
		{
		}

		public static void SetProtectorAsync(this Image image, int protectorId, UnityAction onFinish = null)
		{
		}

		public static void SetProtectorAsync(this MeshRenderer meshRenderer, int matId, int protectorId, UnityAction onFinish = null)
		{
		}

		public static void GetProtectorAsync(int protectorId, UnityAction<Material, int> onFinish = null)
		{
		}

		public static void GetProtectorAsyncUI(int protectorId, UnityAction<Material, int> onFinish = null)
		{
		}

		public static void SetInsight(this RawImage rawImage, bool enable)
		{
		}

		public static void SetInsight(this MeshRenderer meshRenderer, int matId, bool enable)
		{
		}

		private static void SetProtectorForRawImageImpl(RawImage rawImage, Material mat, UnityAction onFinish = null)
		{
		}

		private static void SetProtectorForImageImpl(Image image, Material mat, UnityAction onFinish = null)
		{
		}

		private static void SetProtectorForMeshRendererImpl(MeshRenderer meshRenderer, int matId, Material mat, UnityAction onFinish = null)
		{
		}

		public static string GetName(int sid)
		{
			return null;
		}

		public static string GetShortName(int sid)
		{
			return null;
		}
	}
}
