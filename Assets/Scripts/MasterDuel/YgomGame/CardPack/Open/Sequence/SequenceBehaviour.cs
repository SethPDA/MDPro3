using System.Runtime.CompilerServices;

namespace YgomGame.CardPack.Open.Sequence
{
	public abstract class SequenceBehaviour : ISequenceBehaviour
	{
		public enum State
		{
			None = 0,
			Active = 1,
			End = 2
		}

		protected readonly SequenceBehaviourWork m_Work;

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string name => null;

		protected virtual bool isAcceptToSkipLoop => false;

		public SequenceBehaviour(SequenceBehaviourWork sequenceBehaviourWork)
		{
		}

		public void Begin()
		{
		}

		protected virtual void OnBegin()
		{
		}

		public bool Update()
		{
			return false;
		}

		protected virtual bool OnUpdate()
		{
			return false;
		}

		public void End()
		{
		}

		protected virtual void OnEnd()
		{
		}

		protected virtual void OnInputAccept()
		{
		}

		public virtual bool OnBack()
		{
			return false;
		}
	}
}
