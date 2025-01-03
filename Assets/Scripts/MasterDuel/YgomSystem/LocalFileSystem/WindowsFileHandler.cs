using System.IO;
using Microsoft.Win32.SafeHandles;

namespace YgomSystem.LocalFileSystem
{
	public class WindowsFileHandler : IFileHandler
	{
		private static SafeFileHandle nullHandle;

		private SafeFileHandle m_handle;

		public bool isValid => false;

		static WindowsFileHandler()
		{
		}

		public bool Open(string nativePath, StreamOpenMode openMode)
		{
			return false;
		}

		public void Close()
		{
		}

		public int Write(byte[] data, int offset, int count)
		{
			return 0;
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public long GetSeek()
		{
			return 0L;
		}

		public long GetSize()
		{
			return 0L;
		}

		public long SetSize(long size)
		{
			return 0L;
		}

		public bool Flush()
		{
			return false;
		}
	}
}
