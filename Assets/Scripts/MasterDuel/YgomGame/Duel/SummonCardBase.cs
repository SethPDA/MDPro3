using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Duel
{
	public abstract class SummonCardBase
	{
		protected Texture2D textureFront;

		protected Material protectorMaterial;

		protected int loadCounter;

		protected GameObject autoReleaseCardPicture;

		public bool finished
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

		protected abstract string timelinePath { get; }

		protected abstract string seLabel { get; }

		protected abstract string trailOffsetLabel { get; }

		protected bool isLoading => false;

		protected void Initialize(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
		{
		}

		private void LoadCardFront(int cardID, int rareID, Action<Texture2D> onFinished)
		{
		}

		private void LoadCardBack(int sleeveID, UnityAction<Material> onFinished)
		{
		}

		public void LoadTimeline(string path, int materialNum, Action<bool> onLoaded)
		{
		}

		protected void OnLoadFinished(Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
		{
		}
	}
}
