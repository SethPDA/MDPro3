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
	public class CardCommandEx : MonoBehaviour
	{
		public enum StandType
		{
			FrontAtk = 0,
			FrontDef = 1,
			BackDef = 2,
			NONE = -1
		}

		[Serializable]
		private class CommandSetting
		{
			public StandType type;

			public Sprite icon;

			public Sprite iconSelect;

			public Sprite iconDown;

			public Sprite iconInactive;

			public string textID;
		}

		public class CommandButton
		{
			public ElementObjectManager root;

			public SelectionButton button;

			public ColorContainerImage icon;

			public ExtendedTextMeshProUGUI text;

			public StandType battlePosition;

			public uint engineParam;
		}

		[SerializeField]
		private List<CommandSetting> commandSettings;

		private CommandButton[] buttons;

		private RectTransform commandBG;

		private Image commandBGImage;

		private Selector selector;

		private RectTransform commBase;

		private RectTransform commGrid;

		private RectTransform commGridPosHand;

		private RectTransform commGridPosField;

		private bool docommand;

		private static readonly string prefabPath;

		private Vector3 actPosBase;

		private RectTransform fixedPosition;

		private int bpFace;

		private int cmdMax;

		private int currentCommandIndex;

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

		public Action<uint> OnCommandClick
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

		public Action<uint, Vector2> onDragBegin
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

		public Action<uint, Vector2> onDragging
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

		public Action<uint, Vector2> onDragEnd
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

		private Vector2 commandSize => default(Vector2);

		private Vector2 commandSizeRatio => default(Vector2);

		public static void Create(Transform parent, DuelClient host, Action<CardCommandEx> onLoaded)
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

		public void Open(int cardID, int face, Vector3 screenPoint)
		{
		}

		public void Open()
		{
		}

		public void SetDispButton(uint standType)
		{
		}

		public void SetDispAllButton(bool disp)
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

		public bool SelectCommandByStandType(uint standType)
		{
			return false;
		}

		public void AlphaChange(bool setAlpha)
		{
		}

		public Vector3 SetPosition(Vector2 screenPoint)
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

		public StandType GetCurrentBattlePosition()
		{
			return default(StandType);
		}

		public uint GetCurrentResultParam()
		{
			return 0u;
		}

		private uint GetCommandExToResultParam(StandType battlePosition)
		{
			return 0u;
		}

		public StandType ResultParamToStandType(uint resultParam)
		{
			return default(StandType);
		}

		private CommandSetting GetSetting(StandType commandType)
		{
			return null;
		}

		private string GetCommandText(StandType commandType)
		{
			return null;
		}

		private void PlayTween(string label, string stopLabel)
		{
		}
	}
}
