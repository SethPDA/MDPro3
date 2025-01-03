using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.CardPack.Open.Actor;
using YgomGame.CardPack.Open.Widget;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourCardsOpen : SequenceBehaviour
	{
		public class PlayableCommand
		{
			public DrawCardData drawCardData;

			public CardPackCardActor cardActor;

			public PlayableAsset playableAsset;

			public bool isLoop;

			private int m_Step;

			public bool isDone => false;

			public bool Play()
			{
				return false;
			}

			public PlayableCommand Duplicate()
			{
				return null;
			}
		}

		public class OpenCardGroup
		{
			private readonly List<CardPackCardActor> m_CardActors;

			private readonly CardPackFoundKeyWidget m_FoundKeyWidget;

			private List<PlayableCommand> m_CommandsStep0;

			private Queue<PlayableCommand> m_CommandsStep1;

			private Queue<PlayableCommand> m_CommandsStep2;

			private List<(int, int)> m_FoundSecrets;

			private int m_Step;

			public bool isWaitStep0;

			public bool isComplete => false;

			public int Count => 0;

			public OpenCardGroup(CardPackFoundKeyWidget foundKeyWidget)
			{
			}

			public bool IsContain(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool IsReversedActor(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool IsPlayingActor(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool TryAddCardActor(ActorBindingRefs actorBindRefs, CardPackCardActor cardActor, DrawCardData drawCardData)
			{
				return false;
			}

			public bool Update()
			{
				return false;
			}
		}

		public class OpenCardGroupContainer
		{
			private readonly SequenceBehaviourWork m_Work;

			private readonly IReadOnlyList<DrawCardData> m_DrawCardDatas;

			private readonly List<OpenCardGroup> m_OpenCardGroups;

			private OpenCardGroup m_CurrentGroup;

			private bool m_IsAllCardOpened;

			private int m_Step;

			public Action onAddCardEvent;

			public Action onAddCardCompleteEvent;

			public bool isInEditGroup => false;

			public bool isComplete => false;

			public bool isAllCardOpened => false;

			public IReadOnlyList<DrawCardData> drawCardDatas => null;

			public OpenCardGroupContainer(SequenceBehaviourWork work, IReadOnlyList<DrawCardData> drawCardDatas)
			{
			}

			private bool IsContainGroup(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool IsCompeteReverseActor(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool TryAddNextCardActor(CardPackCardActor cardActor)
			{
				return false;
			}

			public bool TryAddCardActor(CardPackCardActor cardActor, bool isWaitStep0 = false)
			{
				return false;
			}

			public bool AddRemainAllCards()
			{
				return false;
			}

			public void SplitGroup()
			{
			}

			public bool Update()
			{
				return false;
			}
		}

		private readonly int k_Step00_OpenCards;

		private readonly int k_Step01_OpenCardsComplete;

		private readonly int k_Step02_WaitCardsConfirm;

		private readonly int k_Step03_WaitEndTimeline;

		private readonly int k_Step04_Finish;

		private bool m_IsLast;

		private bool m_SelectedDefaultCursor;

		private Vector2 m_PrevTouchScreenPos;

		private int m_Step;

		private bool m_TouchAllOpenTrigger;

		private readonly OpenCardGroupContainer m_OpenGroupContainer;

		private List<object> m_CardDetailMrks;

		private List<object> m_CardDetailPremiums;

		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourCardsOpen(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData packData, bool isLast)
			: base(null)
		{
		}

		protected override void OnBegin()
		{
		}

		protected override bool OnUpdate()
		{
			return false;
		}

		protected override void OnEnd()
		{
		}

		private void CheckHitDraggingCard(Vector2 prevScreenPos, Vector2 currentScreenPos)
		{
		}

		private void OpenCardDetail(CardPackCardActor cardActor)
		{
		}

		private void OnAddCardGroup()
		{
		}

		private void OnAddCardGroupComplete()
		{
		}

		private void OnDownTouchArea()
		{
		}

		private void OnDownCardActor(CardPackCardActor cardActor)
		{
		}

		private void OnDragTouchArea(SelectionItem.DragStatus dragStatus, Vector2 screenPos)
		{
		}

		private void OnDragCardActor(CardPackCardActor cardActor, SelectionItem.DragStatus dragStatus, Vector2 screenPos)
		{
		}

		private void OnUpTouchArea()
		{
		}

		private void OnCardActorUp(CardPackCardActor cardActor)
		{
		}

		private void OnClickAllCardOpen()
		{
		}

		protected override void OnInputAccept()
		{
		}

		private void OnCardDetailKey(CardPackCardActor cardActor)
		{
		}

		private void OnCardAcceptKey(CardPackCardActor cardActor)
		{
		}

		private void OnCardActorClick(CardPackCardActor cardActor)
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
