using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using MDPro3.YGOSharp;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace MDPro3.UI
{
    public class CardActionMenu : UIWidgetCardBase
    {
        [HideInInspector] public bool showing;

        private List<Card> cards;
        private int index;
        private bool shifting;
        object blockMark;

        protected override void Awake()
        {
            base.Awake();

            Cg.alpha = 0f;
            Cg.blocksRaycasts = false;

            ImageCard.GetComponent<Button>().onClick.AddListener(ShowCardExpand);
        }

        private void Update()
        {
            if (!showing || shifting || UIManager.InputBlocker != null) 
                return;
            if (UserInput.WasCancelPressed || UserInput.MouseRightDown)
                Hide();
            if(UserInput.WasRightPressed || UserInput.WasRightShoulderPressed)
                OnNext();
            if (UserInput.WasLeftPressed || UserInput.WasLeftShoulderPressed)
                OnPrev();
            if(UserInput.WasLeftTriggerPressed)
                ShowCardExpand();
        }

        public void Show(List<Card> cards, int index, object blockMark)
        {
            showing = true;
            shifting = true;
            this.cards = cards;
            this.index = index;
            Cg.alpha = 1f;
            Cg.blocksRaycasts = true;

            AudioManager.PlaySE("SE_DECK_WINDOW_OPEN");
            UIManager.ShowFPSLeft();

            ShowTween(Window);
            ShowTween(ButtonGroup.GetComponent<RectTransform>());

            BG.alpha = 0f;
            BG.DOFade(1f, 0.25f).OnComplete(() => shifting = false);

            var card = cards[index];
            SetCardData(card);

            this.blockMark = blockMark;
        }

        protected override void SetCardData(Card data)
        {
            base.SetCardData(data);
            SelectDefaultButton();
        }

        public virtual void SelectDefaultButton()
        {
            EventSystem.current.SetSelectedGameObject(ButtonAddCard.gameObject);
        }

        private void ShowTween(RectTransform rect)
        {
            rect.localScale = new Vector3(0.75f, 0.75f, 1f);
            rect.DOScale(1f, 0.25f).SetEase(Ease.OutQuart);

            var cg = rect.GetComponent<CanvasGroup>();
            cg.alpha = 0f;
            cg.DOFade(1f, 0.25f);
        }

        public void Hide()
        {
            AudioManager.PlaySE("SE_MENU_CANCEL");
            UIManager.ShowFPSRight();

            HideTween(Manager.GetElement<RectTransform>("Window"));
            HideTween(Manager.GetElement<RectTransform>("ButtonGroup"));
            Manager.GetElement<CanvasGroup>("BG").DOFade(0f, 0.2f).OnComplete(() =>
            {
                showing = false;
                Cg.alpha = 0f;
                Cg.blocksRaycasts = false;
                Program.instance.currentServant.JudgeInputBlockerExitMark(blockMark);
                Program.instance.currentServant.SelectLastSelectable();
            });
        }

        private void HideTween(RectTransform rect)
        {
            rect.DOScale(0.75f, 0.2f).SetEase(Ease.InCubic);

            var cg = rect.GetComponent<CanvasGroup>();
            cg.DOFade(0f, 0.2f);
        }

        private void OnNext()
        {
            if (index == cards.Count - 1 || shifting) return;
            shifting = true;
            AudioManager.PlaySE("SE_MENU_SELECT_01");

            var rect = Manager.GetElement<RectTransform>("Window");
            rect.anchoredPosition = new Vector2(0f, -32f);

            var cg = rect.GetComponent<CanvasGroup>();
            cg.alpha = 1f;

            DOTween.Sequence()
                .Append(rect.DOAnchorPos(new Vector2(-480f, -32f), 0.1f).SetEase(Ease.InCubic))
                .Join(cg.DOFade(0f, 0.1f).OnComplete(() =>
                {
                    rect.anchoredPosition = new Vector2(480f, -32f);
                    SetCardData(cards[++index]);
                }))
                .Append(rect.DOAnchorPos(new Vector2(0f, -32f), 0.2f).SetEase(Ease.OutQuart))
                .Join(cg.DOFade(1f, 0.2f))
                .OnComplete(() =>
                {
                    shifting = false;
                });
        }

        private void OnPrev()
        {
            if(index == 0 || shifting) return;
            shifting = true;
            AudioManager.PlaySE("SE_MENU_SELECT_01");

            var rect = Manager.GetElement<RectTransform>("Window");
            rect.anchoredPosition = new Vector2(0f, -32f);

            var cg = rect.GetComponent<CanvasGroup>();
            cg.alpha = 1f;

            DOTween.Sequence()
                .Append(rect.DOAnchorPos(new Vector2(480f, -32f), 0.1f).SetEase(Ease.InCubic))
                .Join(cg.DOFade(0f, 0.1f).OnComplete(() =>
                {
                    rect.anchoredPosition = new Vector2(-480f, -32f);
                    SetCardData(cards[--index]);
                }))
                .Append(rect.DOAnchorPos(new Vector2(0f, -32f), 0.2f).SetEase(Ease.OutQuart))
                .Join(cg.DOFade(1f, 0.2f))
                .OnComplete(() =>
                {
                    shifting = false;
                });
        }

        private void ShowCardExpand()
        {
            UIManager.ShowCardExpand(Card.Id);
        }
    }
}
