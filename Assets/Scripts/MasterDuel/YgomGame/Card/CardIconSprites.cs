using System;
using UnityEngine;

namespace YgomGame.Card
{
	public class CardIconSprites : ScriptableObject
	{
		[Serializable]
		public class AttributeIconTable
		{
			public Content.Attribute attr;

			public Sprite icon;
		}

		[Serializable]
		public class SpellTrapIconTable
		{
			public Content.Icon type;

			public Sprite icon;
		}

		[Serializable]
		public class TypeIconTable
		{
			public Content.Type type;

			public Sprite icon;
		}

		[SerializeField]
		private AttributeIconTable[] attrIcons;

		[SerializeField]
		private SpellTrapIconTable[] spelltrapIcons;

		[SerializeField]
		private TypeIconTable[] typeIcons;

		private static CardIconSprites _instance;

		private const string path = "Card/ScriptableObjects/CardIconSprites";

		public static CardIconSprites instance => null;

		public Sprite GetAttributeIcon(Content.Attribute attr)
		{
			return null;
		}

		public Sprite GetSpellTrapIcon(Content.Icon type)
		{
			return null;
		}

		public Sprite GetTypeIcon(Content.Type type)
		{
			return null;
		}

		public static void Load(Action onLoaded)
		{
		}
	}
}
