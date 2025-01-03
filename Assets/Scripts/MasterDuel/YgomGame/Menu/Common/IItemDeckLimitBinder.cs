using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemDeckLimitBinder
	{
		Component BindItem(GameObject target, int itemID);

		Component BindItemLarge(GameObject target, int itemID);
	}
}
