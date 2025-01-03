using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Scenario
{
	public class ScenarioRootScreen : MonoBehaviour
	{
		public enum State
		{
			None = 0,
			FadeIn = 1,
			FadeOut = 2
		}

		private Image m_Target;

		private float m_FadeDuration;

		private float m_CurrentSec;

		private float m_FromAlpha;

		private float m_ToAlpha;

		private State m_State;

		public bool isPlaying => false;

		public State state => default(State);

		public static ScenarioRootScreen Create(Image target)
		{
			return null;
		}

		public void PlayFadeIn(float duration)
		{
		}

		public void PlayFadeOut(float duration)
		{
		}

		private void Setup(float toAlpha, float duration)
		{
		}

		private void Update()
		{
		}
	}
}
