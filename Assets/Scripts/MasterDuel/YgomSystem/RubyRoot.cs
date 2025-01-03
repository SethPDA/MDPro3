using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem
{
	public class RubyRoot : MonoBehaviour
	{
		public enum Lang
		{
			JP = 0,
			EN = 1,
			KR = 2,
			CN = 3,
			TW = 4
		}

		public class RubyInfo
		{
			public int rubyTextIdx;

			public int rubyCount;

			public int baseTextIdx;

			public int wordCount;

			public float wordPos;

			public float wordWidth;

			public string word;
		}

		[SerializeField]
		private int fontSize;

		[SerializeField]
		public List<RubyInfo> rubyInfoList;

		[SerializeField]
		private RubyTextEx rubyText;

		[SerializeField]
		private RubyTextEx baseText;

		[SerializeField]
		private float rubySizeRatio;

		private const string tagRuby = "$R";

		private const string tagRubyBegin = "(";

		private const string tagRubyEnd = ")";

		private RectTransform _rt;

		private RectTransform rectTransform => null;

		public static Lang GetLang(string locale)
		{
			return default(Lang);
		}

		public void SetText(string str, Lang lang, int fontsize, Color col)
		{
		}

		private void SetupText(string str, Lang lang)
		{
		}

		public void RebuildRuby()
		{
		}

		private void SetFont(Lang lang)
		{
		}

		private void SetFontSize(int size)
		{
		}

		public void SetColor(Color col)
		{
		}

		public float GetBaseTextWidth()
		{
			return 0f;
		}

		private void parseRubyTag(string sourceText, out string baseStr, out string rubyStr, string rubyTag = "$R", string rtTag = "(", string endTag = ")")
		{
			baseStr = null;
			rubyStr = null;
		}
	}
}
