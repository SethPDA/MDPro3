using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioPrefabFader : MonoBehaviour
	{
		private List<Material> m_TargetMaterials;

		public float duration;

		private float m_PastSec;

		private float m_FromAlpha;

		private float m_DstAlpha;

		private float m_CurrentAlpha;

		public event Action onCompleteEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AssignChildren(GameObject root)
		{
		}

		public void Assign(GameObject target)
		{
		}

		public void Assign(MeshRenderer meshRenderer)
		{
		}

		public void Assign(SpriteRenderer spriteRenderer)
		{
		}

		public void Assign(ParticleSystemRenderer particleRenderer)
		{
		}

		public void Assign(Material material)
		{
		}

		public void PlayFadeIn()
		{
		}

		public void PlayFadeOut()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
