using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class SwitchingDeckModel : MonoBehaviour
	{
		public enum MoveType
		{
			Outgoing = 0,
			Incoming = 1
		}

		private enum Step
		{
			Idle = 0,
			WaitOutgoing = 1,
			WaitIncoming = 2
		}

		private Step step;

		private float time;

		private MeshAlphaFader alphaFader;

		private Vector3 posFrom;

		private Vector3 posTo;

		private Material frontMtrl;

		private const float dulation = 0.5f;

		private const float sideOffset = 5.9f;

		private void Awake()
		{
		}

		public void SetTopTexture(Texture texture)
		{
		}

		public void StartSwitching(MoveType moveType, Action onFinished)
		{
		}

		private void Update()
		{
		}

		private void InitOutgoing(Vector3 pos, Action onFinished)
		{
		}

		private void WaitOutgoingStep()
		{
		}

		private void InitIncoming(Vector3 pos, Action onFinished)
		{
		}

		private void WaitIncomingStep()
		{
		}
	}
}
