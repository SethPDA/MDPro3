using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using YgomSystem.ElementSystem;
using DG.Tweening;

namespace MDPro3.UI
{
    public class UIWidgetCardBase : UIWidget
    {
        #region Elements

        #region TitleArea
        private const string LABEL_MS_PLATETITLE = "TitleArea/PlateTitle";
        private MaterialSetter m_PlateTitle;
        protected MaterialSetter PlateTitle =>
            m_PlateTitle = m_PlateTitle != null ? m_PlateTitle
            : Manager.GetNestedElement<MaterialSetter>(LABEL_MS_PLATETITLE);

        private const string LABEL_TXT_CARDNAME = "TitleArea/TextCardName";
        private TextMeshProUGUI m_TextCardName;
        protected TextMeshProUGUI TextCardName =>
            m_TextCardName = m_TextCardName != null ? m_TextCardName
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_CARDNAME);

        private const string LABEL_IMG_ATTRIBUTE = "TitleArea/IconAttribute";
        private Image m_IconAttribute;
        protected Image IconAttribute =>
            m_IconAttribute = m_IconAttribute != null ? m_IconAttribute
            : Manager.GetNestedElement<Image>(LABEL_IMG_ATTRIBUTE);
        #endregion

        #region ParameterArea
        private const string LABEL_IMG_LEVEL = "ParameterArea/IconLevel";
        private Image m_IconLevel;
        protected Image IconLevel =>
            m_IconLevel = m_IconLevel != null ? m_IconLevel
            : Manager.GetNestedElement<Image>(LABEL_IMG_LEVEL);

