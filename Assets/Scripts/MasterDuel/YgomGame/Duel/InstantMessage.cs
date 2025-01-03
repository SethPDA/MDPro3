using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class InstantMessage : DuelUIBase
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

			public string message;

			public float waitTime;

			public static OperationInfo OpenOperation(string message)
			{
				return null;
			}

			public static OperationInfo CloseOperation()
			{
				return null;
			}

			public static OperationInfo WaitOperation(float time)
			{
				return null;
			}
		}

		[SerializeField]
		private GameObject prefabUI;

		private ElementObjectManager ui;

		private ExtendedTextMeshProUGUI textMessage;

		private float currentTime;

		private const string prefabPath = "Prefabs/Duel/InstantMessage";

		private const float DefaultShowTime = 3f;

		private Queue<OperationInfo> operationQueue;

		private OperationInfo currentOperation;

		protected override UITransitionUtil.BlockType openCloseBlockType => default(UITransitionUtil.BlockType);

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<InstantMessage> finishCallback)
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

		public void ReqOpen(string message, float showTime = 3f)
		{
		}

		public void ReqForceClose()
		{
		}

		private void Open(string message)
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
