using TMPro;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public abstract class PlatformTextMeshProOverriderBase<TARGET> : PropertyOverriderBase<TARGET> where TARGET : TMP_Text
	{
		[SerializeField]
		private OverrideFloatProperty m_FontSize;

		[SerializeField]
		private OverrideBoolProperty m_EnableAutoSize;

		[SerializeField]
		private OverrideFloatProperty m_FontSizeMin;

		[SerializeField]
		private OverrideFloatProperty m_FontSizeMax;

		[SerializeField]
		private OverrideFloatProperty m_CharacterSpacing;

		[SerializeField]
		private OverrideFloatProperty m_WordSpacing;

		[SerializeField]
		private OverrideFloatProperty m_LineSpacing;

		[SerializeField]
		private OverrideFloatProperty m_ParagraphSpacing;

		public OverrideFloatProperty fontSize => null;

		public OverrideBoolProperty enableAutoSize => null;

		public OverrideFloatProperty fontSizeMin => null;

		public OverrideFloatProperty fontSizeMax => null;

		public OverrideFloatProperty characterSpacing => null;

		public OverrideFloatProperty wordSpacing => null;

		public OverrideFloatProperty lineSpacing => null;

		public OverrideFloatProperty paragraphSpacing => null;

		public override void Import(TARGET target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(TARGET target, DeviceInfo.PlatformType platformType)
		{
		}

		protected PlatformTextMeshProOverriderBase()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
