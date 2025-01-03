using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionModel : MonoBehaviour
{
	private Animator animator;

	private AnimatorStateInfo defaultState;

	private int syncLayerIdx;

	private bool playing;

	private bool enableSE;

	private string modelSeLabel;

	private int seId;

	private float sePan;

	private int loadModelId;

	private bool isMotionSELoaded;

	private string preAnimationEventSeLabel;

	private List<string> triggerList;

	private const string syncLayerName = "Sync Layer";

	private void Awake()
	{
	}

	public void Init(Animator animator)
	{
	}

	public void Play(string label)
	{
	}

	private void PlayBool(string label)
	{
	}

	public bool IsTransitionCompleteLoopState()
	{
		return false;
	}

	private void PlayTrigger(string label, string seLabel = null)
	{
	}

	public void SetSELabel(string label, int modelId)
	{
	}

	public void SetEnableSE(bool flg)
	{
	}

	private IEnumerator DelaySetFalse(Action action)
	{
		return null;
	}

	public void PlayAnimationEventSe(string seLabel)
	{
	}

	public void SetSePan(float pan)
	{
	}

	public void StopSe(float fade = -1f)
	{
	}

	public bool CheckDefaultState()
	{
		return false;
	}

	public bool HasMotion(string label)
	{
		return false;
	}

	public void ChangeSyncLayerWeight(float val)
	{
	}
}
