using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ToastMessageInform : InformContentBase
	{
		public enum IconType
		{
			None = 0,
			Inform = 1
		}

		private const string k_PrefPath = "Common/ToastMessage/ToastMessage";

		private const string k_ArgKeyMessage = "message";

		private const string k_ArgKeyYPos = "yPos";

		private const string k_ArgKeyIconType = "icon";

		private const string k_ArgKeyCallback = "callback";

		private readonly string k_ELabelMessageText;

		private readonly string k_ELabelIconImage;

		private readonly string k_TweenShow;

		private readonly string k_TweenHide;

		[SerializeField]
		private ViewCreater m_ViewCreater;

		[SerializeField]
		private float m_LifeSecond;

		[SerializeField]
		private Sprite m_InformSprite;

		private ElementObjectManager m_View;

		private bool _end;

		private Sprite GetArgIcon()
		{
			return null;
		}

		public static void OpenWithBlock(string message, Action callback = null)
		{
		}

		public static void Open(string message, Action callback = null)
		{
		}

		public static void Open(string message, IconType iconType)
		{
		}

		public static void Open(string message, float yPos, IconType iconType)
		{
		}

		private static void InnerOpen(string message, Action callback = null, Dictionary<string, object> args = null)
		{
		}

		public override void OnPush()
		{
		}

		private void OnCreatedView(ElementObjectManager eom)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
