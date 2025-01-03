using System;
using System.Collections.Generic;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumResultViewController : BaseMenuViewController
	{
		public enum AwardType
		{
			NONE = 0,
			FIRST = 1,
			SECOND = 2,
			THIRD = 3,
			OTHER = 4,
			PARTICIPATE = 5
		}

		private readonly string BTN_CLOSE_LABEL;

		private readonly string BTN_CLOSE_CENTER_LABEL;

		private readonly string ROOT_FIRST_LABEL;

		private readonly string ROOT_SECOND_LABEL;

		private readonly string ROOT_THIRD_LABEL;

		private readonly string ROOT_RANKED_LABEL;

		private readonly string ROOT_PARTICIPATE_LABEL;

		private readonly string IMG_ICON_LABEL;

		protected readonly string IMG_CUP_LABEL;

		private readonly string PLATFORM_NAME_LABEL;

		private readonly string TXT_TOURNAMENT_NAME_LABEL;

		private readonly string TXT_RANK_LABEL;

		protected const string KEY_TOURNAMENT_NAME = "TournamentName";

		protected const string KEY_AWARD_TYPE = "AwardType";

		protected const string KEY_ORDER = "Order";

		private const string KEY_EXIST_NUM_LOGO = "ExistNumLogo";

		protected const string KEY_FINISH_CALLBACK = "FinishCallback";

		private const string PATH_ATLAS = "Images/Colosseum/All/ColosseumAtlasAll";

		protected BindingGameObjectEx backGroundBGO;

		protected AwardType awardType;

		protected override Type[] textIds => null;

		public static Dictionary<string, object> GetArgs(string tournamentName, AwardType awardType, int dispOrder, bool existNumLogo = false, UnityAction onFinish = null)
		{
			return null;
		}

		protected virtual string GetBgPath()
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected ElementObjectManager GetEomRootRank(AwardType awardType)
		{
			return null;
		}

		protected virtual void SetCupImage(ElementObjectManager targetEom, bool existNumLogo, AwardType awardType)
		{
		}

		protected virtual string GetLogoName(bool existNumLogo, AwardType awardType)
		{
			return null;
		}
	}
}
