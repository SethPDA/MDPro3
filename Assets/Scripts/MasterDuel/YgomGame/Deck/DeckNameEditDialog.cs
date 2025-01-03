using System;
using YgomGame.Menu;

namespace YgomGame.Deck
{
	public class DeckNameEditDialog : SelectDialogViewControllerBase<string>
	{
		private const string LABEL_TXT_HEADLINE = "TextHeadline";

		private const string LABEL_EIF_NAMEFIELD = "SearchField";

		private const string LABEL_TXT_INPUTFIELD = "TextName";

		private const string LABEL_SBN_CONFIRMBUTTON = "SearchButton";

		private const string PREFAB_PATH = "DeckEdit/DeckNameEditDialog";

		public static void Open(Action<string> callback)
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

		public DeckNameEditDialog()
		{
			//((SelectDialogViewControllerBase<>)(object)this)._002Ector();
		}
	}
}
