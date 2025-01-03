using UnityEngine;
using YgomSystem.Effect;

namespace YgomSystem.UI
{
	public class SelectorCameraSetter : MonoBehaviour
	{
		public enum FindType
		{
			ByParentCanvas = 0,
			ByScreenEffect = 1
		}

		public FindType findType;

		public ScreenEffect targetScreenEffect;

		private void Start()
		{
		}

		private Camera FindCamera()
		{
			return null;
		}

		public static Camera FindCameraByParentCanvas(GameObject target)
		{
			return null;
		}

		public static Camera FindCameraByScreenEffect(GameObject target, ScreenEffect screenEffect)
		{
			return null;
		}
	}
}
