using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class AdvantageGauge : MonoBehaviour
	{
		private static AdvantageGauge instance;

		private float m_AdvantageCurrent;

		private float m_AdvantageTarget;

		private float m_AdvantageWave;

		private float m_AdvantageBias;

		private float m_AdvantageBiasPre;

		private int playerid;

		private int rivalid;

		private bool m_ShowEffect;

		private ElementObjectManager m_Eomanager;

		[SerializeField]
		private Material material;

		public static bool isCalc
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static AdvantageGauge Create(Transform parent)
		{
			return null;
		}

		public static bool SwitchGaugeVisible()
		{
			return false;
		}

		public static bool SwitchEffectVisible()
		{
			return false;
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}
	}
}
