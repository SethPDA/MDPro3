using System;
using System.Collections.Generic;

namespace YgomSystem.Network
{
	public class FormatYgom : Format
	{
		public override byte[] Serialize(Dictionary<string, object> dict, byte[] token)
		{
			return null;
		}

		public override Dictionary<string, object> Deserialize(byte[] bin)
		{
			return null;
		}

		public override void DeserializeAsync(byte[] bin, Action<Dictionary<string, object>> onfinish)
		{
		}
	}
}
