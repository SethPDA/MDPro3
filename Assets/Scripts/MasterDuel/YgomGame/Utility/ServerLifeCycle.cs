using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Utility
{
	public class ServerLifeCycle : MonoBehaviour
	{
		private static ServerLifeCycle instance;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnCallMaintenance(Dictionary<string, object> param)
		{
		}
	}
}
