using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class RarityIconBinder : ResourceBinderBase
	{
		public enum Type
		{
			Common = 0,
			Deck = 1
		}

		public readonly string[] rarityLabelCommonFormat;

		public readonly string[] rarityLabelDeckFormat;

		public string GetRarityIconLabel(int id, Type type)
		{
			return null;
		}

		public BindingSpriteContainer BindRarityIcon(Image target, int id, bool async = true, Type type = Type.Common)
		{
			return null;
		}

		public void GetRaritySprite(int id, Type type, Action<Sprite> onFinished)
		{
		}
	}
}
