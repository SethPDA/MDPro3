using System;
using System.Collections;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.YGomTMPro;

public class PvpMenuMatchingViewController : PvpMenuMatchingViewControllerBase
{
	public enum View
	{
		SEARCHING = 0,
		MATCHING = 1,
		TIMEOUT = 2
	}

	private readonly string BTN_CANCEL_LABEL;

	private readonly string BTN_BACK_LABEL;

	private readonly string BTN_RESEARCH_LABEL;

	private readonly string TXT_TIME_LABEL;

	private readonly string TXT_TIPS_LABEL;

	private readonly string ROOT_SEARCH_LABEL;

	private readonly string ROOT_MATCH_LABEL;

	private readonly string ROOT_TIMEOUT_LABEL;

	private readonly string IMG_RANK_LABEL;

	private readonly string IMG_EVENT_LABEL;

	private readonly string IMG_FREE_LABEL;

	private bool m_bRequestBack;

	private bool m_bRequestResearch;

	private bool m_bIsDispTimeout;

	private float m_ResearchTime;

	private DefinitionSetting m_MatchingDefine;

	private ExtendedTextMeshProUGUI m_TextTime;

	private float m_StartTime;

	private GameObject m_rootSearch;

	private GameObject m_rootMatch;

	private GameObject m_rootTimeout;

	private IEnumerator m_yPopViewRoutine;

	private const float LIMIT_POP_TIME = 15f;

	private View m_currentView;

	protected override Type[] textIds => null;

	protected override void Init()
	{
	}

	protected override void OnCreatedView()
	{
	}

	private void SetActiveView(View state)
	{
	}

	private string ConvertDispTime(float elapsedTime)
	{
		return null;
	}

	protected override IEnumerator yMatch()
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnClickBackButton(bool requestBack = true)
	{
	}

	private IEnumerator yPopView()
	{
		return null;
	}
}
