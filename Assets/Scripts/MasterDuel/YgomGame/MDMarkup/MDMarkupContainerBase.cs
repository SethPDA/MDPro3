using System;
using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public abstract class MDMarkupContainerBase// : IMDMarkupContainer
	{
		public GlobalTextData title;

		public List<IMDMarkupContent> contents;

		public abstract MDMarkupDef.ContainerType containerType { get; }

		private GlobalTextData YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Etitle => null;

		private List<IMDMarkupContent> YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Econtents => null;

		public virtual void Clear()
		{
		}

		public virtual object ExportJsonObj()
		{
			return null;
		}

		public void ImportJson(string json)
		{
		}

		public virtual void ImportJsonObj(object jsonObj)
		{
		}

		public IReadOnlyList<string> SearchUseTextGruops()
		{
			return null;
		}

		protected virtual void InnerSearchUseTextGroups(List<string> useTextGroups)
		{
		}
	}
}
