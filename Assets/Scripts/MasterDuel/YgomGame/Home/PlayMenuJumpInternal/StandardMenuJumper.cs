using System;
using System.Collections;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal
{
	public class StandardMenuJumper : PlayMenuJumperBase
	{
		protected override ColosseumUtil.PlayMode playMode => default(ColosseumUtil.PlayMode);

		protected override string prefabPath => null;

		public override void Check(Action<bool> resultCallback)
		{
		}

		private IEnumerator checkCoroutine(Action<bool> callback)
		{
			return null;
		}
	}
}
