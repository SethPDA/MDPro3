using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.DuelLive
{
	public class ProductContextCollection<T> : List<T>//, IProductContextCollection where T : IProductContext, new()
	{
		public readonly List<T> m_ImportedContexts;

		private readonly List<int> m_ImportedSubCategories;

		public readonly List<IDuelLiveProductGruopData> lockedGroups;

		public int filterSubId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isDisplayEmpty => false;

		public List<int> subCategories => null;

		public IReadOnlyList<IProductContext> importedContexts => null;

		private List<IDuelLiveProductGruopData> YgomGame_002EDuelLive_002EIProductContextCollection_002ElockedGroups => null;

		private IProductContext YgomGame_002EDuelLive_002EIProductContextCollection_002EItem => null;

		public event Action onUpdatedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool IsEmpty()
		{
			return false;
		}

		public ProductContextCollection()
		{
			//((List<T>)(object)this)._002Ector();
		}

		public void Import(Dictionary<string, object> productDatas)
		{
		}

		public void Filter()
		{
		}
	}
}
