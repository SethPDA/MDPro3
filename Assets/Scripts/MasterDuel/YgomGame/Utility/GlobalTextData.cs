using System;
using UnityEngine;

namespace YgomGame.Utility
{
	[Serializable]
	public class GlobalTextData
	{
		public bool useId;

		public string tid;

		[TextArea]
		public string ja_JP;

		[TextArea]
		public string en_US;

		[TextArea]
		public string fr_FR;

		[TextArea]
		public string it_IT;

		[TextArea]
		public string de_DE;

		[TextArea]
		public string es_ES;

		[TextArea]
		public string pt_BR;

		[TextArea]
		public string ko_KR;

		[TextArea]
		public string zh_TW;

		[TextArea]
		public string zh_CN;

		private string m_TextGroup;

		private string m_TextId;

		public void Clear()
		{
		}

		private void ParseTextId()
		{
		}

		public string GetTextGroup()
		{
			return null;
		}

		public string GetText()
		{
			return null;
		}

		public string GetConvertedText()
		{
			return null;
		}

		public void SetTextId<T>(T textId)
		{
		}

		public string GetRawText()
		{
			return null;
		}

		public void SetRawText(string rawText)
		{
		}

		public GlobalTextData Copy()
		{
			return null;
		}

		public void CopyTo(GlobalTextData target)
		{
		}

		private string GetLangText(string langKey)
		{
			return null;
		}

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}
	}
}
