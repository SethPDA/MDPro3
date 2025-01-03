using System;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ScenarioShaker : MonoBehaviour
	{
		private bool m_Playing;

		private float m_CycleDuration;

		private float m_Amount;

		private float m_AutoStopSec;

		private float m_CycleSec;

		private RectTransform m_RectTran;

		private Vector3 m_StartPos;

		private Vector3 m_From;

		private Vector3 m_To;

		private Vector3 m_MoveMin;

		private Vector3 m_MoveMax;

		private int m_MoveDir;

		private bool m_IsAutoStop;

		private Action<float> m_OnShakeSetValueAction;

		public static ScenarioShaker Attouch(GameObject target)
		{
			return null;
		}

		public void PlayShake(float cycleDuration, float amount, bool shakeX, bool shakeY, float stopSec = 0f)
		{
		}

		public void StopShake()
		{
		}

		private void Update()
		{
		}

		private void OnShakeXYSetValue(float par)
		{
		}

		private void OnShakeXSetValue(float par)
		{
		}

		private void OnShakeYSetValue(float par)
		{
		}
	}
}
