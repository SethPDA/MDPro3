using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card
{
	public class ProtectorManager
	{
		private const string PATH_PROTECORFOLD = "Protector/<_CARD_ILLUST_>";

		private Dictionary<string, Material> m_PidMatTable;

		private Dictionary<string, Queue<UnityAction<Material, int>>> m_PidTaskTable;

		private bool m_ForUI;

		public static ProtectorManager Create(bool isforui)
		{
			return null;
		}

		public void GetProtectorMatAsync(int protectorId, UnityAction<Material, int> action)
		{
		}

		public void ResetTable()
		{
		}

		private void Initialize(bool isforui)
		{
		}

		private int CheckProtectorId(int protectorId)
		{
			return 0;
		}

		private string GetProtectorPath(int protectorId)
		{
			return null;
		}
	}
}
