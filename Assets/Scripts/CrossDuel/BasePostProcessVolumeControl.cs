using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

namespace Willow
{
	public class BasePostProcessVolumeControl : MonoBehaviour, ITimeControl
	{
		private Volume m_volume;

		private bool m_isValid;

		private bool m_isStart;

		protected Volume volume => null;

		public void SetTime(double time)
		{
		}

		public void OnControlTimeStart()
		{
		}

		public void OnControlTimeStop()
		{
		}

		protected virtual void CheckPostProcess()
		{
		}

		protected virtual void StartPostProcess()
		{
		}

		protected virtual void UpdatePostProcess()
		{
		}
	}
}
