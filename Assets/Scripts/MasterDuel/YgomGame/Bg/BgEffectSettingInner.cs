using MDPro3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Bg
{
	public class BgEffectSettingInner : ElementObject
	{
		public enum AnimationLabelDefine
		{
			None = 0,
			Start = 1,
			LoopPhase1 = 2,
			LoopPhase2 = 3,
			LoopPhase3 = 4,
			LoopPhase4 = 5,
			LoopAll = 6,
			DamagePhase1 = 7,
			DamagePhase2 = 8,
			DamagePhase3 = 9,
			DamagePhase4 = 10,
			DamagePhaseAll = 11,
			ToPhase2 = 12,
			ToPhase3 = 13,
			ToPhase4 = 14,
			ToEnd = 15,
			ToPhaseAll = 16,
			End = 17,
			EndWin = 18,
			EndLose = 19,
			TapPhase1 = 20,
			TapPhase2 = 21,
			TapPhase3 = 22,
			TapPhase4 = 23,
			TapAll = 24,
			KeepPhaseAll = 25,
			DefineMax = 26
		}

		public enum TriggerLabelDefine
		{
			None = 0,
			StartToPhase1 = 1,
			Phase1ToDamagePhase1 = 2,
			DamagePhase1ToPhase1 = 3,
			DamagePhase1ToPhase2 = 4,
			Phase2ToDamagePhase2 = 5,
			DamagePhase2ToPhase2 = 6,
			DamagePhase2ToPhase3 = 7,
			Phase3ToDamagePhase3 = 8,
			DamagePhase3ToPhase3 = 9,
			DamagePhase3ToPhase4 = 10,
			Phase4ToDamagePhase4 = 11,
			DamagePhase4ToPhase4 = 12,
			DamagePhase4ToEnd = 13,
			PhaseToDamagePhaseAll = 14,
			DamagePhaseToPhaseAll = 15,
			DamagePhaseToNextPhaseAll = 16,
			EndWin = 17,
			EndLose = 18,
			TapPhase1 = 19,
			TapPhase2 = 20,
			TapPhase3 = 21,
			TapPhase4 = 22,
            TapAll = 23,
            OtherSidePhase1ToDamagePhase1 = 24,
            OtherSideDamagePhase1ToPhase1 = 25,
            OtherSideDamagePhase1ToPhase2 = 26,
            OtherSidePhase2ToDamagePhase2 = 27,
            OtherSideDamagePhase2ToPhase2 = 28,
            OtherSideDamagePhase2ToPhase3 = 29,
            OtherSidePhase3ToDamagePhase3 = 30,
            OtherSideDamagePhase3ToPhase3 = 31,
            OtherSideDamagePhase3ToPhase4 = 32,
            OtherSidePhase4ToDamagePhase4 = 33,
            OtherSideDamagePhase4ToPhase4 = 34,
            OtherSideDamagePhase4ToEnd = 35,
            OtherSidePhaseToDamagePhaseAll = 36,
            OtherSideDamagePhaseToPhaseAll = 37,
            OtherSideDamagePhaseToNextPhaseAll = 38,
            StartToPhase1Extra = 39
        }

		public float delay;

		public float activeTime;

		public AnimationLabelDefine animationLabel;

		public bool playingOnlyActive;

		public Vector3 tapSize;

		public Vector3 tapOffset;

		public bool otherSide;

		public bool isRootAnimator;

		public float endDelay;

		public bool disableLowEndPlatform;

		public bool enableLowEndPlatformOnly;

		public bool initialized;

		public BgEffectManagerInner manager;

		public ParticleSystem particle;

		public Animator animator;

		private float time;

		private bool enableTap;

		private bool tapPlaying;

		private bool enableLoop;

		private List<string> animatorParams;

		private void OnValidate()
		{
		}

		private void Awake()
		{
			if(animator != null)
			{
				animatorParams = new List<string>();
				foreach(var ani in animator.parameters)
					animatorParams.Add(ani.name);
			}
			if (disableLowEndPlatform && Program.root != Program.rootWindows64)
				Destroy(gameObject);
			if (enableLowEndPlatformOnly && Program.root == Program.rootWindows64)
				Destroy(gameObject);

			if (playingOnlyActive)
				gameObject.SetActive(false);
		}

		public bool PlayEffect(TriggerLabelDefine triggerLabel)
		{
			if (disableLowEndPlatform && Program.root != Program.rootWindows64)
			{
                gameObject.SetActive(false);
				return false;
            }
			if(enableLowEndPlatformOnly && Program.root == Program.rootWindows64)
			{
                gameObject.SetActive(false);
                return false;
            }

            if (particle != null)
				particle.Play();
			if (animator != null)
				animator.SetTrigger(triggerLabel.ToString());
			StartCoroutine(CheckActiveTime());
			return true;
		}

		public void SetEnableLoop(bool flg)
		{
		}

		public void PlayLoopEffect()
		{
		}

		public void SetEnableTap(bool flg)
		{
		}

		public void PlayTapEffect()
		{
			if (IsTapPlaying())
				return;

            if (animator != null)
                animator.SetTrigger("TapAll");
            if (particle !=  null)
				particle.Play();

            StartCoroutine(CheckTapAnimationEnd());
		}

		public bool IsTapPlaying()
		{
			return tapPlaying;
		}

		private IEnumerator CheckTapAnimationEnd()
		{
			tapPlaying = true;
			yield return new WaitForSeconds(activeTime == 0 ? 4 : activeTime);
			tapPlaying = false;
			if(playingOnlyActive &&
				name != "snakeEyes")
				gameObject.SetActive(false);
		}

		private IEnumerator CheckParticleEffectEnd()
		{
			return null;
		}

		private IEnumerator CheckActiveTime()
		{
			yield return new WaitForSeconds(activeTime == 0 ? 4 : activeTime);
			if(playingOnlyActive)
				gameObject.SetActive(false);
		}

		public void PlayAnimatorTrigger(TriggerLabelDefine label)
		{
		}

		public void PlayAnimationEvent(string str)
		{
		}

		private DeviceInfo.ResourceType GetResourceType()
		{
			return default(DeviceInfo.ResourceType);
		}
	}
}
