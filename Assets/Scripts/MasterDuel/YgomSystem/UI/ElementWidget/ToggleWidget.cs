using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomSystem.UI.ElementWidget
{
	public class ToggleWidget : ElementWidgetBase
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelOn;

		private readonly string k_ELabelOff;

		private readonly string k_ELabelBadge;

		private readonly string k_PLabelSoundClickOn;

		private readonly string k_PLabelSoundClickOff;

		public readonly SelectionButton button;

		public readonly GameObject onImage;

		public readonly GameObject offImage;

		public readonly PropertyContainer propertyContainer;

		private bool m_IsOn;

		public bool isOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject badge => null;

		public event Action<bool> onChangeValue
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ToggleWidget(ElementObjectManager eom, bool isOn = false)
			: base(null)
		{
		}

		public void ResetIsOn(bool isOn)
		{
		}

		public void UpdateView()
		{
		}

		private void OnClick()
		{
		}
	}
}
