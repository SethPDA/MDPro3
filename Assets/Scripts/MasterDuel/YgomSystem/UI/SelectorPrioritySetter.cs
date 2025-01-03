using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectorPrioritySetter : MonoBehaviour
	{
		public enum SetMode
		{
			FromSelector = 0
		}

		[SerializeField]
		private SetMode m_SetMode;

		[SerializeField]
		private Selector m_FromSelector;

		private void Start()
		{
		}
	}
}
