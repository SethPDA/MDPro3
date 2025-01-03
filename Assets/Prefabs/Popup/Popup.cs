using DG.Tweening;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace MDPro3.UI.Popup
{
    public class Popup : MonoBehaviour
    {
        [Header("Popup")]
        public Selectable lastSelectable;

        [HideInInspector] public List<string> args;
        [HideInInspector] public float transitionTime = 0.2f;
        public Action quitAction;

        private ElementObjectManager m_Manager;
        protected ElementObjectManager Manager
        {
            get 
            {
                if (m_Manager == null)
                    m_Manager = GetComponent<ElementObjectManager>();
                return m_Manager; 
            }
        }
        protected bool inTransition = true;
        protected bool cancelCallHide = true;

        private Popup lastPopup;

        protected virtual void Initialize()
        {
            var closeButton = Manager.GetElement("CloseButton");
            if (closeButton != null)
            {
                if (closeButton.TryGetComponent<Button>(out var btn))
                    btn.onClick.AddListener(Hide);
                if (closeButton.TryGetComponent<CanvasGroup>(out var cg))
                    cg.alpha = 0f;
            }
            Manager.GetElement<RectTransform>("Content").anchoredPosition = new Vector2(0f, -1080f);

            UIManager.Translate(gameObject);
            SetButtonsLayout();

            lastPopup = Program.instance.ui_.currentPopupB;
            Program.instance.ui_.currentPopupB = this;

            InitializeSelections();
        }

        protected virtual void InitializeSelections()
        {
            if (Manager.GetElement("TitleText") != null && args != null && args.Count > 0)
                Manager.GetElement<TextMeshProUGUI>("TitleText").text = args[0];
        }

        public virtual void Show()
        {
            Initialize();
            Manager.GetElement<RectTransform>("Content").DOAnchorPosY(0f, transitionTime).SetEase(Ease.OutCubic).OnComplete(() =>
            {
                inTransition = false;
                if (Cursor.lockState == CursorLockMode.Locked)
                    SelectLastSelected();
            });

            if (Manager.GetElement("CloseButton") != null)
                Manager.GetElement<CanvasGroup>("CloseButton").DOFade(0.8f, transitionTime);
        }
        public virtual void Hide()
        {
            inTransition = true;
            Manager.GetElement<RectTransform>("Content").DOAnchorPosY(-1080f, transitionTime).SetEase(Ease.InCubic).OnComplete(() =>
            {
                Destroy(gameObject);
                Program.instance.ui_.currentPopupB = lastPopup;
                quitAction?.Invoke();

                if (Cursor.lockState == CursorLockMode.Locked)
                {
                    if (lastPopup != null)
                        lastPopup.SelectLastSelected();
                    else
                        Program.instance.currentServant.SelectLastSelectable();
                }
            });

            if (Manager.GetElement("CloseButton") != null)
                Manager.GetElement<CanvasGroup>("CloseButton").DOFade(0f, transitionTime);
        }

        protected virtual void OnDecide()
        {
            Hide();
        }
        protected virtual void OnCancel()
        {
            Hide();
        }

        protected virtual void SetButtonsLayout()
        {
            var btnCancel = Manager.GetElement("CancelButton");
            var btnDecide = Manager.GetElement("DecideButton");

            if(btnCancel != null)
                btnCancel.GetComponent<Button>().onClick.AddListener(OnCancel);
            if(btnDecide != null)
                btnDecide.GetComponent<Button>().onClick.AddListener(OnDecide);

            if (btnCancel == null || btnDecide == null)
                return;

            var buttonCancel = btnCancel.GetComponent<Button>();
            var buttonDecide = btnDecide.GetComponent<Button>();

            if (Config.GetBool("Confirm", false))
            {
                btnDecide.transform.SetSiblingIndex(1);
                var navigation = buttonCancel.navigation;
                navigation.selectOnRight = null;
                buttonCancel.navigation = navigation;

                navigation = buttonDecide.navigation;
                navigation.selectOnLeft = null;
                buttonDecide.navigation = navigation;
            }
            else
            {
                var navigation = buttonCancel.navigation;
                navigation.selectOnLeft = null;
                buttonCancel.navigation = navigation;

                navigation = buttonDecide.navigation;
                navigation.selectOnRight = null;
                buttonDecide.navigation = navigation;
            }
        }

        protected virtual void SelectLastSelected()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectable.gameObject);
        }

        protected virtual void OnEnable()
        {
            UserInput.OnMouseCursorHide += SelectLastSelected;
        }
        protected virtual void OnDisable()
        {
            UserInput.OnMouseCursorHide -= SelectLastSelected;
        }

        protected virtual bool NeedResponseInput()
        {
            if (inTransition)
                return false;
            if (Program.instance.ui_.currentPopupB != this)
                return false;

            return true;
        }

        protected virtual void Update()
        {
            if (!NeedResponseInput())
                return;
            
            if ((UserInput.MouseRightDown || UserInput.WasCancelPressed) && cancelCallHide)
            {
                AudioManager.PlaySE("SE_MENU_CANCEL");
                Hide();
            }
        }
    }
}
