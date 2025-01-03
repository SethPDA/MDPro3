using UnityEngine;
using YgomSystem.Effect;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioBlurLayerActor
	{
		private readonly int k_DepthBg;

		private readonly int k_DepthBgPrefab;

		private readonly int k_DepthCard;

		private readonly int k_DepthCardPop;

		private readonly string k_MatKeyEffect;

		private readonly ElementObject m_Eo;

		private readonly ScenarioObjectContainer3D m_ObjectContainer3D;

		private readonly SpriteRenderer m_SpriteRenderer;

		public readonly SpriteScaler spriteScaler;

		private int m_Depth;

		public float effect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int depth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ScenarioBlurLayerActor(ElementObject eo, ScenarioObjectContainer3D objectContainer)
		{
		}

		private void ApplyDepthLayers()
		{
		}

		public void UpdateBlurLayerCard(ScenarioCardActor targetCard)
		{
		}

		public void UpdateBlurLayerBGPref(GameObject target)
		{
		}

		private void UpdateBlurLayerGameObject(GameObject target, int targetDepth)
		{
		}
	}
}
