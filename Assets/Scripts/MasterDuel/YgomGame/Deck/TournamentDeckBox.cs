using UnityEngine.UI;
using YgomGame.Menu.Common;

namespace YgomGame.Deck
{
	public class TournamentDeckBox : DeckBox
	{
		private Image m_TournamentLogo;

		private Image m_TournamentBG;

		private void Awake()
		{
		}

		public IAsyncProgressContainer SetData(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, int logoId, int stage = 0, bool opened = false)
		{
			return null;
		}
	}
}
