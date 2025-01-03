using UnityEngine;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformOverriderGroup : MonoBehaviour
	{
		[SerializeField]
		private string m_SwitchLabel;

		[SerializeField]
		private GameObject[] m_ActiveOverriders;

		public GameObject[] activeOverriders => null;

		public string switchLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void ImmediateApply(bool frag = false)
		{
		}
	}
}
