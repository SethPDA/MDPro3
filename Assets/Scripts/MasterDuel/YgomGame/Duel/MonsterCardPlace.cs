using UnityEngine;

namespace YgomGame.Duel
{
	public class MonsterCardPlace : BasicCardPlace
	{
		private BattleAimingEffect btlAimingEff;

		public bool isActiveAimingEffect => false;

		public MonsterCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor)
			: base(null, 0, 0, null)
		{
		}

		public override void Terminate()
		{
		}

		protected override void OnEnterImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
		}

		protected override void OnLeaveImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
		}

		protected override void OnRegisterImpl(CardRoot cardRoot, int index)
		{
		}

		public void EndBattleAimingEffect()
		{
		}

		public void SetVisibleAimingEffect(bool visible)
		{
		}

		private void UpdateXyzIndices()
		{
		}
	}
}
