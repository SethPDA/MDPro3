using UnityEngine;
using static MDPro3.UI.CardCollectionView;

namespace MDPro3.UI
{
    public class SelectionToggle_CardCollectionTab : SelectionToggle
    {
        [Header("SelectionToggle CardCollectionTab")]
        [SerializeField] private Area area;

        protected override void Awake()
        {
            base.Awake();
            exclusiveToggle = true;
            canToggleOffSelf = false;
            toggleWhenSelected = true;
        }

        private void Start()
        {
            if (Program.instance.deckEditor.cardCollectionView.area == area)
                SetToggleOn();
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.deckEditor.cardCollectionView.ShowArea(area);
            foreach (var toggle in transform.parent.GetComponentsInChildren<SelectionToggle_CardCollectionTab>(true))
                toggle.SetShortcut(area);
        }

        protected void SetShortcut(Area area)
        {
            var show = (int)this.area == ((int)area + 1) % 3;
            Manager.GetElement<ShortcutIcon>("ShortcutIcon").Show = show;
        }

        public void OnRightSelection()
        {
            AudioManager.PlaySE(SoundLabelClick);
            var rightSelectable = Selectable.navigation.selectOnRight;
            if (toggled)
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_CardCollectionTab>().SetToggleOn();
            }
            else
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_CardCollectionTab>().OnRightSelection();
            }
        }
    }
}

