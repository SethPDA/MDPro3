using System.Collections.Generic;

namespace YgomSystem.UI
{
	public interface IBindingModifiyByArgsHandler
	{
		void OnPostModifiyByArgs(Dictionary<string, object> args);
	}
}
