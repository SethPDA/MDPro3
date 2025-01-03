using System;
using YgomGame.Utility;

namespace YgomGame.Duel
{
	public class BezierMotionContainerManager : ScriptableObjectManager<BezierMotionContainer>
	{
		public const string motionPathDrawPhaseDrawFirst = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawFirst";

		public const string motionPathDrawPhaseDrawLatter = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawLatter";

		public const string motionPathDrawPhaseToHand = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawToHand";

		public const string motionPathDrawPhaseDeckCenter = "Duel/ScriptableObject/BezierMotion/MotionContainerDeckCenter";

		public const string motionPathDrawPhaseDeckBack = "Duel/ScriptableObject/BezierMotion/MotionContainerDeckBack";

		public const string motionPathCardMoveStrongSummon = "Duel/ScriptableObject/BezierMotion/CardMoveMotion/MotionContainerStrongSummon";

		public const string motionPathDeckReverse = "Duel/ScriptableObject/BezierMotion/MosionContainerDeckReverse";

		public static void Setup(Action on_finished)
		{
		}

		public BezierMotionContainerManager()
		{
			//((ScriptableObjectManager<>)(object)this)._002Ector();
		}
	}
}
