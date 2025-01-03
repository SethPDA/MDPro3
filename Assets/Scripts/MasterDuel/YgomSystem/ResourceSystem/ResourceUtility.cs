using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.ResourceSystem
{
	public static class ResourceUtility
	{
		public const string kUniversalLangPath = "Universal";

		private const string kConvertLangPath = "#";

		private const string kConvertPlatformPath = "<_PLATFORM_>";

		public const string kCommonResourceTypePath = "SD";

		private const string kConvertResourceTypePath = "<_RESOURCE_TYPE_>";

		private const string kConvertCardIllustType = "<_CARD_ILLUST_>";

		private static readonly byte[] CompressedFileHeader;

		public static readonly byte[] AssetBundleHeader;

		private static readonly byte[] PNGFileHeader;

		public static bool isAssetBundleFile(string path, bool isStreamingAssets = false)
		{
			return false;
		}

		public static bool isAssetBundleFile(byte[] data)
		{
			return false;
		}

		public static bool IsPNGFile(byte[] data)
		{
			return false;
		}

		private static void descramble(byte[] src, int ofs, byte[] dst)
		{
		}

		private static bool checkCompressed(byte[] data)
		{
			return false;
		}

		public static byte[] decompressedData(byte[] data)
		{
			return null;
		}

		public static byte[] decompressedData(TextAsset textasset)
		{
			return null;
		}

		public static bool compareHeader(byte[] a, byte[] b, int length)
		{
			return false;
		}

		public static bool ExistsDownloadFile(string path)
		{
			return false;
		}

		public static void UnloadResource(Resource res)
		{
		}

		private static void UnloadAsset(Object obj)
		{
		}

		public static uint GetCrc(string path)
		{
			return 0u;
		}

		public static bool ContainConvertPath(string path)
		{
			return false;
		}

		public static bool ContainLangPath(string path)
		{
			return false;
		}

		public static bool ContainPlatformPath(string path)
		{
			return false;
		}

		public static bool ContainResourceTypePath(string path)
		{
			return false;
		}

		public static bool ContainCardIllustTypePath(string path)
		{
			return false;
		}

		public static string RemoveAutoConvertPath(string path)
		{
			return null;
		}

		public static List<string> GetAllConvertAutoPathList(string path)
		{
			return null;
		}

		public static string ConvertAutoPath(string path)
		{
			return null;
		}

		public static bool IsDataDivideByLang()
		{
			return false;
		}

		private static string GetPlatformDirectory()
		{
			return null;
		}

		private static string GetResourceTypeDirectory()
		{
			return null;
		}

		private static string GetPlatformTypeDirectory()
		{
			return null;
		}
	}
}
