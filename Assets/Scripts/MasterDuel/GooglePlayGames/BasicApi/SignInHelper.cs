namespace GooglePlayGames.BasicApi
{
	public class SignInHelper
	{
		private static int True;

		private static int False;

		private const string PromptSignInKey = "prompt_sign_in";

		public static SignInStatus ToSignInStatus(int code)
		{
			return default(SignInStatus);
		}

		public static void SetPromptUiSignIn(bool value)
		{
		}

		public static bool ShouldPromptUiSignIn()
		{
			return false;
		}
	}
}
