using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Credit
{
	public class CreditEneconWidget
	{
		private readonly string BTN_ENECONICON_LABEL;

		private readonly string IMAGE_CARD_LABEL;

		private readonly string BTN_UP_LABEL;

		private readonly string BTN_DOWN_LABEL;

		private readonly string BTN_RIGHT_LABEL;

		private readonly string BTN_LEFT_LABEL;

		private readonly string BTN_A_LABEL;

		private readonly string BTN_B_LABEL;

		private readonly string BTN_C_LABEL;

		private readonly string BTN_START_LABEL;

		private readonly string ENECON_ROOT_LABEL;

		private readonly string TLABEL_ENECONIN;

		private readonly string TLABEL_ENECONOUT;

		private readonly string TLABEL_ENECONUP;

		private readonly string TLABEL_ENECONDOWN;

		private readonly string TLABEL_ENECONRIGHT;

		private readonly string TLABEL_ENECONLEFT;

		private readonly string TLABEL_ENECONA;

		private readonly string TLABEL_ENECONB;

		private readonly string TLABEL_ENECONC;

		private readonly string TLABEL_ENECONSTART;

		private readonly string TLABEL_CARDIN;

		private readonly string TLABEL_CARDOUT;

		private readonly int ENECON_MRK;

		private string m_tLabelEneconIn;

		private string m_tLabelEneconOut;

		private ElementObjectManager m_Eom;

		private GameObject m_eneconRootGO;

		private RawImage m_cardRawImage;

		private GameObject m_eneconObject;

		private bool m_eneconIsActive;

		private bool m_goIsActive;

		private bool m_useVirtualEnecon;

		public List<(string, Action<KeyCommand.OnKeyResult>)> labelCallBackPairs;

		private List<KeyCommand> m_keyCommandList;

		public Action<KeyCommand.OnKeyResult> OnKonamiCommandResultCallback;

		public Action<KeyCommand.OnKeyResult> OnEneconReleaseResultCallback;

		public Action<KeyCommand.OnKeyResult> OnEneconBreakResultCallback;

		private ElementObjectManager m_eneconEom;

		public bool EneconIsActive => false;

		public CreditEneconWidget(ElementObjectManager eom)
		{
		}

		private void PlayButtonTween(string label)
		{
		}

		public void RegistCallbacks()
		{
		}

		private void OnEneconIconClick()
		{
		}
	}
}
