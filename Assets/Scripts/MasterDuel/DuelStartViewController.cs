using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

public class DuelStartViewController : BaseMenuViewController
{
	protected enum Step
	{
		START = 0,
		INIT = 1,
		WAIT_DUELRESOURCEDONE = 2,
		WAIT_INIT = 3,
		PLAYER_APPEAR = 4,
		WAIT_PLAYER_APPEAR = 5,
		COIN_TOSS = 6,
		WAIT_COIN_TOSS = 7,
		SELECT_TURN = 8,
		WAIT_SELECT_TURN = 9,
		DISP_SELECTED = 10,
		DUEL_BEGIN = 11,
		WAIT_FINAL = 12,
		END = 13,
		ERROR = 14
	}

	internal class PlayerSet
	{
		private readonly string IMG_ICON_LABEL;

		private readonly string IMG_RANK_LABEL;

		private readonly string IMG_LINE_LABEL;

		private readonly string IMG_DLV_LABEL;

		private readonly string PLATFORM_NAME_LABEL;

		private readonly string PLATFORM_ICON_LABEL;

		private readonly string ROOT_RANKUP_LABEL;

		private readonly string TXT_RANKUP_LABEL;

		private readonly string ROOT_RANKDOWN_LABEL;

		private readonly string TXT_RANKDOWN_LABEL;

		private readonly string ROOT_RANK_LABEL;

		private readonly string ROOT_PROFILE_LABEL;

		private readonly string DECK_CASE_LABEL;

		private readonly GameObject root;

		private readonly bool isPlayer;

		internal bool isLoading;

		internal Character2D chara;

		internal bool canChoice;

		internal int myid;

		internal Util.PlatformID platformID;

		internal PlayerSet(GameObject root, bool isPlayer)
		{
		}

		internal bool Initialize()
		{
			return false;
		}
	}

	public static readonly string PrefabPath;

	private readonly string ROOT_PLAYER_LABEL;

	private readonly string ROOT_RIVAL_LABEL;

	private readonly string ROOT_CAN_CHOICE_LABEL;

	private readonly string ROOT_CANT_CHOICE_LABEL;

	private readonly string ROOT_VS_LABEL;

	private readonly string ROOT_RESULT_COINTOSS_LABEL;

	private readonly string TXT_TIME_LABEL;

	private readonly string TXT_LABEL;

	private readonly string SC_SKIP_LABEL;

	private readonly string BTN_FIRST_LABEL;

	private readonly string BTN_SECOND_LABEL;

	private readonly string BTN_BACKKEYSHORTCUT_LABEL;

	private readonly string TIME_COUNT_PATH;

	private bool m_bInit;

	private bool m_bStartDuel;

	private Dictionary<string, object> m_DuelParam;

	private DuelStartWaitingBase m_DSWaitingComponent;

	private Handle m_Handle;

	private IEnumerator m_SelectWaitCoroutine;

	private bool canChoice;

	private GameObject rootPlayer;

	private GameObject rootRival;

	private GameObject rootCanChoice;

	private GameObject rootCantChoice;

	protected GameObject rootVS;

	private GameObject duelStartResultCointoss;

	private PlayerSet player;

	private PlayerSet rival;

	protected Step m_Step;

	protected override Type[] textIds => null;

	protected Step step
	{
		get
		{
			return default(Step);
		}
		set
		{
		}
	}

	public override void NotificationStackEntry()
	{
	}

	protected virtual void InitTimeLine()
	{
	}

	public override void NotificationStackRemove()
	{
	}

	protected override void OnCreatedView()
	{
	}

	public override void ProgressUpdate()
	{
	}

	public void Update()
	{
	}

	private void EvalEachSteps()
	{
	}

	private bool SetPvPConnection()
	{
		return false;
	}

	protected virtual void Init()
	{
	}

	private void WaitDuelResourceDone()
	{
	}

	private bool LoadPlayers()
	{
		return false;
	}

	protected virtual void WaitInit()
	{
	}

	private void PlayerAppear()
	{
	}

	protected virtual void ControllVSImage()
	{
	}

	protected virtual void WaitPlayerAppear()
	{
	}

	private void CoinToss()
	{
	}

	private void WaitCoinToss()
	{
	}

	protected virtual void SelectTurn()
	{
	}

	private void TimeCountNotificator(object mes)
	{
	}

	private void WaitSelectTurn()
	{
	}

	private void DispSelected()
	{
	}

	protected virtual void PlayTweenHide()
	{
	}

	public override void TransitionStart(TransitionType type)
	{
	}

	protected virtual void DuelBegin()
	{
	}

	private void WaitFinal()
	{
	}

	protected virtual void StartDuel()
	{
	}

	protected virtual void CauseError()
	{
	}

	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	private IEnumerator yInit()
	{
		return null;
	}

	private IEnumerator yWait()
	{
		return null;
	}

	private IEnumerator Start()
	{
		return null;
	}
}
