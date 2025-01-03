using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro
{
	public class TextMeshProAutoSizer : MonoBehaviour
	{
		[SerializeField]
		private bool autoUpdate;

		[SerializeField]
		private float checkSizeDelta;

		private TMP_Text tmpText;

		private string currentText;

		private RectTransform rectTransform;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void Apply()
		{
		}

		public static float ApplyFontSize(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax = -1f, float sizeDelta = 1f, bool maxToMin = true)
		{
			return 0f;
		}

		private static float ApplyFontSizeMaxToMin(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax, float sizeDelta)
		{
			return 0f;
		}

		private static float ApplyFontSizeMinToMax(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax, float sizeDelta)
		{
			return 0f;
		}
	}
}
