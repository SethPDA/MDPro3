using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelEffectHandle : MonoBehaviour
	{
		protected GameObject target;

		private float time;

		private float timeToQuit;

		private bool reqQuit;

		protected bool autoQuit;

		private Action onFinished;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation;

		private Vector3 defaultScale;

		public DuelEffectPool effectPool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual bool isPlaying => false;

		public DuelEffectPool.Type type
		{
			[CompilerGenerated]
			get
			{
				return default(DuelEffectPool.Type);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(DuelEffectPool effectPool, DuelEffectPool.Type type, GameObject target, bool autoQuit, Action onFinished)
		{
		}

		public void Terminate()
		{
		}

		protected virtual void OnInitialize()
		{
		}

		protected virtual void OnTerminate()
		{
		}

		public virtual void Play()
		{
		}

		protected virtual void OnPlay()
		{
		}

		public void Stop()
		{
		}

		protected virtual void OnStop()
		{
		}

		public void ReqQuit(float timeToQuit)
		{
		}

		private void Update()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		private void QuitImmediate()
		{
		}
	}
}
