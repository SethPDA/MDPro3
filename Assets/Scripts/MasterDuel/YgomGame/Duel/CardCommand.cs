using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class CardCommand : MonoBehaviour
	{
		[Serializable]
		private class CommandSetting
		{
			public Engine.CommandType type;

			public Sprite icon;

			public Sprite iconSelect;

			public Sprite iconDown;

			public Sprite iconInactive;

			public string textID;

			public bool isPendulum;
		}

		public class CommandButton
		{
			public ElementObjectManager root;

			public SelectionButton button;

			public ColorContainerImage icon;

			public ExtendedTextMeshProUGUI text;

			public Engine.CommandType command;
		}

		[SerializeField]
		private List<CommandSetting> commandSettings;

		private CommandButton[] buttons;

		private ElementObjectManager ui;

		private Selector selector;

		private SelectionButton closeButton;

		private ElementObjectManager affectButtonRoot;

		private SelectionButton affectButton;

		private Action onAffectCallback;

		private RectTransform commandBG;

		private Image commandBGImage;

		private RectTransform commBase;

		private RectTransform commGrid;

		private RectTransform commGridPosHand;

		private RectTransform commGridPosField;

		private Vector2 dispPositionOrg;

		private bool isPendulum;

		private int currentCommandIndex;

		private bool docommand;

		private static readonly string prefabPath;

		public bool dontClose;

		private Vector3 actPosBase;

		private RectTransform fixedPosition;

		private int cmdMax;

		public int cmdPlayer
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

		public int cmdPosition
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

		public int cmdIndex
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

		public Action<bool> OnClose
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<Engine.CommandType> onExecuteCommand
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<int, Vector2> onDragBegin
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<int, Vector2> onDragging
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<int, Vector2> onDragEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool opening
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

		public int selectorPriority
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

		private Vector2 commandSize => default(Vector2);

		private Vector2 commandSizeRatio => default(Vector2);

		public static void Create(Transform parent, DuelClient host, Action<CardCommand> onLoaded)
		{
		}

		public void Initialize(DuelClient host)
		{
		}

		public void Close()
		{
		}

		public void Term()
		{
		}

		public bool Open(uint command, int player, int position, int index, Vector2 screenPoint, Action affectButtonCallback)
		{
			return false;
		}

		public void Open()
		{
		}

		public void SetCommand(uint commandMask)
		{
		}

		public void SetDefaultPosition()
		{
		}

		public void FixedPositionMode()
		{
		}

		public bool SelectCommand(int index)
		{
			return false;
		}

		public bool SelectCommand(Engine.CommandType command)
		{
			return false;
		}

		public void AlphaChange(bool setAlpha)
		{
		}

		public void SetButtonInteractable(Engine.CommandType command, bool interactable)
		{
		}

		public void SetButtonInteractable(int index, bool interactable)
		{
		}

		public void SetAllButtonInteractable(bool interactable)
		{
		}

		public Vector3 SetPosition(Vector2 screenPoint)
		{
			return default(Vector3);
		}

		private void SetComBaseLocalPosition(Vector3 localPosition)
		{
		}

		private void SetComGridLocalPosition(Vector3 localPosition)
		{
		}

		public Vector3 ReapplyPosition()
		{
			return default(Vector3);
		}

		public void SetGridPositionHand()
		{
		}

		public void SetGridPositionField()
		{
		}

		public void SetActiveCommandBG(bool active)
		{
		}

		public void OnCommand(int index)
		{
		}

		public void OnCommand(Engine.CommandType command)
		{
		}

		public void OnAffectButton()
		{
		}

		public Engine.CommandType GetCurrentCommand()
		{
			return default(Engine.CommandType);
		}

		private void ComDoCommand(Engine.CommandType command)
		{
		}

		public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority = SharedDefinition.DuelSelectorPriority.HUD, int priorityInCluster = 7)
		{
		}

		private CommandSetting GetSetting(Engine.CommandType commandType, bool isPendulum)
		{
			return null;
		}

		private string GetCommandText(Engine.CommandType commandType, bool isPendulum)
		{
			return null;
		}

		private void PlayTween(string label, string stopLabel)
		{
		}
	}
}
