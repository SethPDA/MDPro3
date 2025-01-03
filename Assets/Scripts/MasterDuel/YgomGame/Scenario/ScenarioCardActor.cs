using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario
{
	public class ScenarioCardActor : ElementWidgetBase
	{
		public class TimelineAssets
		{
			public TimelineAsset timelineFadeIn;

			public TimelineAsset timelineFadeOut;

			public TimelineAsset timelineFadeSwap;
		}

		internal const string k_ActorProtectorPath = "Protector/<_CARD_ILLUST_>/0001/PMat";

		private readonly string k_ELabelBackModel;

		private readonly string k_ELabelFrontModel;

		private readonly string k_ELabelSubFrontModel;

		private readonly string k_ELabelSideModel;

		private PlayableDirector m_PlayableDirector;

		private TimelineAssets m_TimelineAssets;

		private readonly ScenarioCardPopActor m_CardPopActor;

		public readonly MeshRenderer frontRenderer;

		public readonly MeshRenderer subFrontRenderer;

		public readonly MeshRenderer backRenderer;

		public readonly MeshRenderer sideRenderer;

		private int m_LoadingCnt;

		public bool ready => false;

		public bool isPlaying
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

		public int mrk
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

		public int subMrk
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

		public ScenarioCardPopActor popActor => null;

		public bool isPlayingFadeOut => false;

		public ScenarioCardActor(ElementObjectManager eom, ElementObjectManager cardEom, ElementObjectManager popEom, TimelineAssets timelineAssets)
			: base(null)
		{
		}

		public override void Clear()
		{
		}

		public void ClearSub()
		{
		}

		public void CaptureSub()
		{
		}

		public void Binding(int mrk)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void HideFront()
		{
		}

		public void PlayFadeIn()
		{
		}

		public void PlayFadeOut()
		{
		}

		public void PlaySwap()
		{
		}

		private void OnPlayed(PlayableDirector director)
		{
		}

		private void OnStopped(PlayableDirector director)
		{
		}

		public void ToBlurTarget()
		{
		}

		public void ToIgnoreBlurTarget()
		{
		}
	}
}
