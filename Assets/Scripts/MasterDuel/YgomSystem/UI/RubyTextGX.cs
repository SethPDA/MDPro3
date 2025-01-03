using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;
using YgomSystem.YGomTMPro;

namespace YgomSystem.UI
{
	public class RubyTextGX : ExtendedTextMeshProUGUI//, ILocalizedFontOwner
	{
		private struct RubyInfo
		{
			public string rubyText;

			public int noRubyIndex;

			public int baseTextLen;
		}

		private struct RubyTextInfo
		{
			public List<RubyInfo> rubyInfoList;

			public string parsedText;

			public string parsedTextWithRuby;
		}

		private const string tagRuby = "$R";

		private const string tagRubyBegin = "(";

		private const string tagRubyEnd = ")";

		[SerializeField]
		private float rubyScaleFactor;

		private RubyTextInfo m_RubyTextInfo;

		private List<(int, TMP_TextInfoExtended.VERTEXINDEX, Vector3)> m_MeshModifyInfoList;

		private bool m_ReCalculated;

		private bool m_RubyFit;

		private float m_MeshRectMinX;

		private float m_MeshRectMaxX;

		private float m_MeshRectMinY;

		private float m_MeshRectMaxY;

		private ContentSizeFitter m_ContentSizeFilter;

		private float m_PreferredWidthWithRuby;

		private float m_PreferredHeightWithRuby;

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

		private List<RubyInfo> m_RubyInfoList => null;

		private string m_ParsedText => null;

		private string m_ParsedTextWithRuby => null;

		public override float preferredWidth => 0f;

		public override float preferredHeight => 0f;

		public override string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected void OnPopulateRubyText(TMP_TextInfo tmpinfo)
		{
		}

		private void GenerateMeshModifyInfoData(TMP_TextInfo tmpinfo)
		{
		}

		private void UpdateTmpInfo(TMP_TextInfo tmpinfo, float baseY, float ofs, float word_ofs, float px, float pw, float ph, float cy, float rubyScale, int index, int idx, float d, TMP_TextInfoExtended.VERTEXINDEX pos)
		{
		}

		private void UpdateTmpInfo2(TMP_TextInfo tmpinfo, float baseY, float ofs, float px, float pw, float ph, float cy, float rubyScale, int index, float d, TMP_TextInfoExtended.VERTEXINDEX pos)
		{
		}

		private void AddUpdateData(int index, TMP_TextInfoExtended.VERTEXINDEX pos, Vector3 uiv)
		{
		}

		private void UpdateRubyTextInfo(string rawstr)
		{
		}

		private string parseRubyTag(string sourceText, string rubyTag, string rtTag, string endTag, List<RubyInfo> infos)
		{
			return null;
		}
	}
}
