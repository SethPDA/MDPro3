using System;

namespace YgomSystem.LocalFileSystem
{
	public class InvalidLocationException : Exception
	{
		public InvalidLocationException(string location, string appendMessage = "")
		{
		}
	}
}
