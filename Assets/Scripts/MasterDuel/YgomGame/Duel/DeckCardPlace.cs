using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DeckCardPlace : CardPlace
	{
		private enum Step
		{
			Idle = 0,
			WaitReverse = 1,
			WaitLoad1stCard = 2,
			FinishSync = 3
		}

		private enum ShuffleStep
		{
			Idle = 0,
			InitShuffleDeck = 1,
			WaitShuffleBeforeReverse = 2,
			StartShuffle = 3,
			WaitShuffle = 4,
			WaitEndShuffle = 5,
			WaitShuffleAfterReverse = 6,
			TermShuffle = 7
		}

		public struct Trans3D
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 scale;

			//public Trans3D(Vector3 pos, Quaternion rot, Vector3 sca)
			//{
			//}
		}

		protected CardLocator cardLocator1st;

		private Step step;

		private ShuffleStep shuffleStep;

		private string name;

		private UnityEngine.Object srcObject;

		private SimpleEffect highlightEff;

		private Action onFinishedSync;

		private DeckPlaceStatus deckStatus;

		private bool showDetailStatus;

		private List<MeshRenderer> boxRenderers;

		private Trans3D defaultAnchorTrans;

		private Vector3 defaultAnchorPos;

		private Quaternion defaultAnchorRot;

		private GameObject shuffleDeck;

		private Transform root;

		private Action onFinishedShuffle;

		private Animator boxAnim;

		private Queue<float> seQueue;

		private float time;

		private bool isSync;

		private bool reverse;

		private int topSleeveID;

		private int topCardID;

		private int topUniqueID;

		private bool topFace;

		private ChainedBezierMotion reverseMotion;

		private float reverseTime;

		private const int invalidIndex = -1;

		private static readonly Vector3 cardOfsOfOne;

		private static readonly int anim_Shuffle;

		private static readonly int anim_Idle;

		private bool effectActivation;

		private bool lethalEffectPlayed;

		private const string deckModelResPath = "Duel/Models/DeckModelWrapper";

		public int localTopCardIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int localCardNum
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private int defaultSleeveID => 0;

		public SharedDefinition.Location location
		{
			[CompilerGenerated]
			get
			{
				return default(SharedDefinition.Location);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public GameObject anchor
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

		public GameObject box
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

		public MeshRenderer boxBeforeTopRenderer
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

		private MeshRenderer boxFirstTopRenderer => null;

		private MeshRenderer boxSecondTopRenderer => null;

		private MeshRenderer boxThirdTopRenderer => null;

		private MeshRenderer boxForthTopRenderer => null;

		public MeshRenderer boxAfterTopRenderer
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

		public MeshRenderer boxTopRenderer => null;

		public CardRoot top
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

		private float deckHeightScaler => 0f;

		public float adjustedDeckHeightScaler => 0f;

		private int indexToDownValue => 0;

		public Vector3 posOfNumCardsStatus
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int bottomIndex => 0;

		private Vector3 highLightEffLocalScale => default(Vector3);

		public DeckCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor, string name, SharedDefinition.Location location)
			: base(null, 0, 0)
		{
		}

		public override void Terminate()
		{
		}

		public override bool UpdateInitialize()
		{
			return false;
		}

		public override bool UpdateTerminate()
		{
			return false;
		}

		protected override void OnPrepareToDuel(bool startAtZero, Action onFinished)
		{
		}

		protected override void OnShowUp(bool playEffect, Action onFinished)
		{
		}

		public override CardLocator GetCardLocator(int index, bool create, bool insert)
		{
			return null;
		}

		protected override void ShuffleImpl(Action onFinished)
		{
		}

		protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		protected override void OnUnregister(CardRoot cardRoot, int index)
		{
		}

		protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return false;
		}

		protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		private void UpdatePopUpText()
		{
		}

		private CardRoot LoadCardRootToLocator(CardLocator cardLocator, int cardID, int uniqueID, bool isFace, int sleeveID = -1)
		{
			return null;
		}

		protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
		{
		}

		private void SetDispHighlightEffect(bool disp)
		{
		}

		protected override void ReqDecideEffectImpl(int index, Action onFinished)
		{
		}

		protected override void FlipTurnStartImpl(CardRoot cardRoot, bool isFace)
		{
		}

		public override void OnUpdate()
		{
		}

		public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
		{
			return default(Vector3);
		}

		public Trans3D GetDefaultAnchorTransform()
		{
			return default(Trans3D);
		}

		public void ResetAnchorTransform()
		{
		}

		public void SetBeforeTopTexture(Texture tex)
		{
		}

		private int GetSleeveID(int uniqueID)
		{
			return 0;
		}

		private void UpdateLocatorIndices()
		{
		}

		public void SyncToEngine(Dictionary<string, object> savedEngineParams, Action onFinished, int num = 0)
		{
		}

		private void StartReverseStep()
		{
		}

		private void WaitReverseStep()
		{
		}

		private void StartLoadCardStep()
		{
		}

		private void WaitLoad1stCardStep()
		{
		}

		private void FinishSyncStep()
		{
		}

		private void InitShuffleDeckStep()
		{
		}

		private void WaitShuffleBeforeReverseStep()
		{
		}

		private void StartShuffleStep()
		{
		}

		private void WaitShuffleStep()
		{
		}

		private void WaitEndShuffleStep()
		{
		}

		private void WaitShuffleAfterReverseStep()
		{
		}

		private void TermShuffleStep()
		{
		}

		private void UpdateLocator()
		{
		}

		public void UpdateParts(bool reqReloadTex = true)
		{
		}

		public void Show()
		{
		}

		public void Show(Vector3 pos)
		{
		}

		public Vector3 Hide(bool lethalEffect = false)
		{
			return default(Vector3);
		}

		public void ShowStatusLabel(bool immediate, bool showDetail)
		{
		}

		public void HideStatusLabel(bool immediate, bool finishShowDetail = false)
		{
		}

		public void SetInputEnabled(bool enabled)
		{
		}

		private void UpdateBoxTopTexture()
		{
		}

		private GameObject DuplicateShuffleDeck()
		{
			return null;
		}

		public override Vector3 GetTypicalPos()
		{
			return default(Vector3);
		}

		private Vector3 GetScaleY()
		{
			return default(Vector3);
		}

		public override void OnSelected()
		{
		}

		public override void OnDeselected()
		{
		}
	}
}
