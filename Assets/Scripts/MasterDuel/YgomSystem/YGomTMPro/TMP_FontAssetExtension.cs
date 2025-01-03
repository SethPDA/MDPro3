using System.Collections.Generic;
using TMPro;

namespace YgomSystem.YGomTMPro
{
	public static class TMP_FontAssetExtension
	{
		public static bool CheckClearDynamicGriph(this TMP_FontAsset self)
		{
			return false;
		}

		public static void SearchDependencieFonts(this TMP_FontAsset self, List<TMP_FontAsset> searchList)
		{
		}

		public static bool TryAddCharactersDependencies(this TMP_FontAsset self, List<TMP_FontAsset> searchList, string characters)
		{
			return false;
		}
	}
}
