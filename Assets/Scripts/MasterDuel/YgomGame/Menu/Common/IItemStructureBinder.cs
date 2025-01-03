using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemStructureBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
