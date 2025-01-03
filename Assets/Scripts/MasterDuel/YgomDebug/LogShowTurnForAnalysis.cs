using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowTurnForAnalysis : LogItemBaseForAnalysis
	{
		public static int SINGALCHARWIDTH;

		public static string TEXT_TURN;

		protected string LABEL_EO_PLAERICON;

		[SerializeField]
		protected string m_Label_FaceIconL;

		[SerializeField]
		protected string m_Label_FaceIconR;

		[SerializeField]
		protected string m_Label_FaceIcon;

		[SerializeField]
		protected string m_Label_FaceIconCursor;

		[SerializeField]
		protected string m_Label_LPValueL;

		[SerializeField]
		protected string m_Label_LPValueR;

		[SerializeField]
		protected string m_Label_TurnText;

		[SerializeField]
		protected string m_Label_TurnBg;

		[SerializeField]
		protected Color m_Color_Team0;

		[SerializeField]
		protected Color m_Color_Team1;

		protected int m_IconIDL;

		protected int m_IconIDR;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowTurnDataForAnalysis data)
		{
		}

		protected void SetFaceIcon(int playerid, GameObject root)
		{
		}

		protected void SetLP(string lplabel, int value)
		{
		}

		protected void SetTurn(int value, int playerid)
		{
		}
	}
}
