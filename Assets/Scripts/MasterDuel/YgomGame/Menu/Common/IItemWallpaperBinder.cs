using UnityEngine;

namespace YgomGame.Menu.Common
{
	public interface IItemWallpaperBinder
	{
		Component BindItem(GameObject target, int itemID);
	}
}
