using UnityEngine;

namespace YgomSystem.Utility
{
	public class TransformRouter : MonoBehaviour
	{
		public Transform routingTarget;

		public bool routingPosX;

		public bool routingPosY;

		public bool routingPosZ;

		public bool routingRotX;

		public bool routingRotY;

		public bool routingRotZ;

		public bool routingScaleX;

		public bool routingScaleY;

		public bool routingScaleZ;

		private void LateUpdate()
		{
		}
	}
}
