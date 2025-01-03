using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem
{
	public class RandomRotator : MonoBehaviour
	{
		[SerializeField]
		private Vector3 axis;

		[SerializeField]
		private float angleMin;

		[SerializeField]
		private float angleMax;

		public Quaternion rotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Start()
		{
		}

		public void Apply()
		{
		}
	}
}
