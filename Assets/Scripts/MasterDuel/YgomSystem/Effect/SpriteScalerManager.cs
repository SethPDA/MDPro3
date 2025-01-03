using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Effect
{
	public class SpriteScalerManager : MonoBehaviour
	{
		private Vector2 currentScreenSize;

		private static List<SpriteScaler> scalerList;

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

		private void Update()
		{
		}

		public static void Add(SpriteScaler screen)
		{
		}

		public static void Remove(SpriteScaler screen)
		{
		}
	}
}
