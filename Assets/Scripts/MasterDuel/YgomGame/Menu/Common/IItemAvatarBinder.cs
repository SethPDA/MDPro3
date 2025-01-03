using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemAvatarBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
