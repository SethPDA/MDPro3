using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class UISpriteMaskLocator : UIBehaviour
	{
		[SerializeField]
		private SpriteMask m_SpriteMaskPref;

		[SerializeField]
		private SpriteMask m_SpriteMask;

		private GameObject m_SpriteMaskRoot;

		private List<RectMask2D> m_Masks;

		private List<ParticleSystemRenderer> m_Particles;

		private Vector3 m_LastWorldPos;

		private bool m_Dirty;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void OnDisable()
		{
		}

		private void RefreshComponents()
		{
		}

		private void RefreshTransform()
		{
		}

		private void SettingSpriteMask(RectMask2D selfMask)
		{
		}

		protected override void OnCanvasGroupChanged()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
