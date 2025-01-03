using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_CharacterPlayer : SelectionToggle
    {
        [SerializeField] private string playerCode;

        protected override void Awake()
        {
            base.Awake();
            exclusiveToggle = true;
            canToggleOffSelf = false;
            toggleWhenSelected = true;
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.character.SwitchPlayer(playerCode);
        }

        public void OnLeftSelection()
        {
            AudioManager.PlaySE(SoundLabelClick);
            var leftSelectable = Selectable.navigation.selectOnLeft;
            if (toggled)
            {
                if(leftSelectable != null)
                    leftSelectable.GetComponent<SelectionToggle_CharacterPlayer>().SetToggleOn();
            }
            else
            {
                if (leftSelectable != null)
                    leftSelectable.GetComponent<SelectionToggle_CharacterPlayer>().OnLeftSelection();
            }
        }
        public void OnRightSelection()
        {
            AudioManager.PlaySE(SoundLabelClick);
            var rightSelectable = Selectable.navigation.selectOnRight;
            if (toggled)
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_CharacterPlayer>().SetToggleOn();
            }
            else
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_CharacterPlayer>().OnRightSelection();
            }
        }
    }
}