        private const string LABEL_TXT_LEVEL = "ParameterArea/IconLevel/Text";
        private TextMeshProUGUI m_TextLevel;
        protected TextMeshProUGUI TextLevel =>
            m_TextLevel = m_TextLevel != null ? m_TextLevel
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_LEVEL);

        private const string LABEL_IMG_RANK = "ParameterArea/IconRank";
        private Image m_IconRank;
        protected Image IconRank =>
            m_IconRank = m_IconRank != null ? m_IconRank
            : Manager.GetNestedElement<Image>(LABEL_IMG_RANK);

        private const string LABEL_TXT_RANK = "ParameterArea/IconRank/Text";
        private TextMeshProUGUI m_TextRank;
        protected TextMeshProUGUI TextRank =>
            m_TextRank = m_TextRank != null ? m_TextRank
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_RANK);

        private const string LABEL_IMG_PENDULUMSCALE = "ParameterArea/IconPendulumScale";
        private Image m_IconPendulumScale;
        protected Image IconPendulumScale =>
            m_IconPendulumScale = m_IconPendulumScale != null ? m_IconPendulumScale
            : Manager.GetNestedElement<Image>(LABEL_IMG_PENDULUMSCALE);

        private const string LABEL_TXT_PENDULUMSCALE = "ParameterArea/IconPendulumScale/Text";
        private TextMeshProUGUI m_TextPendulumScale;
        protected TextMeshProUGUI TextPendulumScale =>
            m_TextPendulumScale = m_TextPendulumScale != null ? m_TextPendulumScale
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_PENDULUMSCALE);

        private const string LABEL_IMG_LINK = "ParameterArea/IconLink";
        private Image m_IconLink;
        protected Image IconLink =>
            m_IconLink = m_IconLink != null ? m_IconLink
            : Manager.GetNestedElement<Image>(LABEL_IMG_LINK);

        private const string LABEL_TXT_LINK = "ParameterArea/IconLink/Text";
        private TextMeshProUGUI m_TextLink;
        protected TextMeshProUGUI TextLink =>
            m_TextLink = m_TextLink != null ? m_TextLink
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_LINK);

        private const string LABEL_IMG_RACE = "ParameterArea/IconRace";
        private Image m_IconRace;
        protected Image IconRace =>
            m_IconRace = m_IconRace != null ? m_IconRace
            : Manager.GetNestedElement<Image>(LABEL_IMG_RACE);

        private const string LABEL_IMG_TUNER = "ParameterArea/IconTuner";
        private Image m_IconTuner;
        protected Image IconTuner =>
            m_IconTuner = m_IconTuner != null ? m_IconTuner
            : Manager.GetNestedElement<Image>(LABEL_IMG_TUNER);

        private const string LABEL_GO_SPELLTRAPTYPE = "ParameterArea/SpellTrapType";
        private GameObject m_SpellTrapType;
        protected GameObject SpellTrapType =>
            m_SpellTrapType = m_SpellTrapType != null ? m_SpellTrapType
            : Manager.GetNestedElement(LABEL_GO_SPELLTRAPTYPE);

        private const string LABEL_IMG_SPELLTRAPTYPE = "ParameterArea/IconSpellTrapType";
        private Image m_IconSpellTrapType;
        protected Image IconSpellTrapType =>
            m_IconSpellTrapType = m_IconSpellTrapType != null ? m_IconSpellTrapType
            : Manager.GetNestedElement<Image>(LABEL_IMG_SPELLTRAPTYPE);

        private const string LABEL_TXT_SPELLTRAPTYPE = "ParameterArea/TextSpellTrapType";
        private TextMeshProUGUI m_TextSpellTrapType;
        protected TextMeshProUGUI TextSpellTrapType =>
            m_TextSpellTrapType = m_TextSpellTrapType != null ? m_TextSpellTrapType
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_SPELLTRAPTYPE);

        private const string LABEL_IMG_ATK = "ParameterArea/IconAtk";
        private Image m_IconAtk;
        protected Image IconAtk =>
            m_IconAtk = m_IconAtk != null ? m_IconAtk
            : Manager.GetNestedElement<Image>(LABEL_IMG_ATK);

        private const string LABEL_TXT_ATK = "ParameterArea/IconAtk/Text";
        private TextMeshProUGUI m_TextAtk;
        protected TextMeshProUGUI TextAtk =>
            m_TextAtk = m_TextAtk != null ? m_TextAtk
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_ATK);

        private const string LABEL_IMG_DEF = "ParameterArea/IconDef";
        private Image m_IconDef;
        protected Image IconDef =>
            m_IconDef = m_IconDef != null ? m_IconDef
            : Manager.GetNestedElement<Image>(LABEL_IMG_DEF);

        private const string LABEL_TXT_DEF = "ParameterArea/IconDef/Text";
        private TextMeshProUGUI m_TextDef;
        protected TextMeshProUGUI TextDef =>
            m_TextDef = m_TextDef != null ? m_TextDef
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_DEF);
        #endregion

        #region DescriptionArea

        private const string LABEL_GO_PENDULUMDESCRIPTIONAREA = "DescriptionArea/PendulumDescriptionArea";
        private GameObject m_PendulumDescriptionArea;
        protected GameObject PendulumDescriptionArea =>
            m_PendulumDescriptionArea = m_PendulumDescriptionArea != null ? m_PendulumDescriptionArea
            : Manager.GetNestedElement(LABEL_GO_PENDULUMDESCRIPTIONAREA);

        private const string LABEL_MS_PLATEPENDULUMDESCRIPTION = "DescriptionArea/PlatePendulumDescription";
        private MaterialSetter m_PlatePendulumDescription;
        protected MaterialSetter PlatePendulumDescription =>
            m_PlatePendulumDescription = m_PlatePendulumDescription != null ? m_PlatePendulumDescription
            : Manager.GetNestedElement<MaterialSetter>(LABEL_MS_PLATEPENDULUMDESCRIPTION);

        private const string LABEL_SR_PENDULUMAREA = "DescriptionArea/TextAreaPendulum";
        private ScrollRect m_TextAreaPendulum;
        protected ScrollRect TextAreaPendulum =>
            m_TextAreaPendulum = m_TextAreaPendulum != null ? m_TextAreaPendulum
            : Manager.GetNestedElement<ScrollRect>(LABEL_SR_PENDULUMAREA);

        private const string LABEL_TXT_PENDULUMDESCRIPTIONVALUE = "DescriptionArea/TextPendulumDescriptionValue";
        private TextMeshProUGUI m_TextPendulumDescriptionValue;
        protected TextMeshProUGUI TextPendulumDescriptionValue =>
            m_TextPendulumDescriptionValue = m_TextPendulumDescriptionValue != null ? m_TextPendulumDescriptionValue
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_PENDULUMDESCRIPTIONVALUE);

        private const string LABEL_MS_PLATEDESCRIPTION = "DescriptionArea/PlateDescription";
        private MaterialSetter m_PlateDescription;
        protected MaterialSetter PlateDescription =>
            m_PlateDescription = m_PlateDescription != null ? m_PlateDescription
            : Manager.GetNestedElement<MaterialSetter>(LABEL_MS_PLATEDESCRIPTION);

        private const string LABEL_TXT_DESCRIPTIONITEM = "DescriptionArea/TextDescriptionItem";
        private TextMeshProUGUI m_TextDescriptionItem;
        protected TextMeshProUGUI TextDescriptionItem =>
            m_TextDescriptionItem = m_TextDescriptionItem != null ? m_TextDescriptionItem
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_DESCRIPTIONITEM);

        private const string LABEL_SR_AREA = "DescriptionArea/TextArea";
        private ScrollRect m_TextArea;
        protected ScrollRect TextArea =>
            m_TextArea = m_TextArea != null ? m_TextArea
            : Manager.GetNestedElement<ScrollRect>(LABEL_SR_AREA);

        private const string LABEL_TXT_DESCRIPTIONVALUE = "DescriptionArea/TextDescriptionValue";
        private TextMeshProUGUI m_TextDescriptionValue;
        protected TextMeshProUGUI TextDescriptionValue =>
            m_TextDescriptionValue = m_TextDescriptionValue != null ? m_TextDescriptionValue
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_DESCRIPTIONVALUE);

        #endregion

        #region CardArea

        private const string LABEL_RIMG_CARD = "CardArea/ImageCard";
        private RawImage m_ImageCard;
        protected RawImage ImageCard =>
            m_ImageCard = m_ImageCard != null ? m_ImageCard
            : Manager.GetNestedElement<RawImage>(LABEL_RIMG_CARD);

        private const string LABEL_IMG_LIMIT = "CardArea/IconLimit";
        private Image m_IconLimit;
        protected Image IconLimit =>
            m_IconLimit = m_IconLimit != null ? m_IconLimit
            : Manager.GetNestedElement<Image>(LABEL_IMG_LIMIT);

        private const string LABEL_TXT_CARDNUMVALUE = "CardArea/TextCardNumValue";
        private TextMeshProUGUI m_TextCardNumValue;
        protected TextMeshProUGUI TextCardNumValue =>
            m_TextCardNumValue = m_TextCardNumValue != null ? m_TextCardNumValue
            : Manager.GetNestedElement<TextMeshProUGUI>(LABEL_TXT_CARDNUMVALUE);

        private const string LABEL_GO_POOLAREA = "CardArea/PoolArea";
        private GameObject m_PoolArea;
        protected GameObject PoolArea =>
            m_PoolArea = m_PoolArea != null ? m_PoolArea
            : Manager.GetNestedElement(LABEL_GO_POOLAREA);

        private const string LABEL_IMG_ICONOCG = "CardArea/IconOCG";
        private Image m_IconOCG;
        protected Image IconOCG =>
            m_IconOCG = m_IconOCG != null ? m_IconOCG
            : Manager.GetNestedElement<Image>(LABEL_IMG_ICONOCG);

        private const string LABEL_IMG_ICONTCG = "CardArea/IconTCG";
        private Image m_IconTCG;
        protected Image IconTCG =>
            m_IconTCG = m_IconTCG != null ? m_IconTCG
            : Manager.GetNestedElement<Image>(LABEL_IMG_ICONTCG);

        private const string LABEL_IMG_ICONSCCG = "CardArea/IconSCCG";
        private Image m_IconSCCG;
        protected Image IconSCCG =>
            m_IconSCCG = m_IconSCCG != null ? m_IconSCCG
            : Manager.GetNestedElement<Image>(LABEL_IMG_ICONSCCG);

        private const string LABEL_IMG_ICONDIY = "CardArea/IconDIY";
        private Image m_IconDIY;
        protected Image IconDIY =>
            m_IconDIY = m_IconDIY != null ? m_IconDIY
            : Manager.GetNestedElement<Image>(LABEL_IMG_ICONDIY);

        private const string LABEL_IMG_ICONPRE = "CardArea/IconPRE";
        private Image m_IconPRE;
        protected Image IconPRE =>
            m_IconPRE = m_IconPRE != null ? m_IconPRE
            : Manager.GetNestedElement<Image>(LABEL_IMG_ICONPRE);

        #endregion

        #region MenuArea

        private const string LABEL_GO_MENUAREA = "MenuArea";
        private GameObject m_MenuArea;
        protected GameObject MenuArea =>
            m_MenuArea = m_MenuArea != null ? m_MenuArea
            : Manager.GetElement(LABEL_GO_MENUAREA);

        private const string LABEL_STG_BOOKMARK = "MenuArea/BookmarkToggleButton";
        private SelectionToggle m_ToggleBookMark;
        protected SelectionToggle ToggleBookMark =>
            m_ToggleBookMark = m_ToggleBookMark != null ? m_ToggleBookMark
            : Manager.GetNestedElement<SelectionToggle>(LABEL_STG_BOOKMARK);

        private const string LABEL_SBN_RELATEDCARD = "MenuArea/RelatedCardButton";
        private SelectionButton m_ButtonRelatedCard;
        protected SelectionButton ButtonRelatedCard =>
            m_ButtonRelatedCard = m_ButtonRelatedCard != null ? m_ButtonRelatedCard
            : Manager.GetNestedElement<SelectionButton>(LABEL_SBN_RELATEDCARD);

        private const string LABEL_SBN_ADDCARD = "MenuArea/AddCardButton";
        private SelectionButton m_ButtonAddCard;
        public SelectionButton ButtonAddCard =>
            m_ButtonAddCard = m_ButtonAddCard != null ? m_ButtonAddCard
            : Manager.GetNestedElement<SelectionButton>(LABEL_SBN_ADDCARD);

        private const string LABEL_SBN_REMOVECARD = "MenuArea/RemoveCardButton";
        private SelectionButton m_ButtonRemoveCard;
        public SelectionButton ButtonRemoveCard =>
            m_ButtonRemoveCard = m_ButtonRemoveCard != null ? m_ButtonRemoveCard
            : Manager.GetNestedElement<SelectionButton>(LABEL_SBN_REMOVECARD);

        private const string LABEL_STG_RARITYR = "MenuArea/ToggleRarityR";
        private SelectionToggle_Rarity m_ToggleRarityR;
        protected SelectionToggle_Rarity ToggleRarityR =>
            m_ToggleRarityR = m_ToggleRarityR != null ? m_ToggleRarityR
            : Manager.GetNestedElement<SelectionToggle_Rarity>(LABEL_STG_RARITYR);

        private const string LABEL_STG_RARITYUR = "MenuArea/ToggleRarityUR";
        private SelectionToggle_Rarity m_ToggleRarityUR;
        protected SelectionToggle_Rarity ToggleRarityUR =>
            m_ToggleRarityUR = m_ToggleRarityUR != null ? m_ToggleRarityUR
            : Manager.GetNestedElement<SelectionToggle_Rarity>(LABEL_STG_RARITYUR);

        private const string LABEL_STG_RARITYGR = "MenuArea/ToggleRarityGR";
        private SelectionToggle_Rarity m_ToggleRarityGR;
        protected SelectionToggle_Rarity ToggleRarityGR =>
            m_ToggleRarityGR = m_ToggleRarityGR != null ? m_ToggleRarityGR
            : Manager.GetNestedElement<SelectionToggle_Rarity>(LABEL_STG_RARITYGR);

        private const string LABEL_STG_RARITYMR = "MenuArea/ToggleRarityMR";
        private SelectionToggle_Rarity m_ToggleRarityMR;
        protected SelectionToggle_Rarity ToggleRarityMR =>
            m_ToggleRarityMR = m_ToggleRarityMR != null ? m_ToggleRarityMR
            : Manager.GetNestedElement<SelectionToggle_Rarity>(LABEL_STG_RARITYMR);

        #endregion

        #endregion

        private Card _card;
        public Card Card
        {
            get { return _card; }
            set
            {
                if (_card != null)
                    TextureLoader.DeleteCard(_card.Id);
                _card = value;
                StartCoroutine(SetCardTextureAsync());
            }
        }
        protected Material normalMat;
        protected Material tempMaterial;
        protected bool pendulumTextNeedSplit = true;

        protected override void Awake()
        {
            base.Awake();

            if (MenuArea != null)
            {
                ToggleBookMark.SetToggleOnEvent(() =>
                {
                    Program.instance.deckEditor.BookmarkCard(Card.Id);
                });
                ToggleBookMark.SetToggleOffEvent(() =>
                {
                    Program.instance.deckEditor.UnbookmarkCard(Card.Id);
                });

                ButtonAddCard.SetClickEvent(() =>
                {
                    Program.instance.deckEditor.AddCard(Card);
                });
                ButtonRemoveCard.SetClickEvent(() =>
                {
                    Program.instance.deckEditor.RemoveCard(Card);
                });
            }
        }

        protected virtual void OnDestroy()
        {
            if (Card != null)
                TextureLoader.DeleteCard(Card.Id);
            DestroyImmediate(normalMat);
            DestroyImmediate(tempMaterial);
        }

        protected virtual void SetCardData(Card data)
        {
            if (Card != null && Card.Id == data.Id)
                return;
            Card = data;

            #region Title Area

            TextCardName.text = " " + data.Name;
            PlateTitle.SetMaterialAction((matetial) =>
                {
                    var colors = CardDescription.GetCardFrameColor(data);
                    matetial.SetColor("_Color0", colors[0]);
                    matetial.SetColor("_Color1", colors[1]);
                });
            IconAttribute.sprite = TextureManager.container.GetCardAttributeIcon(data);

            #endregion

            #region Card Area

            IconLimit.sprite = TextureManager.container
                .GetCardRegulationIcon(data.Id, Program.instance.editDeck.banlist);

            SetCardCount();

            if (PoolArea != null)
            {
                IconOCG.gameObject.SetActive((data.Ot & 1) > 0);
                IconTCG.gameObject.SetActive((data.Ot & 2) > 0);
                IconSCCG.gameObject.SetActive((data.Ot & 8) > 0);
                IconDIY.gameObject.SetActive((data.Ot & 4) > 0);
                IconPRE.gameObject.SetActive(data.isPre);
            }

            #endregion

            #region Parameter Area

            var levelType = data.GetLevelType();

            IconLevel.gameObject.SetActive(data.HasType(CardType.Monster) && levelType == Card.LevelType.Level);
            TextLevel.text = data.Level.ToString();

            IconRank.gameObject.SetActive(levelType == Card.LevelType.Rank);
            TextRank.text = data.Level.ToString();

            IconLink.gameObject.SetActive(levelType == Card.LevelType.Link);
            TextLink.text = data.GetLinkCount().ToString();

            IconPendulumScale.gameObject.SetActive(data.HasType(CardType.Pendulum));
            TextPendulumScale.text = data.LScale.ToString();

            var raceIcon = TextureManager.container.GetCardRaceIcon(data);
            IconRace.gameObject.SetActive(raceIcon != null);
            IconRace.sprite = raceIcon;

            IconTuner.gameObject.SetActive(data.HasType(CardType.Tuner));

            if (data.HasType(CardType.Spell) || data.HasType(CardType.Trap))
            {
                SpellTrapType.SetActive(true);
                IconSpellTrapType.sprite = TextureManager.container.GetCardSpellTrapTypeIcon(data);
                TextSpellTrapType.text
                    = StringHelper.SecondType(data.Type) + StringHelper.MainType(data.Type);

                IconAtk.gameObject.SetActive(false);
                IconDef.gameObject.SetActive(false);
            }
            else
            {
                SpellTrapType.SetActive(false);

                IconAtk.gameObject.SetActive(true);
                TextAtk.text = data.GetAttackString();

                IconDef.gameObject.SetActive(levelType != Card.LevelType.Link);
                TextDef.text = data.GetDefenseString();
            }

            #endregion

            #region Description Area

            PlateDescription.SetMaterialAction((matetial) =>
                {
                    var colors = CardDescription.GetCardFrameColor(data);
                    matetial.SetColor("_Color0", colors[0]);
                    matetial.SetColor("_Color1", colors[1]);
                });
            TextDescriptionItem.text = StringHelper.GetType(data);

            TextDescriptionValue.text = pendulumTextNeedSplit
                ? data.GetMonsterDescription() : data.GetDescription(true);

            if (pendulumTextNeedSplit)
            {
                if (data.HasType(CardType.Pendulum))
                {
                    PendulumDescriptionArea.SetActive(true);
                    PlatePendulumDescription.SetMaterialAction((matetial) =>
                    {
                        var colors = CardDescription.GetCardFrameColor(data);
                        matetial.SetColor("_Color0", colors[0]);
                        matetial.SetColor("_Color1", colors[1]);
                    });
                    TextPendulumDescriptionValue.text
                        = data.GetPendulumDescription();
                }
                else
                    PendulumDescriptionArea.SetActive(false);
            }

            #endregion

            #region MenuArea

            if (MenuArea != null)
            {
                var rarity = CardRarity.GetRarity(data.Id);
                if (ToggleRarityR.rarity == rarity)
                    ToggleRarityR.SetToggleOn(false);
                else
                    ToggleRarityR.SetToggleOff(false);

                if (ToggleRarityUR.rarity == rarity)
                    ToggleRarityUR.SetToggleOn(false);
                else
                    ToggleRarityUR.SetToggleOff(false);

                if (ToggleRarityGR.rarity == rarity)
                    ToggleRarityGR.SetToggleOn(false);
                else
                    ToggleRarityGR.SetToggleOff(false);

                if (ToggleRarityMR.rarity == rarity)
                    ToggleRarityMR.SetToggleOn(false);
                else
                    ToggleRarityMR.SetToggleOff(false);

                RefreshBookmarkToggle();
            }

            #endregion
        }

        protected virtual IEnumerator SetCardTextureAsync()
        {
            if (normalMat == null)
                normalMat = TextureManager.GetCardMaterial(-1);
            normalMat.SetTexture("_LoadingTex", TextureManager.container
                .GetCardUnloadTexture(CardsManager.Get(Card.Id)));
            normalMat.SetFloat("_LoadingBlend", 1f);

            if (tempMaterial != null)
                DestroyImmediate(tempMaterial);
            ImageCard.material = normalMat;

            var task = TextureLoader.LoadCardAsync(Card.Id, true);
            while (!task.IsCompleted)
                yield return null;

            ImageCard.texture = task.Result;
            if(CardRarity.GetRarity(Card.Id) == CardRarity.Rarity.Normal)
                normalMat.DOFloat(0f, "_LoadingBlend", 0.1f);
            else
            {
                tempMaterial = TextureManager.GetCardMaterial(Card.Id, false);
                tempMaterial.SetFloat("_LoadingBlend", 1f);
                tempMaterial.SetTexture("_LoadingTex"
                    , normalMat.GetTexture("_LoadingTex"));
                tempMaterial.DOFloat(0f, "_LoadingBlend", 0.1f);
                ImageCard.material = tempMaterial;
            }
        }

        public virtual void SetCardCount(string cardCount)
        {
            TextCardNumValue.text = cardCount;
        }

        public virtual void SetCardCount()
        {
            if (Card == null)
                return;
            TextCardNumValue.text = Program.instance.deckEditor.deckView.GetCardCount(Card.Id).ToString();
        }

        public virtual void RefreshRarity(int code, CardRarity.Rarity rarity)
        {
            if (Card == null || Card.Id != code)
                return;

            if (tempMaterial != null)
                DestroyImmediate(tempMaterial);

            if (rarity == CardRarity.Rarity.Normal)
            {
                normalMat.SetFloat("_LoadingBlend", 0f);
                ImageCard.material = normalMat;
            }
            else
            {
                tempMaterial = TextureManager.GetCardMaterial(code);
                ImageCard.material = tempMaterial;
            }
        }

        public virtual void RefreshBookmarkToggle()
        {
            if(CardRarity.CardBookmarked(Card.Id))
                ToggleBookMark.SetToggleOn(false);
            else
                ToggleBookMark.SetToggleOff(false);
        }
    }
}
