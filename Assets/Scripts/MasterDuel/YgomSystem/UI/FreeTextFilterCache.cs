using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class FreeTextFilterCache : MonoBehaviour
	{
		private static FreeTextFilterCache s_Instance;

		private List<FreeTextFilter> m_ReferencedFilteres;

		private List<string> m_CachedFreeTexts;

		private Dictionary<string, string> m_FilteredTextMap;

		private Dictionary<string, List<FreeTextFilter>> m_FilterRequests;

		private readonly int k_CacheReleaseLine;

		private readonly int k_CacheReleaseCount;

		public IReadOnlyList<FreeTextFilter> referencedFilteres => null;

		public IReadOnlyList<string> cachedFreeTexts => null;

		public IReadOnlyDictionary<string, string> filteredTextMap => null;

		private static FreeTextFilterCache GetInstance()
		{
			return null;
		}

		private static void DestroyInstance()
		{
		}

		public static FreeTextFilterCache AssignReference(FreeTextFilter freeTextFilter)
		{
			return null;
		}

		public void RemoveReference(FreeTextFilter freeTextFilter)
		{
		}

		public void RequestFilter(FreeTextFilter owner, string freeText)
		{
		}

		private void ExecuteFilterAsync(string freeText)
		{
		}
	}
}
