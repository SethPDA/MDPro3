using UnityEngine;

namespace YgomGame.Duel
{
	public class TranslateScreenToWorldXZ : ITranslateScreenToWorld
	{
		private Camera cam;

		public TranslateScreenToWorldXZ(Camera cam)
		{
		}

		public Vector3 TranslateScreenToWorld(Vector2 pos)
		{
			return default(Vector3);
		}
	}
}
