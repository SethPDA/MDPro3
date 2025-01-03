using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public abstract class SpecialWinCommonBase : SpecialWinBase
	{
		protected List<Texture2D> cardTextures;

		private string labelFront;

		protected GameObject cardPictureContainer;

		protected List<int> cardIDs;

		private List<string> _seList;

		protected abstract string[] labels { get; }

		protected override bool destroyOnWinStart => false;

		protected override List<string> seList => null;

		protected override void Setup(PlayableDirector timeline)
		{
		}

		protected override void OnFinished()
		{
		}
	}
}
