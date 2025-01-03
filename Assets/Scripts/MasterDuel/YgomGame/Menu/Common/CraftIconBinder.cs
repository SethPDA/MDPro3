using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class CraftIconBinder : ResourceBinderBase
	{
		public readonly string[] m_CraftIconPath;

		public CraftIconBinder(string[] craftIconPath)
		{
		}

		public string GetCraftIconPath(int id)
		{
			return null;
		}

		public BindingImageEx BindCraftIcon(Image target, int id, bool async = true)
		{
			return null;
		}
	}
}
