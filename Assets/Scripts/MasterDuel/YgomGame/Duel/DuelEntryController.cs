using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomSystem.Timeline;

namespace YgomGame.Duel
{
	public class DuelEntryController
	{
		private class MatchingUIPrepareFlag
		{
			private bool nomatching;

			private bool lightready;

			private byte mateloadedcount;

			public bool isReady => false;

			public void LightLoaded()
			{
			}

			public void MateLoaded()
			{
			}

			public void NoMatching()
			{
			}
		}

		private const string LABEL_TIMELINE_DUELENTRYPVP = "Duel/Timeline/Duel/Universal/DuelEntry/DuelEntry";

		private const string LABEL_TIMELINE_DUELENTRYPVP_TEAM = "Duel/Timeline/Duel/Universal/DuelEntry/DuelEntryTeam";

		private const string LABEL_TIMELINE_DUELENTRYSOLO = "Prefabs/Solo/SoloTransition/SoloTransitonDuelEntry";

		private PlayableDirector m_Director;

		private LabeledPlayableController m_LPController;

		private Character m_MateActorNear;

		private Character m_MateActorFar;

		private DuelEntryMode m_Mode;

		private bool m_MotionPlayed;

		private bool m_DuelStartCameraCreated;

		private bool m_Cancelled;

		private string m_MatepathNear;

		private string m_MatepathFar;

		private string m_AddEventLabel;

		private GameObject m_LightTemplate;

		private MatchingUIPrepareFlag m_MatchingUIPreapareFlag;

		private GameObject m_BackPlane;

		public UnityAction onTimelineStop;

		public bool IsAlive => false;

		public static DuelEntryController Create(DuelEntryMode mode)
		{
			return null;
		}

		private void Initialize(DuelEntryMode mode)
		{
		}

		private void SetBaseTimelineEvent()
		{
		}

		public void Release()
		{
		}

		private IEnumerator DuelEntryPlayCoroutine()
		{
			return null;
		}

		public void OnLoadEnd()
		{
		}

		public void OnFirstMoveDecide()
		{
		}

		private void PlayTimeline()
		{
		}

		private void PrepareMatchingUI()
		{
		}

		private void PrepareLight()
		{
		}

		private void PrepareMate()
		{
		}

		private void MateInitialize(Character mateActor, int mateid, string matepath, bool isnear)
		{
		}

		private int GetMateId(bool isnear)
		{
			return 0;
		}

		private void CreateLight(int playerId)
		{
		}

		private void SetTeamCard()
		{
		}

		private int GetTeamMrk(int myid)
		{
			return 0;
		}

		private void SetFlyingCard()
		{
		}

		private void SetExTimelineEvent()
		{
		}
	}
}
