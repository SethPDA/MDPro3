using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.YGOSharp.OCGWrapper.Enums;

namespace MDPro3.UI
{
    public class PopupDuelPhase : PopupDuel
    {
        [Header("Popup Duel Phase Reference")]
        public AnimatorOverrideController overrideController;
        public Button main1;
        public Button battle;
        public Button main2;
        public Button end;

        public override void InitializeSelections()
        {
            if (selections[0] == DuelPhase.Main1.ToString())
            {
                main1.transition = Selectable.Transition.Animation;
                main1.GetComponent<Animator>().runtimeAnimatorController = overrideController;
                main1.onClick.AddListener(Hide);
            }
            else if (selections[0] == DuelPhase.BattleStart.ToString())
            {
                battle.transition = Selectable.Transition.Animation;
                battle.GetComponent<Animator>().runtimeAnimatorController = overrideController;
                battle.onClick.AddListener(Hide);
            }
            else if (selections[0] == DuelPhase.Main2.ToString())
            {
                main2.transition = Selectable.Transition.Animation;
                main2.GetComponent<Animator>().runtimeAnimatorController = overrideController;
                main2.onClick.AddListener(Hide);
            }

            for (int i = 1; i < selections.Count; i++)
            {
                if (selections[i] == DuelPhase.BattleStart.ToString())
                {
                    battle.transition = Selectable.Transition.Animation;
                    battle.onClick.AddListener(OnBattle);
                }
                else if (selections[i] == DuelPhase.Main2.ToString())
                {
                    main2.transition = Selectable.Transition.Animation;
                    main2.onClick.AddListener(OnMain2);
                }
                else if (selections[i] == DuelPhase.End.ToString())
                {
                    end.transition = Selectable.Transition.Animation;
                    end.onClick.AddListener(OnEnd);
                }
            }
            if (main1.transition == Selectable.Transition.None)
            {
                main1.interactable = false;
                main1.transition = Selectable.Transition.Animation;
                Destroy(main1.GetComponent<UIEventWithAudio>());
            }
            if (battle.transition == Selectable.Transition.None)
            {
                battle.interactable = false;
                battle.transition = Selectable.Transition.Animation;
                Destroy(battle.GetComponent<UIEventWithAudio>());
            }
            if (main2.transition == Selectable.Transition.None)
            {
                main2.interactable = false;
                main2.transition = Selectable.Transition.Animation;
                Destroy(main2.GetComponent<UIEventWithAudio>());
            }
            if (end.transition == Selectable.Transition.None)
            {
                end.interactable = false;
                end.transition = Selectable.Transition.Animation;
                Destroy(end.GetComponent<UIEventWithAudio>());
            }
        }

        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_PHASE_WINDOW_OPEN");
        }

        public override void Hide()
        {
            base.Hide();
            AudioManager.PlaySE("SE_PHASE_WINDOW_CLOSE");
        }

        void OnBattle()
        {
            var m = new BinaryMaster();
            m.writer.Write(6);
            Program.instance.ocgcore.SendReturn(m.Get());
            Hide();
        }
        void OnMain2()
        {
            var m = new BinaryMaster();
            m.writer.Write(2);
            Program.instance.ocgcore.SendReturn(m.Get());
            Hide();
        }
        void OnEnd()
        {
            var m = new BinaryMaster();
            if (selections[0] == DuelPhase.BattleStart.ToString())
                m.writer.Write(3);
            else
                m.writer.Write(7);
            Program.instance.ocgcore.SendReturn(m.Get());
            Hide();
        }
    }
}
