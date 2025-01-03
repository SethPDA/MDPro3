using UnityEngine;
using YgomSystem.Effect;

namespace YgomSystem.UI
{
	public class TweenGraphMatFloat : Tween
	{
		[SerializeField]
		public string field;

		[SerializeField]
		public float from;

		[SerializeField]
		public float to;

		private MaterialSetterGraphWriter m_TargetWriter;

		protected override void OnSetValue(float par)
		{
		}
	}
}
