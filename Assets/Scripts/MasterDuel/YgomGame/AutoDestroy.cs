using System.Collections;
using UnityEngine;

namespace YgomGame
{
	public class AutoDestroy : MonoBehaviour
	{
		[SerializeField]
		private float delayTime;

		private float restTime;

		private void OnEnable()
		{
		}

		private IEnumerator DelayDestroy()
		{
			return null;
		}
	}
}
