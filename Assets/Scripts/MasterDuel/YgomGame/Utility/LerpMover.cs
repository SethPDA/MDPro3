using UnityEngine;

namespace YgomGame.Utility
{
	public class LerpMover : MonoBehaviour
	{
		[SerializeField]
		private float lerpTime;

		private Vector3 preParentPosition;

		private Quaternion preParentRotation;

		private Vector3 targetPosition;

		private Quaternion targetRotation;

		private Vector3 startPosition;

		private Quaternion startRotation;

		private Vector3 currentPosition;

		private Quaternion currentRotation;

		private float time;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
