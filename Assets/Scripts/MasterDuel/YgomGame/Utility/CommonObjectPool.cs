using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Utility
{
	public class CommonObjectPool : MonoBehaviour
	{
		private class PoolInfo
		{
			public string label;

			public GameObject gameObject;

			public PoolInfo(string label, GameObject gameObject)
			{
			}
		}

		private static CommonObjectPool _instance;

		private Dictionary<string, List<PoolInfo>> pool;

		private static CommonObjectPool instance => null;

		private void Push(string group, string label, GameObject target, bool setInactivate)
		{
		}

		private GameObject Pop(string group, string label, Transform parent, bool setAcvtive)
		{
			return null;
		}

		private void ClearGroup(string group)
		{
		}

		public static void PushPool(string group, string label, GameObject target, bool setActive = true)
		{
		}

		public static GameObject PopPool(string group, string label, Transform parent, bool setInactive = true)
		{
			return null;
		}

		public static void ClearPoolGroup(string group)
		{
		}
	}
}
