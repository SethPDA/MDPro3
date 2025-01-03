using TMPro;
using UnityEngine;
using YgomSystem.LocalizedFont;

namespace YgomSystem.YGomTMPro
{
	public class ExtendedTMP_InputField : TMP_InputField, ILocalizedFontOwner
	{
		[SerializeField]
		private LocalizedFontSettingsBase.FontType m_localizedFontType;

		[SerializeField]
		private int m_localizedFontMaterialIndex;

		public LocalizedFontSettingsBase.FontType localizedFontType
		{
			get
			{
				return default(LocalizedFontSettingsBase.FontType);
			}
			set
			{
			}
		}

		public int localizedFontMaterialIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}
	}
}
