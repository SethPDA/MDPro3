using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class SorterToggle : MonoBehaviour
	{
		private UnityAction m_OnClickAscAction;

		private UnityAction m_OnClickDescAction;

		private const string LABEL_SBN_ASCBUTTON = "Button0";

		private const string LABEL_SBN_DESCBUTTON = "Button1";

		private const string LABEL_RT_ASCIMAGEOFF = "ImageOff0";

		private const string LABEL_RT_ASCIMAGEON = "ImageOn0";

		private const string LABEL_RT_DESCIMAGEOFF = "ImageOff1";

		private const string LABEL_RT_DESCIMAGEON = "ImageOn1";

		private const string LABEL_TXT_METHODTEXT = "Label";

		private ElementObjectManager m_eom => null;

		private ExtendedTextMeshProUGUI m_MethodLabel => null;

		private RectTransform m_AscImageOff => null;

		private RectTransform m_AscImageOn => null;

		private RectTransform m_DescImageOff => null;

		private RectTransform m_DescImageOn => null;

		private SelectionButton m_AscButton => null;

		private SelectionButton m_DescButton => null;

		public void Initialize(string label, bool isAscOn, bool isDescOn)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetOnClickAscCallback(UnityAction callback)
		{
		}

		public void SetOnClickDescCallback(UnityAction callback)
		{
		}

		public void SetDownTransitionItem(SelectionItem item)
		{
		}
	}
}
