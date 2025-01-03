using UnityEngine;

namespace YgomGame.CardPack.Open.Widget
{
	[ExecuteInEditMode]
	public class LocalPositionLayoutGroup : MonoBehaviour
	{
		[SerializeField]
		private float m_XSpace;

		private float m_LastXSpace;

		public float xSpace
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Update()
		{
		}

		public void UpdateLayout()
		{
		}
	}
}
