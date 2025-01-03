using DG.Tweening;
using MDPro3.YGOSharp;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionButton_DeckSelector : SelectionButton
    {
        private IEnumerator refreshInstance;
        private List<Tweener> pickupTweens = new();
        private List<Tweener> pickdownTweens = new();

        protected override void Awake()
        {
            base.Awake();
            HidePickup();
        }

        private void OnEnable()
        {
            if (refreshInstance != null)
                StartCoroutine(refreshInstance);
        }

        public void SetDeck(Deck deck,string deckName) 
        {
            Manager.GetElement<TextMeshProUGUI>("TextDeckName").text = deckName;

            IEnumerator ie;
            if (deck == null)
            {
                ie = RefreshAsync();
            }
            else
            {
                ie = RefreshAsync(
                    deck.Case,
                    deck.Protector,
                    deck.Pickup.Count > 0 ? deck.Pickup[0] : 0,
                    deck.Pickup.Count > 1 ? deck.Pickup[1] : 0,
                    deck.Pickup.Count > 2 ? deck.Pickup[2] : 0);
            }

            if (gameObject.activeInHierarchy)
                StartCoroutine(ie);
            else
                refreshInstance = ie;
        }

        private IEnumerator RefreshAsync(int deckCase = 1080001, int protector = 1070001, int card0 = 0, int card1 = 0, int card2 = 0)
        {
            while (!Items.initialized)
                yield return null;

            while (TextureManager.container == null)
                yield return null;

            var deckCaseImage = Manager.GetElement<Image>("DeckImage");
            deckCaseImage.color = Color.clear;
            var cardImage0 = Manager.GetElement<RawImage>("CardImage0");
            cardImage0.color =Color.clear;
            var cardImage1 = Manager.GetElement<RawImage>("CardImage1");
            cardImage1.color = Color.clear;
            var cardImage2 = Manager.GetElement<RawImage>("CardImage2");
            cardImage2.color = Color.clear;

            var ie = Program.items.LoadItemIconAsync(deckCase.ToString(), Items.ItemType.Case);
            while (ie.MoveNext())
                yield return null;
            deckCaseImage.sprite = ie.Current;
            deckCaseImage.color = Color.white;

            if (card0 == 0)
            {
                var ie2 = ABLoader.LoadProtectorMaterial(protector.ToString());
                while (ie2.MoveNext())
                    yield return null;
                cardImage0.texture = null;
                cardImage0.material = ie2.Current;
            }
            else
            {
                var mat = TextureManager.GetCardMaterial(card0);
                var task = TextureManager.LoadCardAsync(card0, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage0.material = mat;
                cardImage0.texture = task.Result;
            }
            cardImage0.color = Color.white;

            if (card1 == 0)
            {
                var ie2 = ABLoader.LoadProtectorMaterial(protector.ToString());
                while (ie2.MoveNext())
                    yield return null;
                cardImage1.texture = null;
                cardImage1.material = ie2.Current;
            }
            else
            {
                var mat = TextureManager.GetCardMaterial(card1);
                var task = TextureManager.LoadCardAsync(card1, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage1.material = mat;
                cardImage1.texture = task.Result;
            }
            cardImage1.color = Color.white;

            if (card2 == 0)
            {
                var ie2 = ABLoader.LoadProtectorMaterial(protector.ToString());
                while (ie2.MoveNext())
                    yield return null;
                cardImage2.texture = null;
                cardImage2.material = ie2.Current;
            }
            else
            {
                var mat = TextureManager.GetCardMaterial(card2);
                var task = TextureManager.LoadCardAsync(card2, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage2.material = mat;
                cardImage2.texture = task.Result;
            }
            cardImage2.color = Color.white;

            refreshInstance = null;
        }

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            ShowPickup();
        }

        protected override void CallHoverOffEvent()
        {
            base.CallHoverOffEvent();
            HidePickup();
        }

        private void ShowPickup()
        {
            foreach (var tween in pickdownTweens)
                if (tween.IsActive())
                    tween.Kill();
            pickdownTweens.Clear();

            var tween1 = Manager.GetElement<CanvasGroup>("CardPos0").DOFade(1f, 0.2f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween1);
            var tween2 = Manager.GetElement<CanvasGroup>("CardPos1").DOFade(1f, 0.22f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween2);
            var tween3 = Manager.GetElement<CanvasGroup>("CardPos2").DOFade(1f, 0.24f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween3);

            var tween4 = Manager.GetElement<RectTransform>("CardImage0").DOAnchorPos3D(new Vector3(0f, 10f, 0f), 0.2f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween4);
            var tween5 = Manager.GetElement<RectTransform>("CardImage1").DOAnchorPos3D(new Vector3(0f, 10f, 0f), 0.22f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween5);
            var tween6 = Manager.GetElement<RectTransform>("CardImage2").DOAnchorPos3D(new Vector3(0f, 10f, 0f), 0.24f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween6);

            var tween7 = Manager.GetElement<RectTransform>("CardImage0").DOLocalRotate(Vector3.zero, 0.2f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween7);
            var tween8 = Manager.GetElement<RectTransform>("CardImage2").DOLocalRotate(Vector3.zero, 0.2f).SetEase(Ease.OutCubic);
            pickupTweens.Add(tween8);
        }

        private void HidePickup()
        {
            foreach (var tween in pickupTweens)
                if (tween.IsActive())
                    tween.Kill();
            pickupTweens.Clear();

            var tween1 = Manager.GetElement<CanvasGroup>("CardPos0").DOFade(0f, 0.2f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween1);
            var tween2 = Manager.GetElement<CanvasGroup>("CardPos1").DOFade(0f, 0.22f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween2);
            var tween3 = Manager.GetElement<CanvasGroup>("CardPos2").DOFade(0f, 0.24f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween3);

            var tween4 = Manager.GetElement<RectTransform>("CardImage0").DOAnchorPos3D(new Vector3(0f, -40f, 0f), 0.2f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween4);
            var tween5 = Manager.GetElement<RectTransform>("CardImage1").DOAnchorPos3D(new Vector3(0f, -40f, 0f), 0.22f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween5);
            var tween6 = Manager.GetElement<RectTransform>("CardImage2").DOAnchorPos3D(new Vector3(0f, -40f, 0f), 0.24f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween6);

            var tween7 = Manager.GetElement<RectTransform>("CardImage0").DOLocalRotate(new Vector3(0f, 0f, -20f), 0.2f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween7);
            var tween8 = Manager.GetElement<RectTransform>("CardImage2").DOLocalRotate(new Vector3(0f, 0f, 20f), 0.2f).SetEase(Ease.OutCubic);
            pickdownTweens.Add(tween8);
        }


    }
}
