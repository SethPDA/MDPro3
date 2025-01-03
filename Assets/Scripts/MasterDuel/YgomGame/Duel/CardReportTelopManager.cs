using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Stats;

namespace YgomGame.Duel
{
	public class CardReportTelopManager : MonoBehaviour
	{
		private class CardReportTelopTask
		{
			public int cardid;

			public List<CardStatsData> datas;

			public bool testflag;

			public CardReportTelopTask(int cardid, bool fortest = false)
			{
			}
		}

		private DuelClient m_Host;

		private const string PREHAB_PATH = "Prefabs/Duel/UI/CardReportTelop";

		private const int MAX_TELOP_COUNT = 5;

		private Queue<CardReportTelopTask> m_TaskQueue;

		private List<CardReportTelopController> m_TelopList;

		private CardReportTelopTask m_CurrentTask;

		private List<int> m_History;

		[SerializeField]
		private int m_Duration;

		private bool isProcessing => false;

		public static void Create(DuelClient host, Transform parent, UnityAction<CardReportTelopManager> onFinish)
		{
		}

		private void Initialize(DuelClient host, Transform parent, UnityAction<CardReportTelopManager> onFinish)
		{
		}

		private void Update()
		{
		}

		public void AddCardReportTelopTask(int cardid)
		{
		}

		public void HideTelopEffect()
		{
		}
	}
}
