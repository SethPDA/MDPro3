using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI.Popup
{
    public class PopupSearchOrder : Popup
    {
        [Header("Popup Selection")]
        public SelectionToggle_SearchOrder lastSelectedToggle;

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

        protected override void SelectLastSelected()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedToggle.gameObject);
        }

        public void SelectLastItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelected();
        }
    }
}
