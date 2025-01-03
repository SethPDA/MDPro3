using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class SelectStandOperation
	{
		public enum Status
		{
			None = 0,
			Neutral = 1,
			Drag = 2,
			OnTarget = 3
		}

		public enum StandType
		{
			FaceAttackFaceDefense = 0,
			FaceAttackBackDefense = 1,
			FaceDefenseBackDefense = 2,
			All = 3,
			None = 4
		}

		public enum ZoneMode
		{
			SelectStand = 0,
			DecidePosition = 1
		}

		[SerializeField]
		private GameObject prefabUI;

		private const string prefabPath = "Prefabs/Duel/UI/CommandOperation";

		private ElementObjectManager ui;

		private GhostCard dragCard;

		private SelectionButton dragCardButton;

		private GameObject operationObject;

		private SelectionButton bgButton;

		private CardCommandEx cardCommandEx;

		private bool usingInfoDialog;

		private RunEffectWorker worker;

		private Status status;

		private Action<int, int, int, uint> onExecuteSpSummon;

		public ZoneMode zoneMode;

		private StandType standType;

		private int loadCount;

		private bool dragging;

		private uint directDraggedStand;

		private int cardID;

		private int uniqueID;

		private CardRoot targetCard;

		private CommandZoneIconController zoneIcon;

		private const float dragCardHeight = 18f;

		private const float dragCardHeightOnTarget = 1f;

		public static SelectStandOperation instance
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

		public static bool readyToSpSummon => false;

		private Vector2 neutralScreenPosition => default(Vector2);

		public static SelectStandOperation Create(RunEffectWorker worker)
		{
			return null;
		}

		private void Initialize(RunEffectWorker worker)
		{
		}

		public void Terminate()
		{
		}

		public void BeginSpSummon(StandType standType, int uniqueID, Action<int, int, int, uint> onExecuteSpSummon, Vector2 screenPoint, Status status, ZoneMode zoneMode)
		{
		}

		public void BeginDrag(Vector2 screenPoint)
		{
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

		public void End()
		{
		}

		public bool EndDrag(Vector2 screenPoint, Status noTargetStatus = Status.Neutral)
		{
			return false;
		}

		public void SetStatus(Status status)
		{
		}

		public bool IsAvailableZone(int player, int position)
		{
			return false;
		}

		public bool SetTargetLocation(int player, int position, bool playDecideEffect = true, bool force = false)
		{
			return false;
		}

		private void SetTargetCardColor(Color color)
		{
		}

		public void SetTargetStand(uint stand)
		{
		}

		private void CancelCommand()
		{
		}

		private bool ExecuteTargetSpSummon(bool force = false)
		{
			return false;
		}

		public void SetSelected(int player, int position, bool selected)
		{
		}

		public void SetCursor(int index)
		{
		}

		public static void Reset()
		{
		}
	}
}
