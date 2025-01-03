using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogTitleWidget : ContentWidgetBase<CommonDialogTitleWidget, EntryTitleData>
	{
		public enum IconType
		{
			None = 0,
			Notice = 1,
			Alert = 2
		}

		private readonly string k_ELabelIcon;

		private readonly string k_ELabelText;

		[SerializeField]
		private Sprite m_NoticeIcon;

		[SerializeField]
		private Sprite m_AlertIcon;

		//private Image m_IconImage;

		private TMP_Text m_Text;

		public static CommonDialogTitleWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryTitleData entryData)
		{
		}

		public CommonDialogTitleWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
