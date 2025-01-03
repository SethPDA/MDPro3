using UnityEngine;
using UnityEngine.UI;
using YgomSystem;

namespace YgomGame.Card
{
	public class CardPictureTop : MonoBehaviour
	{
		private const int MAXLEVEL = 12;

		private const string prefabPath = "Prefabs/Duel/CardPictureTop";

		[SerializeField]
		private RubyRoot rubyRoot;

		[SerializeField]
		private GameObject LevelRoot;

		[SerializeField]
		private Sprite[] LevelSprites;

		[SerializeField]
		private Image[] LevelIcons;

		[SerializeField]
		private int nameFontSize;

		[SerializeField]
		private int levelIconWidth;

		[SerializeField]
		private Color monsterNameColor;

		[SerializeField]
		private Color spellTrapNameColor;

		public static CardPictureTop Create(Transform parent)
		{
			return null;
		}

		public void SetCardTopArea(int cardid, bool maskmode)
		{
		}

		private void SetCardName(int cardid, bool maskmode)
		{
		}

		private void SetLevelRank(int cardid, bool maskmode)
		{
		}

		private void SetLevelIcon(int level, bool maskmode)
		{
		}

		private void SetRankIcon(int rank, bool maskmode)
		{
		}
	}
}
