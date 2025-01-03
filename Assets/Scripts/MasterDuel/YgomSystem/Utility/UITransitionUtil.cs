using System;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class UITransitionUtil
	{
		public enum BlockType
		{
			None = 0,
			Game = 1,
			System = 2
		}

		private TweenContainer tweenContainer;

		public void Setup(GameObject target)
		{
		}

		public void Play(string label, BlockType blockType, Action onPlayFinished, bool stop, string stopLabel)
		{
		}

		public void Immediate(string label)
		{
		}

		public bool Update()
		{
			return false;
		}

		public void Terminate()
		{
		}

		private int GetBlockPriority(BlockType blockType)
		{
			return 0;
		}
	}
}
