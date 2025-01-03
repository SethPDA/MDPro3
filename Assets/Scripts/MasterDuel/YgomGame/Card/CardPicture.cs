using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Card
{
	public class CardPicture : MonoBehaviour
	{
		public CardPictureTop topArea;

		public Transform mainArea;

		public Transform bottomArea;

		private const float MAGICTYPETAGBIAS_GENERIC = -67.48f;

		private const float MAGICTYPETAGBIAS_CH = -50f;

		private const float MAGICTYPETAGBIAS_EN = -76.3f;

		private const int PENDULUMTAGINDEX = 3;

		[SerializeField]
		private RawImage cardframe;

		[SerializeField]
		private RawImage illust_normal;

		[SerializeField]
		private RawImage illust_pendulum;

		[SerializeField]
		private ExtendedTextMeshProUGUI attrRuby;

		[SerializeField]
		private ExtendedTextMeshProUGUI cardText;

		[SerializeField]
		private ExtendedTextMeshProUGUI pdlmText;

		[SerializeField]
		private MDText pdlmScaleL;

		[SerializeField]
		private MDText pdlmScaleR;

		[SerializeField]
		private GameObject nonEffectArea;

		[SerializeField]
		private GameObject atkRoot;

		[SerializeField]
		private GameObject defRoot;

		[SerializeField]
		private MDText atkText;

		[SerializeField]
		private MDText defText;

		[SerializeField]
		private Image linkNum;

		[SerializeField]
		private ExtendedTextMeshProUGUI spelltrapText;

		[SerializeField]
		private Sprite[] AttrSprites;

		[SerializeField]
		private Sprite[] IconSprites;

		[SerializeField]
		private Image AttrIcon;

		[SerializeField]
		private Image SpellTrapIcon;

		[SerializeField]
		private GameObject LinkRoot;

		[SerializeField]
		private GameObject LinkDarkRoot;

		[SerializeField]
		private Image[] LinkIcons;

		[SerializeField]
		private Image Separator;

		private bool materialSetuped;

		private GameObject _cachedGo;

		private int cardId;

		private const string prefabPath = "Prefabs/Duel/CardPicture";

		private const string question = "?";

		private static CardPicture instance;

		public GameObject cachedGameObject => null;

		public static float FontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float FontSize_P
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static CardPicture Create(Transform parent)
		{
			return null;
		}

		public static void CreateAsync(Transform parent, Action<CardPicture> callback, bool bestFit = false)
		{
		}

		private void Initialize()
		{
		}

		public void SetUpCardText(int mrk)
		{
		}

		public void SetupCardAsync(int mrk, UnityAction<bool> onFinished)
		{
		}

		public void SetupText(int mrk, bool maskmode)
		{
		}

		public RawImage GetImage()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void SetFrame(int mrk)
		{
		}

		private void SetupIcon(int cardid, bool maskmode)
		{
		}

		private void SetAttrIcon(int cardid)
		{
		}

		private void SetMagicTypeIcon(int cardid)
		{
		}

		private void SetLinkIcon(int linkmask)
		{
		}

		private void SetUpCardIllustAsync(int mrk, UnityAction onFinished)
		{
		}
	}
}
