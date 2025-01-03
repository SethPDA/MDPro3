using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public abstract class ZoneCard
	{
		public enum Zone
		{
			Grave = 0,
			Exclude = 1
		}

		public enum Mode
		{
			Out = 0,
			In = 1
		}

		protected GameObject autoReleaseObject;

		protected PlayableDirector timeline;

		protected Mode mode;

		protected string timelineLabel;

		public bool isPlaying
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected void Initialize(Zone zone, Mode mode, Action<ZoneCard> onLoadFinished)
		{
		}

		public void Setup(int cardID, int uniqueID)
		{
		}

		private void LoadCardFront(int cardID, Material targetMaterial)
		{
		}

		private void LoadCardBack(int sleeveID, Action<Material> onFinished)
		{
		}

		private string ZoneToTimelineLabel(Zone zone, Mode mode)
		{
			return null;
		}

		public abstract void Play(int cardID, int uniqueID, Vector3 position, Quaternion rotation, Vector3 scale, bool isFace, Action onPlayFinished);

		public virtual void Terminate()
		{
		}
	}
}
