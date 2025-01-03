using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardEffectZoneEffect : CardEffectBase
	{
		private bool zoneEffect;

		private Vector3 placePosition;

		private Quaternion placeRotation;

		private Vector3 placeScale;

		private bool isFace;

		public ZoneCard.Zone zone
		{
			[CompilerGenerated]
			get
			{
				return default(ZoneCard.Zone);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ZoneCard.Mode mode
		{
			[CompilerGenerated]
			get
			{
				return default(ZoneCard.Mode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CardEffectZoneEffect Create(CardRoot cardRoot, ZoneCard.Zone zone, ZoneCard.Mode mode, Vector3 placePosition, Quaternion placeRotation, Vector3 placeScale, bool isFace)
		{
			return null;
		}

		public static CardEffectZoneEffect CreateNoZoneEffect(CardRoot cardRoot)
		{
			return null;
		}

		public static CardEffectZoneEffect Create(CardRoot cardRoot, int position, bool getOut, Vector3 placePosition, Quaternion placeRotation, Vector3 placeScale, bool isFace)
		{
			return null;
		}

		public override void StartEffect()
		{
		}

		public override bool UpdateEffect()
		{
			return false;
		}
	}
}
