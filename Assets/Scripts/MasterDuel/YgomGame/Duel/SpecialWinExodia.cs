using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class SpecialWinExodia : SpecialWinBase
	{
		private List<string> _seList;

		private List<int> cardIDs;

		private List<Texture2D> cardTextures;

		private string[] labels;

		private string labelFront;

		private GameObject cardPictureContainer;

		protected override string prefabPath => null;

		protected override List<string> seList => null;

		public override void Initialize()
		{
		}

		protected override void Setup(PlayableDirector timeline)
		{
		}

		protected override void OnFinished()
		{
		}
	}
}
