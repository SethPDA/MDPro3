using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class MeshAlphaFader : MonoBehaviour
	{
		public enum FadeType
		{
			FadeIn = 0,
			FadeOut = 1
		}

		private FadeType fadeType;

		private float alphaTime;

		private Action onFinishedAlpha;

		private float dulation;

		private bool recursively;

		public bool isShowing => false;

		public bool isHiding => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Finish()
		{
		}

		public void StartFade(FadeType fadeType, float dulation, bool recursively, Action onFinished)
		{
		}

		public void Abort()
		{
		}

		private void SetMeshAlpha(float alpha)
		{
		}

		private void ResetAlphaFade()
		{
		}
	}
}
