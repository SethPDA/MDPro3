using UnityEngine;

namespace YgomSystem.UI
{
	public class PlatformPlayerViewIcon : MonoBehaviour
	{
		public enum DispType
		{
			Graphic = 0,
			GameObject = 1
		}

		public DispType dispTarget;

		public bool isReverse;

		protected virtual void Awake()
		{
		}

		public void SetDisp(bool disp)
		{
		}
	}
}
