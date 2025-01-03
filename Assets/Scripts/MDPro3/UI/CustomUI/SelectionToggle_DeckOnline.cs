using UnityEngine;
using static YgomSystem.UI.ColorContainer;
using YgomSystem.UI;
using TMPro;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_DeckOnline : SelectionToggle_Deck
    {
        [HideInInspector] public string deckAuthor;
        [HideInInspector] public string deckId;
        [HideInInspector] public string lastDate;
        [HideInInspector] public int like;

        public override void Refresh()
        {
            Manager.GetElement("DeckCaseIcon").SetActive(true);
            Manager.GetElement("TextDeckName").SetActive(true);
            Manager.GetElement("IconAddDeck").SetActive(false);
            Manager.GetElement("SelectedStateToggle").SetActive(false);

            Manager.GetElement<TextMeshProUGUI>("TextDeckName").text = deckName;
            Manager.GetElement<TextMeshProUGUI>("TextDeckAuthor").text = "by " + deckAuthor;
            Manager.GetElement<TextMeshProUGUI>("TextDeckDate").text = lastDate;
            Manager.GetElement<TextMeshProUGUI>("TextDeckLike").text = like.ToString();

            if (enumeratorCase != null)
                StopCoroutine(enumeratorCase);
            enumeratorCase = RefreshDeckCaseAsync();
            StartCoroutine(enumeratorCase);

            refreshed = false;
            if (pickuping)
                StartRefresh();
        }

        protected override IEnumerator RefreshAsync()
        {
            while (Program.instance.onlineDeckViewer.inTransition)
                yield return null;

            Material pMat = null;
            var cardImage0 = Manager.GetElement<RawImage>("CardImage0");
            if (card0 != 0)
            {
                var task = TextureManager.LoadCardAsync(card0, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage0.texture = task.Result;
                //var mat = TextureManager.GetCardMaterial(card0);
                //cardImage0.material = mat;
            }
            else
            {
                if (pMat == null)
                {
                    var im = ABLoader.LoadProtectorMaterial(protector);
                    while (im.MoveNext())
                        yield return null;
                    pMat = im.Current;
                }
                cardImage0.texture = null;
                cardImage0.material = pMat;
            }

            var cardImage1 = Manager.GetElement<RawImage>("CardImage1");
            if (card1 != 0)
            {
                var task = TextureManager.LoadCardAsync(card1, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage1.texture = task.Result;
                //var mat = TextureManager.GetCardMaterial(card1);
                //cardImage1.material = mat;
            }
            else
            {
                if (pMat == null)
                {
                    var im = ABLoader.LoadProtectorMaterial(protector);
                    while (im.MoveNext())
                        yield return null;
                    pMat = im.Current;
                }
                cardImage1.texture = null;
                cardImage1.material = pMat;
            }

            var cardImage2 = Manager.GetElement<RawImage>("CardImage2");
            if (card2 != 0)
            {
                var task = TextureManager.LoadCardAsync(card2, true);
                while (!task.IsCompleted)
                    yield return null;
                cardImage2.texture = task.Result;
                //var mat = TextureManager.GetCardMaterial(card2);
                //cardImage2.material = mat;
            }
            else
            {
                if (pMat == null)
                {
                    var im = ABLoader.LoadProtectorMaterial(protector);
                    while (im.MoveNext())
                        yield return null;
                    pMat = im.Current;
                }
                cardImage2.texture = null;
                cardImage2.material = pMat;
            }

            enumerator = null;
            refreshed = true;

        }

        protected override IEnumerator RefreshDeckCaseAsync()
        {
            while (Program.instance.selectDeck.inTransition)
                yield return null;

            for (int i = 0; i < transform.GetSiblingIndex(); i++)
                yield return null;

            var casePath = deckCase.ToString();
            var load = Program.items.LoadItemIconAsync(casePath, Items.ItemType.Case);
            while (load.MoveNext())
                yield return null;
            if (load.Current != null)
                Manager.GetElement<Image>("DeckImage").sprite = load.Current;
        }

        protected override void OnClick()
        {
            AudioManager.PlaySE(SoundLabelClick);
            Program.instance.editDeck.onlineDeckID = deckId;
            Program.instance.editDeck.SwitchCondition(EditDeck.Condition.OnlineDeck);
            Program.instance.ShiftToServant(Program.instance.editDeck);
        }

        protected override void OnSelect(bool playSE)
        {
            HoverOn();
            if (playSE)
                AudioManager.PlaySE(SoundLabelSelectedGamePad);
            Program.instance.currentServant.Selected = Selectable;
            Program.instance.onlineDeckViewer.lastSelectedDeckItem = this;
            foreach (var ccg in transform.GetComponentsInChildren<ColorContainerGraphic>(true))
                ccg.SetColor(SelectMode.Selected, hovering ? StatusMode.Enter : StatusMode.Normal, Selectable.interactable);
        }

        public override void ShowPickup(bool forced = false)
        {
            if (forced)
                forcedPickup = true;
            if (pickuping)
                return;
            pickuping = true;

            ApplyShowPickup();
        }

        public override void HidePickup(bool forced = false)
        {
            if (forced)
                forcedPickup = false;
            if (!pickuping)
                return;
            if (forcedPickup)
                return;
            pickuping = false;

            ApplyHidePickup();
        }
        protected override int GetButtonsCount()
        {
            return Program.instance.onlineDeckViewer.superScrollView.items.Count;
        }

        protected override int GetColumnsCount()
        {
            return Program.instance.onlineDeckViewer.superScrollView.GetColumnCount();
        }
    }
}

