using System;
using System.Collections;
using UnityEngine.Events;

public class PvpMenuMatchingViewController_WcsFinal : PvpMenuMatchingViewControllerBase
{
	private enum View
	{
		INIT = 0,
		SEARCHING = 1,
		MATCHING = 2,
		TIMEOUT = 3
	}

	private readonly string BTN_CANCEL_LABEL;

	private bool m_bCalledPop;

	private IEnumerator m_yPopViewRoutine;

	private const float LIMIT_POP_TIME = 15f;

	private View m_currentView;

	protected override Type[] textIds => null;

	protected override void OnCreatedView()
	{
	}

	protected override void Init()
	{
	}

	protected override IEnumerator yMatch()
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnClickBackButton()
	{
	}

	private IEnumerator yPopView()
	{
		return null;
	}

	private void PopViewControllerSafety(UnityAction onSafetyPopAction = null)
	{
	}
}
