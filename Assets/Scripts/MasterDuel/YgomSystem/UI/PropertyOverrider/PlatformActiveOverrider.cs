using MDPro3;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformActiveOverrider : PropertyOverriderBase<Transform>
	{
		[SerializeField]
		private OverrideBoolProperty m_Active;

		public override void Import(Transform target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(Transform target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformActiveOverrider()
		{
		}

        private void Start()
        {
			if (m_Active.m_DefaultValue && Program.root != Program.rootWindows64)
				Destroy(gameObject);
            if (m_Active.m_MobileValue && Program.root == Program.rootWindows64)
                Destroy(gameObject);
        }
    }
}
