using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame
{
	public class ResidentCreator : MonoBehaviour
	{
		private const string DownloadDataRevision = "dl_rev";

		private const string DownloadListIndex = "dllstidx";

		public static readonly string ResidentTag;

		private static readonly Type[] ResidentGroups;

		public static bool isReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void AddObject(GameObject parent, string objectName, Type type)
		{
		}
	}
}
