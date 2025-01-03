using UnityEngine;

namespace YgomGame.Menu
{
	public interface IBeforeHeaderSupported
	{
		GameObject GetBeforeParts();

		void SetBeforePartsVisible(bool visible);
	}
}
