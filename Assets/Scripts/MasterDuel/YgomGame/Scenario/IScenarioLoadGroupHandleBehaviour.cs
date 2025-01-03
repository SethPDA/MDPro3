using System;
using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public interface IScenarioLoadGroupHandleBehaviour
	{
		void CollectLoadPath(List<(string, Type)> res);

		void CollectLoadMrk(List<int> res);
	}
}
