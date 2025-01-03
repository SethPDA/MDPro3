using UnityEngine;

namespace YgomSystem.UI
{
	public class ColorContainerMatHDR : ColorContainer
	{
		public string colorParamName;

		private Renderer m_TargetRenderer;

		private Renderer targetRenderer => null;

		private Color GetColorByMode(SelectMode selectMode, StatusMode statusMode, bool isActive)
		{
			return default(Color);
		}

		public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
		{
		}
	}
}
