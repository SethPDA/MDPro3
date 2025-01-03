using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MiniMessagePack
{
	public class MiniMessagePacker
	{
		private byte[] tmp0;

		private byte[] tmp1;

		private byte[] string_buf;

		private Encoding encoder;

		public byte[] Pack(object o)
		{
			return null;
		}

		public void Pack(Stream s, object o)
		{
		}

		private void PackNull(Stream s)
		{
		}

		private void Pack(Stream s, IList list)
		{
		}

		private void Pack(Stream s, IDictionary dict)
		{
		}

		private void Pack(Stream s, bool val)
		{
		}

		private void Pack(Stream s, sbyte val)
		{
		}

		private void Pack(Stream s, byte val)
		{
		}

		private void Pack(Stream s, short val)
		{
		}

		private void Pack(Stream s, ushort val)
		{
		}

		private void Pack(Stream s, int val)
		{
		}

		private void Pack(Stream s, uint val)
		{
		}

		private void Pack(Stream s, long val)
		{
		}

		private void Pack(Stream s, ulong val)
		{
		}

		private void Pack(Stream s, float val)
		{
		}

		private void Pack(Stream s, double val)
		{
		}

		private void Pack(Stream s, string val)
		{
		}

		private void Write(Stream s, ushort val)
		{
		}

		private void Write(Stream s, uint val)
		{
		}

		private void Write(Stream s, ulong val)
		{
		}

		public object Unpack(byte[] buf, int offset, int size)
		{
			return null;
		}

		public object Unpack(byte[] buf)
		{
			return null;
		}

		public object Unpack(Stream s)
		{
			return null;
		}

		private long UnpackUint16(Stream s)
		{
			return 0L;
		}

		private long UnpackUint32(Stream s)
		{
			return 0L;
		}

		private string UnpackString(Stream s, long len)
		{
			return null;
		}

		private byte[] UnpackBinary(Stream s, long len)
		{
			return null;
		}

		private List<object> UnpackArray(Stream s, long len)
		{
			return null;
		}

		private Dictionary<string, object> UnpackMap(Stream s, long len)
		{
			return null;
		}
	}
}
