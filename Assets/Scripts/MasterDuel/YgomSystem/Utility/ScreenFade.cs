using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility
{
	public class ScreenFade : MonoBehaviour
	{
		private static ScreenFade s_Instance;

		private Mesh m_screenMesh;

		private Color m_baseColor;

		private Color m_targetColor;

		private Material m_material;

		private float m_timeMax;

		private float m_timeCnt;

		private float m_startDelay;

		private float m_endDelay;

		private float m_easingPow;

		private bool m_ignoreTimeScale;

		private bool m_inputEnable;

		private bool m_autoDestroy;

		private Action m_onFinihed;

		private List<GraphicRaycaster> raycasterList;

		public static void FadeIn(float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, Action onFinihed = null)
		{
		}

		public static void FadeOut(float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, Action onFinihed = null)
		{
		}

		public static void FadeColor(Color baseColor, Color targetColor, float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, Action onFinihed = null)
		{
		}

		public static void FadeEnd()
		{
		}

		private static void CreateFade()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRenderObject()
		{
		}

		public void Play(Color baseColor, Color targetColor, float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, Action onFinihed = null)
		{
		}

		private void DestroyFade()
		{
		}

		private void SetInputEnable(bool enable)
		{
		}

		private Mesh CreateScreenMesh()
		{
			return null;
		}

		private void DwarScreen(Material mat)
		{
		}
	}
}
