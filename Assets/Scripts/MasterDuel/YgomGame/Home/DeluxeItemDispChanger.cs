using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Home
{
	public class DeluxeItemDispChanger : MonoBehaviour
	{
		[SerializeField]
		private int itemId;

		[SerializeField]
		private List<Transform> DeluxeObjects;

		[SerializeField]
		private List<Transform> NotDeluxeObjects;

		[SerializeField]
		private bool isScaleZero;

		private void OnEnable()
		{
		}

		private void UpdateActive()
		{
		}
	}
}
