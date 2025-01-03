using System;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class SearchBoxDialog : SelectDialogViewControllerBase<string, string>
	{
		private const string LABEL_SBN_SEARCHBUTTON = "SearchButton";

		private const string LABEL_TXT_INPUTFIELD = "TextName";

		private const string LABEL_TXT_PLACEHOLDER = "PlaceHolder";

		private const string LABEL_EIF_SEARCHFIELD = "SearchField";

		private const string PREFAB_PATH = "DeckEdit/SearchBoxDialog";

		//private Text m_InputFieldText => null;

		private SelectionButton m_SearchButton => null;

		private ExtendedInputField m_InputField => null;

		public static void Open(string keyword, Action<string> callback)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public SearchBoxDialog()
		{
			//((SelectDialogViewControllerBase<, >)(object)this)._002Ector();
		}
	}
}
