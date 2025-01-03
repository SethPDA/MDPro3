using UnityEngine;

namespace YgomSystem.UI
{
	public abstract class ColorContainer : MonoBehaviour
	{
		public enum SelectMode
		{
			Unselected = 0,
			Selected = 1
		}

		public enum StatusMode
		{
			Normal = 0,
			Down = 1,
			Enter = 2
		}

		public enum ColorMode
		{
			Multiple = 0,
			Override = 1
		}

		public Color baseColor;

		[SerializeField]
		protected bool inheritParentColorSetting;

		[SerializeField]
		private Color colorUnselected;

		[SerializeField]
		private Color colorSelected;

		[SerializeField]
		private Color colorButtonDown;

		[SerializeField]
		private Color colorButtonEnter;

		[SerializeField]
		private Color colorButtonInactive;

		[SerializeField]
		[ColorLabelString]
		private string colorLabelUnselected;

		[SerializeField]
		[ColorLabelString]
		private string colorLabelSelected;

		[ColorLabelString]
		[SerializeField]
		private string colorLabelButtonDown;

		[ColorLabelString]
		[SerializeField]
		private string colorLabelButtonEnter;

		[ColorLabelString]
		[SerializeField]
		private string colorLabelButtonInactive;

		public int index;

		[SerializeField]
		protected ColorMode colorModeUnselected;

		[SerializeField]
		protected ColorMode colorModeSelected;

		[SerializeField]
		protected ColorMode colorModeButtonDown;

		[SerializeField]
		protected ColorMode colorModeButtonEnter;

		[SerializeField]
		protected ColorMode colorModeButtonInactive;

		[SerializeField]
		protected float intensityUnselected;

		[SerializeField]
		protected float intensitySelected;

		[SerializeField]
		protected float intensityButtonDown;

		[SerializeField]
		protected float intensityButtonEnter;

		[SerializeField]
		protected float intensityButtonInactive;

		private SelectMode currentSelectMode;

		private StatusMode currentStatusMode;

		private bool currentIsActive;

		protected Color GetColorUnselected()
		{
            return colorUnselected * intensityUnselected;
		}

		protected Color GetColorSelected()
		{
            return colorSelected * intensitySelected;
        }

        protected Color GetColorButtonDown()
		{
            return colorButtonDown * intensityButtonDown;
        }

        protected Color GetColorButtonEnter()
		{
            return colorButtonEnter * intensityButtonEnter;
        }

        protected Color GetColorButtonInactive()
		{
            return colorButtonInactive * intensityButtonInactive;
        }

        public virtual void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
		{
		}

		public void Reapply()
		{
		}
	}
}
