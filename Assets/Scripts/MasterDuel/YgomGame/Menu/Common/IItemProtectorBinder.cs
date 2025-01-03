using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemProtectorBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
