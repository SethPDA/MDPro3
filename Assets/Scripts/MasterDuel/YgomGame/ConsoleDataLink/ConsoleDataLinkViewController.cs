using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.YGomTMPro;

namespace YgomGame.ConsoleDataLink
{
	public class ConsoleDataLinkViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string TEXT_TOP_LABEL;

		private readonly string TEXT_DESC1_LABEL;

		private readonly string TEXT_CAUTION_LABEL;

		private readonly string BUTTON_LINK_LABEL;

		private readonly string TEXT_DESC3_LABEL;

		private readonly string IMAGE_ICON_LEFT;

		private readonly string IMAGE_ICON_RIGHT;

		private readonly string IMAGE_ICON_ARROW;

		private readonly string IMAGE_TEXT_TOP_BG;

		private Image m_imageIconLeft;

		private Image m_imageIconRight;

		private Image m_imageIconArrow;

		private Image m_imageTextTopBG;

		[SerializeField]
		protected Sprite iconCloud;

		[SerializeField]
		protected Sprite iconUser;

		[SerializeField]
		protected Sprite iconArrow;

		private readonly List<string> m_labelList;

		private List<ExtendedTextMeshProUGUI> m_textList;

		private ExtendedTextMeshProUGUI m_urlText;

		private GameObject m_QRRootGO;

		private GameObject m_ButtonRootGO;

		private readonly string ROOT_QR_LABEL;

		private readonly string TEXT_URL_LABEL;

		private readonly string RAWIMAGE_QRCODE_LABEL;

		private string m_url;

		private readonly string ROOT_ID_LABEL;

		private readonly string BUTTON_KONAMIID_LABEL;

		private readonly string BUTTON_GOOGLEPLAY_LABEL;

		private readonly string TEXT_LABEL;

		protected bool m_isMobile;

		protected override void OnCreatedView()
		{
		}

		private void SetUpView()
		{
		}

		protected void SetIconArrow(Sprite arrow)
		{
		}

		protected void SetIconLeft(Sprite leftIcon)
		{
		}

		protected void SetIconRight(Sprite rightIcon)
		{
		}

		protected void SetImage(Sprite sprite, Image image)
		{
		}

		protected void PlayColorTween(string label)
		{
		}

		protected void SetText(int index, string text)
		{
		}

		protected void SetCaution(string text)
		{
		}

		protected void HideText(int index)
		{
		}

		protected void HideCaution()
		{
		}

		private void JumpToLink()
		{
		}

		protected void SetURL(string url)
		{
		}

		protected void SetKonamiIDButtonCallBack(UnityAction callback)
		{
		}

		protected void SetSocialPlatformButtonCallBack(UnityAction callback)
		{
		}

		protected void OpenUnavailableDialog(string explanation)
		{
		}

		protected void OpenFailureDialog(string explanation)
		{
		}
	}
}
