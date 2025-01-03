using UnityEngine;

namespace YgomSystem.UI
{
	public class BindingMaterial : MonoBehaviour
	{
		[SerializeField]
		private string materialPath;

		[HideInInspector]
		public bool IsDone;

		[SerializeField]
		private bool immediate;

		[SerializeField]
		private bool StartOnAwake;

		private void Awake()
		{
		}

		public void LoadMaterial()
		{
		}
	}
}
