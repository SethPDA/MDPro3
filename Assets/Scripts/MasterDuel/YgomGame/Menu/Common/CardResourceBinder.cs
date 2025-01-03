using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class CardResourceBinder : ResourceBinderBase//, IItemCardBinder, IItemProtectorBinder
	{
		public BindingProtectorMaterial BindProtectorIcon(RawImage target, int itemId, float scale = 0.8f)
		{
			return null;
		}

		public BindingCardMaterial BindCardImage(RawImage target, int mrk, int prare = 1, bool async = true)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemCardBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemProtectorBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}
	}
}
