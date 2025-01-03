using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectionTransitionReciever : MonoBehaviour
	{
		public List<SelectionItem> m_ThrowTargets;

		private SelectionItem m_RecieverCache;

		public SelectionItem recieverItem => null;

		private void OnEnable()
		{
		}

		public bool ThrowToNearTarget()
		{
			return false;
		}

		private void OnSelected()
		{
		}
	}
}
