using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemFieldBinder
	{
		Component BindItem(GameObject target, int itemID);

		Component BindItemLarge(GameObject target, int itemID);
	}
}
