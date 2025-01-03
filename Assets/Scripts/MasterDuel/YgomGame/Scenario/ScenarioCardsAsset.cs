using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Scenario
{
	//[CreateAssetMenu]
	public class ScenarioCardsAsset : ScriptableObject
	{
		private const string k_PathFormat = "Scenarios/Gates/ScenarioCards/{0}";

		public List<int> mrks;

		public static void LoadAsync(string scenarioName, Action<ScenarioCardsAsset> onFinished)
		{
		}
	}
}
