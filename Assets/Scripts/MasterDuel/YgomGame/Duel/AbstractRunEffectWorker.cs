using System;
using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public abstract class AbstractRunEffectWorker
	{
		public virtual bool isInitialized
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual bool isPreparedToDuel
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual bool isTerminated
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public DuelClient host
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

		public virtual void PrepareToDuel()
		{
		}

		public virtual void Terminate()
		{
		}

		public virtual void OnDestroy()
		{
		}

		[Obsolete]
		public virtual void RunEffect(Engine.ViewType viewType, int param1, int param2, int param3)
		{
		}

		public virtual bool IsBusyEffect(Engine.ViewType viewType)
		{
			return false;
		}

		public AbstractRunEffectWorker(DuelClient host)
		{
		}
	}
}
