using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public abstract class CardRootTransition
	{
		protected CardRoot cardRoot;

		protected CardLocator fromLocator;

		protected CardLocator toLocator;

		private bool immediate;

		public bool isFinished
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

		protected virtual void OnInitialize()
		{
		}

		protected virtual bool OnUpdate()
		{
			return false;
		}

		protected virtual void OnImmediate()
		{
		}

		public void Initialize(CardRoot cardRoot, bool immediate)
		{
		}

		public virtual void SetCardLocator(CardLocator fromLocator, CardLocator toLocator)
		{
		}

		public void Update()
		{
		}
	}
}
