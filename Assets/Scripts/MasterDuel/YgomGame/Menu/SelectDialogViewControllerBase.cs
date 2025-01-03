using System;

namespace YgomGame.Menu
{
	public abstract class SelectDialogViewControllerBase<RESULT> : InformDialogViewControllerBase<Action<RESULT>>
	{
		protected void OnDecided(RESULT result)
		{
		}

		protected SelectDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<>)(object)this)._002Ector();
		}
	}
	public abstract class SelectDialogViewControllerBase<ARG, RESULT> : InformDialogViewControllerBase<ARG, Action<RESULT>>
	{
		protected void OnDecided(RESULT result)
		{
		}

		protected SelectDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<, >)(object)this)._002Ector();
		}
	}
	public abstract class SelectDialogViewControllerBase<ARG1, ARG2, RESULT> : InformDialogViewControllerBase<ARG1, ARG2, Action<RESULT>>
	{
		protected void OnDecided(RESULT result)
		{
		}

		protected void SendResult(RESULT result)
		{
		}

		protected SelectDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<, , >)(object)this)._002Ector();
		}
	}
	public abstract class SelectDialogViewControllerBase<ARG1, ARG2, ARG3, RESULT> : InformDialogViewControllerBase<ARG1, ARG2, ARG3, Action<RESULT>>
	{
		protected void OnDecided(RESULT result)
		{
		}

		protected SelectDialogViewControllerBase()
		{
			//((InformDialogViewControllerBase<, , , >)(object)this)._002Ector();
		}
	}
}
