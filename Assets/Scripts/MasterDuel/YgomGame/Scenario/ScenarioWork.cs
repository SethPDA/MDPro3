using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.Scenario
{
	public class ScenarioWork
	{
		public AssetContainer assetContainer;

		public DefinitionSetting definitionSetting;

		private float m_BeforeBGMFadeOut;

		public float onTextFilledArrowWaitSec;

		private float m_HideMenuByAutoSec;

		public float autoProgressUnitSec;

		public float autoProgressWaitClickSec;

		private float m_TitleDuration;

		public float startFadeOutDuration;

		public float startFadeInDuration;

		public float endFadeOutDuration;

		public float endFadeInDuration;

		private ScenarioCardContainer.InitializeData m_CardInitializeData;

		private ScenarioBGActor.Setting m_BGSetting;

		private ScenarioObjectContainer m_ObjectContainer;

		private ScenarioLoadGroupContainer m_LoadGropuContainer;

		private readonly List<string> m_LoadedTextGroupIds;

		private bool m_IsAuto;

		private bool m_IsAutoHide;

		private bool m_IsFullScreen;

		private bool m_IsLog;

		private bool m_Suspend;

		private bool m_DemoMode;

		public bool isHideUI;

		public bool arrowVisible;

		public readonly List<string> playingOnceSeLabels;

		public readonly List<string> playingLoopSeLabels;

		public string scenarioName
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

		public bool isAuto
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isLog
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isAutoHide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isFullScreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isSuspend
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isDemoMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float beforeBGMFadeOut => 0f;

		public float autoHideNeedSec
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float titleDuration => 0f;

		public ScenarioObjectContainer objectContainer => null;

		public ScenarioObjectContainer3D objectContainer3D => null;

		public ScenarioObjectContainerUI objectContainerUI => null;

		public ScenarioCardContainer.InitializeData cardInitializeData => null;

		public ScenarioBGActor.Setting bgSetting => null;

		public ScenarioLoadGroupContainer loadGroupContainer => null;

		public event Action<bool> onChangeAutoEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool> onChangeSuspendEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize(ScenarioObjectContainer objectContainer, ScenarioLoadGroupContainer loadGroupContainer)
		{
		}

		public void WriteEndFadeOutDurationAsSkip()
		{
		}

		public void OnCreatedLoadPacker(ScenarioLoadGroupContainer loadPacker)
		{
		}

		public string GetTextWidthLoadCheck(string text)
		{
			return null;
		}

		public void UnloadTextGroups()
		{
		}
	}
}
