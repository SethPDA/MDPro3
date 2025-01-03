using System;
using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public abstract class CardEffectBase
	{
		public CardRoot cardRoot
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

		public bool finished
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

		protected Action onFinished
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

		public abstract void StartEffect();

		public virtual bool UpdateEffect()
		{
			return false;
		}

		public void OnFinished()
		{
		}
	}
}
