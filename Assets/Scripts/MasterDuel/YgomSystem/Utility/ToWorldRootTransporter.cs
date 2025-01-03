using UnityEngine;

namespace YgomSystem.Utility
{
	public class ToWorldRootTransporter : MonoBehaviour
	{
		[SerializeField]
		private Transform m_Target;

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
