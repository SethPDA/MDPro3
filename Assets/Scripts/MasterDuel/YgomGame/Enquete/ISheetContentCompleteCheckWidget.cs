using System;

namespace YgomGame.Enquete
{
	public interface ISheetContentCompleteCheckWidget
	{
		bool isInputComplete { get; }

		event Action onChangeComplete;
	}
}
