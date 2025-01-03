using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;

public class Character : MonoBehaviour
{
	public enum TapPhase
	{
		TapPhaseNone = 0,
		TapPhaseWait = 1,
		TapPhaseWaitToPhase1 = 2,
		TapPhase1 = 3,
		TapPhasePhase1ToWait = 4,
		TapPhaseWaitToPhase2 = 5,
		TapPhase2 = 6,
		TapPhasePhase2ToWait = 7,
		TapPhaseWaitToPhase3 = 8,
		TapPhase3 = 9,
		TapPhasePhase3ToWait = 10
	}

	public enum WaitType
	{
		WAIT2 = 0,
		WAIT3 = 1,
		WAIT_TYPE_MAX = 2
	}

	public enum SubAvatarChange
	{
		None = 0,
		ChangeBattlePhase = 1,
		SummonExDeck = 2,
		DamageBorder = 3,
		SubAvatarChangeDebug = 999
	}

	private GameObject avatarModel;

	private MotionModel motion;

	private static AvatarModelSetting modelSetting;

	private static AvatarMotionSetting motionSetting;

	private bool enableWaitInterval;

	private float[] waitInterval;

	private float[] waitTarget;

	private float tapInterval;

	private List<Material> matList;

	private const float wait2RandMin = 20f;

	private const float wait2RandMax = 70f;

	private const float wait3Interval = 90f;

	private const float tapIntervalVal = 2f;

	private Coroutine m_InitializeRoutine;

	private Action tapCallback;

	public static readonly string CharacterPrefabPath;

	public AvatarModelSetting ModelSetting => null;

	public AvatarMotionSetting MotionSetting => null;

	public void InitializeAsync(int modelId, bool enableSE = true, bool is2D = false, bool enbleWait = false, Action onComplete = null)
	{
	}

	private IEnumerator yInitializeAsync(int modelId, bool enableSE = true, bool is2D = false, bool enbleWait = false, Action onComplete = null)
	{
		return null;
	}

	public void Initialize(int modelId, bool enableSE = true, bool is2D = false, bool enbleWait = false, GameObject preloadModel = null, AvatarModelSetting avatarSetting = null)
	{
	}

	public void InitializeSelector()
	{
	}

	private void Update()
	{
	}

	public void OnDestroy()
	{
	}

	public void Wait3Reset()
	{
	}

	private string GetModelPath(int modelId)
	{
		return null;
	}

	private string GetSubAvatarPath(int modelId)
	{
		return null;
	}

	private void ModelDestroy()
	{
	}

	public void SetMotionSePan(float pan)
	{
	}

	public void StopMotionSe(float fade = -1f)
	{
	}

	public void SetEnableSe(bool flg)
	{
	}

	public void PlayMotion(AvatarMotionSetting.MotionID motionId)
	{
	}

	public void ChangeSyncLayerWeight(float val)
	{
	}

	public bool HasMotion(AvatarMotionSetting.MotionID motionId)
	{
		return false;
	}

	public void PlayTapMotion()
	{
	}

	public bool IsTransitionCompleteLoopState()
	{
		return false;
	}

	public void SetTapCallback(Action callback)
	{
	}
}
