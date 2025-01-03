using UnityEngine;

namespace YgomGame.Duel
{
	public interface ICardStatusIconAnchor
	{
		GameObject effectAnchor { get; }

		Quaternion localRot { get; }

		Vector3 centerOfs { get; }

		Vector3 atkDefOfs { get; }

		Vector3 levelOfs { get; }

		Vector3 attrOfs { get; }

		Vector3 typeOfs { get; }

		Vector3 counterOfs { get; }

		Vector3 turnsOfs { get; }
	}
}
