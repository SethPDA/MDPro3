using System.Collections.Generic;
using YgomSystem.LocalizedFont;

namespace UnityEngine.UI
{
	public class RubyText : Text, ILocalizedFontOwner
	{
		private struct RubyInfo
		{
			public string rubyText;

			public int noRubyIndex;

			public int baseTextLen;
		}

		[SerializeField]
		private float rubyScaleFactor;

		private bool rubyFit;

		[SerializeField]
		private LocalizedFontSettingsBase.FontType m_localizedFontType;

		[SerializeField]
		private int m_localizedFontMaterialIndex;

		private readonly UIVertex[] m_TempVerts;

		private List<RubyInfo> rubyInfos;

		private const string tagRuby = "$R";

		private const string tagRubyBegin = "(";

		private const string tagRubyEnd = ")";

		private float minX;

		private float maxX;

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

		public float rubyScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool rubyFitWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override float preferredWidth => 0f;

		public override float preferredHeight => 0f;

		protected override void Start()
		{
		}

		private string parseRubyTag(string sourceText, string rubyTag, string rtTag, string endTag, List<RubyInfo> infos)
		{
			return null;
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}
	}
}
