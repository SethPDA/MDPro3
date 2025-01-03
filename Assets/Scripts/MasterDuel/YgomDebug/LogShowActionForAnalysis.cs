using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomDebug
{
	public class LogShowActionForAnalysis : LogItemBaseForAnalysis
	{
		private const int FULLWIDTH = 320;

		private const int FULLWIDTH_WIDTH = 670;

		private const int INDENTWIDTH = 280;

		private const int INDENTWIDTH_WIDTH = 580;

		[SerializeField]
		protected Color m_Color_Team0;

		[SerializeField]
		protected Color m_Color_Team1;

		protected string LABEL_EO_CARDTEX;

		protected string LABEL_EO_CARDMASK;

		protected string LABEL_EO_CURSOR;

		protected string LABEL_EO_CTRICONL;

		protected string LABEL_EO_CTRICONR;

		protected string LABEL_EO_POSICONL;

		protected string LABEL_EO_POSICONR;

		protected string LABEL_EO_PLAYERICON;

		protected string LABEL_EO_CARDL;

		protected string LABEL_EO_CARDR;

		protected string LABEL_EO_ACTION;

		protected string LABEL_EO_ACTTEXT;

		protected string LABEL_EO_COIN;

		protected string LABEL_EO_COINICON;

		protected string LABEL_EO_DICE;

		protected string LABEL_EO_DICEICON;

		protected string LABEL_EO_ARROW;

		protected string LABEL_EO_FACEICONL;

		protected string LABEL_EO_FACEICONR;

		protected string LABEL_EO_FACEICON;

		protected string LABEL_EO_FACEICONFRAME;

		protected string LABEL_EO_LPCHANGE;

		protected string LABEL_EO_CHANGEVALUE;

		protected string LABEL_EO_RESTLP;

		protected string LABEL_EO_CHANGETYPE;

		protected string LABEL_EO_COUNTERCHANGE;

		protected string LABEL_EO_COUNTERNUMPRE;

		protected string LABEL_EO_COUNTERNUMAFT;

		protected string LABEL_EO_COUNTERTYPE;

		protected string LABEL_EO_COUNTERICON;

		protected string LABEL_EO_LINETOP;

		protected string LABEL_EO_LINEBOTTOM;

		protected string LABEL_EO_BACKGROUND;

		protected string LABEL_EO_CARDNAME;

		protected string LABEL_EO_CARDNAMELAYER;

		protected string LABEL_EO_BATTLEARROW;

		protected string LABEL_EO_COLORBARTEAM0;

		protected string LABEL_EO_COLORBARTEAM1;

		protected string LABEL_EO_CONTENT;

		protected string LABEL_EO_POSITIONICONROOT;

		protected int m_CardIdL;

		protected int m_CardIdR;

		protected static Dictionary<LOGACTIONTYPE, string> m_ActTypeStrDict;

		protected static Dictionary<Engine.DamageType, string> m_DmgTypeStrDict;

		private ElementObjectManager m_EOManager_Origin;

		protected DuelIconSprites m_IconSprites => null;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowActionDataForAnalysis data)
		{
		}

		public static void ResetWordTable()
		{
		}

		protected void SetCards(ShowActionDataForAnalysis data)
		{
		}

		protected void SetCard(LogDataSideForAnalysis data, ref int cardidpre, ElementObjectManager cardeom)
		{
		}

		protected void SetPositionIcon(ShowActionDataForAnalysis data, ElementObjectManager poseom)
		{
		}

		protected SelectionButton SetFaceIcon(LogDataSideForAnalysis data, ElementObjectManager eomface)
		{
			return null;
		}

		protected void SetAction(LogDataCenterForAnalysis data)
		{
		}

		protected void SetDiceResult(LogDataCenterForAnalysis data)
		{
		}

		protected void SetCoinResult(LogDataCenterForAnalysis data)
		{
		}

		protected void SetLPChange(LogDataCenterForAnalysis data)
		{
		}

		protected void SetCounterChange(LogDataCenterForAnalysis data)
		{
		}

		private void SetCardTexture(RawImage cardtexture, GameObject cardmask, int cardid, bool face, bool insight)
		{
		}

		protected void SetWidth(bool isIndent)
		{
		}

		protected void SetColor(bool team, bool indent)
		{
		}

		public override void OnAdded()
		{
		}

		public override void OnRemoved()
		{
		}
	}
}
