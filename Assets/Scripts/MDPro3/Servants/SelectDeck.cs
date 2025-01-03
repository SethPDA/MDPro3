using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.UI;
using MDPro3.Net;
using TMPro;
using UnityEngine.EventSystems;
using MDPro3.UI.PropertyOverrider;

namespace MDPro3
{
    public class SelectDeck : Servant
    {
        [Header("SelectDeck")]
        public TMP_InputField inputField;

        public SuperScrollView superScrollView;
        public Dictionary<string, Deck> decks = new Dictionary<string, Deck>();

        [HideInInspector] public SelectionToggle_Deck lastSelectedDeckItem;

        public enum Condition
        {
            ForEdit,
            ForDuel,
            ForSolo,
            MyCard
        }
        public static Condition condition = Condition.ForEdit;
        public void SwitchCondition(Condition condition)
        {
            SelectDeck.condition = condition;
            var btnOnline = Manager.GetElement("ButtonOnline");
            var title = Manager.GetElement<TextMeshProUGUI>("TextTitle");
            switch (condition)
            {
                case Condition.ForEdit:
                    returnServant = Program.instance.menu;
                    btnOnline.SetActive(true);
                    title.text = InterString.Get("编辑卡组");
                    break;
                case Condition.ForDuel:
                    returnServant = Program.instance.room;
                    btnOnline.SetActive(false);
                    title.text = InterString.Get("选择卡组");
                    break;
                case Condition.ForSolo:
                    returnServant = Program.instance.solo;
                    btnOnline.SetActive(false);
                    title.text = InterString.Get("选择卡组");
                    break;
                case Condition.MyCard:
                    returnServant = Program.instance.online;
                    btnOnline.SetActive(false);
                    title.text = InterString.Get("选择卡组");
                    break;
            }
        }

