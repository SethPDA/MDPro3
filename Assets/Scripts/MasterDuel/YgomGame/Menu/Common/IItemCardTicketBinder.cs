using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemCardTicketBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
