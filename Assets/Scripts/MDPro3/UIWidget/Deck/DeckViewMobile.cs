using UnityEngine;

namespace MDPro3.UI
{
    public class DeckViewMobile : DeckView
    {
        protected override void Awake()
        {
            contentWidth = 818f - 16f;
            defaultColumns = 5;
            defaultMainDeckRows = int.MaxValue;
            defaultExtraDeckRows = int.MaxValue;
            defaultSideDeckRows = int.MaxValue;
            defaultSpacing = new(8f, 8f);
            dragCardScale = new(1.3f, 1.3f, 1f);
            base.Awake();
        }

        protected override void ChangeGridSpacing(DeckLocation location)
        {
            return;
        }
    }
}

