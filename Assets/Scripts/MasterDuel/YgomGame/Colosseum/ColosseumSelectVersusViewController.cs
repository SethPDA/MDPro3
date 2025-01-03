using System;
using System.Collections.Generic;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumSelectVersusViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public const string PREF_PATH = "Colosseum/ColosseumSelectVersus";

		private const string E_RootButton = "RootButton";

		private const string E_Button = "Button";

		private const string E_Image = "Image";

		private const string E_ImageParticipate = "ImageParticipate";

		private const string E_Text = "Text";

		private const string E_TextHeadline = "TextHeadline";

		private const string E_TextParticipate = "TextParticipate";

		private const string E_ImageBg = "ImageBg";

		private const string E_ImageIcon = "ImageIcon";

		private const string E_ImageMonster = "ImageMonster";

		private const string ARGKEY_VERSUSID = "ArgKeyVersusId";

		private const string ARGKEY_ONCLICKBUTTON = "ArgKeyOnClickButton";

		private int versus_id;

		private Action<int, ViewController> onDecide;

		protected override Type[] textIds => null;

		public static Dictionary<string, object> GetArgs(int versus_id, Action<int, ViewController> onDecide)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitView()
		{
		}

		private void SetButton(ElementObjectManager eom, int logoId, int groupId)
		{
		}

		private void StartPerformance()
		{
		}
	}
}
