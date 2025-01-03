using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize
{
	public class PackActor : ElementWidgetBase
	{
		private const string k_ELabelPackSprite = "PackSprite";

		private const string k_ELabelCoverSprite = "CoverSprite";

		private const string k_ELabelArrowSprite = "ArrowSprite";

		private const string k_TLabelIn = "In";

		private const string k_TLabelLoop = "Loop";

		private const string k_TLabelOut = "Out";

		private readonly PlayableDirector m_PlayableDirector;

		private readonly LabeledPlayableController m_LabeledController;

		public SelectionButton button => null;

		public SpriteRenderer packSprite => null;

		public SpriteRenderer coverSprite => null;

		public SpriteRenderer arrowSprite => null;

		public PackActor(ElementObjectManager eom)
			: base(null)
		{
		}

		public void PlayInConfirm()
		{
		}

		private IEnumerator yPlayInConfirm()
		{
			return null;
		}

		public void PlayOutConfirm()
		{
		}

		public bool IsPlayingOut()
		{
			return false;
		}
	}
}
