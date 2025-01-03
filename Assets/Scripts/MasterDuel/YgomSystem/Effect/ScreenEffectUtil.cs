using UnityEngine;

namespace YgomSystem.Effect
{
	public static class ScreenEffectUtil
	{
		public static int layer3DOnUI;

		private static Camera _defaultCamera3DOnUI;

		public static int layer2DOnUI;

		private static Camera _defaultCamera2DOnUI;

		public static int layer3D;

		private static Camera _defaultCamera3D;

		public static int layer2D;

		private static Camera _defaultCamera2D;

		public static Camera defaultCamera3DOnUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Camera defaultCamera2DOnUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Camera defaultCamera3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Camera defaultCamera2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
