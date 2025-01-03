using System;
using YgomGame.Menu;

namespace YgomGame.Colosseum
{
	public class ColosseumStartViewController : BaseMenuViewController
	{
		public enum PrefabType
		{
			STANDARD = 0,
			TOURNAMENT = 1,
			WCS = 2,
			TOURNAMENT_NOMESSAGE = 3
		}

		private readonly string BTN_CLOSE_LABEL;

		private readonly string IMG_TOURNAMENT_LABEL;

		private readonly string TXT_NAME_LABEL;

		private readonly string E_TextDescription;

		private readonly string E_Logo;

		private const string KEY_NAME = "TournamentName";

		private const string KEY_LOGO = "LogoId";

		private const string KEY_TYPE = "PrefabType";

		private const string KEY_IDENTIFIER = "Identifier";

		public const string KEY_ENDACTION_QUEUE = "EndActionQueue";

		public const string KEY_ENDACTION = "EndAction";

		private PrefabType prefabType;

		protected override Type[] textIds => null;

		public static void Open(PrefabType prefabType, string tournamentName = "", int logoId = 0, int identifier = 0, Action onFinish = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnClickBackButton()
		{
		}

		private void UpdateStandardView()
		{
		}

		private void UpdateTouramentView()
		{
		}

		private void UpdateWCSView()
		{
		}

		private void UpdateTouramentNoMessageView()
		{
		}
	}
}
