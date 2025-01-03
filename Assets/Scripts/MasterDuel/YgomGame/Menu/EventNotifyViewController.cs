using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu
{
	public class EventNotifyViewController : InformDialogViewControllerBase<string[], Action>
	{
		private const string k_PrefPath = "Common/EventNotify/EventNotify";

		private readonly string k_ELabelRootShow;

		private readonly string k_ELabelRootHide;

		private readonly string k_ELabelTemplate;

		private readonly string k_ELabelText;

		private readonly string k_ELabelShorcutSkip;

		[SerializeField]
		private float m_LifeSecond;

		[SerializeField]
		private float m_IntervalShowSecond;

		[SerializeField]
		private float m_IntervalHideSecond;

		[SerializeField]
		private int m_MaxDisp;

		private GameObject m_RootShow;

		private GameObject m_RootHide;

		private Queue<GameObject> m_HideQueue;

		private bool m_IsSkip;

		public static void Open(string[] messages, Action callback = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public EventNotifyViewController()
		{
			//((InformDialogViewControllerBase<, >)(object)this)._002Ector();
		}
	}
}
