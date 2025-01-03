namespace MDPro3.UI
{
    public class PopupSearchOrder : PopupBase
    {
        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
            foreach (var toggle in transform.GetComponentsInChildren<ToggleForSearchOrder>())
                if (toggle.sortOrder == Program.instance.editDeck.sortOrder)
                {
                    toggle.SwitchOnWithoutAction();
                    break;
                }
        }
        public override void Hide()
        {
            base.Hide();
            AudioManager.PlaySE("SE_MENU_CANCEL");
        }
        public override void OnCancel()
        {
            Hide();
        }
    }
}
