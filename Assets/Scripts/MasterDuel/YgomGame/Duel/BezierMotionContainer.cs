using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class BezierMotionContainer : ScriptableObject
	{
		public List<BezierMotionSetting> motionList;

		public ChainedBezierMotion GetChainedBezierMotion()
		{
			return null;
		}

		public BezierMotionContainer Clone()
		{
			return null;
		}
	}
}
