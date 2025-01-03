using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Settings;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class ActivateConfirmToggle : MonoBehaviour
	{
		private DuelHUD duelHUD;

		private ElementObjectManager ui;

		private SelectionButton button;

		private SelectionItem shortcut;

		private GameObject autoIcon;

		private GameObject onIcon;

		private GameObject offIcon;

		private GameObject shortcutIcon;

		private Image autoIconImage;

		private Image onIconImage;

		private Image offIconImage;

		private DuelClient.ActivateConfirmMode reqMode;

		private DuelClient.ActivateConfirmMode buttonMode;

		private float setOnTimer;

		private float setOffTimer;

		private const float setDelayTime = 0.2f;

		private bool reqDelaySet;

		private bool callbackRegisted;

		private List<uint> callbackIDs;

		public bool forceCancelMode
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

		public void Initialize(ElementObjectManager ui, DuelHUD duelHUD)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void OnClickToggle(bool playActionAnime)
		{
		}

		private void SetMode(DuelClient.ActivateConfirmMode mode)
		{
		}

		public void SetDisp(bool disp)
		{
		}

		public void SetManualType(SettingsUtil.DuelParam.MANUAL_TYPE type)
		{
		}

		public void SetIcon(DuelClient.ActivateConfirmMode mode)
		{
		}
	}
}
