using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp;

namespace MDPro3.UI
{
    public class PopupSearchFilter : PopupBase
    {
        [Header("Popup Search Filter")]
        public Button btnReset;
        public Button btnPack;
        public InputField levelFrom;
        public InputField levelTo;
        public InputField attackFrom;
        public InputField attackTo;
        public InputField defenceFrom;
        public InputField defenceTo;
        public InputField scaleFrom;
        public InputField scaleTo;
        public InputField yearFrom;
        public InputField yearTo;

        private void Start()
        {
            var f = Program.instance.editDeck.filters;
            if (f.Count > 0)
            {
                foreach (var toggle in transform.GetComponentsInChildren<ToggleForSearchFilter>())
                {
                    if (toggle.group == 0 && (toggle.filterCode & f[0]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 1 && (toggle.filterCode & f[1]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 2 && (toggle.filterCode & f[2]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 3 && (toggle.filterCode & f[3]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 4 && (toggle.filterCode & f[4]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 5 && (toggle.filterCode & f[5]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 6 && (toggle.filterCode & f[6]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 7 && (toggle.filterCode & f[7]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 8 && (toggle.filterCode & f[8]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 9 && (toggle.filterCode & f[9]) > 0)
                        toggle.SwitchOn();
                    else if (toggle.group == 10 && (toggle.filterCode & f[10]) > 0)
                        toggle.SwitchOn();

                }
                if (f[11] > 0)
                    levelFrom.text = f[11].ToString();
                if (f[12] > 0)
                    levelTo.text = f[12].ToString();
                if (f[13] > 0)
                    attackFrom.text = f[13].ToString();
                if (f[14] > 0)
                    attackTo.text = f[14].ToString();
                if (f[15] > 0)
                    defenceFrom.text = f[15].ToString();
                if (f[16] > 0)
                    defenceTo.text = f[16].ToString();
                if (f[17] > 0)
                    scaleFrom.text = f[17].ToString();
                if (f[18] > 0)
                    scaleTo.text = f[18].ToString();
                if (f[19] > 0)
                    yearFrom.text = f[19].ToString();
                if (f[20] > 0)
                    yearTo.text = f[20].ToString();
            }
            btnPack.GetComponent<ButtonPress>().text.text = EditDeck.pack == "" ? InterString.Get("所有卡包") : EditDeck.pack;
            btnPack.onClick.AddListener(OnPack);
        }
        public override void Initialize()
        {
            base.Initialize();
            Program.instance.currentServant.returnAction = OnCancel;
        }
        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
        }


        public override void OnConfirm()
        {
            base.OnConfirm();
            Hide();

            long type = 0;
            long attribute = 0;
            //ContinuousSpell = 0x8000000
            //ContinuousTrap = 0x10000000
            long spellType = 0;
            long race = 0;
            //NonEffect = 0x8000000
            long ability = 0;
            //Ban = 1
            //Limit = 2
            //SemiLimit = 4
            //NoLimit = 8
            long limit = 0;
            //OCG =1
            //TCG = 2
            //SCOCG = 8
            //DIY = 4
            //OCGOnly = 16
            //TCGOnly = 32
            //NonOnly = 64
            long pool = 0;
            long effect = 0;
            long rarity = 0;
            //Yes = 1
            //No = 2
            long cutin = 0;
            long link = 0;

            bool dirty = false;
            foreach (var toggle in transform.GetComponentsInChildren<ToggleForSearchFilter>())
            {
                if (toggle.switchOn)
                {
                    dirty = true;
                    if (toggle.group == 0)
                        type += toggle.filterCode;
                    else if (toggle.group == 1)
                        attribute += toggle.filterCode;
                    else if (toggle.group == 2)
                        spellType += toggle.filterCode;
                    else if (toggle.group == 3)
                        race += toggle.filterCode;
                    else if (toggle.group == 4)
                        ability += toggle.filterCode;
                    else if (toggle.group == 5)
                        limit += toggle.filterCode;
                    else if (toggle.group == 6)
                        pool += toggle.filterCode;
                    else if (toggle.group == 7)
                        effect += toggle.filterCode;
                    else if (toggle.group == 8)
                        rarity += toggle.filterCode;
                    else if (toggle.group == 9)
                        cutin += toggle.filterCode;
                    else if (toggle.group == 10)
                        link += toggle.filterCode;
                }
            }
            var filters = new List<long>()
        { type, attribute, spellType, race, ability, limit, pool, effect, rarity, cutin, link };
            if (levelFrom.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(levelFrom.text));
            }
            else
                filters.Add(-233);
            if (levelTo.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(levelTo.text));
            }
            else
                filters.Add(-233);
            if (attackFrom.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(attackFrom.text));
            }
            else
                filters.Add(-233);
            if (attackTo.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(attackTo.text));
            }
            else
                filters.Add(-233);
            if (defenceFrom.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(defenceFrom.text));
            }
            else
                filters.Add(-233);
            if (defenceTo.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(defenceTo.text));
            }
            else
                filters.Add(-233);
            if (scaleFrom.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(scaleFrom.text));
            }
            else
                filters.Add(-233);
            if (scaleTo.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(scaleTo.text));
            }
            else
                filters.Add(-233);
            if (yearFrom.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(yearFrom.text));
            }
            else
                filters.Add(-233);
            if (yearTo.text.Length > 0)
            {
                dirty = true;
                filters.Add(long.Parse(yearTo.text));
            }
            else
                filters.Add(-233);

