using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Duel
{
	public class CardInfoDetailForDuel : CardInfoDetail
	{
		protected const string PATH_PREHABFORDUEL = "Prefabs/Duel/UI/CardInfoDetailForDuel";

		private ToggleWidget m_OriginInfoToggle;

		private SelectionButton m_RelativeCardButton;

		private DuelClient m_Host;

		private bool m_BlcokRelatriveCard;

		public static void Create(DuelClient host, Transform parent, UnityAction<CardInfoDetailForDuel> finishedCallback)
		{
		}

		protected override void InitializeBase()
		{
		}

		public new void Show()
		{
		}

		private void InitToggle()
		{
		}

		private void SetCardByOriginalInfo()
		{
		}
	}
}
