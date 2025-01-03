using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Win32
{
	public static class FileApi
	{
		public enum DesiredAccess : uint
		{
			GENERIC_ALL = 0x10000000u,
			GENERIC_EXECUTE = 0x20000000u,
			GENERIC_WRITE = 0x40000000u,
			GENERIC_READ = 0x80000000u
		}

		public enum ShareMode : uint
		{
			FILE_SHARE_NONE = 0u,
			FILE_SHARE_READ = 1u,
			FILE_SHARE_WRITE = 2u,
			FILE_SHARE_DELETE = 4u
		}

		public enum CreationDisposition : uint
		{
			CREATE_NEW = 1u,
			CREATE_ALWAYS = 2u,
			OPEN_EXISTING = 3u,
			OPEN_ALWAYS = 4u,
			TRUNCATE_EXISTING = 5u
		}

		public enum FlagsAndAttributes : uint
		{
			FILE_ATTRIBUTE_READONLY = 1u,
			FILE_ATTRIBUTE_HIDDEN = 2u,
			FILE_ATTRIBUTE_SYSTEM = 4u,
			FILE_ATTRIBUTE_DIRECTORY = 16u,
			FILE_ATTRIBUTE_ARCHIVE = 32u,
			FILE_ATTRIBUTE_DEVICE = 64u,
			FILE_ATTRIBUTE_NORMAL = 128u,
			FILE_ATTRIBUTE_TEMPORARY = 256u,
			FILE_ATTRIBUTE_SPARSE_FILE = 512u,
			FILE_ATTRIBUTE_REPARSE_POINT = 1024u,
			FILE_ATTRIBUTE_COMPRESSED = 2048u,
			FILE_ATTRIBUTE_OFFLINE = 4096u,
			FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u,
			FILE_ATTRIBUTE_ENCRYPTED = 16384u,
			FILE_ATTRIBUTE_VIRTUAL = 65536u,
			FILE_ATTRIBUTE_VALID_FLAGS = 32695u,
			FILE_ATTRIBUTE_VALID_SET_FLAGS = 12711u,
			FILE_FLAG_OVERLAPPED = 1073741824u
		}

		public enum SeekOrigin : uint
		{
			FILE_BEGIN = 0u,
			FILE_CURRENT = 1u,
			FILE_END = 2u
		}

		[StructLayout(2)]
		internal struct LARGE_INTEGER
		{
			//[FieldOffset(0)]
			//internal int LowPart;

			//[FieldOffset(4)]
			//internal int HighPart;

			//[FieldOffset(0)]
			//internal long QuadPart;
		}

		[PreserveSig]
		internal static extern SafeFileHandle CreateFile(string lpFileName, DesiredAccess dwDesiredAccess, ShareMode dwShareMode, IntPtr lpSecurityAttributess, CreationDisposition dwCreationDisposition, FlagsAndAttributes dwFlagsAndAttributes, SafeFileHandle hTemplateFile);

		[PreserveSig]
		internal static extern bool WriteFile(SafeFileHandle handle, byte[] bytes, int numBytesToWrite, out int numBytesWrite, IntPtr overlapped_MustBeZero);

		[PreserveSig]
		internal static extern bool ReadFile(SafeFileHandle handle, byte[] buffer, int numBytesToRead, out int numBytesRead, IntPtr overlapped_MustBeZero);

		[PreserveSig]
		internal static extern bool GetFileSizeEx(SafeFileHandle hFile, ref LARGE_INTEGER lpFileSize);

		[PreserveSig]
		internal static extern bool SetFilePointerEx(SafeFileHandle hFile, LARGE_INTEGER liDistanceToMove, ref LARGE_INTEGER lpNewFilePointer, SeekOrigin dwMoveMethod);

		[PreserveSig]
		internal static extern bool SetEndOfFile(SafeFileHandle hFile);

		[PreserveSig]
		internal static extern bool FlushFileBuffers(SafeFileHandle hFile);
	}
}
