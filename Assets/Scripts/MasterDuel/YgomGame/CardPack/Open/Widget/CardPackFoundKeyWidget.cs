using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.Open.Widget
{
	public class CardPackFoundKeyWidget : ElementWidgetBehaviourBase<CardPackFoundKeyWidget>
	{
		private readonly string k_ELabelNumText;

		private readonly string k_ELabelKeyIcon;

		private readonly string k_ELabelKeyIconBase;

		private int m_TotalFoundNum;

		private PlayableDirector m_Playable;

		private PlayableDirector m_KeyIconPlayable;

		private TextMeshPro m_NumText;

		private GameObject m_KeyIcon;

		private CardPackFoundKey[] m_FoundKeys;

		public bool isPlayingPlayable
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CardPackFoundKeyWidget Create(ElementObjectManager eom, IReadOnlyList<GameObject> cardFoundKeys)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void PlayFoundKeys(IReadOnlyList<(int, int)> foundKeys)
		{
		}

		private void OnObtainSecretKey(CardPackFoundKey obtainKey)
		{
		}

		private void OnBeginPlayable(PlayableDirector playable)
		{
		}

		private void OnEndPlayable(PlayableDirector playable)
		{
		}

		public CardPackFoundKeyWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
