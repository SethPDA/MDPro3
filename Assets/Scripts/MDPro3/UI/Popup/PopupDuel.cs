using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

namespace MDPro3.UI
{
    public class PopupDuel : PopupBase
    {
        [Header("Popup Duel Reference")]
        public Button btnHide;
        [HideInInspector]
        public bool exitable;
        bool hided;
        public float extraHeight = 65f;

        public override void Initialize()
        {
            base.Initialize();
            Program.instance.ocgcore.allGameObjects.Add(gameObject);
            if (btnHide != null)
                btnHide.onClick.AddListener(FieldView);
            Program.instance.ocgcore.currentPopup = this;
            if (!exitable)
            {
                if (btnHide != null)
                    Program.instance.ocgcore.returnAction = FieldView;
                else
                    Program.instance.ocgcore.returnAction = () => { };
            }

            var uiScale = Config.GetUIScale(maxUIScale);
            hideY = -540f - height * uiScale - extraHeight;
            window.anchoredPosition = new Vector2(0f, hideY);
        }
        public virtual void FieldView()
        {
            if (hided)
            {
                hided = false;
                window.DOAnchorPosY(showY, transitionTime);
                AudioManager.PlaySE("SE_MENU_SLIDE_03");
                btnHide.transform.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                hided = true;
                var scale = window.transform.localScale.x;
                var targetY = -540 - height * scale;
                window.DOAnchorPosY(targetY, transitionTime);
                AudioManager.PlaySE("SE_MENU_SLIDE_04");
                btnHide.transform.GetChild(0).gameObject.SetActive(true);
            }
        }

        public override void Show()
        {
            Initialize();
            window.DOAnchorPos(new Vector2(0f, showY), transitionTime);
            if (shadow != null)
            {
                shadow.DOFade(0.8f, transitionTime);
                shadow.raycastTarget = true;
            }
        }
        public override void Hide()
        {
            if (shadow != null)
                shadow.DOFade(0f, transitionTime);
            window.DOAnchorPos(new Vector2(0f, hideY), transitionTime).OnComplete(() =>
            {
                Destroy(gameObject);
                Program.instance.ocgcore.returnAction = null;
                whenQuitDo?.Invoke();
            });
            Program.instance.ocgcore.Sleep((int)(transitionTime * 100));
            Program.instance.ocgcore.currentPopup = null;
        }
        public override void OnConfirm()
        {
            AudioManager.PlaySE("SE_DUEL_DECIDE");
        }
        public override void OnCancel()
        {
            AudioManager.PlaySE("SE_DUEL_CANCEL");
        }

        public void OnDestroy()
        {
            Program.instance.ocgcore.returnAction = null;
        }
    }
}
