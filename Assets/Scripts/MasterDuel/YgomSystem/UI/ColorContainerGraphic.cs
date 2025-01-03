using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class ColorContainerGraphic : ColorContainer
	{
		private Graphic _targetGraphic;

		public Graphic targetGraphic 
		{ 
			get
			{
				if(_targetGraphic == null)
					_targetGraphic = GetComponent<Graphic>();
				return _targetGraphic;
			}
		}

		public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
		{
			SetTargetGraphicColor(select_mode, status_mode, is_active);
		}

		private void SetTargetGraphicColor(SelectMode select_mode, StatusMode status_mode, bool is_active)
		{
			var color = baseColor;

			switch (select_mode)
			{
				case SelectMode.Selected: 
					if(colorModeSelected == ColorMode.Multiple)
						color *= GetColorSelected();	
					else
						color = GetColorSelected();
					break;
                case SelectMode.Unselected:
                    if (colorModeUnselected == ColorMode.Multiple)
                        color *= GetColorUnselected();
                    else
                        color = GetColorUnselected();
                    break;
            }

			switch (status_mode)
			{
                case StatusMode.Down:
					if(colorModeButtonDown == ColorMode.Multiple)
						color *= GetColorButtonDown();
					else
						color = GetColorButtonDown();
                    break;
                case StatusMode.Enter:
                    if (colorModeButtonEnter == ColorMode.Multiple)
                        color *= GetColorButtonEnter();
                    else
                        color = GetColorButtonEnter();
                    break;
            }

			if (!is_active)
			{
				if(colorModeButtonInactive == ColorMode.Multiple)
					color *= GetColorButtonInactive();
				else
					color = GetColorButtonInactive();
			}

            targetGraphic.color = color;
        }

        private void SetTargetGraphicColor(Color select_color, ColorMode select_color_mode, Color status_color, ColorMode status_color_mode, Color active_color, ColorMode active_color_mode)
		{
		}
	}
}
