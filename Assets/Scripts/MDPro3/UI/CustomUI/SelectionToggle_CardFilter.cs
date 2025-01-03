using UnityEngine;

namespace MDPro3.UI
{
    public class SelectionToggle_CardFilter : SelectionToggle
    {
        public static SelectionToggle_CardFilter Instance;

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
            SetClickEvent(() =>
            {
                Program.instance.deckEditor.cardCollectionView.ShowFilters();
            });
        }

        protected override void OnClick()
        {
        }
    }
}
