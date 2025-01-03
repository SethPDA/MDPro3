using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.ResourceSystem
{
	public class DependenciesList
	{
		[Serializable]
		public class DependenciesInfo
		{
			public string assetName;

			public string[] dependencies;
		}

		private const string kManifestFileName = "manifest";

		[SerializeField]
		private List<DependenciesInfo> informations;

		private Dictionary<string, DependenciesInfo> dictionary;

		public static string GetFileNameForCommon()
		{
			return null;
		}

		public static string GetFileNameForLanguage()
		{
			return null;
		}

		public static string GetFileNameForCardIllust()
		{
			return null;
		}

		public static string GetFileNameForStreamingData()
		{
			return null;
		}

		public static string GetFileName(string lang)
		{
			return null;
		}

		public static DependenciesList Load()
		{
			return null;
		}

		private static DependenciesList LoadBaseData()
		{
			return null;
		}

		private static DependenciesList LoadLanguageData()
		{
			return null;
		}

		private static DependenciesList LoadCardIllustData()
		{
			return null;
		}

		public static DependenciesList LoadStreaming()
		{
			return null;
		}

		private static DependenciesList LoadStreamingBaseData()
		{
			return null;
		}

		private static DependenciesList LoadStreamingCommonData()
		{
			return null;
		}

		private static DependenciesList LoadStreamingLangData()
		{
			return null;
		}

		private static DependenciesList LoadStreamingCardIllustData()
		{
			return null;
		}

		private static DependenciesList EncryptFromBytes(byte[] bytes)
		{
			return null;
		}

		public void Initialize()
		{
		}

		public string[] GetDependencies(string assetName)
		{
			return null;
		}

		public bool Exist(string assetName)
		{
			return false;
		}

		public void Merge(DependenciesList target)
		{
		}

		public void Clear()
		{
		}
	}
}
