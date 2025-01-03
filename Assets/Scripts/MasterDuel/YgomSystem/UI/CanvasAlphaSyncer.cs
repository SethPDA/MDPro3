using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI
{
	public class CanvasAlphaSyncer : UIBehaviour
	{
		[Serializable]
		private class TargetData
		{
			public Renderer renderer;

			public string alphaParamName;
		}

		[SerializeField]
		private List<TargetData> m_Targets;

		private float m_LastAlpha;

		private bool m_CanvasGroupDirty;

		private List<CanvasGroup> m_CanvasGroups;

		protected override void OnBeforeTransformParentChanged()
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

		private void OnDirtyAlpha()
		{
		}

		private void OnDirtyTransformTree()
		{
		}

		private void LateUpdate()
		{
		}

		public void Apply()
		{
		}

		private void CollectCanvasGroups()
		{
		}

		private float CalcSourceAlpha()
		{
			return 0f;
		}
	}
}
