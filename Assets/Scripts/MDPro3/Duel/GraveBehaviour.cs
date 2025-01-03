using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Bg;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.UI;
using static MDPro3.GameCard;

namespace MDPro3
{
    public class GraveBehaviour : MonoBehaviour
    {
        public int controller;
        BgEffectManager manager;

        BoxCollider graveCollider;
        BoxCollider excludeCollider;

        GameObject grave;
        GameObject exclude;

        private void Start()
        {
            manager = GetComponent<BgEffectManager>();
            grave = manager.GetElement<Transform>("GraveIn").parent.gameObject;
            graveCollider = grave.AddComponent<BoxCollider>();
            graveCollider.center = new Vector3(0, 1, 0);
            graveCollider.size = new Vector3(6, 2, 6);
            exclude = manager.GetElement<Transform>("ExcludeIn").parent.gameObject;
            excludeCollider = exclude.AddComponent<BoxCollider>();
            excludeCollider.center = new Vector3(0, 1, 0);
            excludeCollider.size = new Vector3(6, 2, 6);
        }

        bool graveCountShowing;
        bool excludeCountShowing;

        private void Update()
        {
            if (UserInput.HoverObject == grave)
            {
                manager.GetElement<Renderer>("Material01").material.SetFloat("_GraveMouseOver", 1);
                if (UserInput.MouseLeftDown)
                    manager.GetElement<Renderer>("Material01").material.SetFloat("_GravePressButton", 1);
                else
                    manager.GetElement<Renderer>("Material01").material.SetFloat("_GravePressButton", 0);
                if (UserInput.MouseLeftUp)
                    GraveOnClick();
            }
            else
            {
                manager.GetElement<Renderer>("Material01").material.SetFloat("_GraveMouseOver", 0);
                manager.GetElement<Renderer>("Material01").material.SetFloat("_GravePressButton", 0);
                if (UserInput.MouseLeftUp)
                    HideGraveButtons();
                if (graveCountShowing)
                {
                    graveCountShowing = false;
                    Program.instance.ocgcore.HidePlaceCount();
                }
            }

            if (UserInput.HoverObject == exclude)
            {
                manager.GetElement<Renderer>("Material01").material.SetFloat("_ExcludeMouseOver", 1);
                if (UserInput.MouseLeftDown)
                    manager.GetElement<Renderer>("Material01").material.SetFloat("_ExcludePressButton", 1);
                else
                    manager.GetElement<Renderer>("Material01").material.SetFloat("_ExcludePressButton", 0);
                if (UserInput.MouseLeftUp)
                    ExcludeOnClick();
            }
            else
            {
                manager.GetElement<Renderer>("Material01").material.SetFloat("_ExcludeMouseOver", 0);
                manager.GetElement<Renderer>("Material01").material.SetFloat("_ExcludePressButton", 0);
                if (UserInput.MouseLeftDown)
                    HideExcludeButtons();
                if (excludeCountShowing)
                {
                    excludeCountShowing = false;
                    Program.instance.ocgcore.HidePlaceCount();
                }
            }
            if (UserInput.HoverObject == grave)
                if (!graveCountShowing)
                {
                    graveCountShowing = true;
                    Program.instance.ocgcore.ShowLocationCount(new GPS { location = (uint)CardLocation.Grave, controller = (uint)controller });
                }
            if (UserInput.HoverObject == exclude)
                if (!excludeCountShowing)
                {
                    excludeCountShowing = true;
                    Program.instance.ocgcore.ShowLocationCount(new GPS { location = (uint)CardLocation.Removed, controller = (uint)controller });
                }
        }
        bool graveButtonsCreated = false;
        bool excludeButtonsCreated = false;
        void GraveOnClick()
        {
            AudioManager.PlaySE("SE_DUEL_SELECT");

            List<GameCard> cards = Program.instance.ocgcore.GCS_GetLocationCards(controller, (int)CardLocation.Grave);
            Program.instance.ocgcore.list.Show(cards, CardLocation.Grave, controller);

            if (Program.instance.ocgcore.returnAction != null)
                return;
            if (!graveButtonsCreated)
            {
                bool spsummmon = false;
                bool activate = false;
                foreach (var card in Program.instance.ocgcore.cards)
                    if ((card.p.location & (uint)CardLocation.Grave) > 0)
                        if (card.p.controller == controller)
                            foreach (var btn in card.buttons)
                            {
                                if (btn.type == ButtonType.Activate)
                                    activate = true;
                                if (btn.type == ButtonType.SpSummon)
                                    spsummmon = true;
                            }
                if (activate)
                {
                    int response = -1;
                    graveButtons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("发动效果"), type = ButtonType.Activate });
                }
                if (spsummmon)
                {
                    int response = -2;
                    graveButtons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("特殊召唤"), type = ButtonType.SpSummon });
                }
                CreateGraveButtons();
            }
            else
                ShowGraveButtons();
        }
        void ExcludeOnClick()
        {
            AudioManager.PlaySE("SE_DUEL_SELECT");

            List<GameCard> cards = Program.instance.ocgcore.GCS_GetLocationCards(controller, (int)CardLocation.Removed);
            Program.instance.ocgcore.list.Show(cards, CardLocation.Removed, controller);

            if (Program.instance.ocgcore.returnAction != null)
                return;
            if (!graveButtonsCreated)
            {
                bool spsummmon = false;
                bool activate = false;
                foreach (var card in Program.instance.ocgcore.cards)
                    if ((card.p.location & (uint)CardLocation.Removed) > 0)
                        if (card.p.controller == controller)
                            foreach (var btn in card.buttons)
                            {
                                if (btn.type == ButtonType.Activate)
                                    activate = true;
                                if (btn.type == ButtonType.SpSummon)
                                    spsummmon = true;
                            }
                if (activate)
                {
                    int response = -1;
                    excludeButtons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("发动效果"), type = ButtonType.Activate });
                }
                if (spsummmon)
                {
                    int response = -2;
                    excludeButtons.Add(new DuelButtonInfo() { response = new List<int>() { response }, hint = InterString.Get("特殊召唤"), type = ButtonType.SpSummon });
                }
                CreateExcludeButtons();
            }
            else
                ShowExcludeButtons();
        }

        void ShowGraveButtons()
        {
            foreach (var button in graveButtonObjs)
                button.Show();
        }
        void ShowExcludeButtons()
        {
            foreach (var button in excludeButtonObjs)
                button.Show();
        }
        void HideGraveButtons()
        {
            foreach (var button in graveButtonObjs)
                button.Hide();
        }
        void HideExcludeButtons()
        {
            foreach (var button in excludeButtonObjs)
                button.Hide();
        }

        public List<DuelButtonInfo> graveButtons = new List<DuelButtonInfo>();
        public List<DuelButton> graveButtonObjs = new List<DuelButton>();
        public List<DuelButtonInfo> excludeButtons = new List<DuelButtonInfo>();
        public List<DuelButton> excludeButtonObjs = new List<DuelButton>();
        void CreateGraveButtons()
        {
            if (graveButtonsCreated || Program.instance.ocgcore.returnAction != null || graveButtons.Count == 0)
                return;
            for (int i = 0; i < graveButtons.Count; i++)
            {
                var obj = Instantiate(Program.instance.ocgcore.container.duelButton);
                var mono = obj.GetComponent<DuelButton>();
                graveButtonObjs.Add(mono);
                mono.response = graveButtons[i].response;
                mono.hint = graveButtons[i].hint;
                mono.type = graveButtons[i].type;
                mono.id = i;
                mono.buttonsCount = graveButtons.Count;
                mono.cookieCard = null;
                mono.location = (uint)CardLocation.Grave;
                mono.controller = (uint)controller;
                mono.Show();
            }
            graveButtonsCreated = true;
        }
        void CreateExcludeButtons()
        {
            if (excludeButtonsCreated || Program.instance.ocgcore.returnAction != null || excludeButtons.Count == 0)
                return;
            for (int i = 0; i < excludeButtons.Count; i++)
            {
                var obj = Instantiate(Program.instance.ocgcore.container.duelButton);
                var mono = obj.GetComponent<DuelButton>();
                excludeButtonObjs.Add(mono);
                mono.response = excludeButtons[i].response;
                mono.hint = excludeButtons[i].hint;
                mono.type = excludeButtons[i].type;
                mono.id = i;
                mono.buttonsCount = excludeButtons.Count;
                mono.cookieCard = null;
                mono.location = (uint)CardLocation.Removed;
                mono.controller = (uint)controller;
                mono.Show();
            }
            excludeButtonsCreated = true;
        }

        public void ClearGraveButtons()
        {
            foreach (var go in graveButtonObjs)
                Destroy(go.gameObject);
            graveButtonObjs.Clear();
            graveButtons.Clear();
            graveButtonsCreated = false;
        }
        public void ClearExcludeButtons()
        {
            foreach (var go in excludeButtonObjs)
                Destroy(go.gameObject);
            excludeButtonObjs.Clear();
            excludeButtons.Clear();
            excludeButtonsCreated = false;
        }


    }
}
