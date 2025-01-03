using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupDuelPosition : PopupDuel
    {
        [Header("Popup Duel Position Reference")]
        public RawImage positionAttack;
        public RawImage positionDefense;
        public RawImage positionDefenseDown;

        public Button btnPositionAttack;
        public Button btnPositionDefense;
        public Button btnPositionDefenseDown;

        public int code;
        public int count;
        public int option1;
        public int option2;

        public override void InitializeSelections()
        {
            StartCoroutine(RefreshCard(code));
            if (count == 3)
            {
                btnPositionAttack.onClick.AddListener(OnAttack);
                btnPositionDefense.onClick.AddListener(OnDefense);
                btnPositionDefenseDown.onClick.AddListener(OnDefenseDown);
            }
            else
            {
                bool p1 = false;
                bool p2 = false;
                bool p3 = false;

                if (option1 == 1)
                {
                    btnPositionAttack.onClick.AddListener(OnAttack);
                    positionAttack.GetComponent<RectTransform>().anchoredPosition = new Vector2(-150, 0);
                    p1 = true;
                }
                else if (option1 == 2)
                {
                    btnPositionAttack.onClick.AddListener(OnAttackDown);
                    positionAttack.GetComponent<RectTransform>().anchoredPosition = new Vector2(-150, 0);
                    p1 = true;
                }
                else
                {
                    btnPositionDefense.onClick.AddListener(OnDefense);
                    positionDefense.GetComponent<RectTransform>().anchoredPosition = new Vector2(-150, 0);
                    p2 = true;
                }

                if (option2 == 4)
                {
                    btnPositionDefense.onClick.AddListener(OnDefense);
                    positionDefense.GetComponent<RectTransform>().anchoredPosition = new Vector2(150, 0);
                    p2 = true;
                }
                else
                {
                    btnPositionDefenseDown.onClick.AddListener(OnDefenseDown);
                    positionDefenseDown.GetComponent<RectTransform>().anchoredPosition = new Vector2(150, 0);
                    p3 = true;
                }

                if (!p1)
                    Destroy(positionAttack.gameObject);
                if (!p2)
                    Destroy(positionDefense.gameObject);
                if (!p3)
                    Destroy(positionDefenseDown.gameObject);
            }
        }
        IEnumerator RefreshCard(int code)
        {
            var task = TextureManager.LoadCardAsync(code, false);
            while (!task.IsCompleted)
                yield return null;
            var mat = TextureManager.GetCardMaterial(code);
            if (positionAttack != null)
            {
                if (option1 == 1)
                {
                    positionAttack.material = mat;
                    positionAttack.texture = task.Result;
                }
                else
                    positionAttack.material = Program.instance.ocgcore.myProtector;
            }
            if (positionDefense != null)
            {
                positionDefense.material = mat;
                positionDefense.texture = task.Result;
            }
            if (positionDefenseDown != null)
                positionDefenseDown.material = Program.instance.ocgcore.myProtector;
        }

        void OnAttack()
        {
            Hide();
            var p = new BinaryMaster();
            p.writer.Write(1);
            Program.instance.ocgcore.SendReturn(p.Get());
        }
        void OnAttackDown()
        {
            Hide();
            var p = new BinaryMaster();
            p.writer.Write(2);
            Program.instance.ocgcore.SendReturn(p.Get());
        }
        void OnDefense()
        {
            Hide();
            var p = new BinaryMaster();
            p.writer.Write(4);
            Program.instance.ocgcore.SendReturn(p.Get());
        }
        void OnDefenseDown()
        {
            Hide();
            var p = new BinaryMaster();
            p.writer.Write(8);
            Program.instance.ocgcore.SendReturn(p.Get());
        }
    }
}
