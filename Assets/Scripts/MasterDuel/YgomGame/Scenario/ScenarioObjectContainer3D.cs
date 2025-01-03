using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioObjectContainer3D : ScenarioContainerBase
	{
		private readonly string k_ELabelBGRoot;

		private readonly string k_ELabelActorRoot;

		private readonly string k_ELabelPrefabBackUIRoot;

		private readonly string k_ELabelPrefabOverUIRoot;

		private readonly string k_ELabelBlurLayer;

		public readonly ScenarioBGContainer bgContainer;

		public readonly ScenarioActorContainer actorContainer;

		public readonly ScenarioPrefabContainer prefabContainer;

		public readonly ScenarioBlurLayerActor blurScreenActor;

		public ScenarioObjectContainer3D(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(ScenarioWork work)
		{
		}

		public void ApplyCameraScale(Camera camera3d, Camera overuicamera3d)
		{
		}

		private void OnCreateCardActor(ScenarioCardActor cardActor)
		{
		}

		private void OnCreatePref(string label, GameObject gom)
		{
		}
	}
}
