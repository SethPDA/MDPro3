using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame
{
	public class PopUpTextManager
	{
		private struct PUTData
		{
			public Func<string> text;

			public bool isforui;

			//public PUTData(Func<string> text, bool isforui)
			//{
			//}
		}

		public enum Mode
		{
			OnPointerEnter = 0,
			OnSelected = 1
		}

		private GameObject m_Template;

		private Queue<PopUpText> m_FreeInstanceQueue;

		private Queue<PopUpText> m_AllInstanceQueue;

		private Dictionary<Mode, Dictionary<SelectionButton, PUTData>> m_PopUpBtnTable;

		private Dictionary<SelectionButton, PopUpText> m_SbtnPutTable;

		public bool Initialized
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

		public static PopUpTextManager Create(UnityAction onFinish = null)
		{
			return null;
		}

		private void Initialize(UnityAction onFinish)
		{
		}

		public void Terminate()
		{
		}

		public void RegistPopUpCallback(SelectionButton sbtn, Func<string> text, bool isforui = true, Mode mode = Mode.OnPointerEnter)
		{
		}

		private void OnEnterPopUpArea(SelectionButton sbtn, Mode mode = Mode.OnPointerEnter)
		{
		}

		private void OnExitPopUpArea(SelectionButton sbtn)
		{
		}

		public void RemovePopUpCallback(SelectionButton sbtn, Mode mode = Mode.OnPointerEnter)
		{
		}

		public bool UpdatePopUpText(SelectionButton sbtn, Func<string> text, Mode mode = Mode.OnPointerEnter)
		{
			return false;
		}

		public void UpdateTextData(SelectionButton sbtn, Mode mode, Func<string> text)
		{
		}

		public void HidePopUpText()
		{
		}

		private PopUpText GetPutInstance()
		{
			return null;
		}

		private void CreatePutInstance()
		{
		}

		private void ReturnInstance(PopUpText instance)
		{
		}
	}
}
