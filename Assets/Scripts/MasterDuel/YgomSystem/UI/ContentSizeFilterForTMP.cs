using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class ContentSizeFilterForTMP : MonoBehaviour
	{
		[SerializeField]
		private float minWidth;

		[SerializeField]
		private float minHeight;

		[SerializeField]
		private TextMeshProUGUI m_TargetTmp;

		private RectTransform rectTransform;

		private bool m_UpdateSize;

		public bool EnableWidthControl;

		public bool EnableHeightControl;

		public event UnityAction onResized
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
