using System;

namespace YgomSystem.LocalFileSystem
{
	public class UndefinedStorageException : Exception
	{
		public UndefinedStorageException(int value, string appendMessage = "")
		{
		}
	}
}
