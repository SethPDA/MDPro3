using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustThirdPartySharing
	{
		internal bool? isEnabled;

		internal Dictionary<string, List<string>> granularOptions;

		public AdjustThirdPartySharing(bool? isEnabled)
		{
		}

		public void addGranularOption(string partnerName, string key, string value)
		{
		}
	}
}
