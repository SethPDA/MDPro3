using UnityEngine;

namespace YgomSystem.Home
{
	public abstract class ActiveFalseTarget<T> : MonoBehaviour where T : MonoBehaviour
	{
		[SerializeField]
		private GameObject targetGameObject;

		protected T component;

		private void OnEnable()
		{
		}

		protected abstract bool IsActive();
	}
}
