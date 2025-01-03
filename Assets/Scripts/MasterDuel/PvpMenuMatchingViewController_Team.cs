using System;
using System.Collections;
using UnityEngine.Events;

public class PvpMenuMatchingViewController_Team : PvpMenuMatchingViewControllerBase
{
	private readonly string BTN_CANCEL_LABEL;

	private readonly string E_TextSearching;

	private bool m_bCalledPop;

	private bool m_bIsTimeOut;

	private bool m_bIsLeader;

	private IEnumerator m_yPopViewRoutine;

	private const float LIMIT_POP_TIME = 15f;

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
