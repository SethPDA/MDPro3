using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static MDPro3.UI.CardCollectionView;

namespace MDPro3.UI
{
    public class SelectionToggle_SearchOrder : SelectionToggle
    {
        [Header("SelectionToggle SearchOrder")]
        [SerializeField] private SortOrder sortOrder = SortOrder.ByType;

        protected override void Awake()
        {
            base.Awake();

            exclusiveToggle = true;
            canToggleOffSelf = false;
        }

        private void Start()
        {
            if (sortOrder == _SortOrder)
            {
                SetToggleOn();
                EventSystem.current.SetSelectedGameObject(gameObject);
            }
        }

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            ((Popup.PopupSearchOrder)Program.instance.ui_.currentPopupB).lastSelectedToggle = this;
        }

        protected override void CallSubmitEvent()
        {
            _SortOrder = sortOrder;
            Program.instance.deckEditor.cardCollectionView.SetSortIcon(GetIconSprite());
            Program.instance.deckEditor.cardCollectionView.PrintSearchCards();
            Program.instance.ui_.currentPopupB.Hide();
        }

        protected override void OnClick()
        {
            AudioManager.PlaySE(SoundLabelClick);
            SetToggleOn();
            CallSubmitEvent();
        }

        protected override void OnSubmit()
        {
            base.OnSubmit();
            OnClick();
        }
    }
}
