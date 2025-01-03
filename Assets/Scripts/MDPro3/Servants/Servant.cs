using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine.EventSystems;
using YgomSystem.ElementSystem;

namespace MDPro3.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    [RequireComponent(typeof(ElementObjectManager))]
    public class Servant : MonoBehaviour
    {
        [Header("Servant")]
        [SerializeField] protected Selectable defaultSeletable;

        [HideInInspector] public bool showing;
        [HideInInspector] public bool inTransition;
        [HideInInspector] public int depth;
        [HideInInspector] public Selectable Selected;
        [HideInInspector] public Servant returnServant;

        public Action returnAction;

        protected bool showLine;
        protected bool needExit = true;
        protected float transitionTime = 0.4f;
        protected float blackAlpha = 0f;
        protected float subBlackAlpha = 0f;
        protected CanvasGroup cg;

        private ElementObjectManager m_Manager;
        public ElementObjectManager Manager 
        {
            get
            {
                if(m_Manager == null)
                    m_Manager = GetComponent<ElementObjectManager>();
                return m_Manager;
            }
        }

        public virtual void Initialize()
        {
            cg = GetComponent<CanvasGroup>();

            if (depth != 0)
            {
                cg.alpha = 0f;
                cg.blocksRaycasts = false;
                //transform.GetChild(0).gameObject.SetActive(false);
            }

            UserInput.OnMouseCursorHide += OnMouseCursorHide;
        }

        public void Show(int preDepth)
        {
            if (!showing)
            {
                showing = true;
                ApplyShowArrangement(preDepth);
            }
        }

        public void Hide(int preDepth)
        {
            if (showing)
            {
                showing = false;
                ApplyHideArrangement(preDepth);
            }
        }

        public virtual void PerFrameFunction()
        {
            if (!showing)
                return;
            if (NeedResponseInput())
            {
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();
            }
        }

        public virtual void OnReturn()
        {
            if (inTransition) return;
            AudioManager.PlaySE("SE_MENU_CANCEL");
            if (returnAction != null)
            {
                returnAction.Invoke();
                return;
            }
            else
                OnExit();
        }

        public virtual void OnExit()
        {
            if (Program.instance.currentSubServant == this)
            {
                if (this is Setting)
                {
                    Hide(0);
                    Program.instance.currentSubServant = null;
                }
                else
                    Program.instance.ShowSubServant(returnServant);
            }
            else
                Program.instance.ShiftToServant(returnServant);
        }

        public virtual void SelectLastSelectable()
        {
            if (Selected != null)
                EventSystem.current.SetSelectedGameObject(Selected.gameObject);
            else if (defaultSeletable != null)
                EventSystem.current.SetSelectedGameObject(defaultSeletable.gameObject);
        }

        public virtual void JudgeInputBlockerExitMark(object o)
        {
        }

        protected virtual void ApplyShowArrangement(int preDepth)
        {
            transform.GetChild(0).gameObject.SetActive(true);

            bool blackTransition = false;
            if (Program.instance.currentServant == this && preDepth == -1)
                blackTransition = true;

            if (blackTransition)
            {
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    cg.alpha = 1f;
                    cg.blocksRaycasts = true;
                    if (needExit)
                        UIManager.ShowExitButton(0);
                    else
                        UIManager.HideExitButton(0);

                    if (showLine)
                        UIManager.ShowLine(0);
                    else
                        UIManager.HideLine(0);
                    RectTransform t = transform.GetChild(0).GetComponent<RectTransform>();
                    t.localEulerAngles = Vector3.zero;
                    t.anchoredPosition3D = Vector3.zero;

                    if(Manager.GetElement("LeftPart") != null && Manager.GetElement("RightPart") != null)
                    {
                        var leftPart = Manager.GetElement<RectTransform>("LeftPart");
                        leftPart.DOAnchorPosX(0f, 0f);
                        var rightPart = Manager.GetElement<RectTransform>("RightPart");
                        rightPart.DOAnchorPosX(0f, 0f);
                    }
                });
            }
            else
            {
                inTransition = true;

                if (Manager.GetElement("LeftPart") != null && Manager.GetElement("RightPart") != null)
                    Show_Push();
                else
                    Show_Uncover(preDepth);

                if (needExit)
                    UIManager.ShowExitButton(transitionTime);
                else
                    UIManager.HideExitButton(transitionTime);
                if (showLine)
                    UIManager.ShowLine(transitionTime);
                else
                    UIManager.HideLine(transitionTime);

                Program.instance.ui_.blackBack.DOFade(Program.instance.currentServant.depth == -1 ? subBlackAlpha : blackAlpha, transitionTime)
                    .OnComplete(() =>
                    {
                        inTransition = false;
                        cg.blocksRaycasts = true;
                        if (depth > 0)
                            Program.instance.ui_.blackBack.raycastTarget = true;

                        if (Cursor.lockState == CursorLockMode.Locked)
                            SelectLastSelectable();
                    });
            }
        }
        protected virtual void Show_Uncover(int preDepth)
        {
            cg.alpha = 0f;
            DOTween.Sequence()
                .AppendInterval(0.15f)
                .Append(cg.DOFade(1f, 0.3f).SetEase(Ease.Linear));

            RectTransform t = transform.GetChild(0).GetComponent<RectTransform>();
            if (depth < preDepth)
            {
                t.anchoredPosition3D = new Vector3(-240f, 0f, -360f);
                DOTween.Sequence()
                    .AppendInterval(0.15f)
                    .Append(t.DOAnchorPos3D(Vector3.zero, 0.5f).SetEase(Ease.OutQuart));
                t.localEulerAngles = new Vector3(0f, 15f, 0f);
                DOTween.Sequence()
                    .AppendInterval(0.15f)
                    .Append(t.DOLocalRotate(Vector3.zero, 0.5f).SetEase(Ease.OutQuart));
            }
            else
            {
                t.anchoredPosition3D = new Vector3(240f, 0f, 360f);
                DOTween.Sequence()
                    .AppendInterval(0.15f)
                    .Append(t.DOAnchorPos3D(Vector3.zero, 0.5f).SetEase(Ease.OutQuart));
                t.localEulerAngles = new Vector3(0f, -15f, 0f);
                DOTween.Sequence()
                    .AppendInterval(0.15f)
                    .Append(t.DOLocalRotate(Vector3.zero, 0.5f).SetEase(Ease.OutQuart));
            }
        }
        protected virtual void Show_Push()
        {
            cg.alpha = 0f;
            DOTween.Sequence()
                .AppendInterval(0.2f)
                .Append(cg.DOFade(1f, 0.4f).SetEase(Ease.Linear));

            var leftPart = Manager.GetElement<RectTransform>("LeftPart");
            leftPart.anchoredPosition = new Vector2(-1500f, 0f);
            DOTween.Sequence()
                .AppendInterval(0.2f)
                .Append(leftPart.DOAnchorPosX(0f, 0.4f).SetEase(Ease.OutQuart));

            var rightPart = Manager.GetElement<RectTransform>("RightPart");
            rightPart.anchoredPosition = new Vector2(1500f, 0f);
            DOTween.Sequence()
                .AppendInterval(0.2f)
                .Append(rightPart.DOAnchorPosX(0f, 0.4f).SetEase(Ease.OutQuart));
        }

        protected virtual void ApplyHideArrangement(int nextDepth)
        {
            bool blackTransition = false;
            if (nextDepth == -1)
                blackTransition = true;

            if (blackTransition)
            {
                if (cg != null)
                {
                    DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                    {
                        cg.alpha = 0f;
                        cg.blocksRaycasts = false;
                    });
                }
            }
            else
            {
                inTransition = true;
                if (Manager.GetElement("LeftPart") != null && Manager.GetElement("RightPart") != null)
                    Hide_Pop();
                else
                    Hide_Cover(nextDepth);
                DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
                {
                    inTransition = false;
                    transform.GetChild(0).gameObject.SetActive(false);
                });
            }
            if (nextDepth <= 0)
            {
                UIManager.HideExitButton(transitionTime);
                Program.instance.ui_.blackBack.DOFade(0, transitionTime).OnComplete(() =>
                {
                    Program.instance.ui_.blackBack.raycastTarget = false;
                });
            }
        }
        protected virtual void Hide_Cover(int nextDepth)
        {
            cg.blocksRaycasts = false;
            cg.DOFade(0f, 0.2f).SetEase(Ease.Linear);

            RectTransform t = transform.GetChild(0).GetComponent<RectTransform>();
            if (depth < nextDepth)
            {
                t.DOAnchorPos3D(new Vector3(-240f, 0f, -360f), 0.2f).SetEase(Ease.InCubic);
                t.DOLocalRotate(new Vector3(0f, 15f, 0f), 0.2f).SetEase(Ease.InCubic);
            }
            else
            {
                t.DOAnchorPos3D(new Vector3(240f, 0f, 360f), 0.2f).SetEase(Ease.InCubic);
                t.DOLocalRotate(new Vector3(0f, -15f, 0f), 0.2f).SetEase(Ease.InCubic);
            }
        }
        protected virtual void Hide_Pop()
        {
            cg.blocksRaycasts = false;
            cg.DOFade(0f, 0.25f).SetEase(Ease.Linear);
            Manager.GetElement<RectTransform>("LeftPart").DOAnchorPosX(-1500f, 0.25f).SetEase(Ease.InCubic);
            Manager.GetElement<RectTransform>("RightPart").DOAnchorPosX(1500f, 0.25f).SetEase(Ease.InCubic);
        }
        #region Input Response
        protected virtual void OnMouseCursorHide()
        {
            if (NeedResponseInput())
                SelectLastSelectable();
        }

        protected virtual bool NeedResponseInput()
        {
            if(!showing) 
                return false;
            if(UIManager.InputBlocker != null)
                return false;
            if(Program.instance.ui_.currentPopup != null)
                return false;
            if (Program.instance.ui_.currentPopupB != null)
                return false;
            if (Program.instance.ui_.subMenu.showing)
                return false;
            if(Program.instance.ui_.currentSidePanel != null)
                return false;
            return true;
        }

        #endregion
    }

}

