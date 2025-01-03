using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class AttackTargetingOperation
	{
		private DuelGameObjectManager goManager;

		private List<int> targets;

		private TargetingLine targetingLine;

		private AttackZoneIconController zoneIcon;

		private Vector3 basePosition;

		private Vector2 startScreenPoint;

		private int attackPlayer;

		private int attackPosition;

		private int targetPlayer;

		private int targetPosition;

		public bool activate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool dragOperation
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static AttackTargetingOperation Create(DuelGameObjectManager goManager)
		{
			return null;
		}

		public void Initialize(DuelGameObjectManager goManager)
		{
		}

		public void Tarminate()
		{
		}

		public void BeginDragTargeting(int attackPlayer, int attackPosition, int targetMask, Vector2 screenPoint)
		{
		}

		public void BeginSingleTargeting(int attackPlayer, int attackPosition, int targetPlayer, int targetPosition)
		{
		}

		private void BeginTargeting(int attackPlayer, int attackPosition, Vector2 screenPoint)
		{
		}

		public void UpdateTargeting(Vector2 screenPoint)
		{
		}

		private Vector3 GetTargetWorldPosition(int player, int position)
		{
			return default(Vector3);
		}

		public (int, int) EndTargeting(bool forceHideLine)
		{
			return default((int, int));
		}

		private void SelectAttackableZone(int player, int position)
		{
		}

		public void SetDispLine(bool disp)
		{
		}

		public (int, int, int, int) GetCurrentTargetingInfo()
		{
			return default((int, int, int, int));
		}
	}
}
