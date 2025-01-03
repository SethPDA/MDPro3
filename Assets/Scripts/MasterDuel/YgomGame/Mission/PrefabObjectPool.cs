using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Mission
{
	public class PrefabObjectPool
	{
		private readonly Transform m_Root;

		private readonly Dictionary<GameObject, Stack<GameObject>> m_ReusableStackMap;

		public Dictionary<GameObject, Action<GameObject>> onCreatedCallbackMap;

		private Stack<GameObject> GetReusableStack(GameObject pref)
		{
			return null;
		}

		public PrefabObjectPool(Transform root)
		{
		}

		private GameObject Create(GameObject pref, Transform owner)
		{
			return null;
		}

		public void Reserve(GameObject pref, int count = 1)
		{
		}

		public GameObject Rent(GameObject pref, GameObject owner)
		{
			return null;
		}

		public void Return(GameObject pref, GameObject obj)
		{
		}
	}
}
