using UnityEngine;

namespace YgomGame.CardPack.Open.Widget
{
	[ExecuteInEditMode]
	public class FromToObjMover : MonoBehaviour
	{
		[SerializeField]
		private GameObject m_From;

		[SerializeField]
		private GameObject m_To;

		[SerializeField]
		private float m_Normal;

		private float m_LastNormal;

		public float normal
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

		public void UpdateLocation()
		{
		}
	}
}
