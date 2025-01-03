using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;

public abstract class PvpMenuMatchingViewControllerBase : BaseMenuViewController
{
	protected bool m_bInit;

	protected bool m_bAbort;

	protected bool m_bStartDuel;

	protected PvpMenuDefine.MatchingType m_MatchingType;

	protected Dictionary<string, object> m_MatchingParam;

	protected Dictionary<string, object> m_DuelParam;

	protected PvpMenuMatchingBase m_MatchingComponent;

	protected IEnumerator m_MatchingCoroutine;

	protected IEnumerator m_AbortCoroutine;

	private int showProgressCount;

	public int ShowProgressCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected abstract IEnumerator yMatch();

	protected virtual void Init()
	{
	}

	public override void NotificationStackEntry()
	{
	}

	public override void NotificationStackRemove()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	protected IEnumerator yInit()
	{
		return null;
	}

	protected IEnumerator yCancelMatching()
	{
		return null;
	}

	protected IEnumerator yStopByFatalError()
	{
		return null;
	}

	protected void ShowSystemProgress()
	{
	}

	protected void HideSystemProgress()
	{
	}

	private void ResetProgress()
	{
	}

	public Coroutine WrapStartCoroutine(IEnumerator routine)
	{
		return null;
	}

	public void WrapStopCoroutine(IEnumerator routine)
	{
	}
}
