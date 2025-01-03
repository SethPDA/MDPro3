using System.Collections.Generic;

namespace KonamiCommonIAB
{
	public class IabDelegate
	{
		public delegate void OnInitializationFinishedDelegate(bool result);

		public delegate void OnGetItemDetailsFinished(Result result, List<ProductInfo> details);

		public delegate void OnGetItemProductDetailsFinished(Result result, List<ProductInfo> details);

		public delegate void OnBuyFinishedDelegate(Result result, Purchase purchase);

		public delegate void OnAcknowledgeFinishedDelegate(Result result);
	}
}
