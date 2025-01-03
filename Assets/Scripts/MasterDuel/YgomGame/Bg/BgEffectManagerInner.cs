using DG.Tweening;
using MDPro3;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Bg
{
	public class BgEffectManagerInner : ElementObjectManager
	{
		public class BgEffectRequest
		{
			public BgEffectSettingInner setting;

			public float time;

			public BgEffectSettingInner.AnimationLabelDefine animationLabel;

			public BgEffectSettingInner.TriggerLabelDefine trigerLabel;
		}

		public class BgPhaseChangeSeRequest
		{
			public BgEffectSettingInner.TriggerLabelDefine trigerLabel;

			public string seLabel;
		}

		public class BgAnimationEventParam
		{
			public BgEffectSettingInner.TriggerLabelDefine trigger;

			public BgEffectSettingInner.AnimationLabelDefine animationLabel;

			public BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine tLabel, BgEffectSettingInner.AnimationLabelDefine aLabel)
			{
				trigger = tLabel;
				animationLabel = aLabel;
			}
		}

		[Serializable]
		public class BgEffectAdditionalSe
		{
			public string animationName;

			public string seLabel;

			public float time;
		}

		public delegate void CheckDamageCallback();

		private List<BgEffectSettingInner.TriggerLabelDefine> phaseCheckLabel;

		private const string animationEventFuncName = "PlayAnimationEvent";

		private const string additionalSeEventFuncName = "PlayAdditionalSeEvent";

		private Dictionary<BgEffectSettingInner.AnimationLabelDefine, List<BgEffectSettingInner>> effectSettings;

		private List<BgEffectSettingInner> triggerSettings;

		private List<BgEffectRequest> playEffectReqList;

		private List<BgEffectRequest> removeEffectList;

		private List<BgPhaseChangeSeRequest> playSeReqList;

		private Animator rootAnimator;

		public float finishAnimationDelay;

		private Dictionary<string, BgAnimationEventParam> animationEventParamDic;

		private BgUnit bgUnit;

		private bool initalized;

		private bool enableSe;

		private CheckDamageCallback checkDamageCallback;

		private BgUnit.BgPhase checkDamagePhase;

		public List<BgEffectAdditionalSe> additionalSeList;

        BgAnimationEventParam[] animationEventParams = new BgAnimationEventParam[]
		{
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.StartToPhase1, BgEffectSettingInner.AnimationLabelDefine.Start),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.Phase1ToDamagePhase1, BgEffectSettingInner.AnimationLabelDefine.DamagePhase1),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase1ToPhase1, BgEffectSettingInner.AnimationLabelDefine.LoopPhase1),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase1ToPhase2, BgEffectSettingInner.AnimationLabelDefine.ToPhase2),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.Phase2ToDamagePhase2, BgEffectSettingInner.AnimationLabelDefine.DamagePhase2),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase2ToPhase2, BgEffectSettingInner.AnimationLabelDefine.LoopPhase2),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase2ToPhase3, BgEffectSettingInner.AnimationLabelDefine.ToPhase3),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.Phase3ToDamagePhase3, BgEffectSettingInner.AnimationLabelDefine.DamagePhase3),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase3ToPhase3, BgEffectSettingInner.AnimationLabelDefine.LoopPhase3),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase3ToPhase4, BgEffectSettingInner.AnimationLabelDefine.ToPhase4),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.Phase4ToDamagePhase4, BgEffectSettingInner.AnimationLabelDefine.DamagePhase4),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase4ToPhase4, BgEffectSettingInner.AnimationLabelDefine.LoopPhase4),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhase4ToEnd, BgEffectSettingInner.AnimationLabelDefine.ToEnd),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.PhaseToDamagePhaseAll, BgEffectSettingInner.AnimationLabelDefine.DamagePhaseAll),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhaseToPhaseAll, BgEffectSettingInner.AnimationLabelDefine.ToPhaseAll),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.DamagePhaseToNextPhaseAll, BgEffectSettingInner.AnimationLabelDefine.KeepPhaseAll),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.EndWin, BgEffectSettingInner.AnimationLabelDefine.EndWin),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.EndLose, BgEffectSettingInner.AnimationLabelDefine.EndLose),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.TapPhase1, BgEffectSettingInner.AnimationLabelDefine.TapPhase1),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.TapPhase2, BgEffectSettingInner.AnimationLabelDefine.TapPhase2),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.TapPhase3, BgEffectSettingInner.AnimationLabelDefine.TapPhase3),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.TapPhase4, BgEffectSettingInner.AnimationLabelDefine.TapPhase4),
                new BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine.TapAll, BgEffectSettingInner.AnimationLabelDefine.TapAll),
		};

        public BgUnit GetBgUnit()
		{
			return null;
		}

		public ElementObject[] GetSerializedElements()
		{
			return serializedElements;
		}

        private void Awake()
        {
            Initialize(animationEventParams, new BgUnit(name.ToLower().Contains("near") ? BgUnit.Side.Near : BgUnit.Side.Far));
        }

        private void Update()
		{
        }

		public void Initialize(BgAnimationEventParam[] animationEventParams, BgUnit unit)
		{
			initalized = true;
            triggerSettings = new List<BgEffectSettingInner>();
            foreach (var element in serializedElements)
            {
                if (element is BgEffectSettingInner)
                    triggerSettings.Add(element as BgEffectSettingInner);
            }

            effectSettings = new Dictionary<BgEffectSettingInner.AnimationLabelDefine, List<BgEffectSettingInner>>();
            for (int i = 0; i < 27; i++)
            {
                var labelDefine = (BgEffectSettingInner.AnimationLabelDefine)i;
                var list = new List<BgEffectSettingInner>();
                foreach (var setting in triggerSettings)
                {
                    if (setting.animationLabel == labelDefine)
                        list.Add(setting);
                }
                if (list.Count > 0)
                    effectSettings.Add(labelDefine, list);
            }
        }

        public void Initialize(BgEffectManagerInner childlenMng, ElementObject[] elementObjects, bool isOtherSideElement = false)
		{
		}

		public void SetupBgEfectSettings(ElementObject[] elementObjects, bool isOtherSideElement = false)
		{
		}

		public void PlayAnimationEvent(string str)
		{
		}

		public void PlayAdditionalSeEvent(string label)
		{
		}

		public void PlayEffect(BgEffectSettingInner.AnimationLabelDefine label)
		{
		}

		public void SetEnableTapEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
		{
		}

		public void SetEnableLoopEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
		{
		}

		public void PlayAnimatorTriggerDelay(BgEffectSettingInner.TriggerLabelDefine label, float delay, string seLabel = "")
		{
			StartCoroutine(PlayAnimatorTriggerDelayCoroutine(label, delay, seLabel));
		}

		private IEnumerator PlayAnimatorTriggerDelayCoroutine(BgEffectSettingInner.TriggerLabelDefine label, float delay, string seLabel = "")
		{
			yield return new WaitForSeconds(delay);
			PlayAnimatorTrigger(label, seLabel);

        }

		public void PlayAnimatorTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
		{
			AudioManager.PlaySE(seLabel);
			foreach(var add in additionalSeList)
			{
				if(add.animationName == label.ToString())
				{
                    DOTween.To(v => { }, 0, 0, add.time).OnComplete(() =>
                    {
						AudioManager.PlaySE(add.seLabel, 0.6f);
                    });
                }
            }

			var animationLabel = BgEffectSettingInner.AnimationLabelDefine.None;
			foreach(var param in animationEventParams)
                if (param.trigger == label)
                {
                    animationLabel = param.animationLabel;
                    break;
                }
			if (TryGetComponent<Animator>(out var animator))
			{
                animator.SetTrigger(label.ToString());
			}

			effectSettings.TryGetValue(BgEffectSettingInner.AnimationLabelDefine.None, out var settings);
            if (settings != null)
                foreach (var setting in settings)
                    if (setting != null && setting.gameObject != null)
                    {
                        setting.gameObject.SetActive(true);
                        setting.PlayEffect(label);
                        if (setting.particle != null)
                            setting.particle.Play();
                        if (setting.animator != null)
                            setting.animator.SetTrigger(label.ToString());
                        else
                        {
                            setting.gameObject.SetActive(false);
                            setting.gameObject.SetActive(true);
                        }
                    }

            effectSettings.TryGetValue(animationLabel, out settings);
            if (settings != null)
                foreach (var setting in settings)
                    if (setting != null && setting.gameObject != null)
                    {
                        setting.gameObject.SetActive(true);
                        setting.PlayEffect(label);
                        if (setting.particle != null)
                            setting.particle.Play();
                        if (setting.animator != null)
                            setting.animator.SetTrigger(label.ToString());
                        else
                        {
                            setting.gameObject.SetActive(false);
                            setting.gameObject.SetActive(true);
                        }
                    }
        }

        public void PlayTapAnimation()
		{
			if (IsTapPlaying())
				return;

            effectSettings.TryGetValue(BgEffectSettingInner.AnimationLabelDefine.TapAll, out var settings);
			foreach(var setting in settings)
			{
				setting.gameObject.SetActive(true);
                setting.PlayTapEffect();
            }

			var se = "SE_FIELD_MAT" + name.Substring(4, 3) + "_TAP";
			AudioManager.PlaySE(se);
			if (name.ToLower().Contains("near"))
				se += "_P";
			else
				se += "_R";
            AudioManager.PlaySE(se);
        }

        public bool IsTapPlaying()
		{
            effectSettings.TryGetValue(BgEffectSettingInner.AnimationLabelDefine.TapAll, out var settings);
            foreach (var setting in settings)
                if (setting.IsTapPlaying())
                    return true;
            return false;
        }

        public void SetEnableSE(bool flg)
		{
		}

		public void SetRootAnimatorSpeed(float speed)
		{
		}

		public void SetCheckDamageCallback(BgUnit.BgPhase phase, CheckDamageCallback cb)
		{
		}
	}
}
