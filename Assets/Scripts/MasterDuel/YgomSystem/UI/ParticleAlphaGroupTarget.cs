using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI
{
	public class ParticleAlphaGroupTarget : UIBehaviour
	{
		[SerializeField]
		private string m_AlphaParamName;

		private ParticleAlphaGroup m_Group;

		private Renderer m_TargetCache;

		private Renderer target => null;

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

		private void SetGroupDirty()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnChangeGroupAlpha(float alpha)
		{
		}

		protected override void OnDestroy()
		{
		}

		private float CollectCanvasGroupAlpha()
		{
			return 0f;
		}

		private void SetTargetAlpha(float alpha)
		{
		}
	}
}
