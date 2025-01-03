using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI
{
	public class HoldIndicator : MonoBehaviour
	{
		private ElementObjectManager ui;

		private GameObject indicatorRoot;

		private RectTransform indicatorPosition;

		private Image indicator;

		private float ignoreRate;

		private bool show;

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		public void Show(bool resetIndicator = true)
		{
		}

		public void Hide()
		{
		}

		private void SetDispRoot(bool disp)
		{
		}

		public void SetIndication(float time, float max)
		{
		}

		public void SetPoint(Vector2 screenPoint)
		{
		}

		public void SetPointUseCurrentScreenPoint()
		{
		}
	}
}
