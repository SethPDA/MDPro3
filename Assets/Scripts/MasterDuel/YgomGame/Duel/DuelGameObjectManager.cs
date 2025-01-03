using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Bg;

namespace YgomGame.Duel
{
	public class DuelGameObjectManager : MonoBehaviour
	{
		private enum Step
		{
			PreLoading = 0,
			PreLoaded = 1,
			Preparing = 2,
			Idle = 3,
			Terminating = 4
		}

		private Step step;

		private List<CardRoot> cardRoots;

		private bool reqCardEffectFinishedCallback;

		public Action onCardEffectFinished;

		public RunEffectWorker effectWorker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public PopUpTextManager popUpTextManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isInitialized
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

		public bool isPreparedToDuel
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

		private CardInstancePool cardInstancePool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DuelEffectPool duelEffectPool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DuelResourcePool duelResourcePool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public MainCameraOrganizer mainCamera => null;

		public BgManager bg
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DuelFieldBase duelField
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FaceDownCardEffectPool faceDownCardEffectPool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ActivePlayerFieldEffect activePlayerFieldEffect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DuelTimer3D duelTimer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isShownUp => false;

		public static DuelGameObjectManager Create()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private IEnumerator InitializeProcess()
		{
			return null;
		}

		public void SetRunEffectWorker(RunEffectWorker worker)
		{
		}

		public static void WarningGameObjectExists(string path)
		{
		}

		public static GameObject CreateGameObject(GameObject parent, string name, Type[] components = null)
		{
			return null;
		}

		public static T CreateGameObject<T>(GameObject parent, string name, Type[] components = null) where T : MonoBehaviour
		{
			return null;
		}

		public void Terminate()
		{
		}

		public void PrepareToDuel()
		{
		}

		private IEnumerator PrepareToDuelProcess()
		{
			return null;
		}

		public CardRoot RentCardInstance()
		{
			return null;
		}

		public void ReturnCardInstance(CardRoot cardRoot)
		{
		}

		public CardRoot FindCardInstance(int uniqueId)
		{
			return null;
		}

		public CardRoot FindCardInstance(int player, int position, int index)
		{
			return null;
		}

		public CardRoot FindPlacedCardInstance(int player, int position, int index)
		{
			return null;
		}

		public List<CardRoot> FindPlacedCardsInstance(int player, int position, int excludeIndex = -1)
		{
			return null;
		}

		private void ReturnAllCards()
		{
		}

		private void SyncEngineCards()
		{
		}

		public void RefreshFieldCard()
		{
		}

		public bool IsCardEffectPlaying(CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsCardEffectPlaying(Type type, CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode, CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsMoveEffectRequested(CardRoot excludeCard = null)
		{
			return false;
		}

		public CardRoot GetFieldCardAt(int index)
		{
			return null;
		}

		public int GetFieldCardNum()
		{
			return 0;
		}

		public void SetVisible(bool visible)
		{
		}

		public void ShowDuelStartField(bool playEffect)
		{
		}

		private void CheckCardEffectPlaying()
		{
		}

		public void RequestActionOnPlayedCardEffect(Action action)
		{
		}

		private void Update()
		{
		}

		private void IdleStep()
		{
		}

		private void TerminatingStep()
		{
		}
	}
}
