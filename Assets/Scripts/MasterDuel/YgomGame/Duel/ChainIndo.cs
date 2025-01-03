using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	internal struct ChainIndo
	{
		public Transform chainhead;

		public float unitlength;

		public Stack<Transform> chainstack;

		public Vector3 srcpos;

		public Vector3 dstpos;

		public Vector3 currentpos => default(Vector3);

		public float currentlength => 0f;

		//public ChainIndo(Transform chainhead, float unitlength, Vector3 srcpos, Vector3 dstpos)
		//{
		//}
	}
}
