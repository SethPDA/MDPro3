using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DecideOperation
	{
		[SerializeField]
		private GameObject prefabUI;

		private const string prefabPath = "Prefabs/Duel/UI/DecideOperation";

		private ElementObjectManager ui;

		private GameObject operationObject;

		private SelectionButton bgButton;

		private CardCommand cardCommand;

		private RunEffectWorker worker;

		private Action onExecuteCommand;

		private int loadCount;

		private CardRoot targetCard;

		private bool isCancelButtonActive;

		private bool isDecisionButtonActive;

		private CommandZoneIconController zoneIcon;

		public static DecideOperation instance
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

		public int player
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int position
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int index
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool initialized => false;

		public bool isTerminated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool activate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isCommandDisp => false;

		public static DecideOperation Create(RunEffectWorker worker)
		{
			return null;
		}

		private void Initialize(RunEffectWorker worker)
		{
		}

		public void Terminate()
		{
		}

		public bool BeginCommand(int player, int position, int index, Action onExecuteCommand, Vector2 screenPoint)
		{
			return false;
		}

		public void Update()
		{
		}

		public void End(bool selectOpenedItem = true)
		{
		}

		private void ExecuteCommand()
		{
		}

		public void ExecuteDecideCommand()
		{
		}

		public void SetSelected(int player, int position, bool selected)
		{
		}

		public void SetCursor(int index)
		{
		}
	}
}
