using System.Collections.Generic;

namespace YgomGame.Card
{
	public class CardPictureFontHelper
	{
		public enum Mode
		{
			Normal = 0,
			CardCheck = 1
		}

		private Dictionary<short, float> m_NormalFontSizeTable;

		private Dictionary<short, float> m_PendulumFontSizeTable;

		private const string DATAFILEPATHBASE = "Card/ScriptableObjects/#/CardPictureFontSetting";

		public const byte AUTOSIZE = 0;

		private static CardPictureFontHelper m_Instance;

		public static Mode m_Mode;

		public static void Create()
		{
		}

		public static bool GetNormalTextFontSize(int cardid, out float fontsize)
		{
			fontsize = default(float);
			return false;
		}

		public static bool GetPendulumTextFontSize(int cardid, out float fontsize)
		{
			fontsize = default(float);
			return false;
		}

		public static void LoadDataToTable()
		{
		}

		public static void ResetTable()
		{
		}

		public static void AddData(int cardid, float fontsize, bool ispendulum)
		{
		}

		public static void ClearData()
		{
		}

		public static void RewriteData()
		{
		}

		protected void Initialize()
		{
		}

		private void ClearTable()
		{
		}

		private void SetData()
		{
		}

		private bool GetNormalTextFontSizeImpl(int cardid, out float fontsize)
		{
			fontsize = default(float);
			return false;
		}

		private bool GetPendulumTextFontSizeImpl(int cardid, out float fontsize)
		{
			fontsize = default(float);
			return false;
		}
	}
}
