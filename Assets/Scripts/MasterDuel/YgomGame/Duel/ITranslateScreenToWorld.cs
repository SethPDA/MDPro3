using UnityEngine;

namespace YgomGame.Duel
{
	public interface ITranslateScreenToWorld
	{
		Vector3 TranslateScreenToWorld(Vector2 pos);
	}
}
