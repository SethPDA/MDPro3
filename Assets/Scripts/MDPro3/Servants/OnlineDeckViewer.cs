using DG.Tweening;
using MDPro3;
using MDPro3.UI;
using MDPro3.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using MDPro3.UI.PropertyOverrider;

public class OnlineDeckViewer : Servant
{
    [Header("OnlineDeckViewer")]
    public TMP_InputField inputFieldDeckName;
    public TMP_InputField inputFieldAuthorName;

    public SuperScrollView superScrollView;
    private OnlineDeck.OnlineDeckData[] decks;
    [HideInInspector] public SelectionToggle_DeckOnline lastSelectedDeckItem;

    #region Servant
    public override void Initialize()
    {
        showLine = true;
        depth = 4;
        returnServant = Program.instance.selectDeck;
        base.Initialize();
        transform.GetChild(0).gameObject.SetActive(false);
    }

    protected override void ApplyShowArrangement(int preDepth)
    {
        base.ApplyShowArrangement(preDepth);
        RefreshList();
    }

    protected override void ApplyHideArrangement(int preDepth)
    {
        base.ApplyHideArrangement(preDepth);
        DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
        {
            superScrollView?.Clear();
            decks = null;
        });
    }

    public override void SelectLastSelectable()
    {
        EventSystem.current.SetSelectedGameObject(lastSelectedDeckItem.gameObject);
    }

    protected override bool NeedResponseInput()
    {
        if(inputFieldDeckName.isFocused)
            return false;
        if (inputFieldAuthorName.isFocused)
            return false;
        return base.NeedResponseInput();
    }

    public override void PerFrameFunction()
    {
        if (!showing) return;
        if (NeedResponseInput())
        {
            if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                OnReturn();
            if (UserInput.WasGamepadButtonWestPressed)
            {
                AudioManager.PlaySE("SE_MENU_SELECT_01");
                inputFieldDeckName.ActivateInputField();
            }
            if (UserInput.WasGamepadButtonNorthPressed)
            {
                AudioManager.PlaySE("SE_MENU_SELECT_01");
                inputFieldAuthorName.ActivateInputField();
            }
        }
    }

    #endregion

    private void RefreshList()
    {
        decks = null;
        StartCoroutine(RefreshAsync());
    }

    private IEnumerator RefreshAsync()
    {
        var task = OnlineDeck.FetchSimpleDeckList(10000, inputFieldDeckName.text, inputFieldAuthorName.text);
        yield return new WaitUntil(() => task.IsCompleted);

        if(task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
        {
            decks = task.Result;
            if(decks == null)
            {
                MessageManager.Cast(InterString.Get("网络异常，获取在线卡组列表失败。"));
                yield break;
            }
            Manager.GetElement<TextMeshProUGUI>("TextDeckNumValue").text = decks.Length.ToString();
            Print();
        }
        else
            MessageManager.Cast(InterString.Get("网络异常，获取在线卡组列表失败。"));
    }

    private void Print()
    {
        superScrollView?.Clear();

        var scale = Config.GetUIScale();

        var handle = Addressables.LoadAssetAsync<GameObject>("ItemDeckOnline");
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
            List<string[]> tasks = new List<string[]>();
            foreach (var deck in decks)
            {
                var task = new string[10]
                {
                    deck.deckName,
                    deck.deckContributor,
                    deck.deckId,
                    deck.deckCase == 0 ? "1080001" : deck.deckCase.ToString(),
                    deck.deckCoverCard1.ToString(),
                    deck.deckCoverCard2.ToString(),
                    deck.deckCoverCard3.ToString(),
                    deck.deckProtector == 0 ? "1070001" : deck.deckProtector.ToString(),
                    deck.deckLike.ToString(),
                    deck.lastDate
                };
                tasks.Add(task);
            }
            superScrollView.Print(tasks);
            if (superScrollView.items.Count > 0)
                lastSelectedDeckItem = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_DeckOnline>();
            if (Cursor.lockState == CursorLockMode.Locked)
                SelectLastSelectable();
            Manager.GetElement<TextMeshProUGUI>("TextDeckNumValue").text = (superScrollView.items.Count - 1).ToString();
        };
    }

    private void ItemOnListRefresh(string[] task, GameObject item)
    {
        var handler = item.GetComponent<SelectionToggle_DeckOnline>();
        handler.deckName = task[0];
        handler.deckAuthor = task[1];
        handler.deckId = task[2];
        handler.deckCase = int.Parse(task[3]);
        handler.card0 = int.Parse(task[4]);
        handler.card1 = int.Parse(task[5]);
        handler.card2 = int.Parse(task[6]);
        handler.protector = task[7];
        handler.like = int.Parse(task[8]);
        handler.lastDate = task[9];
        handler.Refresh();
    }

    public void OnSearchSubmit()
    {
        RefreshList();
    }
}
