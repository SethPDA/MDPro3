using System.Collections.Generic;

namespace YgomGame.Menu.Common
{
	public interface IAsyncProgressContainer
	{
		IReadOnlyList<IAsyncProgressContent> asyncProgressContents { get; }
	}
}
