using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenSpeedWriter : MonoBehaviour
	{
		[SerializeField]
		private string m_Label;

		[SerializeField]
		private Tween[] m_TargetTweens;

		[SerializeField]
		private float[] m_OriginalDurations;

		[SerializeField]
		private float m_Speed;

		private bool m_Ready;

		private void Initialize(string label = null)
		{
		}

		private void WriteSpeed(float speed = 1f)
		{
		}

		private static void InnerTargetWriteSpeed(GameObject target, float speed = 1f, string label = null)
		{
		}

		public static void TargetWriteSpeed(GameObject target, float speed = 1f, string label = null, bool includeChildren = false)
		{
		}
	}
}
