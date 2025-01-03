using System.IO;

namespace YgomSystem.Hash
{
	public class CRC32
	{
		private static readonly uint[] CRC32Table;

		private static readonly int CHAR_BIT;

		private static readonly int CHUNK_SIZE;

		private static uint GetMemCRC32(uint crc32, byte[] data, int size)
		{
			return 0u;
		}

		public static uint GetBinaryStreamCRC32(BinaryReader br)
		{
			return 0u;
		}

		public static uint GetStringCRC32(string str)
		{
			return 0u;
		}

		public static uint GetBinaryCRC32(byte[] data)
		{
			return 0u;
		}
	}
}
