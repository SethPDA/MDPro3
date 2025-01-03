using System;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class ResourceBindingPathSetting : ScriptableObject
	{
		[Serializable]
		public class ItemPathData
		{
			public bool divideResourceType;

			public string SD;

			public string SD_L;

			[SerializeField]
			public string HighEndHD;

			[SerializeField]
			public string HighEndHD_L;

			public string GetPath(bool isLarge)
			{
				return null;
			}
		}

		public class EnabledIfAttribute : PropertyAttribute
		{
			public string switcherFieldName;

			public bool enable;

			public EnabledIfAttribute(string switcherFieldName, bool enable)
			{
			}
		}

		internal const string k_SettingPath = "Definition/UISystem/ResourceBindingPathSetting";

		internal const string k_RarityIcon_RaritySpriteContainerPath = "Images/Card/RaritySpriteContainer";

		internal const string k_CraftIcon_CP0Path = "Images/Menu/GUI_alpha_Icon_CP0";

		internal const string k_CraftIcon_CP1Path = "Images/Menu/GUI_alpha_Icon_CP1";

		internal const string k_CraftIcon_CP2Path = "Images/Menu/GUI_alpha_Icon_CP2";

		internal const string k_CraftIcon_CP3Path = "Images/Menu/GUI_alpha_Icon_CP3";

		internal const string k_RegulationSpriteContainerPath = "Images/Card/RegulationSpriteContainer";

		internal const string k_Shop_CardThumbSettingPath = "Definition/Shop/CardThumbSettings";

		internal const string k_Shop_HighlightThumbImagePath = "Images/Shop/HighlightThumbs/{0}";

		internal const string k_Shop_HighlightThumbPrefPath = "Prefabs/Shop/HighlightThumbs/{0}";

		internal const string k_OutGameBG_FrontBGPath = "Prefabs/OutGameBg/Front/Front{0:D4}";

		internal const string k_OutGameBG_BackBGPath = "Prefabs/OutGameBg/Back/Back{0:D4}";

		internal const string k_Solo_CardThumbSettingPath = "Definition/Solo/SoloCardThumbSettings";

		internal const string k_CardPack_PackTicketPath = "Images/PackTicket/<_RESOURCE_TYPE_>/PackTicket";

		internal const string k_CardPack_PackTexPath = "Images/CardPack/<_RESOURCE_TYPE_>/<_CARD_ILLUST_>/{0}";

		[SerializeField]
		private ConsumeItemBinder.ConsumeItemPathData m_ConsumeItemPathData;

		[SerializeField]
		private DeckResourceBinder.DeckPathData m_DeckPathData;

		[SerializeField]
		private PlayerIconResourceBinder.PlayerIconPathData m_PlayerIconPathData;

		[SerializeField]
		private FieldResourceBinder.FieldPathData m_FieldPathData;

		[SerializeField]
		private EventLogoResourceBinder.EventLogoPathData m_EventLogoPathData;

		[SerializeField]
		private RegulationLogoResourceBinder.RegulationLogoPathData m_RegulationLogoPathData;

		[SerializeField]
		private AvatarResourceBinder.AvatarResourcePathData m_AvatarResourcePathData;

		[SerializeField]
		private WallPaperResourceBinder.WallPaperResourcePathData m_WallPaperResourcePathData;

		[SerializeField]
		private ProfileResourceBinder.ProfileResource m_ProfileResource;

		public ConsumeItemBinder.ConsumeItemPathData consumeItemPathData => null;

		public DeckResourceBinder.DeckPathData deckPathData => null;

		public PlayerIconResourceBinder.PlayerIconPathData playerIconPathData => null;

		public FieldResourceBinder.FieldPathData fieldPathData => null;

		public EventLogoResourceBinder.EventLogoPathData eventLogoPathData => null;

		public RegulationLogoResourceBinder.RegulationLogoPathData regulationLogoPathData => null;

		public AvatarResourceBinder.AvatarResourcePathData avatarResourcePathData => null;

		public WallPaperResourceBinder.WallPaperResourcePathData wallPaperResourcePathData => null;

		public ProfileResourceBinder.ProfileResource profileResourcePathData => null;
	}
}
