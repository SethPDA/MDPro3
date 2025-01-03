using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public abstract class DuelFieldBase : MonoBehaviour, IFieldPlacementInfo
	{
		private enum Step
		{
			WaitLoadPlayMat = 0,
			Initializing = 1,
			WaitPrepareToDuel = 2,
			WaitPrepared = 3,
			FinishPrepare = 4,
			WaitShowUp = 5,
			ExecDuel = 6,
			Terminating = 7,
			Finish = 8
		}

		public class HalfField
		{
			public MonsterCardPlace[] monsterPlaces;

			public MagicCardPlace[] magicPlaces;

			public MagicCardPlace pendulumLPlace;

			public MagicCardPlace pendulumRPlace;

			public MagicCardPlace fieldPlace;

			public DeckCardPlace deckPlace;

			public DeckCardPlace extraPlace;

			public GraveCardPlace gravePlace;

			public GraveCardPlace excludePlace;
		}

		public class SelectionItemContainer
		{
			public SharedDefinition.Location location;

			public int position;

			public List<SelectionButton> item;
		}

		private Step step;

		private bool initCardPlaces;

		private List<TargetingLine> affectLinkLines;

		private List<CardPlace> affectCardPlaces;

		private GameObject nearMdl;

		private GameObject farMdl;

		private bool highlightAvailable;

		protected Dictionary<int, HalfField> halfFields;

		protected NearHandCardPlace nearHandPlace;

		protected FarHandCardPlace farHandPlace;

		public List<SelectionItemContainer> selectionItemList;

		private Selector selector;

		private Coroutine initAllPlaceCoroutine;

		private Coroutine showUpCoroutine;

		private bool loadNearMat;

		private bool loadFarMat;

		private bool dragging;

		protected abstract string nearMatResourcePath { get; }

		protected abstract string farMatResourcePath { get; }

		protected abstract Vector3 matSize { get; }

		public abstract int numMonsterPlaces { get; }

		public abstract int numMagicPlaces { get; }

		public abstract int monsterStartIdx { get; }

		public abstract int monsterEndIdx { get; }

		public abstract int magicStartIdx { get; }

		public abstract int magicEndIdx { get; }

		public DuelGameObjectManager goManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<CardPlace> cardPlaces
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

		public bool isTerminated
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

		public bool isPrepared
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

		public bool isShownUp
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

		protected abstract void AssignAll(SharedDefinition.Location loc, GameObject parent);

		protected abstract GameObject GetFrame(SharedDefinition.Location loc, int position);

		protected abstract List<GameObject> GetFrames(SharedDefinition.Location loc);

		protected abstract GameObject GetPlayMat(SharedDefinition.Location loc);

		protected abstract MeshRenderer GetPlayMatRenderer(SharedDefinition.Location loc);

		public virtual void OnUpdate()
		{
		}

		public virtual void OnTerminate()
		{
		}

		public virtual bool UpdateInitialize()
		{
			return false;
		}

		public virtual bool UpdateTerminate()
		{
			return false;
		}

		public static T Create<T>(DuelGameObjectManager goManager, GameObject root, string name) where T : DuelFieldBase
		{
			return null;
		}

		protected void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public void PrepareToDuel()
		{
		}

		public void Inactivate()
		{
		}

		public CardPlace GetCardPlace(int team, int position)
		{
			return null;
		}

		public CardLocator GetCardLocator(int team, int position, int index)
		{
			return null;
		}

		public bool GetPosture(int team, int position, int index, out Vector3 pos, out Quaternion rot)
		{
			pos = default(Vector3);
			rot = default(Quaternion);
			return false;
		}

		public MonsterCardPlace[] GetMonsterPlaces(int team)
		{
			return null;
		}

		public MagicCardPlace[] GetMagicPlaces(int team)
		{
			return null;
		}

		private DeckCardPlace[] GetDeckPlaces(int team)
		{
			return null;
		}

		private GraveCardPlace[] GetGravePlaces(int team)
		{
			return null;
		}

		public CardPlace[] GetSwitchablePlaces(int team)
		{
			return null;
		}

		public Vector3 GetHandCardPosition(int index, int numCards, SharedDefinition.Location location)
		{
			return default(Vector3);
		}

		public Quaternion GetHandCardRotation(SharedDefinition.Location location)
		{
			return default(Quaternion);
		}

		public void HighlightIfAvailable(bool available, uint cmdBit, Action onFinished)
		{
		}

		public void UpdateHighlightEffect()
		{
		}

		public void UpdateState(Action onFinished)
		{
		}

		public void ReqAffectEffect(int team, int position)
		{
		}

		public void ClearAffectEffect()
		{
		}

		public bool IsAffectCardPlace(int player, int position)
		{
			return false;
		}

		public void ShowUpOnStartDuel(bool playEffect)
		{
		}

		private IEnumerator ShowUpCoroutine(bool playEffect)
		{
			return null;
		}

		private void Update()
		{
		}

		private void WaitLoadPlayMatStep()
		{
		}

		private void InitializingStep()
		{
		}

		private void WaitPreparedStep()
		{
		}

		private void ExecDuelStep()
		{
		}

		private void TerminatingStep()
		{
		}

		private void FinishStep()
		{
		}

		private void InitAllPlaces()
		{
		}

		private IEnumerator InitAllPlacesProcess()
		{
			return null;
		}

		public bool AnchorNameToPosition(string name, out int player, out int position)
		{
			player = default(int);
			position = default(int);
			return false;
		}

		private GameObject CreateAnchor(SharedDefinition.Location loc, int position)
		{
			return null;
		}

		public void AddSelectionItem(SharedDefinition.Location location, int position, SelectionButton item)
		{
		}

		public void RemoveSelectionItem(SharedDefinition.Location location, int position, SelectionButton item)
		{
		}

		public void RemoveSelectionItem(SharedDefinition.Location location, int position, int index)
		{
		}

		public SelectionButton GetSelectionItem(SharedDefinition.Location location, int position, int index)
		{
			return null;
		}

		public SelectionButton GetSelectionItem(int player, int position, int index)
		{
			return null;
		}

		public SelectionButton GetSelectionItem(Vector2 screenPoint)
		{
			return null;
		}

		public SelectionItemContainer GetSelectionItemContainer(SharedDefinition.Location location, int position)
		{
			return null;
		}

		public (SharedDefinition.Location, int, int) GetPosition(SelectionItem item)
		{
			return default((SharedDefinition.Location, int, int));
		}

		public (SharedDefinition.Location, int, int) GetPosition(Vector2 screen_point)
		{
			return default((SharedDefinition.Location, int, int));
		}

		private void SetupSelectionItemTransition()
		{
		}

		private void SetupSelectionItemTransition(SelectionButton item, PadInputDirection direction, SharedDefinition.Location transitionLocation, int transitionPosition)
		{
		}

		public bool SelectItem(int player, int position, int index)
		{
			return false;
		}
	}
}
