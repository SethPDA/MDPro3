using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Duel
{
	public class CpuThinkingIcon : MonoBehaviour
	{
		private float MAXTHINKINGTIME;

		private float m_CpuThinkingCount;

		private bool m_ShowIcon;

		private CanvasGroup m_CanvasGroup;

		public static void Create(Transform parent, UnityAction<CpuThinkingIcon> onFinish)
		{
		}

		public void OnCpuThinkingBegin()
		{
		}

		public void OnCpuThinkingEnd()
		{
		}

		protected void Initialize()
		{
		}

		private void ResetMenbers()
		{
		}

		private void Update()
		{
		}
	}
}
