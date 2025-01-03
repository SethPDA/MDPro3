using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Duel
{
	public class InstantCardDisplay : DuelUIBase
	{
		private class OperationInfo
		{
			public enum Operation
			{
				Open = 0,
				Wait = 1,
				Close = 2
			}

			public Operation operation;

			public int cardID;

			public float waitTime;

			public bool applyEffect;

			public static OperationInfo OpenOperation(int cardID)
			{
				return null;
			}

			public static OperationInfo CloseOperation()
			{
				return null;
			}

			public static OperationInfo WaitOperation(float time, bool applyEffect)
			{
				return null;
			}
		}

		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private RawImage cardPicture;

		private ParticleSystem applyEffectRoot;

		private float showTime;

		private float currentTime;

		private const string prefabPath = "Prefabs/Duel/InstantCardDisplay";

		private const float DefaultShowTime = 3f;

		private Queue<OperationInfo> operationQueue;

		private OperationInfo currentOperation;

		protected override UITransitionUtil.BlockType openCloseBlockType => default(UITransitionUtil.BlockType);

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<InstantCardDisplay> finishCallback)
		{
		}

		public override void Initialize(RunEffectWorker effectWorker)
		{
		}

		private void CreateUI()
		{
		}

		protected override void HideUI()
		{
		}

		protected override void ShowUI()
		{
		}

		public void ReqOpen(int cardID, bool applyEffect, float showTime = 3f)
		{
		}

		private void Open(int cardID)
		{
		}

		private void Wait(bool applyEffect)
		{
		}

		public void ReqForceClose()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateOperation()
		{
		}
	}
}
