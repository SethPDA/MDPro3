using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class CardPackResourceBinder : ResourceBinderBase, IItemCardTicketBinder
	{
		public readonly string m_PackTicketPath;

		public readonly string m_PackTexPath;

		public CardPackResourceBinder(string packTicket, string packTexPath)
		{
		}

		public string GetPackTicketPath(int itemId = 0)
		{
			return null;
		}

		public BindingImageEx BindPackTicket(Image target, int packTicketId = 0, bool async = true)
		{
			return null;
		}

		public string GetPackTexPath(string packImageName)
		{
			return null;
		}

		public BindingImageEx BindCardPackImage(Image target, string packImageName, bool async = true)
		{
			return null;
		}

		public Component BindItem(GameObject target, int itemID)
		{
			return null;
		}
	}
}
