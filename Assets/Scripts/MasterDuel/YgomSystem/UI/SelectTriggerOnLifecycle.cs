using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectTriggerOnLifecycle : MonoBehaviour
	{
		[SerializeField]
		private SelectionItem m_SelectedCheckItem;

		[SerializeField]
		private List<SelectionItem> m_OnEnableTargets;

		[SerializeField]
		private List<SelectionItem> m_OnDisableTargets;

		public SelectionItem selectedCheckItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SelectionItem> onEnableTargets => null;

		public List<SelectionItem> onDisableTargets => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
