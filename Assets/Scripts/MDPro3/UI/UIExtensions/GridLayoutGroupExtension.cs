using System;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public static class GridLayoutGroupExtension
    {
        public static Vector2Int Size(this GridLayoutGroup grid)
        {
            int itemsCount = grid.transform.childCount;
            Vector2Int size = Vector2Int.zero;

            if (itemsCount == 0)
                return size;

            switch (grid.constraint)
            {
                case GridLayoutGroup.Constraint.FixedColumnCount:
                    size.x = grid.constraintCount;
                    size.y = GetAnotherAxisCount(itemsCount, size.x);
                    break;

                case GridLayoutGroup.Constraint.FixedRowCount:
                    size.y = grid.constraintCount;
                    size.x = GetAnotherAxisCount(itemsCount, size.y);
                    break;

                case GridLayoutGroup.Constraint.Flexible:
                    size = flexibleSize(grid);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"Unexpected constraint: {grid.constraint}");
            }

            return size;
        }

        private static Vector2Int flexibleSize(this GridLayoutGroup grid)
        {
            int itemsCount = grid.transform.childCount;
            float prevX = float.NegativeInfinity;
            int xCount = 0;

            for (int i = 0; i < itemsCount; i++)
            {
                Vector2 pos = ((RectTransform)grid.transform.GetChild(i)).anchoredPosition;

                if (pos.x <= prevX)
                    break;

                prevX = pos.x;
                xCount++;
            }

            int yCount = GetAnotherAxisCount(itemsCount, xCount);
            return new Vector2Int(xCount, yCount);
        }

        private static int GetAnotherAxisCount(int totalCount, int axisCount)
        {
            return totalCount / axisCount + Mathf.Min(1, totalCount % axisCount);
        }
    }
}
