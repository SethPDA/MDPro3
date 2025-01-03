using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioLoadGroupContainer : MonoBehaviour
	{
		private List<ScenarioBehaviour> m_AllBehaviours;

		private int m_LoadingCount;

		private List<(string, Type)> m_LoadPaths;

		private List<int> m_LoadMrks;

		private ScenarioBehaviour_LoadGroup_Begin m_CurrentBeginBehaviour;

		private ScenarioBehaviour_LoadGroup_End m_CurrentEndBehaviour;

		public static ScenarioLoadGroupContainer Create(GameObject owner, List<ScenarioBehaviour> allBehaviours)
		{
			return null;
		}

		private void Clear()
		{
		}

		public bool LoadGroup(ScenarioBehaviour_LoadGroup_Begin beginBehaviour)
		{
			return false;
		}

		public bool IsLoading()
		{
			return false;
		}

		public bool UnloadGroup(ScenarioBehaviour_LoadGroup_End beginBehaviour)
		{
			return false;
		}

		public void UnloadAll()
		{
		}

		private void OnDestroy()
		{
		}

		private void AddLoadingCount()
		{
		}

		private void DecLoadingCount()
		{
		}
	}
}
