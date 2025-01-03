using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogIconTextWidget : ContentWidgetBase<CommonDialogIconTextWidget, EntryIconTextData>
	{
		public enum IconType
		{
			None = 0,
			Path = 1,
			Gem = 2,
			Item = 3
		}

		private readonly string k_ELabelIcon;

		private readonly string k_ELabelText;

		private readonly string k_ELabelNumText;

		[SerializeField]
		private Sprite m_GemIcon;

		//private Image m_IconImage;

		private TMP_Text m_Text;

		private TMP_Text m_NumText;

		public static CommonDialogIconTextWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryIconTextData entryData)
		{
		}

		public CommonDialogIconTextWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
