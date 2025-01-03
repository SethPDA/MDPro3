using System;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.DeckBrowser
{
	public class PickupCursorWidget : ElementWidgetBehaviourBase<PickupCursorWidget>
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/PickupCursor";

		private readonly string k_ELabelText;

		private bool m_IsActive;

		private GameObject m_GameObject;

		private int m_PickupId;

		private ExtendedTextMeshProUGUI m_Text;

		public Action onClickedCallback;

		public Action onCreated;

		public bool isActive => false;

		public int pickupId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Initialize(ElementObjectManager eom, int pickupId = -1)
		{
		}

		public static void Create(Transform parent, Action<PickupCursorWidget> onCreated, int pickupId = -1)
		{
		}

		private void SetPickupId(int pickupId)
		{
		}

		public PickupCursorWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
