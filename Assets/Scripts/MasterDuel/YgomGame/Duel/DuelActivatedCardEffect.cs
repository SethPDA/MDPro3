using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class DuelActivatedCardEffect
	{
		private static Dictionary<int, List<int>> myActivatedCardEffectNoDict;

		private static Dictionary<int, List<int>> rivalActivatedCardEffectNoDict;

		private static bool myCardActivated;

		private static bool rivalCardActivated;

		public static bool showingActivatedIconCardEffectTextByButton;

		public static int uIdActivatedIconCardEffectTextByButton;

		public static void CutinActivate(int player)
		{
		}

		public static void CardHappen(int cardId, int efxNo)
		{
		}

		public static void EffectTaskRunDialog(int cardId, int efxNo, int player)
		{
		}

		public static void SetShowActivatedIconCardEffectTextByButton(bool show)
		{
		}

		public static void SetUniqueIdActivatedIconCardEffectTextByButton(int uId)
		{
		}

		public static bool CheckActivatedCardEffectNo(int cardId, int owner)
		{
			return false;
		}

		public static List<int> GetActivatedCardEffectNo(int cardId, int owner)
		{
			return null;
		}

		private static void AddActivatedCardEffectNoDict(Dictionary<int, List<int>> activatedCardEffectNoDict, int cardId, int efxNo)
		{
		}

		public static void InitActivatedCardEffectDict()
		{
		}

		public static void ResetActivatedCardEffectDictValue()
		{
		}
	}
}
