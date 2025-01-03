using System;
using System.IO;
using System.Threading.Tasks;

namespace YgomSystem.LocalFileSystem
{
	public class LocalFileStream : IDisposable
	{
		private Stream m_ioStream;

		private FileLocation m_location;

		private string m_nativePath;

		private StreamOpenMode m_openMode;

		private ReadRequest m_asyncReadRequest;

		public string nativePath => null;

		public StreamOpenMode openMode => default(StreamOpenMode);

		public Stream ioStream => null;

		public long Position => 0L;

		public long Length => 0L;

		public long Remain => 0L;

		private LocalFileStream()
		{
		}

		private void initialize(string _nativePath, FileLocation _location, StreamOpenMode _openMode)
		{
		}

		private void openStreamByLocation(Storage _storage, string _name, FileNameType _nameType, StreamOpenMode _openMode)
		{
		}

		private void openStreamByNativePath(string _nativePath, StreamOpenMode _openMode)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~LocalFileStream()
		{
		}

		public LocalFileStream(Storage storage, string name, FileNameType nameType, StreamOpenMode openMode)
		{
		}

		public LocalFileStream(Storage storage, string name, StreamOpenMode openMode)
		{
		}

		public LocalFileStream(FileLocation location, StreamOpenMode openMode)
		{
		}

		public LocalFileStream(string nativePath, StreamOpenMode openMode)
		{
		}

		public FileLocation GetLocation()
		{
			return default(FileLocation);
		}

		public void Write(byte[] data, int offset, int count)
		{
		}

		public Task WriteAsync(byte[] data, int offset, int count)
		{
			return null;
		}

		public void WriteAsyncCallback(byte[] data, int offset, int count, Action finishCallback, Action<Exception> errorCallback)
		{
		}

		public void WriteAllBytes(byte[] writeData)
		{
		}

		public Task WriteAllBytesAsync(byte[] writeData)
		{
			return null;
		}

		public void WriteAllBytesCallback(byte[] writeData, Action finishCallback, Action<Exception> errorCallback)
		{
		}

		public void WriteByte(byte data)
		{
		}

		public void WriteShort(short val)
		{
		}

		public void WriteUShort(ushort val)
		{
		}

		public void WriteInt(int val)
		{
		}

		public void WriteUInt(uint val)
		{
		}

		public void WriteLong(long val)
		{
		}

		public void WriteULong(ulong val)
		{
		}

		public void WriteFloat(float val)
		{
		}

		public void WriteDouble(double val)
		{
		}

		public void WriteBool(bool val)
		{
		}

		public void WriteChar(char val)
		{
		}

		public void WriteString(string str)
		{
		}

		public void Fill(byte data, int count)
		{
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return null;
		}

		public void ReadAsyncCallback(byte[] buffer, int offset, int count, Action<int> finishCallback, Action<Exception> errorCallback)
		{
		}

		public byte[] ReadBytes(int count = 0)
		{
			return null;
		}

		public byte[] ReadAllBytes()
		{
			return null;
		}

		public Task<byte[]> ReadAllBytesAsync()
		{
			return null;
		}

		public void ReadAllBytesCallback(Action<byte[]> finishCallback, Action<Exception> errorCallback)
		{
		}

		public ReadRequest RequestReadAllBytes()
		{
			return null;
		}

		private T readType<T>(Func<byte[], int, T> bitConverter, int sizeOfType) where T : struct
		{
			return default(T);
		}

		public byte ReadByte()
		{
			return 0;
		}

		public short ReadShort()
		{
			return 0;
		}

		public ushort ReadUShort()
		{
			return 0;
		}

		public int ReadInt()
		{
			return 0;
		}

		public uint ReadUInt()
		{
			return 0u;
		}

		public long ReadLong()
		{
			return 0L;
		}

		public ulong ReadULong()
		{
			return 0uL;
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public bool ReadBool()
		{
			return false;
		}

		public char ReadChar()
		{
			return '\0';
		}

		public string ReadString()
		{
			return null;
		}

		private bool tryReadType<T>(Func<T> reader, out T result) where T : struct
		{
			result = default(T);
			return false;
		}

		public bool TryReadByte(out byte result)
		{
			result = default(byte);
			return false;
		}

		public bool TryReadShort(out short result)
		{
			result = default(short);
			return false;
		}

		public bool TryReadUShort(out ushort result)
		{
			result = default(ushort);
			return false;
		}

		public bool TryReadInt(out int result)
		{
			result = default(int);
			return false;
		}

		public bool TryReadUInt(out uint result)
		{
			result = default(uint);
			return false;
		}

		public bool TryReadLong(out long result)
		{
			result = default(long);
			return false;
		}

		public bool TryReadULong(out ulong result)
		{
			result = default(ulong);
			return false;
		}

		public bool TryReadFloat(out float result)
		{
			result = default(float);
			return false;
		}

		public bool TryReadDouble(out double result)
		{
			result = default(double);
			return false;
		}

		public bool TryReadBool(out bool result)
		{
			result = default(bool);
			return false;
		}

		public bool TryReadChar(out char result)
		{
			result = default(char);
			return false;
		}

		public bool TryReadString(out string result)
		{
			result = null;
			return false;
		}

		public long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public void Head()
		{
		}

		public void Tail()
		{
		}

		public void Flush()
		{
		}

		public Task FlushAsync()
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
