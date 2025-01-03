using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize
{
	public class ActorRoot : ElementWidgetBase
	{
		private const string k_ELabelRoot3D = "Root3D";

		private const string k_ELabelRootUI = "RootUI";

		private const string k_ELabel3D_PackGroup = "PackGroup";

		internal const string k_TLabel_Shuffle = "shuffle";

		internal const string k_TLabel_SelectBegin = "select_begin";

		internal const string k_TLabel_SelectEnd = "select_end";

		internal const string k_TLabel_Result = "result";

		private readonly PlayableDirector m_Director;

		private readonly LabeledPlayableController m_PlayableController;

		private readonly PackGroupActor m_PackGroup;

		public LabeledPlayableController playableController => null;

		public PackGroupActor packGroup => null;

		public ActorRoot(GameObject root3D, GameObject rootUI, ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetPackTrackOverrideEnableAll(bool enable)
		{
		}

		public void SetPackTrackOverrideEnableAt(int idx, bool enable)
		{
		}

		public void TMRebuildGraph()
		{
		}
	}
}
