using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Enquete
{
	public abstract class ContextBase : IContext
	{
		public string label
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ContextBase()
		{
		}

		public ContextBase(object jsonData)
		{
		}

		public virtual void Import(object jsonData)
		{
		}

		public virtual void CopyTo(ContextBase target)
		{
		}

		public abstract void SearchDependencieTextGroups(List<string> resultList);
	}
}
