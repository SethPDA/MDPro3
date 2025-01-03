using System.Collections.Generic;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumResultViewController_Wcs : ColosseumResultViewController
	{
		protected const string KEY_LOGO_ID = "LogoId";

		protected override string GetBgPath()
		{
			return null;
		}

		public static Dictionary<string, object> GetArgs(string tournamentName, AwardType awardType, int dispOrder, int logoId, UnityAction onFinish = null)
		{
			return null;
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void SetCupImage(ElementObjectManager targetEom, bool existNumLogo, AwardType awardType)
		{
		}

		protected override string GetLogoName(bool existNumLogo, AwardType awardType)
		{
			return null;
		}

		private string GetTweenLavel(AwardType awardType)
		{
			return null;
		}
	}
}
