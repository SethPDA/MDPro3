using System;
using YgomGame.Utility;

namespace YgomGame.Duel
{
	public class BezierMotionSettingManager : ScriptableObjectManager<BezierMotionSetting>
	{
		public const string motionPathCardShowMoveHandNear = "Duel/ScriptableObject/BezierMotion/CardShowMoveHandNear";

		public const string motionPathCardShowMoveHandFar = "Duel/ScriptableObject/BezierMotion/CardShowMoveHandFar";

		public const string motionPathCardShowMoveFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowMoveFieldNear";

		public const string motionPathCardShowMoveFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowMoveFieldFar";

		public const string motionPathCardShowBackHandNear = "Duel/ScriptableObject/BezierMotion/CardShowBackHandNear";

		public const string motionPathCardShowBackHandFar = "Duel/ScriptableObject/BezierMotion/CardShowBackHandFar";

		public const string motionPathCardShowBackFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowBackFieldNear";

		public const string motionPathCardShowBackFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowBackFieldFar";

		public const string motionPathCardShowApplyMoveHandNear = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveHandNear";

		public const string motionPathCardShowApplyMoveHandFar = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveHandFar";

		public const string motionPathCardShowApplyMoveFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveFieldNear";

		public const string motionPathCardShowApplyMoveFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveFieldFar";

		public const string motionPathCardShowApplyBack = "Duel/ScriptableObject/BezierMotion/CardShowApplyBack";

		public const string motionPathCardShowHappen = "Duel/ScriptableObject/BezierMotion/CardShowHappen";

		public const string motionPathCardShowDisabled = "Duel/ScriptableObject/BezierMotion/CardShowDisabled";

		public const string motionPathCardShowApply = "Duel/ScriptableObject/BezierMotion/CardShowApply";

		public const string motionPathCardFlipCard = "Duel/ScriptableObject/BezierMotion/CardFlipCard";

		public const string motionPathCardFlipPlateMonster = "Duel/ScriptableObject/BezierMotion/CardFlipPlateMonster";

		public const string motionPathCardFlipPlateMagic = "Duel/ScriptableObject/BezierMotion/CardFlipPlateMagic";

		public const string motionPathCardFlipDeckCard = "Duel/ScriptableObject/BezierMotion/CardFlipDeckCard";

		public static void Setup(Action on_finished)
		{
		}

		public BezierMotionSettingManager()
		{
			//((ScriptableObjectManager<>)(object)this)._002Ector();
		}
	}
}
