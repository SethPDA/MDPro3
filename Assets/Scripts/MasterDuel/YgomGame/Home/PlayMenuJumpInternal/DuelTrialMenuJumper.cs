using System;
using System.Collections;
using System.Collections.Generic;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal
{
	public class DuelTrialMenuJumper : PlayMenuJumperBase
	{
		private int m_eventID;

		protected override ColosseumUtil.PlayMode playMode => default(ColosseumUtil.PlayMode);

		protected override string prefabPath => null;

		protected override void ExtendArgs(ref Dictionary<string, object> args)
		{
		}

		public DuelTrialMenuJumper(int eventID)
		{
		}

		public override void Check(Action<bool> resultCallback)
		{
		}

		private IEnumerator checkCoroutine(Action<bool> callback)
		{
			return null;
		}
	}
}
