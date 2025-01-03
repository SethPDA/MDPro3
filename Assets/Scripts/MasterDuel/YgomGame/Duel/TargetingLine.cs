using UnityEngine;

namespace YgomGame.Duel
{
	public class TargetingLine : MonoBehaviour
	{
		private SimpleEffect effect;

		private LineRenderer lineRendererMain;

		private LineRenderer lineRendererSub;

		private Vector3[] originPositionsMain;

		private Vector3[] originPositionsSub;

		private bool usePrefabHeight;

		public static TargetingLine Create(DuelGameObjectManager goManager, DuelEffectPool.Type effectType, bool usePrefabHeight = true, bool setOver3DLayer = true)
		{
			return null;
		}

		private void Initialize(bool setOver3DLayer)
		{
		}

		public void Terminate()
		{
		}

		public void SetPosition(Vector3 tailPosition, Vector3 headPosition)
		{
		}

		private void SetPositionMain(Vector3 tailPosition, Vector3 headPosition)
		{
		}

		private void SetPositionSub(Vector3 tailPosition, Vector3 headPosition)
		{
		}

		public Vector3 GetOriginHeadPosition()
		{
			return default(Vector3);
		}

		public void SetDisp(bool disp)
		{
		}

		public void SetRollover(bool active)
		{
		}

		public void SetTiling(float tiling)
		{
		}
	}
}
