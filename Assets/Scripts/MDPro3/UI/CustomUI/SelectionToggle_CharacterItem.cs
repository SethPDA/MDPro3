using System;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_CharacterItem : SelectionToggle
    {
        public string characterID;
        private string charaName;
        private string charaProfile;

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
            if (Program.instance.character.characters == null)
                return;

            charaName = Program.instance.character.characters.GetName(characterID);
            charaProfile = Program.instance.character.characters.GetProfile(characterID);
            charaProfile = Cid2Ydk.ReplaceWithCardName(charaProfile);

            var handle = Addressables.LoadAssetAsync<Sprite>("sn" + characterID);
            handle.Completed += (result) =>
            {
                var icon = Manager.GetElement<Image>("Out");
                icon.sprite = result.Result;
                icon.color = Color.white;
            };
        }

        protected override void CallHoverOnEvent()
        {
            base.CallHoverOnEvent();
            Program.instance.character.SetHoverText(charaName);
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            CallHoverOnEvent();
            Program.instance.character.Manager.GetElement<TextMeshProUGUI>("DetailName").text = charaName;
            Program.instance.character.Manager.GetElement<TextMeshProUGUI>("DetailDesc").text = charaProfile;
            Config.Set(Program.instance.character.condition + "Character" + SelectCharacter.player, characterID);
            Program.instance.ocgcore.CheckCharaFace();
            Program.instance.character.lastSelectedCharacter = this;
            Program.instance.currentServant.Selected = Selectable;
            if (!EventSystem.current.alreadySelecting)
                EventSystem.current.SetSelectedGameObject(gameObject);

            var detailImage = Program.instance.character.Manager.GetElement<Image>("DetialImage");
            detailImage.color = Color.clear;

            var handle = Addressables.LoadAssetAsync<Sprite>("sn" + characterID + "_2");
            handle.Completed += (result) =>
            {
                if (result.Result == null)
                    return;
                detailImage.color = Color.white;
                detailImage.sprite = result.Result;
            };
        }

        protected override void OnClick()
        {
            AudioManager.PlaySE(SoundLabelClick);
            SetToggleOn();
            Program.instance.currentServant.Selected = Selectable;
        }

        protected override int GetButtonsCount()
        {
            return Program.instance.character.GetCurrentSerialCount();
        }

        private GridLayoutGroup m_grid;
        private GridLayoutGroup Grid
        {
            get
            {
                if (m_grid == null)
                    m_grid = Program.instance.character.Manager.GetElement<ScrollRect>("ScrollRect").content.GetComponent<GridLayoutGroup>();
                return m_grid;
            }
        }

        protected override int GetColumnsCount()
        {
            return Grid.Size().x;
        }
    }
}
