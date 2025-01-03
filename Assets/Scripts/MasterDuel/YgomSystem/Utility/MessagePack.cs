using System.IO;
using MiniMessagePack;

namespace YgomSystem.Utility
{
	public class MessagePack
	{
		public static MiniMessagePacker packer;

		public static byte[] Pack(object o)
		{
			return null;
		}

		public void Pack(Stream s, object o)
		{
		}

		public static object Unpack(byte[] buf, int offset, int size)
		{
			return null;
		}

		public static object Unpack(byte[] buf)
		{
			return null;
		}

		public static object Unpack(Stream s)
		{
			return null;
		}
	}
}
