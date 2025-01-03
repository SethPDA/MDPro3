using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomGame.Duel
{
	public abstract class SummonEffectBase
	{
		protected Texture2D destTextureFront;

		protected Material destProtectorMaterial;

		protected Texture2D[] matTextureFront;

		protected Material[] matProtectorMaterials;

		protected Transform destCard;

		private Vector3 destCardPosition;

		private Quaternion destCardRotation;

		private Vector3 destCardScale;

		protected Action onStartCard;

		protected Action onFinished;

		protected int materialNum;

		protected int loadCounter;

		protected PlayableDirector mainTimeline;

		protected GameObject autoReleaseCardPicture;

		protected List<int> cardidList;

		protected List<UnityAction<Texture2D>> onFinishList;

		protected bool monsterCutinInvoked;

		private bool startCardInvoked;

		protected bool skipped;

		protected bool isTerminated;

		protected List<string> loadedTimelineList;

		public MonsterCutinEffect monsterCutinEffect
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

		public bool isLoading => false;

		public bool isEffectReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isEffectPlaying
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int destCardUniqueID
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

		public abstract Engine.SpSummonType spSummonType { get; }

		public virtual void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
		{
		}

		protected void LoadCardFront()
		{
		}

		protected void LoadCardBack(int sleeveID, UnityAction<Material> onFinished)
		{
		}

		protected void TerminateCard()
		{
		}

		public void Play(Action onFinished, Action onStartCard)
		{
		}

		protected abstract bool PlayEffect(Action onFinished);

		protected PlayableDirector PlayTimeline(string label, Action onFinished)
		{
			return null;
		}

		protected void PlayTimeline(string path, UnityAction<PlayableDirector> onLoaded, Action onFinished)
		{
		}

		protected void LoadTimeline(string path)
		{
		}

		public (Vector3, Quaternion, Vector3) GetDestCardPlace()
		{
			return default((Vector3, Quaternion, Vector3));
		}

		public void UpdateDestCardPlace()
		{
		}

		protected void SetupEventCallback()
		{
		}

		private void PlayStartCard()
		{
		}

		private void PlayMonsterCutin()
		{
		}

		protected virtual void Finish()
		{
		}

		public void UnloadResources()
		{
		}

		public virtual bool Skip()
		{
			return false;
		}

		protected TimelineClip GetStrongSummonEvent(PlayableDirector timeline)
		{
			return null;
		}

		protected void StopSE(PlayableDirector timeline)
		{
		}

		public void Terminate()
		{
		}
	}
}
