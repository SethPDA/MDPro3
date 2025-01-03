using DG.Tweening;
using MDPro3;
using MDPro3.UI;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.Utility;
using UnityEngine.EventSystems;

public class SelectCharacter : Servant
{
    [Header("SelectCharacter")]
    [SerializeField] private SelectionToggle_CharacterSeries defaultToggle;

    [HideInInspector] public SelectionToggle_CharacterSeries lastSelectedToggle;
    [HideInInspector] public SelectionToggle_CharacterItem lastSelectedCharacter;

    public static string player = "0";
    public Characters characters;
    private GameObject characterItem;
    private string currentSerial = "00";
    private List<GameObject> targetItems = new List<GameObject>();

    private static List<GameObject> dm = new();
    private static List<GameObject> gx = new();
    private static List<GameObject> _5ds = new();
    private static List<GameObject> dsod = new();
    private static List<GameObject> zexal = new();
    private static List<GameObject> arcv = new();
    private static List<GameObject> vrains = new();
    private static List<GameObject> sevens = new();
    private static List<GameObject> npc = new();

    private Dictionary<string, List<GameObject>> pools = new()
    {
        { "00", dm},
        { "01", gx},
        { "02", _5ds},
        { "03", dsod},
        { "04", zexal},
        { "05", arcv},
        { "06", vrains},
        { "07", sevens},
        { "08", npc},
    };

    public enum Condition
    {
        Duel,
        Watch,
        Replay
    }
    public Condition condition = Condition.Duel;
    public void SwitchCondition(Condition condition)
    {
        this.condition = condition;
        var title = Manager.GetElement<TextMeshProUGUI>("Title");
        switch (condition)
        {
            case Condition.Duel:
                depth = 3;
                title.text = InterString.Get("决斗角色");
                break;
            case Condition.Watch:
                depth = 3;
                title.text = InterString.Get("观战角色");
                break;
            case Condition.Replay:
                depth = 3;
                title.text = InterString.Get("回放角色");
                break;
        }
    }

    #region Servant
    public override void Initialize()
    {
        depth = 2;
        showLine = false;
        subBlackAlpha = 0.9f;

        base.Initialize();

        var handle = Addressables.LoadAssetAsync<Characters>("Characters");
        handle.Completed += (result) =>
        {
            characters = result.Result;
            LoadCharacters();
            Program.instance.setting.RefreshCharacterName();
        };

        var handle2 = Addressables.LoadAssetAsync<GameObject>("ItemCharacter");
        handle2.Completed += (result) =>
        {
            characterItem = result.Result;
        };
    }
    protected override void ApplyShowArrangement(int preDepth)
    {
        Manager.GetElement<SelectionToggle_CharacterPlayer>("PlayerToggle0").SetToggleOn();
        base.ApplyShowArrangement(preDepth);
    }
    protected override void ApplyHideArrangement(int preDepth)
    {
        base.ApplyHideArrangement(preDepth);
        DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
        {
            foreach (var pool in pools)
                foreach (var c in pool.Value)
                    Destroy(c);
            foreach (var pool in pools)
                pool.Value.Clear();
        });
    }
    public override void PerFrameFunction()
    {
        if(!showing) return;
        if (!NeedResponseInput())
            return;
        if (UserInput.WasLeftShoulderPressed)
            Manager.GetElement<SelectionToggle_CharacterPlayer>("PlayerToggle0").OnLeftSelection();
        if (UserInput.WasRightShoulderPressed)
            Manager.GetElement<SelectionToggle_CharacterPlayer>("PlayerToggle0").OnRightSelection();

        if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
            OnReturn();
    }
    public override void SelectLastSelectable()
    {
        if (Selected != null)
        {
            if (Selected.TryGetComponent<SelectionToggle_CharacterItem>(out _))
                EventSystem.current.SetSelectedGameObject(Selected.gameObject);
            else if (Selected.TryGetComponent<SelectionToggle_CharacterSeries>(out _))
                EventSystem.current.SetSelectedGameObject(Selected.gameObject);
            else
                EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
        }
        else
            EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
    }
    public override void OnReturn()
    {
        if (inTransition) return;
        if (returnAction != null)
        {
            returnAction.Invoke();
            return;
        }
        AudioManager.PlaySE("SE_MENU_CANCEL");
        GameObject selected = EventSystem.current.currentSelectedGameObject;

        if (selected == null)
            OnExit();
        else if (Cursor.lockState == CursorLockMode.None)
            OnExit();
        else if (selected.TryGetComponent<SelectionToggle_CharacterItem>(out _))
        {
            if (lastSelectedToggle != null)
                EventSystem.current.SetSelectedGameObject(lastSelectedToggle.gameObject);
            else
                EventSystem.current.SetSelectedGameObject(defaultToggle.gameObject);
        }
        else
            OnExit();
    }
    public override void OnExit()
    {
        if (Program.instance.currentSubServant == this)
            Program.instance.ShowSubServant(Program.instance.setting);
        else
            Program.instance.ShiftToServant(Program.instance.setting);
    }
    #endregion

    public void LoadCharacters()
    {
        characters.Initialize();
        characters.ChangeLanguage(Language.GetConfig());
    }

    public void SwitchPlayer(string player)
    {
        SelectCharacter.player = player;
        if (!showing)
            return;

        var configCharacter = Config.Get(condition + "Character" + player, VoiceHelper.defaultCharacter);
        var configSeries = characters.GetCharacterSeries(configCharacter);
        Manager.GetElement<SelectionToggle_CharacterSeries>("Page" + configSeries).SetToggleOn();
    }

    public void ShowCharacters(string serial)
    {
        currentSerial = serial;

        if(characters == null || characterItem == null) 
            return;

        foreach (var pool in pools)
        {
            if (pool.Key != currentSerial)
            {
                foreach (var character in pool.Value)
                    character.SetActive(false);
            }
            else
                targetItems = pool.Value;
        }

        if (targetItems.Count == 0)
        {
            var targetCharacters = characters.GetSeriesCharacters(currentSerial);
            int count = 0;
            for(int i = 0; i < targetCharacters.Count; i++)
            {
                if (targetCharacters[i].notReady)
                    continue;
                var item = Instantiate(characterItem);
                var mono = item.GetComponent<SelectionToggle_CharacterItem>();
                mono.index = count;
                mono.characterID = targetCharacters[i].id;
                mono.Refresh();
                item.transform.SetParent(Manager.GetElement<ScrollRect>("ScrollRect").content, false);
                targetItems.Add(item);
                count++;
            }
        }

        foreach(var item in targetItems)
        {
            item.SetActive(true);
            var mono = item.GetComponent<SelectionToggle_CharacterItem>();
            var config = Config.Get(condition + "Character" + player, VoiceHelper.defaultCharacter);

            if (mono.characterID == config)
                mono.SetToggleOn();
        }
    }

    public int GetCurrentSerialCount()
    {
        if (characters == null || characterItem == null)
            return 0;

        foreach (var pool in pools)
            if (pool.Key == currentSerial)
                return pool.Value.Count;

        return 0;
    }

    public GameObject GetFirstActiveCharacterItem()
    {
        var content = Manager.GetElement<ScrollRect>("ScrollRect").content;

        for (int i = 0; i < content.childCount; i++)
            if (content.GetChild(i).gameObject.activeSelf)
                return content.GetChild(i).gameObject;
        return null;
    }

    public void SetHoverText(string text)
    {
        Manager.GetElement<TextMeshProUGUI>("HoverText").text = text;
    }
}
