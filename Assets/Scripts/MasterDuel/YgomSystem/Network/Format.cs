using System;
using System.Collections.Generic;

namespace YgomSystem.Network
{
	public abstract class Format
	{
		protected static Format _singleInstance;

		public static Format GetInstance()
		{
			return null;
		}

		public abstract byte[] Serialize(Dictionary<string, object> dict, byte[] token);

		public abstract Dictionary<string, object> Deserialize(byte[] bin);

		public abstract void DeserializeAsync(byte[] bin, Action<Dictionary<string, object>> onfinish);
	}
}
