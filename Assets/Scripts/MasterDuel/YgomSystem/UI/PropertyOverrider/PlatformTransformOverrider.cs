using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformTransformOverrider : PropertyOverriderBase<Transform>
	{
		[SerializeField]
		private OverrideVector3Property m_Position;

		[SerializeField]
		private OverrideQuaternionProperty m_Rotation;

		[SerializeField]
		private OverrideVector3Property m_Scale;

		public override void Import(Transform target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(Transform target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformTransformOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
