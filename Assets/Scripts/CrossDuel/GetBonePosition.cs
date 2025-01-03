using UnityEngine;

namespace Willow
{
	[ExecuteAlways]
	public class GetBonePosition : MonoBehaviour
	{
		private static readonly int s_rootPosId;

		[SerializeField]
		private Transform m_targetRendererTrans;

		[SerializeField]
		private SkinnedMeshRenderer m_targetRenderer;

		[SerializeField]
		private Material m_drivenMaterial;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void UpdateRootPosProperty(Vector3 position)
		{
		}
	}
}
