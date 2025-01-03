using System;

namespace YgomGame.Menu
{
	public interface IConfirmSupported
	{
		void ConfirmDialog(Action action, bool isback);
	}
}
