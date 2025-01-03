using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Download
{
	public class DLCList
	{
		[Serializable]
		public struct DLCInfo
		{
			public string assetName;

			public string version;

			public long bytes;

			public string crc;

			public string path => null;
		}

		public const string kFileName = "dlcList.json";

		[SerializeField]
		private List<DLCInfo> informations;

		private static DLCList s_localList;

		public Dictionary<string, DLCInfo> fileDict
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Count => 0;

		private void Initialize()
		{
		}

		private void Clear()
		{
		}

		public List<string> GetAssetNames()
		{
			return null;
		}

		public long GetBytes()
		{
			return 0L;
		}

		public void Set(DLCInfo info)
		{
		}

		public void Remove(DLCInfo info)
		{
		}

		public void Merge(DLCList merge)
		{
		}

		public DLCList GetDiffList(DLCList target, bool versionCheck = true)
		{
			return null;
		}

		private string GetText()
		{
			return null;
		}

		public bool Exists(string path, bool convertHash = true)
		{
			return false;
		}

		private static DLCList GetLocalInstance()
		{
			return null;
		}

		public static bool ExistsLocalData(string path)
		{
			return false;
		}

		public static void ClearLocalInstance()
		{
		}

		public static DLCList Load()
		{
			return null;
		}

		public static DLCList LoadStreaming()
		{
			return null;
		}

		public static DLCList LoadFromJson(string json)
		{
			return null;
		}

		public static void Save(DLCList target)
		{
		}

		public static void Delete()
		{
		}
	}
}
