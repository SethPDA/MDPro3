using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame
{
	public class CardCheckViewController : ViewController
	{
		private const string LABEL_EO_CARDID = "CardId";

		private const string LABEL_EO_TSIZE = "TextSize";

		private const string LABEL_EO_TSIZE_P = "TextSize_P";

		private const string LABEL_EO_NLENGTH = "NameLength";

		private const string LABEL_EO_TLENGTH = "TextLength";

		private const string LABEL_EO_TLENGTH_P = "TextLength_P";

		private const string LABEL_EO_TOGGLE = "Toggle";

		private const string LABEL_EO_CHECK = "Check";

		private const string LABEL_EO_RANDOM = "Random";

		private const string LABEL_EO_UPDATEFONT = "UpdateFont";

		private const string LABEL_EO_MASK = "Mask";

		private const string LABEL_EO_INPUT_FIELD = "InputField";

		private const string LABEL_EO_COUNTER = "Counter";

		private const string LABEL_EO_STARTID = "StartId";

		private const string LABEL_EO_ENDID = "EndId";

		private const string LABEL_EO_DURATION = "Duration";

		private const string LABEL_EO_PLAY = "Play";

		private const string LABEL_EO_PAUSE = "Pause";

		private const string LABEL_EO_DROPDOWNLANGUAGE = "DropDownLanguage";

		private const string LABEL_EO_UPDATELANGUAGE = "UpdateLanguage";

		private const string LABEL_EO_TOGGLEALLLANGUAGE = "ToggleAllLanguage";

		private const string LABEL_EO_LANGUAGE00 = "ja-JP";

		private const string LABEL_EO_LANGUAGE01 = "en-US";

		private const string LABEL_EO_LANGUAGE02 = "fr-FR";

		private const string LABEL_EO_LANGUAGE03 = "it-IT";

		private const string LABEL_EO_LANGUAGE04 = "de-DE";

		private const string LABEL_EO_LANGUAGE05 = "es-ES";

		private const string LABEL_EO_LANGUAGE06 = "pt-BR";

		private const string LABEL_EO_LANGUAGE07 = "ko-KR";

		private const string LABEL_EO_LANGUAGE08 = "zh-TW";

		private const string LABEL_EO_LANGUAGE09 = "zh-CN";

		private string[] LABEL_EO_LANGUAGE;

		private const string LABEL_EO_IMAGETYPE = "ImageType";

		private const string LABEL_EO_OCG = "OCG";

		private const string LABEL_EO_TCG = "TCG";

		private const string LABEL_EO_ILLUST = "Illust";

		private const string LABEL_EO_ILLUST_HD = "Illust_HD";

		private const string LABEL_EO_FRAME_M = "FrameM";

		private const string LABEL_EO_FRAME_P = "FrameP";

		private const string LABEL_EO_FRAME_ST = "FrameST";

		private const string LABEL_EO_INPUT = "Input";

		private const string LABEL_EO_STYLE_NORMAL = "NormalStyle";

		private const string LABEL_EO_STYLE_SHINE = "ShineStyle";

		private const string LABEL_EO_STYLE_ROYAL = "RoyalStyle";

		private const string LABEL_EO_TOGGLE_SAVE_IMAGE = "SaveImage";

		private const string LABEL_EO_TOGGLE_SAVE_FONTINFO = "SaveFontSize";

		private const string LABEL_EO_TOGGLE_CLEAR_FONTINFO = "ClearFontSize";

		private const string LABEL_EO_TOGGLE_CHECK_FONTINFO = "CheckFontSize";

		private List<int> m_InputMRKList;

		private bool m_AutoPlay;

		private ElementObjectManager m_Eom;

		private int CARDNUM;

		private int m_CurrentPicture;

		private List<RawImage> m_CardPictures;

		private List<int> m_TargetList;

		private int m_ListId;

		private int m_ListEnd;

		private int m_StyleId;

		private Selector m_Selector;

		private bool m_isOCG;

		private string CurrentLang;

		private int m_CardId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_FSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_FSize_P
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_NLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_TLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_TLength_P
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_StartId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int m_EndId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private float m_Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private SelectionButton m_CheckButton => null;

		private SelectionButton m_RandomButton => null;

		private SelectionButton m_UpdateFontButton => null;

		private RawImage m_CardPicture => null;

		private SelectionButton m_Play => null;

		private SelectionButton m_Pause => null;

		private UnityEngine.UI.Toggle[] m_LanguageToggles => null;

		private SelectionButton[] m_UpdateLanguage => null;

		private Dropdown m_DropDwonLanguage => null;

		private SelectionButton m_Language => null;

		private UnityEngine.UI.Toggle m_ToggleAllLanguage => null;

		private SelectionButton m_AllLanguage => null;

		private MDText m_imageTypeText => null;

		private UnityEngine.UI.Toggle m_ToggleFrame_M => null;

		private SelectionButton m_Frame_M => null;

		private bool m_IsFrame_M => false;

		private UnityEngine.UI.Toggle m_ToggleFrame_P => null;

		private SelectionButton m_Frame_P => null;

		private bool m_IsFrame_P => false;

		private UnityEngine.UI.Toggle m_ToggleFrame_ST => null;

		private SelectionButton m_Frame_ST => null;

		private bool m_IsFrame_ST => false;

		private SelectionButton m_NormalStyleButton => null;

		private SelectionButton m_ShineStyleButton => null;

		private SelectionButton m_RoyalStyleButton => null;

		private SelectionButton m_InputListButton => null;

		private SelectionButton m_SaveImage => null;

		private SelectionButton m_SaveFontSize => null;

		private SelectionButton m_ClearFontSize => null;

		private SelectionButton m_CheckDataMode => null;

		private UnityEngine.UI.Toggle m_ToggleSaveImage => null;

		private bool m_IsAllLanguage => false;

		private void Start()
		{
		}

		private IEnumerator OnStart()
		{
			return null;
		}

		private void Update()
		{
		}

		private void DebugPrintCardData(int mrk)
		{
		}

		private void MakeTargetList()
		{
		}

		private void MakeTargetListforAll()
		{
		}

		private void UpdateFontSize()
		{
		}

		private void UpdateCardAsync()
		{
		}

		private void UpdateCardOneAsync()
		{
		}

		private void ChangeLanguage(string lang)
		{
		}

		private void SaveCardImageAsJpg(Texture texture, int cardId)
		{
		}

		private IEnumerator AutoUpdateCard()
		{
			return null;
		}

		private void InputList(string country)
		{
		}

		private void NameCheck(string country)
		{
		}

		private void ContainsCheck(string country)
		{
		}
	}
}
