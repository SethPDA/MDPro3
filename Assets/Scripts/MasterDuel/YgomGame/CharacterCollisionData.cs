using System;
using UnityEngine;

namespace YgomGame
{
	[Serializable]
	public class CharacterCollisionData
	{
		public GameObject target;

		public Vector3 center;

		public Vector3 size;

		public CharacterCollisionData(GameObject target, Vector3 center, Vector3 size)
		{
		}
	}
}
