using System;

namespace YgomSystem.UI
{
	public interface ILoadingIconHandler
	{
		bool visible { get; }

		event Action onReloadEvent;

		bool IsDone();
	}
}
