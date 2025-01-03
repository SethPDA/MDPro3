namespace YgomGame.Duel
{
	public interface IFieldPlacementInfo
	{
		int numMonsterPlaces { get; }

		int numMagicPlaces { get; }

		int monsterStartIdx { get; }

		int monsterEndIdx { get; }

		int magicStartIdx { get; }

		int magicEndIdx { get; }
	}
}
