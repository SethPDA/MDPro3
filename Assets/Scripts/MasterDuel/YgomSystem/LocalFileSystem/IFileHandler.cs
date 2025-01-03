using System.IO;

namespace YgomSystem.LocalFileSystem
{
	public interface IFileHandler
	{
		bool isValid { get; }

		bool Open(string nativePath, StreamOpenMode openMode);

		void Close();

		int Write(byte[] data, int offset, int count);

		int Read(byte[] buffer, int offset, int count);

		long Seek(long offset, SeekOrigin origin);

		long GetSeek();

		long GetSize();

		long SetSize(long size);

		bool Flush();
	}
}
