using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_PrefabCreate : ScenarioBehaviour, IScenarioLoadGroupHandleBehaviour
	{
		private bool m_CreateRequested;

		private GameObject m_CreatedObj;

		public ScenarioBehaviour_PrefabCreate(object commandData)
			: base(null)
		{
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}

		public void CollectLoadPath(List<(string, Type)> res)
		{
		}

		public void CollectLoadMrk(List<int> res)
		{
		}
	}
}
