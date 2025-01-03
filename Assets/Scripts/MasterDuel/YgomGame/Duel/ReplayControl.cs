using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class ReplayControl : MonoBehaviour
	{
		private DuelHUD duelHUD;

		private ElementObjectManager ui;

		private SelectionButton playButton;

		private SelectionButton pauseButton;

		private GameObject message;

		private GameObject realtimeReplay;

		private GameObject ffIconOn;

		private GameObject ffIconOff;

		private bool initialized;

		public Action<bool> OnChangeReplayPause
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

		public Action OnFastReplay
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

		public bool IsPause
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

		private void Awake()
		{
		}

		public void Initialize(ElementObjectManager ui, DuelHUD duelHUD, GameObject replayMessage)
		{
		}

		private void Update()
		{
		}

		public void OnTapPause()
		{
		}

		public void OnTapPlay()
		{
		}

		public void OnTapFast()
		{
		}

		private void UpdateFFIcon()
		{
		}

		public void SetDisp(bool disp)
		{
		}
	}
}
