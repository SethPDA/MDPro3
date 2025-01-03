using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ZoneCardOut : ZoneCard
	{
		private List<Action> onPlayFinished;

		private const float playedCallbackIntervalTime = 0.1f;

		public static ZoneCardOut Create(Zone zone, Mode mode, Action<ZoneCard> onLoadFinished)
		{
			return null;
		}

		public override void Play(int cardID, int uniqueID, Vector3 position, Quaternion rotation, Vector3 scale, bool isFace, Action onPlayFinished)
		{
		}

		private IEnumerator PlayFinishedCallbackExecuter()
		{
			return null;
		}

		public override void Terminate()
		{
		}
	}
}
