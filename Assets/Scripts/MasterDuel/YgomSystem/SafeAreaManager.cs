using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem
{
	public class SafeAreaManager : MonoBehaviour
	{
		private static List<SafeAreaScreen> screenList;

		private Rect currentSafeArea;

		public static bool reqUpdate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public static void Add(SafeAreaScreen screen)
		{
		}

		public static void Remove(SafeAreaScreen screen)
		{
		}
	}
}
