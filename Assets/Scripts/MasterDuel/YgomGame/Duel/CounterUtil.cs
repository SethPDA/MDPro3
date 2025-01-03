using System.Collections.Generic;
using UnityEngine;
using YgomGame.TextIDs;
using YgomSystem.Utility;

namespace YgomGame.Duel
{
	public class CounterUtil
	{
		private class CounterInfo
		{
			public IDS_COUNTER nameTextID;

			public string iconLabel;

			public CounterInfo(IDS_COUNTER nameTextID, string iconLabel)
			{
			}
		}

		private static SpriteContainer counterIconContainer;

		private static Dictionary<Engine.CounterType, CounterInfo> counterInfoList;

		public static void Initialize(SpriteContainer counterIconContainer)
		{
		}

		public static string GetCounterName(Engine.CounterType type)
		{
			return null;
		}

		public static Sprite GetCounterIcon(Engine.CounterType type)
		{
			return null;
		}

		public static void Terminate()
		{
		}
	}
}
