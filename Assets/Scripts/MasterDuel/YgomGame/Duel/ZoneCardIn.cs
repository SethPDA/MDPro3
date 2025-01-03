using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ZoneCardIn : ZoneCard
	{
		private Action onPlayFinished;

		public static ZoneCardIn Create(Zone zone, Mode mode, Action<ZoneCard> onLoadFinished)
		{
			return null;
		}

		public override void Play(int cardID, int uniqueID, Vector3 position, Quaternion rotation, Vector3 scale, bool isFace, Action onPlayFinished)
		{
		}

		public override void Terminate()
		{
		}
	}
}
