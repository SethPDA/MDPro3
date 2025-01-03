using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class TransitionCard : CardBase
	{
		public enum TraceTargetType
		{
			Transform = 0,
			Position = 1
		}

		public enum MotionMode
		{
			Linear = 0,
			BezierAdd = 1,
			BezierRemove = 2,
			NoMove = 3
		}

		public enum Size
		{
			NoChange = 0,
			ToLarge = 1,
			ToSmall = 2
		}

		private enum Step
		{
			Idle = 0,
			Moving = 1,
			FadeOut = 2
		}

		[SerializeField]
		private BezierMotionContainer bezierMotionAdd;

		[SerializeField]
		private BezierMotionContainer bezierMotionRemove;

		private ElementObjectManager elements;

		private List<RawImage> cardImages;

		private List<Tween> tweenIn;

		private List<Tween> tweenOut;

		private List<Tween> tweenOutFade;

		private List<Tween> tweenLargeSize;

		private List<Tween> tweenSmallSize;

		private Transform pivot;

		private Vector3 basePosition;

		private Transform targetTransform;

		private Vector3 targetPosition;

		private Vector3[] positionHistory;

		private float remainTime;

		private const float traceTime = 0.5f;

		private ChainedBezierMotion motion;

		private bool outFade;

		private Action onTraceFinishedCallback;

		private TraceTargetType traceTargetType;

		private MotionMode mode;

		private Step step;

		private Vector3 target => default(Vector3);

		private bool isAvailableTarget => false;

		public static TransitionCard Create(TransitionCard prefab, Transform parent)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void SetData(int id, int style)
		{
		}

		public void SetData(CardBaseData cbd)
		{
		}

		public void SetPosition(Vector3 position)
		{
		}

		public void StartCardTracing(MotionMode mode, Vector3 basePosition, Transform target, bool outFade, Size size, Action onFinished)
		{
		}

		public void StartPositionTracing(MotionMode mode, Vector3 basePosition, Vector3 target, bool outFade, Size size, Action onFinished)
		{
		}

		public void StartAddEffect(Transform target, Size size, Action onFinished)
		{
		}

		private void StartTracing(MotionMode mode, Vector3 basePosition, bool outFade, Size size, Action onFinished)
		{
		}

		private void Update()
		{
		}

		private void UpdatePivotPosition()
		{
		}

		private void UpdateMoving()
		{
		}

		private void UpdateFadeOut()
		{
		}

		private void UpdateHistory()
		{
		}

		private void UpdateCardPosition()
		{
		}

		private void OnTraceFinished()
		{
		}

		private void PlayTween(List<Tween> tweenList)
		{
		}

		public void SetTweenDuration(List<Tween> tweenList, float duration)
		{
		}

		private bool IsTweenPlaying(List<Tween> tweenList)
		{
			return false;
		}
	}
}
