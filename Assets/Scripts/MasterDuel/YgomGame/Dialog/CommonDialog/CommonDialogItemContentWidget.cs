using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogItemContentWidget : ContentWidgetBase<CommonDialogItemContentWidget, EntryItemContentData>, IContentWidgetAsyncLoader
	{
		public class StrechRectTransformChanger
		{
			private readonly int left;

			private readonly int right;

			private readonly int top;

			private readonly int bottom;

			public StrechRectTransformChanger(int left, int right, int top, int bottom)
			{
			}

			public void ApplayRect(RectTransform targetRect)
			{
			}
		}

		private readonly string k_ELabelNameText;

		private readonly string k_ELabelCategoryText;

		private readonly string k_ELabelNumText;

		private readonly string k_ELabelThumbHolder;

		private readonly string k_ELabelBadgeLocator;

		private readonly string k_ELabelButton;

		private readonly string k_ELabelEffectRawImage;

		private readonly string k_ALabelItemObtainEffect;

		private TMP_Text m_NameText;

		private TMP_Text m_CategoryText;

		private TMP_Text m_Text;

		//private RawImage m_EffectRawImage;

		private GameObject m_RenderTarget;

		private int m_RtId;

		private StrechRectTransformChanger structureCursorRect;

		public static CommonDialogItemContentWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		public void AsyncBinding(IEntryData entryData, Action onComplete)
		{
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryItemContentData entryData)
		{
		}

		//protected override void Start()
		//{
		//}

		//protected override void OnDestroy()
		//{
		//}

		public CommonDialogItemContentWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
