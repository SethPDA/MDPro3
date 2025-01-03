using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemProfileTagBinder
	{
		Component BindItem(GameObject target, int itemID);

		Component BindItemLarge(GameObject target, int itemID);
	}
}
