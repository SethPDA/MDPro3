using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu
{
	public abstract class InformDialogViewControllerBase : DialogViewControllerBase
	{
		protected static void InnerOpen(string prefabPath, Dictionary<string, object> args = null)
		{
		}

		protected static void InnerOpen(GameObject prefab, Dictionary<string, object> args = null)
		{
		}
	}
	public abstract class InformDialogViewControllerBase<ARG> : InformDialogViewControllerBase
	{
		protected const string k_DefaultArgkey1 = "arg1";

		protected virtual ARG arg1 => default(ARG);

		protected static void InnerOpen(string prefabPath, ARG arg, Dictionary<string, object> args = null)
		{
		}

		protected static void InnerOpen(GameObject prefab, ARG arg, Dictionary<string, object> args = null)
		{
		}
	}
	public abstract class InformDialogViewControllerBase<ARG1, ARG2> : InformDialogViewControllerBase<ARG1>
	{
		protected const string k_DefaultArgkey2 = "arg2";

		protected virtual ARG2 arg2 => default(ARG2);

		protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, Dictionary<string, object> args = null)
		{
		}

		protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, Dictionary<string, object> args = null)
		{
		}

		protected InformDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<>)(object)this)._002Ector();
		}
	}
	public abstract class InformDialogViewControllerBase<ARG1, ARG2, ARG3> : InformDialogViewControllerBase<ARG1, ARG2>
	{
		protected const string k_DefaultArgkey3 = "arg3";

		protected virtual ARG3 arg3 => default(ARG3);

		protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, ARG3 arg3, Dictionary<string, object> args = null)
		{
		}

		protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, ARG3 arg3, Dictionary<string, object> args = null)
		{
		}

		protected InformDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<, >)(object)this)._002Ector();
		}
	}
	public abstract class InformDialogViewControllerBase<ARG1, ARG2, ARG3, ARG4> : InformDialogViewControllerBase<ARG1, ARG2, ARG3>
	{
		protected const string k_DefaultArgkey4 = "arg4";

		protected virtual ARG4 arg4 => default(ARG4);

		protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, ARG3 arg3, ARG4 arg4, Dictionary<string, object> args = null)
		{
		}

		protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, ARG3 arg3, ARG4 arg4, Dictionary<string, object> args = null)
		{
		}

		protected InformDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<, , >)(object)this)._002Ector();
		}
	}
}
