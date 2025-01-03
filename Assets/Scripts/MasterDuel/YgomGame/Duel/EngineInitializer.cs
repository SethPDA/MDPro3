namespace YgomGame.Duel
{
	public abstract class EngineInitializer
	{
		public abstract int myPlayerNum { get; }

		public int rivalPlayerNum => 0;

		public abstract int firstPlayer { get; }

		public abstract int[][] deck0 { get; }

		public abstract int[][] deck1 { get; }

		public abstract uint randSeed { get; }

		public abstract Engine.PlayerType myselfType { get; }

		public abstract Engine.PlayerType rivalType { get; }

		public abstract Engine.PlayerType myselfPartnerType { get; }

		public abstract Engine.PlayerType rivalPartnerType { get; }

		public abstract int fDuelType { get; }

		public abstract Engine.LimitedType limitedType { get; }

		public abstract int[] rare0 { get; }

		public abstract int[] rare1 { get; }

		public abstract byte[] replayData { get; }

		public abstract uint cpuParam { get; }

		public abstract Engine.CpuParam cpuFlag { get; }

		public virtual int challenge => 0;

		public virtual int challenge0 => 0;

		public virtual int challenge1 => 0;

		public virtual int duelId => 0;

		public virtual bool noshuffle => false;

		public virtual bool inputTimer => false;

		public virtual byte[] packedReplay => null;

		public virtual int[] repFinish => null;

		public virtual bool match => false;

		public virtual bool isTagDuel => false;

		public virtual int[][] deck2 => null;

		public virtual int[][] deck3 => null;

		public virtual int[] life => null;

		public virtual uint[] cpuParams => null;

		public virtual int[] rare2 => null;

		public virtual int[] rare3 => null;

		public virtual int[] hand => null;

		public virtual int item => 0;

		private int[][] deck(int player)
		{
			return null;
		}

		public virtual void LoadResources()
		{
		}

		public virtual bool WaitLoad()
		{
			return false;
		}

		public void InitEngine(Engine.RunEffect runEffect, Engine.IsBusyEffect isBusyEffect, ref RecordManager recmanref)
		{
		}
	}
}
