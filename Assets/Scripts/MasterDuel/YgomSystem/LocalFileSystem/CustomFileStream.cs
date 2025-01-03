using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace YgomSystem.LocalFileSystem
{
	public class CustomFileStream : Stream
	{
		[Flags]
		private enum Access
		{
			Readable = 1,
			Writable = 2
		}

		protected IFileHandler m_file;

		private string m_nativePath;

		private long m_seek;

		protected long m_dataLength;

		private byte[] m_temp1ByteArray;

		private object m_syncObject;

		private Access m_access;

		private bool isReadable => false;

		private bool isWritable => false;

		public string nativePath => null;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long Length => 0L;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override bool CanRead => false;

		public override bool CanTimeout => false;

		public override int ReadTimeout
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override int WriteTimeout
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected CustomFileStream(string nativePath, StreamOpenMode openMode, IFileHandler fileHandler)
		{
		}

		~CustomFileStream()
		{
		}

		public static CustomFileStream Create<T>(string nativePath, StreamOpenMode openMode) where T : IFileHandler, new()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override void Write(byte[] data, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void Flush()
		{
		}

		public override void SetLength(long value)
		{
		}
	}
}
