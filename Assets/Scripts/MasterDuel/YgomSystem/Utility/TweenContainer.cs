using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	public class TweenContainer
	{
		private List<Tween> tweens;

		private Action onPlayFinished;

		private string playingLabel;

		private bool playing;

		public void Setup(GameObject target)
		{
		}

		public void AddTweens(Tween[] tweens)
		{
		}

		public void Play(string playLabel, Action onPlayFinished, bool stop = true, string stopLabel = "")
		{
		}

		public void Stop(string label)
		{
		}

		private bool IsPlaying(string label = null)
		{
			return false;
		}

		public bool Update()
		{
			return false;
		}

		public void Immediate(string label)
		{
		}

		public void CaptureFrom(string label = null)
		{
		}

		private void InvokeOnPlayFinished()
		{
		}
	}
}
