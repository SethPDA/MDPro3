using MDPro3;
using Percy;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Duel
{
	public class DuelChainSpot : MonoBehaviour
	{
		private enum Step
		{
			WaitChainResolveBegin = 0,
			WaitChainResolveEnd = 1,
			WaitTimelineEnd = 2,
			Idle = 3
		}

		private const string LABEL_ICON_CHAINWRAP = "ChainWrapSet";

		private const string LABEL_ICON_NUM0 = "DummyNum01";

		private const string LABEL_ICON_NUM1 = "DummyNum02_01";

		private const string LABEL_ICON_NUM2 = "DummyNum02_02";

		private ElementObjectManager m_EOManager_Origin;

		private Vector3 m_OriginPos;

		private Step m_Step;

		private bool m_OnChainResolveBeginFlag;

		private bool m_OnChainResolveEndFlag;

		private DuelIconSprites m_DuelIconSprites => null;

		private ElementObjectManager m_EOManager => GetComponent<ElementObjectManager>();

		private PlayableDirector m_PlayableDirector => GetComponent<PlayableDirector>();

		private LabeledPlayableController m_LPController;

        private void Awake()
        {
            m_LPController = LabeledPlayableController.Create(GetComponent<PlayableDirector>());
			foreach (var sr in transform.GetComponentsInChildren<SpriteRenderer>(true))
				sr.sortingLayerName = "ChainSpot";
        }

        public void Play(int chainnum, uint location, bool cardexist, bool turn, Vector3 worldposition, bool mutesound)
		{
			if(chainnum < 10)
			{
				m_EOManager.GetElement("DummyNum02_01").SetActive(false);
                m_EOManager.GetElement("DummyNum02_02").SetActive(false);
                m_EOManager.GetElement<SpriteRenderer>("DummyNum01").sprite = GetNumSprite(chainnum);
            }
			else
			{
                m_EOManager.GetElement("DummyNum01").SetActive(false);
				int tensDigit = (chainnum / 10) % 10;
				int onesDigit = chainnum % 10;
                m_EOManager.GetElement<SpriteRenderer>("DummyNum02_01").sprite = GetNumSprite(tensDigit);
                m_EOManager.GetElement<SpriteRenderer>("DummyNum02_02").sprite = GetNumSprite(onesDigit);
            }
			var offsetY = 0f;
			if ((location & (uint)CardLocation.Hand) > 0)
				offsetY = 3f;
			transform.position = worldposition + new Vector3(0, offsetY, 0);

			if (!cardexist)
				Destroy(m_EOManager.GetElement(LABEL_ICON_CHAINWRAP));
			else if (turn)
				m_EOManager.GetElement<Transform>(LABEL_ICON_CHAINWRAP).localEulerAngles = new Vector3(0, 90, 0);

            transform.localScale = GameCard.GetCardScale(new GPS() { location = location });
			if (mutesound)
				AudioManager.nextMuteSE = "SE_DUELCHAIN_01";
        }

        Sprite GetNumSprite(int num)
		{
			switch(num)
			{
				case 0:
					return TextureManager.container.chainCircleNum0;
                case 1:
                    return TextureManager.container.chainCircleNum1;
                case 2:
                    return TextureManager.container.chainCircleNum2;
                case 3:
                    return TextureManager.container.chainCircleNum3;
                case 4:
                    return TextureManager.container.chainCircleNum4;
                case 5:
                    return TextureManager.container.chainCircleNum5;
                case 6:
                    return TextureManager.container.chainCircleNum6;
                case 7:
                    return TextureManager.container.chainCircleNum7;
                case 8:
                    return TextureManager.container.chainCircleNum8;
                case 9:
                    return TextureManager.container.chainCircleNum9;
				default:
					return TextureManager.container.typeNone;
            }
        }

		IEnumerator PlayLabel(int type)
		{
			while (m_LPController.loopMixerBehaviour == null)
				yield return null;
			if(type == 0)
                m_LPController.PlayLabel("ChainResolveBegin", m_LPController.loopMixerBehaviour.loopClips[1]);
			else if(type == 1)
                m_LPController.PlayLabel("ChainResolveEnd", (TimelineClip)null);
        }

        public void OnChainResolveBegin()
		{
			StartCoroutine(PlayLabel(0));
		}

		public void OnChainResolveEnd()
		{
            StartCoroutine(PlayLabel(1));
        }

		public void OnChainSetMore()
		{
		}

		private void Update()
		{
		}

		private void WaitChainResolveBegin()
		{
		}

		private void WaitChainResolveEnd()
		{
		}

		private void WaitTimelineEnd()
		{
		}
	}
}
