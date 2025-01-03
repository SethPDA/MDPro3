using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_AppearanceItem : SelectionToggle
    {
        public int itemID;
        public string itemName;
        public string description;
        public string path;
        private bool loaded;

        private Coroutine refreshCoroutine;
        private Coroutine hideCoroutine;

        protected override void Awake()
        {
            base.Awake();
            HoverOff();
            exclusiveToggle = true;
            canToggleOffSelf = false;
            manuallySetNavigation = false;
        }

        public void Refresh()
        {
            refreshCoroutine = StartCoroutine(RefreshAsync());
        }

        private IEnumerator RefreshAsync()
        {
            for (int i = 0; i < index; i++)
                yield return null;

            var protector = Manager.GetElement<RawImage>("Protector");
            var icon = Manager.GetElement<Image>("Icon");

            if (path.StartsWith("Protector"))
            {
                var ie = ABLoader.LoadProtectorMaterial(itemID.ToString());
                StartCoroutine(ie);
                while (ie.MoveNext())
                    yield return null;
                protector.material = ie.Current;
                protector.material.renderQueue = 3000;
                protector.color = Color.white;
                icon.gameObject.SetActive(false);
            }
            else if (path.Length > 0)
            {
                var load = Program.items.LoadItemIconAsync(itemID.ToString(), Items.ItemType.Unknown);
                while (load.MoveNext())
                    yield return null;
                icon.sprite = load.Current;
                icon.color = Color.white;
                if (path.StartsWith("ProfileFrame"))
                {
                    icon.rectTransform.localScale = Vector3.one * 0.8f;
                    var ie = ABLoader.LoadFrameMaterial(itemID.ToString());
                    StartCoroutine(ie);
                    while (ie.MoveNext())
                        yield return null;
                    Material mat = ie.Current;
                    icon.material = mat;
                    icon.material.SetTexture("_ProfileFrameTex", icon.sprite.texture);
                    icon.sprite = TextureManager.container.black;
                    icon.color = Color.white;
                }
                else if (path.StartsWith("DeckCase"))
                {
                    icon.rectTransform.localScale = Vector3.one * 0.8f;
                }
                protector.gameObject.SetActive(false);
            }
            else //CrossDuel Mate
            {
                var task = TextureManager.LoadArtAsync(itemID, true);
                while (!task.IsCompleted)
                    yield return null;
                icon.color = Color.white;
                icon.sprite = TextureManager.Texture2Sprite(task.Result);
                protector.gameObject.SetActive(false);
            }

            if (path.StartsWith("ProfileIcon"))
                icon.material = Appearance.matForFace;

            loaded = true;
            refreshCoroutine = null;
        }

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            Program.instance.appearance.SetHoverText(itemName);
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            CallHoverOnEvent();

            Program.instance.appearance.SetDetailName(itemName);
            Program.instance.appearance.SetDetailDescription(description);
            Program.instance.appearance.SetHoverText(itemName);
            Program.instance.appearance.lastSelectedItem = this;
            Program.instance.currentServant.Selected = Selectable;
            if(!EventSystem.current.alreadySelecting)
                EventSystem.current.SetSelectedGameObject(gameObject);

            var protector = Manager.GetElement<RawImage>("Protector");
            var icon = Manager.GetElement<Image>("Icon");


            if (Program.instance.appearance.condition == Appearance.Condition.Deck)
            {
                if (path.StartsWith("DeckCase"))
                {
                    if (Program.instance.editDeck.deck.Case != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Case = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconCase").sprite = icon.sprite;
                    }
                }
                else if (path.StartsWith("Protector"))
                {
                    if (Program.instance.editDeck.deck.Protector != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Protector = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconProtector").material = protector.material;
                    }
                }
                else if (path.StartsWith("FieldIcon"))
                {
                    if (Program.instance.editDeck.deck.Field != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Field = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconField").sprite = icon.sprite;
                    }
                }
                else if (path.StartsWith("FieldObj"))
                {
                    if (Program.instance.editDeck.deck.Grave != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Grave = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconGrave").sprite = icon.sprite;
                    }
                }
                else if (path.StartsWith("FieldAvatarBase"))
                {
                    if (Program.instance.editDeck.deck.Stand != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Stand = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconStand").sprite = icon.sprite;
                    }
                }
                else
                {
                    if (Program.instance.editDeck.deck.Mate != itemID)
                    {
                        Program.instance.editDeck.dirty = true;
                        Program.instance.editDeck.deck.Mate = itemID;
                        Program.instance.editDeck.Manager.GetElement<Image>("IconMate").sprite = icon.sprite;
                    }
                }
            }
            else
            {
                if (path.StartsWith("WallPaperIcon"))
                    Config.Set("Wallpaper", itemID.ToString());
                else
                    Config.Set(Program.instance.appearance.condition.ToString() + Appearance.currentContent + Appearance.player, itemID.ToString());
            }

            StartCoroutine(ShowDetailAsync());
        }

        private IEnumerator ShowDetailAsync()
        {

            Program.instance.appearance.SetDetailImage(TextureManager.container.typeNone);
            while (!loaded)
                yield return null;

            var protector = Manager.GetElement<RawImage>("Protector");
            var icon = Manager.GetElement<Image>("Icon");

            if (!icon.gameObject.activeSelf)//Protector
            {
                Program.instance.appearance.SetDetailRawImageMaterial(protector.material);

                if (Appearance.player == "0")
                {
                    if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        Appearance.duelProtector0 = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        Appearance.watchProtector0 = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        Appearance.replayProtector0 = protector.material;
                }
                else if (Appearance.player == "1")
                {
                    if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        Appearance.duelProtector1 = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        Appearance.watchProtector1 = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        Appearance.replayProtector1 = protector.material;
                }
                else if (Appearance.player == "0Tag")
                {
                    if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        Appearance.duelProtector0Tag = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        Appearance.watchProtector0Tag = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        Appearance.replayProtector0Tag = protector.material;
                }
                else if (Appearance.player == "1Tag")
                {
                    if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        Appearance.duelProtector1Tag = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        Appearance.watchProtector1Tag = protector.material;
                    else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        Appearance.replayProtector1Tag = protector.material;
                }
            }
            else
            {
                Program.instance.appearance.SetDetailImage(icon.sprite);
                if (path.StartsWith("ProfileIcon"))
                    Program.instance.appearance.SetDetailImageMaterial(null);
                else
                    Program.instance.appearance.SetDetailImageMaterial(icon.material);
                if (path.StartsWith("ProfileIcon"))
                {
                    if (Appearance.player == "0")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                            Appearance.duelFace0 = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                            Appearance.watchFace0 = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                            Appearance.replayFace0 = icon.sprite;
                    }
                    else if (Appearance.player == "1")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                            Appearance.duelFace1 = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                            Appearance.watchFace1 = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                            Appearance.replayFace1 = icon.sprite;
                    }
                    else if (Appearance.player == "0Tag")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                            Appearance.duelFace0Tag = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                            Appearance.watchFace0Tag = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                            Appearance.replayFace0Tag = icon.sprite;
                    }
                    else if (Appearance.player == "1Tag")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                            Appearance.duelFace1Tag = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                            Appearance.watchFace1Tag = icon.sprite;
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                            Appearance.replayFace1Tag = icon.sprite;
                    }
                }
                else if (path.StartsWith("ProfileFrame"))
                {
                    if (Appearance.player == "0")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.duelFace0);
                            Appearance.duelFrameMat0 = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.watchFace0);
                            Appearance.watchFrameMat0 = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.replayFace0);
                            Appearance.replayFrameMat0 = icon.material;
                        }
                    }
                    else if (Appearance.player == "1")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.duelFace1);
                            Appearance.duelFrameMat1 = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.watchFace1);
                            Appearance.watchFrameMat1 = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.replayFace1);
                            Appearance.replayFrameMat1 = icon.material;
                        }
                    }
                    else if (Appearance.player == "0Tag")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.duelFace0Tag);
                            Appearance.duelFrameMat0Tag = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.watchFace0Tag);
                            Appearance.watchFrameMat0Tag = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.replayFace0Tag);
                            Appearance.replayFrameMat0Tag = icon.material;
                        }
                    }
                    else if (Appearance.player == "1Tag")
                    {
                        if (Program.instance.appearance.condition == Appearance.Condition.Duel)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.duelFace1Tag);
                            Appearance.duelFrameMat1Tag = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Watch)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.watchFace1Tag);
                            Appearance.watchFrameMat1Tag = icon.material;
                        }
                        else if (Program.instance.appearance.condition == Appearance.Condition.Replay)
                        {
                            Program.instance.appearance.SetDetailImage(Appearance.replayFace1Tag);
                            Appearance.replayFrameMat1Tag = icon.material;
                        }
                    }
                }
            }
        }


        protected override void OnClick()
        {
            AudioManager.PlaySE(SoundLabelClick);
            SetToggleOn();
            Program.instance.currentServant.Selected = Selectable;
        }

        protected override int GetButtonsCount()
        {
            return Program.instance.appearance.GetCurrentGenreCount();
        }

        private GridLayoutGroup m_grid;
        private GridLayoutGroup Grid
        {
            get
            {
                if (m_grid == null)
                    m_grid = Program.instance.appearance.Manager.GetElement<ScrollRect>("ScrollRect").content.GetComponent<GridLayoutGroup>();
                return m_grid;
            }
        }

        protected override int GetColumnsCount()
        {
            return Grid.Size().x;
        }

        public void Hide()
        {
            if (hideCoroutine != null || !gameObject.activeSelf)
                return;
            hideCoroutine = StartCoroutine(HideAsync());

            GetComponent<LayoutElement>().ignoreLayout = true;
            GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
        private IEnumerator HideAsync()
        {
            var cg = GetComponent<CanvasGroup>();
            cg.alpha = 0f;
            cg.blocksRaycasts = false;
            while (!loaded)
                yield return null;
            hideCoroutine = null;
            gameObject.SetActive(false);
        }

        public void Show()
        {
            if(hideCoroutine != null)
            {
                StopCoroutine(hideCoroutine);
                hideCoroutine = null;
            }

            var cg = GetComponent<CanvasGroup>();
            cg.alpha = 1f;
            cg.blocksRaycasts = true;

            GetComponent<LayoutElement>().ignoreLayout = false;
            transform.SetSiblingIndex(index);
        }

        public void Dispose()
        {
            if(refreshCoroutine != null)
                StopCoroutine(refreshCoroutine);

            if (hideCoroutine != null)
                StopCoroutine(hideCoroutine);

            Destroy(gameObject);
        }
    }
}
