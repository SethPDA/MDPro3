using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelRitualDialog : DuelInfoDialogBase
	{
		public enum Mode
		{
			None = 0,
			Star = 1,
			Link = 2,
			Atk = 3
		}

		private class RitualDialogOperationInfo : OperationInfo
		{
			public static OperationInfo OpenOperation(DuelRitualDialog dialog, Place place)
			{
				return null;
			}

			public static OperationInfo OpenOperation(DuelRitualDialog dialog)
			{
				return null;
			}
		}

		private GameObject starGroup;

		private GameObject linkGroup;

		private GameObject atkGroup;

		private ElementObjectManager starTemplate;

		private ElementObjectManager linkTemplate;

		private ExtendedTextMeshProUGUI textRequireParam;

		private ExtendedTextMeshProUGUI textCurrentParam;

		private Mode currentMode;

		private List<ElementObjectManager> countObjects;

		private const string prefabPath = "Prefabs/Duel/DuelRitualDialog";

		public Engine.DialogRitualType ritualType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.DialogRitualType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int remainNum
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

		public int maxNum
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

		public string message
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

		public bool isReady
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

		public void ReqOpen(Place place)
		{
		}

		public void ReqOpen()
		{
		}

		public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelRitualDialog> finishCallback)
		{
		}

		protected override void CreateUI()
		{
		}

		public void Begin(string message, Engine.DialogRitualType type, int remainNum, int maxNum)
		{
		}

		public void End()
		{
		}

		public void SetStarFadeEnable(bool enable, int uniqueId)
		{
		}

		private void Open(Place place)
		{
		}

		private void Open()
		{
		}

		private void SetupCountGroup(Mode mode, int maxNum)
		{
		}

		public void SetCount(int remainNum)
		{
		}

		private void DestroyCountObjectList()
		{
		}
	}
}
