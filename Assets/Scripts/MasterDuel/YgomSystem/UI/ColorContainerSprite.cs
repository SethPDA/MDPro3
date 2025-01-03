using UnityEngine;

namespace YgomSystem.UI
{
	public class ColorContainerSprite : ColorContainer
	{
		private SpriteRenderer _targetSpriteRenderer;

		public SpriteRenderer targetSpriteRenderer => null;

		public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
		{
		}

		private void SetTargetGraphicColor(SelectMode select_mode, StatusMode status_mode, bool is_active)
		{
		}

		private void SetTargetGraphicColor(Color select_color, ColorMode select_color_mode, Color status_color, ColorMode status_color_mode, Color active_color, ColorMode active_color_mode)
		{
		}
	}
}
