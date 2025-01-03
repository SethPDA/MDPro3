using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class SelectionButton : RectSelectionItem
	{
		[Serializable]
		public class OnClickEvent : UnityEvent
		{

		}

		public delegate void PointerCallback(SelectionItem this_item);

		private Dictionary<GameObject, List<ColorContainer>> colorContainers;

		[SerializeField]
		private string tweenLabelInitialize;

		[SerializeField]
		private string tweenLabelEnter;

		[SerializeField]
		private string tweenLabelDown;

		[SerializeField]
		private string tweenLabelClick;

		[SerializeField]
		private string tweenLabelExit;

		[SerializeField]
		private string tweenLabelSelected;

		[SerializeField]
		private string tweenLabelDeselected;

		[SerializeField]
		public bool playTweenInitialize;

		[SerializeField]
		public bool playTweenEnter;

		[SerializeField]
		public bool playTweenDown;

		[SerializeField]
		public bool playTweenClick;

		[SerializeField]
		public bool playTweenExit;

		[SerializeField]
		public bool playTweenSelected;

		[SerializeField]
		public bool playTweenDeselected;

		[SerializeField]
		public bool playSound;

		[SerializeField]
		private string _soundLabelClick;

		[SerializeField]
		private string _soundLabelClickInactive;

		[SerializeField]
		private string _soundLabelPointerEnter;

		[SerializeField]
		private string _soundLabelSelectedGamePad;

		private ColorContainer.SelectMode currentSelectMode;

		private ColorContainer.StatusMode currentStatusMode;

		public OnClickEvent onClick;

		public OnClickEvent onDoubleClick;

		public int colorContainerIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string soundLabelClick
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string soundLabelClickInactive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string soundLabelPointerEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string soundLabelSelectedGamePad
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isClickExclusive
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event PointerCallback onEnter
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

		public event PointerCallback onExit
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

		public event PointerCallback onDown
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

		public event PointerCallback onUp
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

		protected override void Awaked()
		{
		}

		protected override void Destroyed()
		{
		}

		public override UpdateItemStatus UpdateItem()
		{
			return default(UpdateItemStatus);
		}

		public override UpdateItemStatus UpdateSelectedItem()
		{
			return default(UpdateItemStatus);
		}

		public void SetupColorContainer()
		{
		}

		private void SetColorContainerColor(ColorContainer.SelectMode select_mode, ColorContainer.StatusMode status_mode)
		{
		}

		public void SetColorContainerIndex(int index)
		{
		}

		public override bool OnPointerClick()
		{
			return false;
		}

		public override bool OnPointerDoubleClick()
		{
			return false;
		}

		public override bool OnPointerDown()
		{
			return false;
		}

		public void PointerDownEffect()
		{
		}

		public override bool OnPointerEnter()
		{
			return false;
		}

		public void PointerEnterEffect(bool pointerDown)
		{
		}

		public override bool OnPointerExit()
		{
			return false;
		}

		public void PointerExitEffect(bool pointerDown)
		{
		}

		public override bool OnPointerUp()
		{
			return false;
		}

		public void PointerUpEffect()
		{
		}

		public override bool OnSelected(bool initializeSelection = false)
		{
			return false;
		}

		public void SelectEffect(bool initializeSelection = false)
		{
		}

		public override bool OnDeselected()
		{
			return false;
		}

		public void DeselectEffect()
		{
		}

		private void OnClick()
		{
		}

		private void OnDoubleClick()
		{
		}

		public void Click()
		{
		}

		private bool ClickFunc()
		{
			return false;
		}

		private void PlayTween(string play_label, string stop_label = null)
		{
		}

		private void PlaySound(string label)
		{
		}

		public void SetClickShortCutKeyDown(int gamepad_key_type)
		{
		}

		public void SetClickShortCutKeyDown(SelectorManager.KeyType key_type)
		{
		}

		public void SetClickShortCutKeyDown(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
		{
		}

		public void RemoveClickShortCutKeyDown(SelectorManager.KeyType key_type)
		{
		}

		public void RemoveClickShortCutKeyDown(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
		{
		}

		public void SetClickShortCutKeyRelease(SelectorManager.KeyType key_type)
		{
		}

		public void SetClickShortCutKeyRelease(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
		{
		}

		public void RemoveClickShortCutKeyRelease(SelectorManager.KeyType key_type)
		{
		}

		public void RemoveClickShortCutKeyRelease(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
		{
		}

		public void SetClickShortCutMouseRelease(SelectorManager.MouseType mouse_type)
		{
		}

		public void RemoveClickShortCutMouseRelease(SelectorManager.MouseType mouse_type)
		{
		}

		public void SetClickShortCutMouseDown(SelectorManager.MouseType mouse_type)
		{
		}

		public void RemoveClickShortCutMouseDown(SelectorManager.MouseType mouse_type)
		{
		}
	}
}
