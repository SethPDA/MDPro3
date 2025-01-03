using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Duel
{
	public class EngineInitializerByServer : EngineInitializer
	{
		private int[][][] m_decks;

		private int[][] m_rares;

		private const int maxDecks = 4;

		private int[] repfin;

		public override int myPlayerNum => 0;

		public override int firstPlayer => 0;

		public override int[][] deck0 => null;

		public override int[][] deck1 => null;

		public override int[][] deck2 => null;

		public override int[][] deck3 => null;

		public override uint randSeed => 0u;

		public override Engine.PlayerType myselfType => default(Engine.PlayerType);

		public override Engine.PlayerType rivalType => default(Engine.PlayerType);

		public override Engine.PlayerType myselfPartnerType => default(Engine.PlayerType);

		public override Engine.PlayerType rivalPartnerType => default(Engine.PlayerType);

		public override int fDuelType => 0;

		public override Engine.LimitedType limitedType => default(Engine.LimitedType);

		public override int[] rare0 => null;

		public override int[] rare1 => null;

		public override int[] rare2 => null;

		public override int[] rare3 => null;

		public override byte[] replayData => null;

		public override int[] repFinish => null;

		public override byte[] packedReplay => null;

		public override uint cpuParam => 0u;

		public override Engine.CpuParam cpuFlag => default(Engine.CpuParam);

		public override uint[] cpuParams => null;

		public override int challenge => 0;

		public override int challenge0 => 0;

		public override int challenge1 => 0;

		public override int duelId => 0;

		public override bool noshuffle => false;

		public override bool inputTimer => false;

		public override bool match => false;

		public override bool isTagDuel => false;

		public override int[] life => null;

		public override int[] hand => null;

		public override int item => 0;

		public Dictionary<string, object> duelSettings
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

		private void SetupDeckAndRare(List<object> decks, int player, out int[][] dstDeck, out int[] dstRare)
		{
			dstDeck = null;
			dstRare = null;
		}

		private int[] GetRejectedArray(int[] arr, List<int> rejectIndices)
		{
			return null;
		}

		private int[] objectListToIntArray(List<object> src, bool rejectZero, out List<int> rejectIdxs)
		{
			rejectIdxs = null;
			return null;
		}

		private int[] dicDeckToIntArray(Dictionary<string, object> dic, string key1, string key2, bool rejectZero, out List<int> rejectIdxs)
		{
			rejectIdxs = null;
			return null;
		}
	}
}
