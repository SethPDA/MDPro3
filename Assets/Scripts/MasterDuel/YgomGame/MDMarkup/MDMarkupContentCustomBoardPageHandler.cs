using System;
using System.Runtime.CompilerServices;

namespace YgomGame.MDMarkup
{
	[Serializable]
	public class MDMarkupContentCustomBoardPageHandler : IMDMarkupContent
	{
		public int startIdx;

		public int length;

		public string title;

		public Func<int, object> onCreatePageMMAContainerFunc;

		public Action<MDMarkupBoardPagerContainerWidget.Context, int> onUpdatePageCallback;

		public MDMarkupDef.MarkupType markupType => default(MDMarkupDef.MarkupType);

		public int contentIndent => 0;

		public event Action<int, bool> onFocusPageEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void InvokeOnFocusPageEvent(int idx, bool isFirst)
		{
		}

		public object ExportJsonObj()
		{
			return null;
		}

		public void ImportJsonObj(object jsonObj)
		{
		}

		public string ToJson()
		{
			return null;
		}
	}
}
