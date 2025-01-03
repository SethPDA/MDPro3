using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Effect
{
	public class AspectScaler : MonoBehaviour
	{
		[SerializeField]
		private bool applyOnUpdate;

		[SerializeField]
		private float aspect;

		public Camera viewCamera
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(Camera view_camera)
		{
		}

		public void Apply()
		{
		}

		private void Update()
		{
		}
	}
}
