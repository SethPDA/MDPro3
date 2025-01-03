namespace YgomGame.Colosseum
{
	public class ColosseumPathManager
	{
		internal class PathBase
		{
			internal string deck_list;

			internal string accessory_box;

			internal string accessory_sleeve;

			internal string pickcards_ids;

			internal string pickcards_r;

			internal string id_name;

			internal string deck_list_accessory;

			internal string deck_list_pickcards_ids;

			internal string deck_list_pickcards_r;

			internal string name_reg_id;

			internal string ids;
		}

		internal class PathTournament : PathBase
		{
			internal PathTournament(int id)
			{
			}
		}

		internal class PathExhibition : PathBase
		{
			internal PathExhibition(int identifier, bool isRental)
			{
			}
		}

		internal class PathDuelistCup : PathBase
		{
			internal PathDuelistCup()
			{
			}
		}

		internal class PathRankEvent : PathBase
		{
			internal PathRankEvent(int id)
			{
			}
		}

		internal class PathDuelTrial : PathBase
		{
			internal PathDuelTrial(int identifier, bool isRental, int deckNo = 1)
			{
			}
		}

		internal class PathWCS : PathBase
		{
			internal PathWCS()
			{
			}
		}

		internal class PathVersus : PathBase
		{
			internal PathVersus(int identifier, bool isRental, int deckNo = 1)
			{
			}
		}

		public const int BASE_VERSUS_LOGO_ID = 400;

		private PathBase path;

		public string DECK_LIST => null;

		public string ACCESSORY_BOX => null;

		public string ACCESSORY_SLEEVE => null;

		public string PICKCARDS_IDS => null;

		public string PICKCARDS_R => null;

		public string ARGKEY_ID_NAME => null;

		public string DECK_LIST_ACCESSORY => null;

		public string DECK_LIST_PICKCARDS_IDS => null;

		public string DECK_LIST_PICKCARDS_R => null;

		public string NAME_REG_ID => null;

		public object IDS => null;

		public ColosseumPathManager(ColosseumUtil.PlayMode playMode, int identifier)
		{
		}

		public ColosseumPathManager(ColosseumUtil.PlayMode playMode, bool isRental, int identifier, int identifier2 = 1)
		{
		}
	}
}
