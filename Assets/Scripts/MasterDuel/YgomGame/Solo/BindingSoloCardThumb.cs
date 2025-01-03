using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;

namespace YgomGame.Solo
{
	public class BindingSoloCardThumb : MonoBehaviour, IAsyncProgressContent
	{
		private enum BindTargetType
		{
			DEFAULT = 0,
			OTHER = 1
		}

		private RectTransform m_RectTransform;

		private RectTransform m_RectMask;

		private RawImage m_CardTextureImage;

		private AspectRatioFitter m_AspectRatioFitter;

		private SoloCardThumbSettings.ThumbSetting m_ThumbSetting;

		public bool isReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static BindingSoloCardThumb Binding(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting, BindTargetType bindTargetType)
		{
			return null;
		}

		public static BindingSoloCardThumb Binding(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting)
		{
			return null;
		}

		public static BindingSoloCardThumb BindingOther(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void InnerBinding(SoloCardThumbSettings.ThumbSetting thumbSetting, BindTargetType bindTargetType)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		private void OnLoadCardTextureComplete(BindTargetType bindTargetType)
		{
		}
	}
}