            if (btnPack.GetComponent<ButtonPress>().text.text != InterString.Get("所有卡包"))
                dirty = true;
            if (dirty)
            {
                Program.instance.editDeck.FilterButtonSwitch(true);
                Program.instance.editDeck.filters = filters;
                EditDeck.pack = btnPack.GetComponent<ButtonPress>().text.text == InterString.Get("所有卡包") ?
                    string.Empty : btnPack.GetComponent<ButtonPress>().text.text;
            }
            else
            {
                Program.instance.editDeck.FilterButtonSwitch(false);
                Program.instance.editDeck.filters.Clear();
                EditDeck.pack = string.Empty;
            }
            Program.instance.editDeck.OnClickSearch();
        }
        public override void Hide()
        {
            base.Hide();
        }

        public override void OnCancel()
        {
            base.OnCancel();
            Hide();
        }

        public void OnReset()
        {
            foreach (var toggle in transform.GetComponentsInChildren<Toggle>())
                toggle.SwitchOff();
            levelFrom.text = "";
            levelTo.text = "";
            attackFrom.text = "";
            attackTo.text = "";
            defenceFrom.text = "";
            defenceTo.text = "";
            scaleFrom.text = "";
            scaleTo.text = "";
            yearFrom.text = "";
            yearTo.text = "";
            btnPack.GetComponent<ButtonPress>().text.text = InterString.Get("所有卡包");
        }



        public void OnPack()
        {
            var selections = new List<string>() 
            { 
                InterString.Get("卡包"),
                string.Empty
            };
            foreach (var pack in PacksManager.packs)
                selections.Add(pack.fullName);
            UIManager.ShowPopupSelection(selections, OnPackSelect, OnPackClose);
        }

        void OnPackSelect()
        {
            string selected = UnityEngine.EventSystems.EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            btnPack.GetComponent<ButtonPress>().text.text = selected;
        }
        void OnPackClose()
        {
            Program.instance.currentServant.returnAction = Hide;
        }

        private void Update()
        {
            float aspect = Screen.width / (float)Screen.height;
            if (aspect < 16f / 9f)
                window.transform.localScale = new Vector3(aspect * 9f / 16f, 1f, 1f);
            else
                window.transform.localScale = Vector3.one;
        }

    }
}
