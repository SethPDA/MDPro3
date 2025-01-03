using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Home
{
	public class ActiveTargetWithBindingTopicsCardUV : MonoBehaviour
	{
		[SerializeField]
		private List<Transform> activeTrueObjects;

		[SerializeField]
		private List<Transform> activeFalseObjects;

		[SerializeField]
		private bool isScaleZero;

		protected BindingTopicsCardUV component;

		private void OnEnable()
		{
		}

		private void UpdateActive()
		{
		}
	}
}
