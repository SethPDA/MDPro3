using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public abstract class SpecialWinBase
	{
		protected PlayableDirector timeline;

		protected abstract string prefabPath { get; }

		public bool isReady
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

		public virtual bool finished
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

		public bool goNext
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

		protected abstract List<string> seList { get; }

		protected virtual bool destroyOnWinStart => false;

		public virtual void Initialize()
		{
		}

		protected void LoadSE()
		{
		}

		protected void LoadTimeine(Action<PlayableDirector> onLoaded)
		{
		}

		protected virtual void Setup(PlayableDirector timeline)
		{
		}

		public void Play(Action onWinStart)
		{
		}

		protected virtual void OnFinished()
		{
		}
	}
}
