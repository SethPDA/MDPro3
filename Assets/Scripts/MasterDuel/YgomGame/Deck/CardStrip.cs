using System.Collections.Generic;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class CardStrip : DeckEditCard
	{
		private ExtendedTextMeshProUGUI m_CardInventory;

		private Image m_InDeckIndicatorRental;

		private Image m_InDeckIndicator1;

		private Image m_InDeckIndicator2;

		private Image m_InDeckIndicator3;

		private int inDeckR;

		private int inDeckN;

		private int inDeckP1;

		private int inDeckP2;

		private List<Image> m_IndicatorsR;

		private List<Image> m_IndicatorsN;

		private List<Image> m_IndicatorsP1;

		private List<Image> m_IndicatorsP2;

		private int inDeckAlterR;

		private int inDeckAlterN;

		private int inDeckAlterP1;

		private int inDeckAlterP2;

		private List<Image> m_IndicatorsAlterR;

		private List<Image> m_IndicatorsAlterN;

		private List<Image> m_IndicatorsAlterP1;

		private List<Image> m_IndicatorsAlterP2;

		private bool isIni;

		protected new void InitializeElemnts()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetCardInventory(bool nonPrizeOnly = false)
		{
		}

		public void SetCardInventory(int num)
		{
		}

		public void SetInDeckSum(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numRental, int alterR)
		{
		}

		private void AdjustIndicator(int oldNum, int newNum, List<Image> list, Image template, bool isAlter = false)
		{
		}

		public void SetInDeckIndicatorColor(bool isFull)
		{
		}

		public override void SetData(CardBaseData baseData, int regulationID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
		{
		}

		public new void ScalingIcons(float scale = 1.5f)
		{
		}

		public SelectionItem GetSelectionItem()
		{
			return null;
		}
	}
}
