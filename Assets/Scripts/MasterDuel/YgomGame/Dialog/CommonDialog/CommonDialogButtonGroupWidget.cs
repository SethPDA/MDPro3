using System.Runtime.CompilerServices;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogButtonGroupWidget : ElementWidgetBehaviourBase<CommonDialogButtonGroupWidget>
	{
		public enum ButtonType
		{
			Positive = 0,
			Destructive = 1,
			Disable = 2,
			Highlight = 3
		}

		private readonly string k_ELabelButtonPositive;

		private readonly string k_ELabelButtonDestructive;

		private readonly string k_ELabelButtonDisable;

		private readonly string k_ELabelButtonHighlight;

		private readonly string k_ELabelSpace;

		private CommonDialogButtonWidget m_ButtonPositive;

		private CommonDialogButtonWidget m_ButtonDestructive;

		private CommonDialogButtonWidget m_ButtonDisable;

		private CommonDialogButtonWidget m_ButtonHighlight;

		public bool endDefault
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CommonDialogButtonGroupWidget Create(ElementObjectManager eom, bool endDefault)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public CommonDialogButtonWidget GetButtonWidget(ButtonType buttonType)
		{
			return null;
		}

		public void SetSpace()
		{
		}

		public CommonDialogButtonGroupWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
