using UnityEngine;

namespace YgomGame.Duel
{
	public class CardSelectionListGroupLabel : MonoBehaviour
	{
		[SerializeField]
		private Color m_ColorMyself;

		[SerializeField]
		private Color m_ColorRIval;

		[SerializeField]
		private Color m_ColorDefault;

		public void SetLabel(int player, CardSelectionList.CardLocateType locate)
		{
		}

		public void UpdatePosition(Vector2 position)
		{
		}
	}
}
