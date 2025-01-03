using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace YgomSystem.Utility
{
	public class SpriteAtlasContainer : MonoBehaviour
	{
		public SpriteAtlas spriteAtlas;

		public List<SpriteAtlas> additionalSpriteAtlas;

		public List<string> spriteAtlasHashList;
	}
}
