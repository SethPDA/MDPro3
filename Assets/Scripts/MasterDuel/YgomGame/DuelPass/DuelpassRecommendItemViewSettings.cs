using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duelpass
{
	//[CreateAssetMenu]
	public class DuelpassRecommendItemViewSettings : ScriptableObject
	{
		public const string path = "Definition/Duelpass/DuelpassRecommendItemViewSettings";

		[SerializeField]
		public List<ItemViewSetting> settings;

		public static void LoadAsync(Action<DuelpassRecommendItemViewSettings> onFinished)
		{
		}
	}
}
