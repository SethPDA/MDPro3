namespace LZ4ps
{
	public static class LZ4Codec
	{
		private class LZ4HC_Data_Structure
		{
			public byte[] src;

			public int src_base;

			public int src_end;

			public int src_LASTLITERALS;

			public byte[] dst;

			public int dst_base;

			public int dst_len;

			public int dst_end;

			public int[] hashTable;

			public ushort[] chainTable;

			public int nextToUpdate;
		}

		private const int MEMORY_USAGE = 14;

		private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;

		private const int BLOCK_COPY_LIMIT = 16;

		private const int MINMATCH = 4;

		private const int SKIPSTRENGTH = 6;

		private const int COPYLENGTH = 8;

		private const int LASTLITERALS = 5;

		private const int MFLIMIT = 12;

		private const int MINLENGTH = 13;

		private const int MAXD_LOG = 16;

		private const int MAXD = 65536;

		private const int MAXD_MASK = 65535;

		private const int MAX_DISTANCE = 65535;

		private const int ML_BITS = 4;

		private const int ML_MASK = 15;

		private const int RUN_BITS = 4;

		private const int RUN_MASK = 15;

		private const int STEPSIZE_64 = 8;

		private const int STEPSIZE_32 = 4;

		private const int LZ4_64KLIMIT = 65547;

		private const int HASH_LOG = 12;

		private const int HASH_TABLESIZE = 4096;

		private const int HASH_ADJUST = 20;

		private const int HASH64K_LOG = 13;

		private const int HASH64K_TABLESIZE = 8192;

		private const int HASH64K_ADJUST = 19;

		private const int HASHHC_LOG = 15;

		private const int HASHHC_TABLESIZE = 32768;

		private const int HASHHC_ADJUST = 17;

		private static readonly int[] DECODER_TABLE_32;

		private static readonly int[] DECODER_TABLE_64;

		private static readonly int[] DEBRUIJN_TABLE_32;

		private static readonly int[] DEBRUIJN_TABLE_64;

		private const int MAX_NB_ATTEMPTS = 256;

		private const int OPTIMAL_ML = 18;

		private static void Assert(bool condition, string errorMessage)
		{
		}

		internal static void Poke2(byte[] buffer, int offset, ushort value)
		{
		}

		internal static ushort Peek2(byte[] buffer, int offset)
		{
			return 0;
		}

		internal static uint Peek4(byte[] buffer, int offset)
		{
			return 0u;
		}

		private static uint Xor4(byte[] buffer, int offset1, int offset2)
		{
			return 0u;
		}

		private static ulong Xor8(byte[] buffer, int offset1, int offset2)
		{
			return 0uL;
		}

		private static bool Equal2(byte[] buffer, int offset1, int offset2)
		{
			return false;
		}

		private static bool Equal4(byte[] buffer, int offset1, int offset2)
		{
			return false;
		}

		private static void Copy4(byte[] buf, int src, int dst)
		{
		}

		private static void Copy8(byte[] buf, int src, int dst)
		{
		}

		private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len)
		{
		}

		private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end)
		{
			return 0;
		}

		private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end)
		{
			return 0;
		}

		public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static byte[] Encode32(byte[] input, int inputOffset, int inputLength)
		{
			return null;
		}

		public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static byte[] Encode64(byte[] input, int inputOffset, int inputLength)
		{
			return null;
		}

		public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
		{
			return 0;
		}

		public static byte[] Decode32(byte[] input, int inputOffset, int inputLength, int outputLength)
		{
			return null;
		}

		public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
		{
			return 0;
		}

		public static byte[] Decode64(byte[] input, int inputOffset, int inputLength, int outputLength)
		{
			return null;
		}

		private static LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len)
		{
			return null;
		}

		private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static byte[] Encode32HC(byte[] input, int inputOffset, int inputLength)
		{
			return null;
		}

		private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static byte[] Encode64HC(byte[] input, int inputOffset, int inputLength)
		{
			return null;
		}

		private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			return 0;
		}

		private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static void LZ4HC_Insert_32(LZ4HC_Data_Structure ctx, int src_p)
		{
		}

		private static int LZ4HC_CommonLength_32(LZ4HC_Data_Structure ctx, int p1, int p2)
		{
			return 0;
		}

		private static int LZ4HC_InsertAndFindBestMatch_32(LZ4HC_Data_Structure ctx, int src_p, ref int src_match)
		{
			return 0;
		}

		private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
		{
			return 0;
		}

		private static int LZ4_encodeSequence_32(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end)
		{
			return 0;
		}

		private static int LZ4_compressHCCtx_32(LZ4HC_Data_Structure ctx)
		{
			return 0;
		}

		private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			return 0;
		}

		private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static void LZ4HC_Insert_64(LZ4HC_Data_Structure ctx, int src_p)
		{
		}

		private static int LZ4HC_CommonLength_64(LZ4HC_Data_Structure ctx, int p1, int p2)
		{
			return 0;
		}

		private static int LZ4HC_InsertAndFindBestMatch_64(LZ4HC_Data_Structure ctx, int src_p, ref int matchpos)
		{
			return 0;
		}

		private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
		{
			return 0;
		}

		private static int LZ4_encodeSequence_64(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref)
		{
			return 0;
		}

		private static int LZ4_compressHCCtx_64(LZ4HC_Data_Structure ctx)
		{
			return 0;
		}

		public static int MaximumOutputLength(int inputLength)
		{
			return 0;
		}

		internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength)
		{
		}
	}
}
