using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformRectTransformOverrider : PropertyOverriderBase<RectTransform>
	{
		[SerializeField]
		private bool m_AddCanvasExpandSizeY;

		[SerializeField]
		private OverrideVector2Property m_AnchorMin;

		[SerializeField]
		private OverrideVector2Property m_AnchorMax;

		[SerializeField]
		private OverrideVector2Property m_AnchoredPosition;

		[SerializeField]
		private OverrideVector2Property m_SizeDelta;

		[SerializeField]
		private OverrideVector2Property m_Pivot;

		public OverrideVector2Property sizeDelta => null;

		public override void Import(RectTransform target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(RectTransform target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformRectTransformOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
