using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class CardStatusLabel3DSetting : ScriptableObject
	{
		private static CardStatusLabel3DSetting m_Instance;

		private const string PATH = "Duel/ScriptableObject/CardStatusLabel3DSetting";

		[SerializeField]
		private int m_FontSize_Active;

		[SerializeField]
		private int m_FontSize_Inactive;

		[SerializeField]
		private int m_FontSize_Slash;

		[SerializeField]
		private int m_FontSizeForMobile_Active;

		[SerializeField]
		private int m_FontSizeForMobile_Inactive;

		[SerializeField]
		private int m_FontSizeForMobile_Slash;

		[SerializeField]
		private Color m_FontColor_Normal;

		[SerializeField]
		private Color m_FontColor_Changed;

		[SerializeField]
		private Color m_FontColor_Slash;

		[SerializeField]
		private Color m_FontColor_Up;

		[SerializeField]
		private Color m_FontColor_UpLight;

		[SerializeField]
		private Color m_FontColor_Down;

		[SerializeField]
		private Color m_FontColor_DownLight;

		[SerializeField]
		private float m_FadeSpeed;

		[SerializeField]
		private float m_BrightInactive;

		protected static CardStatusLabel3DSetting Instance => null;

		public static int FontSize_Active => 0;

		public static int FontSize_Inactive => 0;

		public static int FontSize_Slash => 0;

		public static int FontSizeForMobile_Active => 0;

		public static int FontSizeForMobile_Inactive => 0;

		public static int FontSizeForMobile_Slash => 0;

		public static Color FontColor_Normal => default(Color);

		public static Color FontColor_Changed => default(Color);

		public static Color FontColor_Up => default(Color);

		public static Color FontColor_UpLight => default(Color);

		public static Color FontColor_Down => default(Color);

		public static Color FontColor_DownLight => default(Color);

		public static Color FontColor_Slash => default(Color);

		public static float FadeSpeed => 0f;

		public static float BrightInactive => 0f;
	}
}
