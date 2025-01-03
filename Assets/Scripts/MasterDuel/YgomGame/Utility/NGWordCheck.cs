using TMPro;

namespace YgomGame.Utility
{
	public class NGWordCheck
	{
		public enum ErrorType
		{
			Normal = 0,
			Error1 = 1,
			Error2 = 2
		}

		private const int lowerLimit = 3;

		private const int upperLimit = 12;

		private const int numLimit = 6;

		private const string numberRegex = "\\d";

		public static (ErrorType, string) Check(string src, TMP_FontAsset fontAsset = null)
		{
			return default((ErrorType, string));
		}

		public static string GetErrorMessage(ErrorType errorType)
		{
			return null;
		}
	}
}
