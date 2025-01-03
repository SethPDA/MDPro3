using UnityEngine;

namespace YgomSystem.UI
{
	public abstract class AbstractInputBlocker : MonoBehaviour
	{
		protected bool blocking;

		protected abstract int blockPriority { get; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
