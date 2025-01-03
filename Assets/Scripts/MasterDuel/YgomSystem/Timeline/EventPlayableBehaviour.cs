using DG.Tweening;
using MDPro3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class EventPlayableBehaviour : PlayableBehaviour
	{
		public class EventInfo
		{
			public string label;

			public double time;

			public bool isDone;
		}

		public List<EventInfo> eventList;

		public double startTime;

		private bool processed;

		//DIY
        public string label;
        PlayableDirector director;

        public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
            PlayContent();
            foreach (var e in eventList)
            {
                if (e.label == "WinStart" && !e.isDone)
                {
                    e.isDone = true;
                    DOTween.To(v => { }, 0, 0, (float)e.time).OnComplete(() =>
                    {
                        Program.instance.ocgcore.endingAction?.Invoke();
                    });
                }
            }
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
            if(playable.GetPlayState() == PlayState.Playing)
                PlayContent();
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
		{
        }

		private void CheckEventInfos(Playable playable)
		{
		}

		bool played = false;
		private void PlayContent()
		{
			if(played)
				return;
			played = true;
            if (label == "StartCard")
            {
                Program.instance.ocgcore.startCard?.Invoke();
            }
            else if (label == "StrongSummon")
            {
                if (Program.instance.currentServant != Program.instance.ocgcore)
                    return;
                MDPro3.TimelineManager.skippable = false;
                var code = Program.instance.ocgcore.summonCard.GetData().Id;
                if (MonsterCutin.HasCutin(code))
                    MonsterCutin.Play(code, (int)Program.instance.ocgcore.summonCard.p.controller);
            }
            else if(label == "Next")//Engage
            {
                if (Program.instance.ocgcore.nextMoveManager == null)
                    return;
                var target = Program.instance.ocgcore.nextMoveManager.GetElement<Transform>("DummyCard01");
                var card = Program.instance.ocgcore.lastMoveCard;
                card.model.SetActive(true);
                card.ResetModelRotation();
                card.model.transform.position = target.position;
                card.model.transform.eulerAngles = new Vector3(- target.eulerAngles.x, 0f, 0f);

                Program.instance.ocgcore.nextMoveAction = null;
                card.Move(card.p, false, 0f, Program.instance.ocgcore.nextMoveTime);
                DOTween.To(v => { }, 0, 0, Program.instance.ocgcore.nextMoveTime).OnComplete(() =>
                {
                    OcgCore.messagePass = true;
                });
            }
        }

    }
}