        #region Servant
        public override void Initialize()
        {
            showLine = true;
            depth = 3;
            base.Initialize();
            inputField.onEndEdit.AddListener(Print);
            SwitchCondition(Condition.ForEdit);
            transform.GetChild(0).gameObject.SetActive(false);
        }
        public override void OnExit()
        {
            if (Program.exitOnReturn)
                Program.GameQuit();
            else
                Program.instance.ShiftToServant(returnServant);
        }
        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            RefreshList();
            ShowDefaultButtons();
        }
        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            Config.Save();
            DOTween.To(v => { }, 0, 0, transitionTime * 0.9f).OnComplete(() =>
            {
                Manager.GetElement<SelectionToggle>("ButtonPickupCard").SetToggleOff();
                superScrollView.Clear();
            });
        }
        public override void PerFrameFunction()
        {
            if (!showing) return;
            if (NeedResponseInput())
            {

                if (UserInput.WasLeftStickPressed)
                    Manager.GetElement<SelectionToggle>("ButtonPickupCard").SwitchToggle();

                if (UserInput.WasGamepadButtonWestPressed)
                {
                    AudioManager.PlaySE("SE_MENU_SELECT_01");
                    if (Manager.GetElement("ButtonOnline").activeSelf)
                    {
                        OnOnlineDeckView();
                    }
                    else
                    {
                        OnDeleteConfirm();
                    }
                }
                if (UserInput.WasGamepadButtonNorthPressed)
                {
                    AudioManager.PlaySE("SE_MENU_SELECT_01");
                    inputField.ActivateInputField();
                }
                if (UserInput.WasRightShoulderPressed)
                {
                    if (Manager.GetElement("ButtonOnline").activeSelf)
                    {
                        AudioManager.PlaySE("SE_MENU_SELECT_01");
                        OnDelete();
                    }
                }
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                {
                    if (Manager.GetElement("ButtonOnline").activeSelf)
                        OnReturn();
                    else
                    {
                        AudioManager.PlaySE("SE_MENU_CANCEL");
                        OnDeleteCancel();
                    }
                }
            }
        }
        public override void SelectLastSelectable()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedDeckItem.gameObject);
        }
        protected override bool NeedResponseInput()
        {
            if (inputField.isFocused)
                return false;
            if(buttonLayoutSwitching) 
                return false;
            return base.NeedResponseInput();
        }
        #endregion

        public void SelectLastDeckItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelectable();
        }

        public void RefreshList()
        {
            if (!showing)
                return;

            decks.Clear();
            ShowDefaultButtons();
            Manager.GetElement<SelectionToggle>("ButtonPickupCard").SetToggleOff();

            bool debug = false;

#if UNITY_EDITOR
            debug = true;
#endif

            if(condition == Condition.MyCard && debug)
            {
                foreach (var d in OnlineDeck.decks)
                {
                    if (d.isDelete)
                        continue;
                    if (decks.ContainsKey(d.deckName))
                    {
                        int avoid = 2;
                        while (decks.ContainsKey(d.deckName + $" ({avoid})"))
                            avoid++;
                        d.deckName += $" ({avoid})";
                    }
                    decks.Add(d.deckName, new Deck(d.deckYdk, d.deckId));
                }

                var configDeck = Config.Get("DeckInUse", "");
                if (decks.ContainsKey(configDeck))
                {
                    var deck = decks[configDeck];
                    decks.Remove(configDeck);
                    var newDecks = new Dictionary<string, Deck>();
                    newDecks[configDeck] = deck;
                    foreach(var d in decks)
                        newDecks.Add(d.Key, d.Value);
                    decks = newDecks;
                }
            }
            else
            {
                if (!Directory.Exists(Program.deckPath))
                    Directory.CreateDirectory(Program.deckPath);
                var files = Directory.GetFiles(Program.deckPath, "*.ydk");
                List<string> fileList = files.ToList();
                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    fileName = fileName.Substring(0, fileName.Length - 4);
                    if (fileName == Config.Get("DeckInUse", ""))
                    {
                        fileList.Remove(file);
                        fileList.Insert(0, file);
                        break;
                    }
                }
                List<string> list = new List<string>();
                foreach (var deck in fileList)
                {
                    var name = Path.GetFileName(deck);
                    name = name.Substring(0, name.Length - 4);
                    decks.Add(name, new Deck(deck));
                }
            }
            Print(inputField.text);
        }

        public void Print(string search = "")
        {
            ExitDeleteDeck();

            superScrollView?.Clear();

            var handle = Addressables.LoadAssetAsync<GameObject>("ItemDeck");
            handle.Completed += (result) =>
            {
                var itemWidth = PropertyOverrider.NeedMobileLayout() ? 336f : 260f;
                var itemHeight = PropertyOverrider.NeedMobileLayout() ? 300f : 232f;
                var space = PropertyOverrider.NeedMobileLayout() ? 30f : 24f;
                var bottomPadding = (PropertyOverrider.NeedMobileLayout() ? 196f : 150f) - space;
                superScrollView = new SuperScrollView(
                    -1,
                    itemWidth + space,
                    itemHeight + space,
                    10,
                    bottomPadding,
                    result.Result,
                    ItemOnListRefresh,
                    Manager.GetElement<ScrollRect>("ScrollRect"));
                List<string[]> tasks = new() { new string[7] { string.Empty, "0", "0", "0", "0", "0", "0" } };
                foreach (var deck in decks)
                {
                    if (!deck.Key.Contains(search))
                        continue;
                    var task = new string[8]
                    {
                        deck.Key,
                        deck.Value.Case.ToString(),
                        "0", "0", "0",
                        deck.Value.Protector.ToString(),
                        "0",//For Delete
                        deck.Value.deckId
                    };
                    if (deck.Value.Pickup.Count > 0)
                        task[2] = deck.Value.Pickup[0].ToString();
                    if (deck.Value.Pickup.Count > 1)
                        task[3] = deck.Value.Pickup[1].ToString();
                    if (deck.Value.Pickup.Count > 2)
                        task[4] = deck.Value.Pickup[2].ToString();
                    tasks.Add(task);
                }
                superScrollView.Print(tasks);
                lastSelectedDeckItem = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Deck>();
                if (Cursor.lockState == CursorLockMode.Locked)
                    SelectLastSelectable();
                Manager.GetElement<TextMeshProUGUI>("TextDeckNumValue").text = (superScrollView.items.Count - 1).ToString();
            };
        }

        void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Deck>();
            handler.deckName = task[0];
            handler.deckCase = int.Parse(task[1]);
            handler.card0 = int.Parse(task[2]);
            handler.card1 = int.Parse(task[3]);
            handler.card2 = int.Parse(task[4]);
            handler.protector = task[5];
            handler.isOn = task[6] != "0";
            handler.Refresh();
        }

        public bool PickupShowing
        {
            get { return m_pickupShowing; }
            set
            {
                m_pickupShowing = value;
                DeckHover();
            }
        }
        private bool m_pickupShowing = false;
        public void DeckHover()
        {
            if (superScrollView == null)
                return;

            foreach (var item in superScrollView.items)
            {
                if(item.gameObject == null)
                    continue;
                var handler = item.gameObject.GetComponent<SelectionToggle_Deck>();

                if(PickupShowing)
                    handler.ShowPickup(true);
                else
                    handler.HidePickup(true);
            }
        }

        public void DeckCreate()
        {
            ExitDeleteDeck();
            var selections = new List<string>()
            {
                InterString.Get("请输入卡组名。@n创建卡组时会自动导入剪切板中的卡组码。"),
                string.Empty
            };
            UIManager.ShowPopupInput(selections, DeckCheck, null, TmpInputValidation.ValidationType.Path);
        }

        void DeckCheck(string deckName)
        {
            var path = Program.deckPath + deckName + Program.ydkExpansion;

            if (File.Exists(path))
            {
                deckInUse = deckName;
                List<string> tasks = new List<string>()
                {
                    InterString.Get("该卡组名已存在"),
                    InterString.Get("该卡组名的文件已存在，是否直接覆盖创建？"),
                    InterString.Get("覆盖"),
                    InterString.Get("取消")
                };
                DOTween.To(v => { }, 0, 0, transitionTime + 0.1f).OnComplete(() =>
                {
                    UIManager.ShowPopupYesOrNo(tasks, DeckFileCreateWithName, null);
                });
            }
            else
                DeckFileCreate(deckName);
        }

        public static string deckInUse;
        void DeckFileCreateWithName()
        {
            DeckFileCreate(deckInUse);
        }

        void DeckFileCreate(string deckName)
        {
            try
            {
                var path = Program.deckPath + deckName + Program.ydkExpansion;
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.Create(path).Close();

                string clipBoard = GUIUtility.systemCopyBuffer;
                if (clipBoard.Contains("#main"))
                    File.WriteAllText(path!, clipBoard, Encoding.UTF8);
                else if (clipBoard.Contains("ygotype=deck&v=1&d="))
                {
                    var uri = new Uri(clipBoard);
                    var deck = DeckShareURL.UriToDeck(uri);
                    deck.Save(deckName, DateTime.Now);
                }
                Config.Set("DeckInUse", deckName);
                RefreshList();
            }
            catch(Exception e)
            {
                Debug.LogException(e);
                MessageManager.Cast(InterString.Get("创建卡组失败！请检查文件夹权限。"));
            }
        }


        void DeleteOnlineDecks(List<string> ids)
        {
            if (MyCard.account == null)
                return;
            _ = OnlineDeck.DeleteDecks(ids);
        }

        public void OnOnlineDeckView()
        {
            Program.instance.ShiftToServant(Program.instance.onlineDeckViewer);
        }

        public void OnShowPickup()
        {
            PickupShowing = true;
        }

        public void OnHidePickup()
        {
            PickupShowing = false;
        }


        #region Delete Deck
        public void OnDelete()
        {
            if(buttonLayoutSwitching) return;
            SwitchButtonLayouts(false);
        }
        public void OnDeleteCancel()
        {
            if (buttonLayoutSwitching) return;
            SwitchButtonLayouts(true);
            foreach (var item in superScrollView.items)
            {
                if (item.gameObject == null)
                    continue;
                item.gameObject.GetComponent<SelectionToggle_Deck>().HideToggle();
            }
        }
        public void OnDeleteConfirm()
        {
            if (buttonLayoutSwitching) return;

            var toDeleteIndex = new List<int>();
            var toDeleteIds = new List<string>();
            for(int i = 0; i < superScrollView.items.Count; i++)
                if (superScrollView.items[i].args[6] != "0")
                {
                    File.Delete(Program.deckPath + superScrollView.items[i].args[0] + Program.ydkExpansion);
                    toDeleteIndex.Add(i);
                    toDeleteIds.Add(superScrollView.items[i].args[7]);
                }

            var lastSelect = lastSelectedDeckItem.index;
            int removedCount = 0;
            for (int i = 0; i < toDeleteIndex.Count; i++)
            {
                superScrollView.RemoveAt(toDeleteIndex[i] - removedCount);
                removedCount++;
            }
            lastSelectedDeckItem = (SelectionToggle_Deck)superScrollView.GetItemByIndex(lastSelect);
            if (Cursor.lockState == CursorLockMode.Locked)
                SelectLastSelectable();
            DeleteOnlineDecks(toDeleteIds);

            ExitDeleteDeck(true);
        }
        private void ExitDeleteDeck(bool needSwitch = false)
        {
            if(superScrollView == null || superScrollView.items == null)
                return;

            foreach (var item in superScrollView.items)
                item.args[6] = "0";
            foreach (var item in superScrollView.items)
            {
                if (item.gameObject == null)
                    continue;
                item.gameObject.GetComponent<SelectionToggle_Deck>().HideToggle();
            }

            buttonLayoutSwitching = true;

            if(needSwitch)
            {
                var header = Manager.GetElement<RectTransform>("Header");
                var footer = Manager.GetElement<RectTransform>("Footer");
                UIManager.HideExitButton(0.2f);

                DOTween.Sequence()
                    .Append(header.DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? 130f : 120f, 0.2f).OnComplete(() =>
                    {
                        ShowDefaultButtons();
                        UIManager.ShowExitButton(0.3f, Ease.OutQuart);
                    }))
                    .Append(header.DOAnchorPosY(0f, 0.3f).SetEase(Ease.OutQuart));

                DOTween.Sequence()
                    .Append(footer.DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? -186f : -140f, 0.2f))
                    .Append(footer.DOAnchorPosY(0f, 0.3f).SetEase(Ease.OutQuart)).OnComplete(() =>
                    {
                        buttonLayoutSwitching = false;
                    });
            }
            else
            {
                ShowDefaultButtons();
                buttonLayoutSwitching = false;
            }
        }

        private bool buttonLayoutSwitching;
        private void SwitchButtonLayouts(bool showDefault)
        {
            buttonLayoutSwitching = true;

            var header = Manager.GetElement<RectTransform>("Header");
            var footer = Manager.GetElement<RectTransform>("Footer");
            UIManager.HideExitButton(0.2f);

            DOTween.Sequence()
                .Append(header.DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? 130f : 120f, 0.2f).OnComplete(() =>
                {
                    if (showDefault)
                        ShowDefaultButtons();
                    else
                        ShowDeleteButtons();
                    UIManager.ShowExitButton(0.3f, Ease.OutQuart);
                    if (!showDefault)
                        foreach (var item in superScrollView.items)
                        {
                            if (item.gameObject == null)
                                continue;
                            item.gameObject.GetComponent<SelectionToggle_Deck>().ShowToggle();
                        }
                }))
                .Append(header.DOAnchorPosY(0f, 0.3f).SetEase(Ease.OutQuart));

            DOTween.Sequence()
                .Append(footer.DOAnchorPosY(PropertyOverrider.NeedMobileLayout() ? -186f : -140f, 0.2f))
                .Append(footer.DOAnchorPosY(0f, 0.3f).SetEase(Ease.OutQuart)).OnComplete(() =>
                {
                    buttonLayoutSwitching = false;
                });
        }
        private void ShowDefaultButtons()
        {
            Manager.GetElement("ButtonDelete").SetActive(true);
            Manager.GetElement("ButtonDeleteCancel").SetActive(false);
            Manager.GetElement("ButtonOnline").SetActive(true);
            Manager.GetElement("ButtonDeleteConfirm").SetActive(false);
            inputField.gameObject.SetActive(true);
        }
        private void ShowDeleteButtons()
        {
            Manager.GetElement("ButtonDelete").SetActive(false);
            Manager.GetElement("ButtonDeleteCancel").SetActive(true);
            Manager.GetElement("ButtonOnline").SetActive(false);
            Manager.GetElement("ButtonDeleteConfirm").SetActive(true);
            inputField.gameObject.SetActive(false);
        }

        #endregion
    }
}
