using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using TMPro;

namespace MDPro3.UI
{
    public class PopupDuelSelectCardItem : MonoBehaviour
    {
        public Image head;
        public Image locationIcon;
        public RawImage cardFace;
        public GameObject cardBack;
        public Button button;
        public Image levelIcon;
        public TextMeshProUGUI textLevel;
        public Image pendulumIcon;
        public TextMeshProUGUI textPendulum;
        public Image tunerIcon;
        public GameObject checkOn;
        public GameObject orderBase;
        public Text orderText;
        public GameObject chain;
        public Text chainText;
        public GameObject target;


        public int id;
        public List<GameCard> cards;
        public PopupDuelSelectCard manager;

        public GameCard card;
        static Color opColor = new Color(0.9f, 0, 0, 1);

        public bool selected;
        public bool unselectable;
        static Color unselectableColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        public bool preselected;
        static float doubleClickTime = 0.2f;


        private void Start()
        {
            StartCoroutine(RefreshCard(card.GetData().Id));

            if ((card.p.location & (uint)CardLocation.Search) > 0)
            {
                GetComponent<Image>().color = Color.black;
                head.color = Color.black;
            }
            else if (card.p.controller != 0)
            {
                GetComponent<Image>().color = opColor;
                head.color = opColor;
            }

            bool showHead = false;
            if (id == 0)
                showHead = true;
            else if (card.p.location != cards[id - 1].p.location 
                || card.p.controller != cards[id - 1].p.controller)
                showHead = true;
            if (showHead)
                locationIcon.sprite = TextureManager.GetCardLocationIcon(card.p);
            else
                head.gameObject.SetActive(false);

            bool isEnd = false;
            if (id == cards.Count - 1)
                isEnd = true;
            else if (card.p.location != cards[id + 1].p.location 
                || card.p.controller != cards[id + 1].p.controller)
                isEnd = true;
            if (isEnd)
                GetComponent<RectTransform>().sizeDelta = new Vector2(145, 180);
            else
                GetComponent<RectTransform>().sizeDelta = new Vector2(180, 180);


            if ((card.p.position & (uint)CardPosition.FaceUp) > 0)
                cardBack.SetActive(false);

            if (card.chains.Count > 0)
            {
                chain.SetActive(true);
                chainText.text = card.chains[0].i.ToString();
            }
            else
            {
                chain.SetActive(false);

                if (Program.instance.ocgcore.cardsBeTarget.Contains(card))
                    target.SetActive(true);
                else
                    target.SetActive(false);
            }

            var origin = CardsManager.Get(card.GetData().Id);

            if (origin.HasType(CardType.Monster))
            {
                levelIcon.sprite = TextureManager.GetCardLevelIcon(card.GetData());
                if (card.GetData().HasType(CardType.Link))
                    textLevel.text = CardDescription.GetCardLinkCount(card.GetData()).ToString();
                else
                    textLevel.text = card.GetData().Level.ToString();

                if (origin.HasType(CardType.Tuner))
                    tunerIcon.gameObject.SetActive(true);
            }
            else
            {
                levelIcon.sprite = TextureManager.container.typeNone;
                textLevel.text = string.Empty;
            }

            if (origin.HasType(CardType.Pendulum))
            {
                pendulumIcon.gameObject.SetActive(true);
                textPendulum.text = card.GetData().LScale.ToString();
            }
            else
            {
                pendulumIcon.gameObject.SetActive(false);
                textPendulum.text = string.Empty;
            }

            button.onClick.AddListener(OnClick);
        }

        bool refreshed;
        IEnumerator RefreshCard(int code)
        {
            refreshed = false;
            cardFace.texture = TextureManager.container.unknownCard.texture;
            var task = TextureManager.LoadCardAsync(code, true);
            while (!task.IsCompleted)
                yield return null;
            var mat = TextureManager.GetCardMaterial(code);
            cardFace.material = mat;
            cardFace.material.mainTexture = task.Result;
            cardFace.texture = task.Result;
            refreshed = true;
        }

        public IEnumerator DisposeAsync()
        {
            while (!refreshed)
                yield return null;
            Destroy(gameObject);
        }

        float clickTime;
        void OnClick()
        {
            AudioManager.PlaySE("SE_MENU_SELECT_01");
            if ((card.p.location & (uint)CardLocation.Onfield) > 0
                && (card.p.location & (uint)CardLocation.Overlay) == 0)
            {
                if (manager.arrow == null)
                {
                    manager.arrow = ABLoader.LoadFromFile("MasterDuel/Effects/other/fxp_arrow_aim_001", true);
                    Program.instance.ocgcore.allGameObjects.Add(manager.arrow);
                }
                manager.arrow.transform.position = card.model.transform.position;
            }
            else
            {
                if (manager.arrow != null)
                    manager.arrow.SetActive(false);
            }

            Program.instance.ocgcore.description.Show(card, cardFace.material);

            if (selected)
            {
                if (!unselectable)
                {
                    if ((Time.time - clickTime) < doubleClickTime * Time.timeScale)
                    {
                        if (manager.selectedCount == 1 && manager.min == 1 && manager.max == 1)
                            manager.OnConfirm();
                        else
                            UnselectThis();
                    }
                    else
                        UnselectThis();
                }
            }
            else
            {
                if (!unselectable)
                {
                    SelectThis();
                    clickTime = Time.time;
                }
                else
                {
                    if (manager.max == 1 
                        && manager.min == 1
                        && Program.instance.ocgcore.currentMessage != GameMessage.SelectSum)
                    {
                        foreach (var card in manager.monos)
                            card.UnselectThis();
                        SelectThis();
                        clickTime = Time.time;
                    }
                }
            }

        }

        void SelectThis()
        {
            if (selected) return;
            selected = true;
            manager.selectedCount++;

            if(Program.instance.ocgcore.currentMessage == GameMessage.ConfirmCards)
            {
            }
            else if (!manager.order)
                checkOn.SetActive(true);
            else
            {
                orderBase.SetActive(true);
                orderText.text = manager.selectedCount.ToString();
            }
        }

        public void RemoveOrder(int i)
        {
            if (!selected)
                return;
            int order = int.Parse(orderText.text);
            if (order > i)
                orderText.text = (order - 1).ToString();
        }

        public int GetOrder()
        {
            return int.Parse(orderText.text);
        }

        void UnselectThis()
        {
            if (!selected || unselectable) return;
            selected = false;
            manager.selectedCount--;

            if (!manager.order)
                checkOn.SetActive(false);
            else
            {
                orderBase.SetActive(false);
                manager.RemoveOrder(GetOrder());
            }
        }
        public void UnselectableThis()
        {
            unselectable = true;
            cardFace.color = unselectableColor;
            cardBack.GetComponent<Image>().color = unselectableColor;
            levelIcon.color = unselectableColor;
            pendulumIcon.color = unselectableColor;
            textLevel.color = unselectableColor;
            textPendulum.color = unselectableColor;
            tunerIcon.color = unselectableColor;
        }
        public void SelectableThis()
        {
            if (preselected)
                return;
            unselectable = false;
            cardFace.color = Color.white;
            cardBack.GetComponent<Image>().color = Color.white;
            levelIcon.color = Color.white;
            pendulumIcon.color = Color.white;
            textLevel.color = Color.white;
            textPendulum.color = Color.white;
            tunerIcon.color = Color.white;
        }

        public void PreSelectThis()
        {
            preselected = true;
            SelectThis();
            UnselectableThis();
        }
    }
}
