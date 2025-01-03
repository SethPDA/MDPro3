using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioPrefabContainer : ScenarioContainerBase
	{
		private readonly int k_LocatorLen;

		private readonly string k_ELabelLocatorFormat;

		private readonly string k_PrefLabelBg;

		private readonly Dictionary<string, GameObject> m_CreatedObjectMap;

		private readonly Transform[] m_BackUILocators;

		private readonly Transform[] m_OverUILocators;

		public readonly ElementObjectManager backUIEom;

		public readonly ElementObjectManager overUIEom;

		public Action<string, GameObject> onCreateCallback;

		public bool isBgLabel(string label)
		{
			return false;
		}

		public ScenarioPrefabContainer(ElementObjectManager backUIEom, ElementObjectManager overUIEom)
			: base(null)
		{
		}

		public void CreatePrefabObject(string label, string path, int locateSlot, Action<GameObject> onComplete, bool isOverUI = false)
		{
		}

		public GameObject GetCreatedGameObject(string label)
		{
			return null;
		}

		public GameObject[] FindBGObjects()
		{
			return null;
		}

		public bool DestroyPrefabObject(string label)
		{
			return false;
		}
	}
}
