using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using YgomSystem.YGomTMPro;

namespace YgomSystem
{
	public class RubyTextEx : ExtendedTextMeshProUGUI
	{
		public enum Mode
		{
			BaseText = 0,
			RubyText = 1
		}

		private string orgStr;

		private Mode textMode;

		private RubyRoot.Lang textLang;

		private List<RubyRoot.RubyInfo> rubyInfoList;

		private Action populatedAction;

		public bool RubyInfoCalculated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetText(string str, Mode mode, RubyRoot.Lang lang, List<RubyRoot.RubyInfo> infoList, Action populated = null)
		{
		}

		protected void OnPopulateRubyText(TMP_TextInfo tmpinfo)
		{
		}
	}
}
