using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class CardExpand : UIWidget
    {
        #region Elements

        private const string LABEL_RIMG_CARD = "ImageCard";
        private RawImage m_ImageCard;
        protected RawImage ImageCard =>
            m_ImageCard = m_ImageCard != null ? m_ImageCard
            : Manager.GetElement<RawImage>(LABEL_RIMG_CARD);
        private RectTransform m_CardRect;
        protected RectTransform CardRect =>
            m_CardRect = m_CardRect != null ? m_CardRect
            : Manager.GetElement<RectTransform>(LABEL_RIMG_CARD);

        private const string LABEL_TXT_Shortcut = "TextShortcut";
        private TextMeshProUGUI m_TextShortcut;
        protected TextMeshProUGUI TextShortcut =>
            m_TextShortcut = m_TextShortcut != null ? m_TextShortcut
            : Manager.GetElement<TextMeshProUGUI>(LABEL_TXT_Shortcut);

        #endregion

        private bool expanded;
        private bool isRushDuelCard;
        private bool shifting;
        private int cardCode;

        protected override void Awake()
        {
            ImageCard.GetComponent<Button>()
                .onClick.AddListener(Zoom);
            BG.GetComponent<SelectionButton>()
                .SetClickEvent(Hide);
            TextShortcut.text = InterString.Get("À©´ó");
        }

        private void Update()
        {
            if (shifting) return;
            if (UserInput.WasCancelPressed || UserInput.MouseRightDown)
            {
                if (expanded)
                    ZoomOut();
                else
                    Hide();
            }
            if (UserInput.WasLeftTriggerPressed)
                Zoom();
        }

        private void OnDestroy()
        {
            TextureLoader.DeleteCard(cardCode);
            DestroyImmediate(ImageCard.material);
        }

        public void Show(int code)
        {
            cardCode = code;
            AudioManager.PlaySE("SE_CARDEXPAND_DISPLAY");
            BG.alpha = 0.3f;
            BG.DOFade(1f, 0.1f);
            shifting = true;

            ImageCard.color = new Color(1f, 1f, 1f, 0.3f);
            ImageCard.DOFade(1f, 0.1f);
            ImageCard.transform.localScale = new Vector3 (1.3f, 1.3f, 1f);
            ImageCard.transform.DOScale(new Vector3(1.5f, 1.5f, 1f), 0.25f).SetEase(Ease.OutQuart);
            ImageCard.transform.localEulerAngles = new Vector3 (8f, 12f, 2f);
            ImageCard.transform.DOLocalRotate(Vector3.zero, 0.35f).SetEase(Ease.OutQuart)
                .OnComplete(() => { shifting = false; });
            EventSystem.current.SetSelectedGameObject(ImageCard.gameObject);

            StartCoroutine(TextureLoader.LoadCardToRawImage(code, ImageCard));

            isRushDuelCard = CardRenderer.NeedRushDuelStyle(code);
        }

        private void Hide()
        {
            if (shifting) return;
            shifting = true;
            AudioManager.PlaySE("SE_CARDEXPAND_CLOSE");

            BG.DOFade(0f, 0.21f).OnComplete(() =>
            {
                Destroy(gameObject);
                Program.instance.currentServant.SelectLastSelectable();
            });

            DOTween.Sequence()
                .AppendInterval(0.05f)
                .Append(ImageCard.DOFade(0f, 0.15f));
            ImageCard.transform.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.2f).SetEase(Ease.InCubic);
            ImageCard.transform.DOLocalRotate(new Vector3(-10f, -16f, -3f), 0.2f).SetEase(Ease.InCubic);
        }

        private void Zoom()
        {
            if (expanded)
                ZoomOut();
            else
                ZoomIn();
        }

        private void ZoomIn()
        {
            if (shifting) return;
            shifting = true;
            AudioManager.PlaySE("SE_CARDEXPAND_ZOOMIN");
            expanded = true;

            CardRect.DOScale(new Vector3(2.82f, 2.82f, 1f), 0.2f).SetEase(Ease.OutCubic);
            CardRect.DOLocalMove(new Vector3(0f, isRushDuelCard ? -224f : -103f, -100f), 0.2f).SetEase(Ease.OutCubic);
            CardRect.DORotate(new Vector3(4f, 6f, 1f), 0.15f).OnComplete(() =>
            {
                CardRect.DORotate(Vector3.zero, 0.2f).OnComplete(() => shifting = false);
            });

            TextShortcut.text = InterString.Get("ËõÐ¡");
        }

        private void ZoomOut()
        {
            if (shifting) return;
            shifting = true;
            AudioManager.PlaySE("SE_CARDEXPAND_ZOOMOUT");
            expanded = false;

            CardRect.DOScale(new Vector3(1.5f, 1.5f, 1f), 0.2f).SetEase(Ease.OutCubic);
            CardRect.DOLocalMove(new Vector3(0f, 0f, -100f), 0.2f).SetEase(Ease.OutCubic);
            CardRect.DORotate(new Vector3(-4f, -6f, -1f), 0.15f).OnComplete(() =>
            {
                CardRect.DORotate(Vector3.zero, 0.2f).OnComplete(() => shifting = false);
            });

            TextShortcut.text = InterString.Get("À©´ó");
        }
    }
}
