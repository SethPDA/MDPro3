using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EngineBusyIdTable
	{
		private static readonly Dictionary<Engine.ViewType, Engine.ViewType> tbl;

		public static Dictionary<Engine.ViewType, Engine.ViewType> table => null;

		public static Engine.ViewType GetBusyEffectId(Engine.ViewType runEffectId)
		{
			return default(Engine.ViewType);
		}
	}
}
