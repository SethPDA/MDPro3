using System;
using YgomGame.Menu;

namespace YgomGame.Solo
{
	public class SoloModeSortViewController : BaseMenuViewController, IBokeSupported
	{
		public class SortData
		{
			public string label;

			public SoloFilterSortUtil.GateSort ascendSort;

			public SoloFilterSortUtil.GateSort descendSort;

			public SortData(string label, SoloFilterSortUtil.GateSort ascendSort, SoloFilterSortUtil.GateSort descendSort)
			{
			}
		}

		private const string PREF_PATH = "Solo/SoloModeSort";

		private const string ARGS_SORT_DATAS = "ArgsSortDatas";

		private const string ARGS_CALLBACK = "ArgsKeyCallback";

		private const string ARGS_CURRENT_SORT = "ArgsKeyCurrentSort";

		private const string ARGS_TITLE = "ArgsKeyTitle";

		private const string E_TextTitle = "TextTitle";

		private const string E_ButtonFooter = "ButtonFooter";

		private const string E_Label = "Label";

		private const string E_Template = "Template";

		private const string E_Button0 = "Button0";

		private const string E_ImageOn0 = "ImageOn0";

		private const string E_ImageOff0 = "ImageOff0";

		private const string E_Button1 = "Button1";

		private const string E_ImageOn1 = "ImageOn1";

		private const string E_ImageOff1 = "ImageOff1";

		private SortData[] sortDatas;

		private Action<SoloFilterSortUtil.GateSort> decideAction;

		private SoloFilterSortUtil.GateSort currentSort;

		private string title;

		protected override Type[] textIds => null;

		public static void Open(SortData[] sortDatas, Action<SoloFilterSortUtil.GateSort> decideAction, SoloFilterSortUtil.GateSort currentSort, string title = "")
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitDisp()
		{
		}
	}
}
