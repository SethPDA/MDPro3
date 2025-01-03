using System;
using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Menu
{
	public class PvpMenuMatchingTournament : PvpMenuMatchingBase
	{
		public bool goto_cpu;

		private int tid;

		public override void StartMatching(Dictionary<string, object> param)
		{
		}

		public override IEnumerator yWaitMatching(Action callback)
		{
			return null;
		}

		public override void SetBootDuelParam(ref Dictionary<string, object> param)
		{
		}
	}
}
