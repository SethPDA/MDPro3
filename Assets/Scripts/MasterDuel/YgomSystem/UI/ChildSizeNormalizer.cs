using UnityEngine;

namespace YgomSystem.UI
{
	[ExecuteInEditMode]
	public class ChildSizeNormalizer : MonoBehaviour
	{
		[SerializeField]
		private RectTransform.Axis _mode;

		[SerializeField]
		private float _spacing;

		private int childCount;

		private float spacing;

		private RectTransform _rectTransform;

		private RectTransform.Axis mode;

		private Rect rect;

		private RectTransform rectTransform => null;

		private void Update()
		{
		}

		private void Reset()
		{
		}

		public void NormalizeChildSize()
		{
		}
	}
}
