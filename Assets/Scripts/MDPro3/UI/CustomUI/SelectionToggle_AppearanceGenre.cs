using MDPro3.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_AppearanceGenre : SelectionToggle
    {

        protected override void Awake()
        {
            base.Awake();

            exclusiveToggle = true;
            canToggleOffSelf = false;
            toggleWhenSelected = true;
        }

        public override void SetToggleOn(bool callEvent = true)
        {
            if (!toggled)
                Program.instance.appearance.Manager.GetElement<ScrollRect>("ScrollRect").verticalScrollbar.value = 1f;
            base.SetToggleOn();
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.appearance.ShowItems(name.Split(" ")[1]);
            Program.instance.appearance.lastSelectedToggle = this;
        }

        protected override void OnSubmit()
        {
            base.OnSubmit();

            UserInput.NextSelectionIsAxis = true;
            var target = Program.instance.appearance.GetCurrentContentItem();
            if (target == null)
                return;
            EventSystem.current.SetSelectedGameObject(target);
        }
    }
}
