using MDPro3;
using MDPro3.UI;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class CharacterItem : MonoBehaviour, IPointerEnterHandler
    {
        public Image icon;
        public Button button;
        public GameObject checkMark;

        public int id;
        public string characterID;
        string charaName;
        string charaProfile;

        public bool selected;

        Sprite chara002;

        void Start()
        {
            button.onClick.AddListener(SelectThis);
            icon.color = Color.clear;

            var handle = Addressables.LoadAssetAsync<Sprite>("sn" + characterID);
            handle.Completed += (result) =>
            {
                icon.sprite = result.Result;
                icon.color = Color.white;
            };
        }

        public void Load()
        {
            if (Program.instance.character.characters == null)
                return;

            charaName = Program.instance.character.characters.GetName(characterID);
            charaProfile = Program.instance.character.characters.GetProfile(characterID);
            charaProfile = Cid2Ydk.ReplaceWithCardName(charaProfile);
        }

        public void SelectThis()
        {
            selected = true;
            checkMark.SetActive(true);

            foreach (var item in transform.parent.GetComponentsInChildren<CharacterItem>(true))
                if (item != this)
                    item.UnselectThis();
            Program.instance.character.Manager.GetElement<TextMeshProUGUI>("DetailName").text = charaName;
            Program.instance.character.Manager.GetElement<TextMeshProUGUI>("DetailDesc").text = charaProfile;
            ShowChara002();

            Config.Set(Program.instance.character.condition + "Character" + SelectCharacter.player, characterID);
            Program.instance.ocgcore.CheckCharaFace();
        }

        public void UnselectThis()
        {
            selected = false;
            checkMark.SetActive(false);
        }

        void ShowChara002()
        {
            var detailImage = Program.instance.character.Manager.GetElement<Image>("DetialImage");
            detailImage.color = Color.clear;

            var handle = Addressables.LoadAssetAsync<Sprite>("sn" + characterID + "_2");
            handle.Completed += (result) =>
            {
                chara002 = result.Result;
                if (selected && chara002 != null)
                {
                    detailImage.color = Color.white;
                    detailImage.sprite = chara002;
                }
            };
        }

        public void Show()
        {
            var cg = GetComponent<CanvasGroup>();
            cg.alpha = 1.0f;
            cg.blocksRaycasts = true;
        }

        public void Hide()
        {
            var cg = GetComponent<CanvasGroup>();
            cg.alpha = 0f;
            cg.blocksRaycasts = false;
            gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Program.instance.character.Manager.GetElement<TextMeshProUGUI>("HoverText").text = charaName;
        }
    }
}
