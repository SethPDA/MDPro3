using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class CommandOperation
	{
		public enum Status
		{
			None = 0,
			Neutral = 1,
			Drag = 2,
			OnTarget = 3
		}

		[SerializeField]
		private GameObject prefabUI;

		private const string prefabPath = "Prefabs/Duel/UI/CommandOperation";

		private ElementObjectManager ui;

		private GhostCard dragCard;

		private SelectionButton dragCardButton;

		private TargetingLine targetLine;

		private GameObject operationObject;

		private SelectionButton bgButton;

		private CardCommand cardCommand;

		private bool usingInfoDialog;

		private RunEffectWorker worker;

		private uint commandMask;

		private uint commandMaskOrigin;

		private Status status;

		private Action<int, int, int, Engine.CommandType> onExecuteCommand;

		private int loadCount;

		private bool dragging;

		private int cardID;

		private CardRoot targetCard;

		private bool isMonsterCard;

		private List<Engine.CommandType> commandList;

		private CommandZoneIconController zoneIcon;

		private bool directDragging;

		private Engine.CommandType directDraggedCommand;

		private const float dragCardHeight = 3f;

		private const float dragCardHeightOnTarget = 1f;

		public static CommandOperation instance
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

		public bool draggable
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

		public static int targetPlayer
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

		public static int targetPosition
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

		public static int targetIndex
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

		public static Engine.CommandType targetCommand
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.CommandType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static uint targetStand
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool decideCommand
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

		public static bool decideLocation
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

		private static bool onTarget
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isCommandDisp => false;

		public static bool readyToCommandExecution => false;

		private Vector2 neutralScreenPosition => default(Vector2);

		public static CommandOperation Create(RunEffectWorker worker)
		{
			return null;
		}

		private void Initialize(RunEffectWorker worker)
		{
		}

		public void Terminate()
		{
		}

		public bool BeginCommand(int player, int position, int index, Action<int, int, int, Engine.CommandType> onExecuteCommand, Vector2 screenPoint, Status status)
		{
			return false;
		}

		public bool BeginCommand(uint commandMask, int player, int position, int index, Action<int, int, int, Engine.CommandType> onExecuteCommand, Vector2 screenPoint, Status status)
		{
			return false;
		}

		private void CommandToList(uint commandMask)
		{
		}

		public void BeginDrag(Vector2 screenPoint)
		{
		}

		private void UpdateCommandInteractable(int targetPlayer, int targetPosition)
		{
		}

		private bool IsDragCommandMask(uint commandMask, bool isMonster)
		{
			return false;
		}

		public void Update()
		{
		}

		public void UpdateDrag(Vector2 screenPoint)
		{
		}

		private void UpdateCardPosition(Vector2 screenPoint, float height, bool immediate)
		{
		}

		public void End(bool selectOpenedItem = true, bool closeCommand = true)
		{
		}

		public void EndDrag(Vector2 screenPoint, Status noTargetStatus = Status.Neutral)
		{
		}

		public void SetStatus(Status status)
		{
		}

		public bool IsAvailableZone(int player, int position)
		{
			return false;
		}

		public bool SetTargetLocation(int player, int position)
		{
			return false;
		}

		private void SetTargetCardColor(Color color)
		{
		}

		public void SetTargetCommand(Engine.CommandType command)
		{
		}

		public bool ExecuteTargetCommand(bool force = false)
		{
			return false;
		}

		public void SetSelected(int player, int position, bool selected)
		{
		}

		public void SetCursor(int index)
		{
		}

		public void ReapplyCommandPosition()
		{
		}

		public static void Reset()
		{
		}
	}
}
