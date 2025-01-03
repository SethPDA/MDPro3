using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_GridLayoutGroup : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_RectOffset m_Padding;
        [SerializeField] private OverrideProperty_Vector2 m_CellSize;
        [SerializeField] private OverrideProperty_Vector2 m_Spacing;
        [SerializeField] private OverrideProperty_Int m_ConstraintCount;
        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<GridLayoutGroup>();
            target.padding = m_Padding.m_DefaultValue;
            target.cellSize = m_CellSize.m_DefaultValue;
            target.spacing = m_Spacing.m_DefaultValue;
            if (m_ConstraintCount.m_DefaultValue > 0)
                target.constraintCount = m_ConstraintCount.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<GridLayoutGroup>();
            target.padding = m_Padding.m_MobileValue;
            target.cellSize = m_CellSize.m_MobileValue;
            target.spacing = m_Spacing.m_MobileValue;
            if(m_ConstraintCount.m_MobileValue > 0)
                target.constraintCount = m_ConstraintCount.m_MobileValue;
        }
    }
}
