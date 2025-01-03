namespace YgomSystem.LocalFileSystem
{
	public class ReadRequest
	{
		public enum Status
		{
			None = 0,
			Working = 1,
			Success = 2,
			Error = 3
		}

		public Status status;

		public byte[] readData;

		public bool isReading => false;

		public bool isSuccess => false;
	}
}
