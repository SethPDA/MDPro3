using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public interface IContext
	{
		string label { get; }

		void Import(object jsonData);

		void SearchDependencieTextGroups(List<string> resultList);
	}
}
