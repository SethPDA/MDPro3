using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelFieldNewMaster : DuelFieldBase
	{
		public class HalfMat
		{
			public GameObject root;

			public GameObject matModel;

			public GameObject[] monsters;

			public GameObject[] magics;

			public GameObject mainDeck;

			public GameObject grave;

			public GameObject exclude;

			public GameObject fieldMagic;

			public GameObject extra;
		}

		private HalfMat[] mats;

		public override int numMonsterPlaces => 0;

		public override int numMagicPlaces => 0;

		public override int monsterStartIdx => 0;

		public override int monsterEndIdx => 0;

		public override int magicStartIdx => 0;

		public override int magicEndIdx => 0;

		protected override string nearMatResourcePath => null;

		protected override string farMatResourcePath => null;

		protected override Vector3 matSize => default(Vector3);

		protected override void AssignAll(SharedDefinition.Location loc, GameObject parent)
		{
		}

		protected override GameObject GetFrame(SharedDefinition.Location loc, int position)
		{
			return null;
		}

		protected override List<GameObject> GetFrames(SharedDefinition.Location loc)
		{
			return null;
		}

		protected override GameObject GetPlayMat(SharedDefinition.Location loc)
		{
			return null;
		}

		protected override MeshRenderer GetPlayMatRenderer(SharedDefinition.Location loc)
		{
			return null;
		}
	}
}
