using YgomGame.Card;

namespace YgomGame.Duel
{
	public class CommandZoneIconController : ZoneIconController
	{
		public static CommandZoneIconController Create(RunEffectWorker worker)
		{
			return null;
		}

		public int ActivateCommandAvailableZone(uint commandMask, int cardID, int player, int position, int index, bool ignoreCard)
		{
			return 0;
		}

		public int ActivateDecideAvailableZone(bool ignoreCard)
		{
			return 0;
		}

		public int ActivateSelectStandZone(uint mask)
		{
			return 0;
		}

		public int ActivateSelectStandZone(int cardID, int player, int position)
		{
			return 0;
		}

		private bool IsAvailableZoneHandCommand(Engine.CommandType command, int commandPlayer, int commandPosition, int commandIndex, int targetPlayer, int targetPosition)
		{
			return false;
		}

		public bool IsCommandAvailableZone(Engine.CommandType command, int commandPlayer, int commandPosition, int commandIndex, int targetPlayer, int targetPosition, Content.Attribute attribute, bool isExMonster, bool isFieldMagic)
		{
			return false;
		}

		private bool CheckAvailableZone(int player, int position)
		{
			return false;
		}
	}
}
