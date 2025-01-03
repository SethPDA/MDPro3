using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemCardBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
