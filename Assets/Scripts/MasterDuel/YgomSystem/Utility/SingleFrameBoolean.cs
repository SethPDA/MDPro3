using UnityEngine;

namespace YgomSystem.Utility
{
	public class SingleFrameBoolean : MonoBehaviour
	{
		private bool m_DefaultVal;

		private bool m_CurrentVal;

		public bool frameValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static SingleFrameBoolean Create(GameObject owner, bool defaultVal = false)
		{
			return null;
		}

		private void LateUpdate()
		{
		}
	}
}
