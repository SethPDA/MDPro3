using UnityEngine;
using YgomGame.Card;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Test
{
	public class MonsterCutinTest : ViewController
	{
		[SerializeField]
		private GameObject prefabUI;

		[SerializeField]
		private CardIndividualSetting setting;

		private int cardID;

		private bool useCardParameter;

		private bool isMyself;

		private Content.Attribute attribute;

		private string cardName;

		private MonsterCutinEffect.LevelType levelType;

		private int level;

		private int attack;

		private int defense;

		private bool isOcg;

		private MonsterCutinEffect monsterCutinEffect;

		private bool isPlaying;

		private ElementObjectManager ui;

		public override void NotificationStackEntry()
		{
		}

		private void PlayCutin()
		{
		}
	}
}
