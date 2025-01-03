using System;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenStretchTo : Tween
	{
		[Serializable]
		public struct StretchOffset
		{
			public float left;

			public float right;

			public float top;

			public float bottom;

			public static StretchOffset operator +(StretchOffset a, StretchOffset b)
			{
				return default(StretchOffset);
			}

			public static StretchOffset operator *(StretchOffset a, StretchOffset b)
			{
				return default(StretchOffset);
			}

			public static StretchOffset operator *(StretchOffset a, float b)
			{
				return default(StretchOffset);
			}

			public static StretchOffset operator -(StretchOffset a, StretchOffset b)
			{
				return default(StretchOffset);
			}
		}

		protected StretchOffset m_From;

		[SerializeField]
		public StretchOffset to;

		[SerializeField]
		public bool ResetFromOnEnable;

		private RectTransform m_RectTransform_Field;

		protected RectTransform m_RectTransform => null;

		private void OnEnable()
		{
		}

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
