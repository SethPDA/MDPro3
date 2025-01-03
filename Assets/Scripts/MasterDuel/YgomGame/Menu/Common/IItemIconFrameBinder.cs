using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemIconFrameBinder
	{
		Component BindItem(GameObject target, int itemID);

		Component BindItemLarge(GameObject target, int itemID);
	}
}
