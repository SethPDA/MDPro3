using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public abstract class Tween : MonoBehaviour
	{
		public enum Easing
		{
			Linear = 0,
			CubicIn = 1,
			CubicOut = 2,
			CubicInOut = 3,
			BackIn = 4,
			BackOut = 5,
			BackInOut = 6,
			BounceIn = 7,
			BounceOut = 8,
			BounceInOut = 9,
			Customize = 10,
			QuartIn = 11,
			QuartOut = 12,
			QuartInOut = 13
		}

		public static DG.Tweening.Ease GetDGTweenEase(Easing ease)
		{
			switch (ease)
			{
				case Easing.Linear:
					return DG.Tweening.Ease.Linear;
				case Easing.CubicIn:
                    return DG.Tweening.Ease.Linear;
                case Easing.CubicOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.CubicInOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.BackIn:
                    return DG.Tweening.Ease.Linear;
                case Easing.BackOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.BackInOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.BounceIn:
                    return DG.Tweening.Ease.Linear;
                case Easing.BounceOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.BounceInOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.Customize:
                    return DG.Tweening.Ease.Linear;
                case Easing.QuartIn:
                    return DG.Tweening.Ease.Linear;
                case Easing.QuartOut:
                    return DG.Tweening.Ease.Linear;
                case Easing.QuartInOut:
                    return DG.Tweening.Ease.Linear;
				default:
                    return DG.Tweening.Ease.Linear;
            }
        }


        public enum Style
		{
			Once = 0,
			Loop = 1,
			PingPong = 2,
			PingPongLoop = 3,
			SyncLoop = 4,
			SyncPingPongLoop = 5
		}

		private static readonly float FRAMERATE_LIMIT;

		public string label;

		[SerializeField]
		public Easing easing;

		[SerializeField]
		public Style style;

		[SecField]
		[SerializeField]
		public float duration;

		[SerializeField]
		[SecField]
		public float setupWait;

		[SecField]
		[SerializeField]
		public float startDelay;

		[SerializeField]
		public bool ignoreTimeScale;

		[SerializeField]
		public UnityEvent onFinished;

		[SerializeField]
		public bool callOnFinishedDestroy;

		[HideInInspector]
		public AnimationCurve curve;

		protected float timeDelta;

		protected float crntTime;

		private bool isCaptured;

		private float setupWaitCount;

		private bool isExecFinished;

		private static float BounceOut(float k)
		{
			return 0f;
		}

		private static float BounceIn(float k)
		{
			return 0f;
		}

		public static float EasingValue(float k, Easing e)
		{
			return 0f;
		}

		private float GetEasing(float k)
		{
			return 0f;
		}

		protected virtual void CaptureAwake()
		{
		}

		protected virtual void CaptureFrom()
		{
		}

		protected abstract void OnSetValue(float par);

		private void Awake()
		{
		}

		private void ExecSetup()
		{
		}

		private void ExecPlay(float time, bool forceUpdate = false)
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Stop()
		{
		}

		public void End()
		{
		}

		public void Reset()
		{
		}

		public void ResetWithTimeDelta()
		{
		}

		public void GotoAndPlay(float time)
		{
		}

		public void GotoAndPause(float time)
		{
		}

		public void DestroySelf()
		{
		}

		public void PlayLabel(string _label)
		{
		}

		public bool IsPlaying(string _label = "", bool isActive = false)
		{
			return false;
		}

		public bool IsFinished()
		{
			return false;
		}

		public static void TargetPlayLabel(GameObject target, string _label = "", bool includeChildren = false, bool wakeup = false)
		{
		}

		public static bool TargetIsPlaying(GameObject target, string _label = "", bool includeChildren = false, bool isActive = false)
		{
			return false;
		}

		public static void TargetGotoAndPlayLabel(GameObject target, float time, string _label = "", bool includeChildren = false, bool wakeup = false)
		{
		}

		public static void TargetGotoAndPauseLabel(GameObject target, float time, string _label = "", bool includeChildren = false, bool wakeup = false)
		{
		}

		public static void TargetPauseLabel(GameObject target, string _label = "", bool includeChildren = false)
		{
		}

		public static void TargetStopLabel(GameObject target, string _label = "", bool includeChildren = false, string exlabel = "")
		{
		}

		public static void TargetEndLabel(GameObject target, string _label = "", bool includeChildren = false)
		{
		}

		public static void TargetForwardLabel(GameObject target, float sec, string _label = "", bool includeChildren = false)
		{
		}

		public static void TargetCaptureFrom(GameObject target, string _label = "", bool includeChildren = false, bool force = false)
		{
		}

		public static void TargetCaptureFrom(Tween tween, bool force)
		{
		}

		public static void AllPlayLabel(string label)
		{
		}

		public static void AllStopLabel(string label)
		{
		}

		public static void AllPauseLabel(string label)
		{
		}

		public static void AllEndLabel(string label)
		{
		}

		public static List<Tween> GetTweenTarget(GameObject target, string _label = "", bool includeChildren = false)
		{
			return null;
		}

		public static List<Tween> GetTweenAll(string label)
		{
			return null;
		}
	}
}
