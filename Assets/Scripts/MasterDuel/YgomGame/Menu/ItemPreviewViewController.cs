using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Bg;
using YgomGame.Duel;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class ItemPreviewViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		private enum RootIconType
		{
			None = 0,
			S = 1,
			M = 2,
			L = 3,
			LL = 4,
			Protector = 5
		}

		private struct CameraSettings
		{
			public float xMax;

			public float xMin;

			public float yMax;

			public float yMin;

			public float fov;

			public float nearClip;

			public float farClip;

			//public CameraSettings(float xMax_, float xMin_, float yMax_, float yMin_, float fov_, float nearClip_, float farClip_)
			//{
			//}
		}

		private readonly string MATE_TRANSFORM_SETTING_PATH;

		private readonly string ROOT_ICON_S_LABEL;

		private readonly string ROOT_ICON_M_LABEL;

		private readonly string ROOT_ICON_L_LABEL;

		private readonly string ROOT_ICON_LL_LABEL;

		private readonly string ROOT_ICON_PROTECTOR_LABEL;

		private readonly string ROOT_ICON_EFFECT_LABEL;

		private readonly string ROOT_MATE_LABEL;

		private readonly string ROOT_FIELD_LABEL;

		private readonly string ROOT_TAG_LABEL;

		private readonly string ROOT_TAG_IMAGE_LABEL;

		private readonly string ROOT_WALLPAPER_LABEL;

		private readonly string TEXT_ITEM_NUM_LABEL;

		private readonly string TEXT_ITEM_NAME_LABEL;

		private readonly string TEXT_ITEM_CATEGORY_LABEL;

		private readonly string TEXT_ITEM_DESC_LABEL;

		private readonly string TMP_TAG_LABEL;

		private readonly string TXT_TAG_LABEL;

		private readonly string BTN_LABEL;

		public const string k_ArgKeyIsPeriod = "isPeriod";

		public const string k_ArgKeyItemId = "itemId";

		public const string k_ArgKeyItemCategory = "itemCategory";

		public const string k_ArgKeyItemNum = "itemNum";

		public const string k_ArgKeyFieldIds = "fieldIds";

		public const string k_ArgKeyOpenAsDialog = "openAsDialog";

		public const string k_ArgKeyField = "field";

		public const string k_ArgKeyFieldOpposite = "fieldOpposite";

		public const string k_ArgKeyAvatarBase = "avatarBase";

		public const string k_ArgKeyAvatarBaseOpposite = "avatarBaseOpposite";

		public const string k_ArgKeyFieldObj = "fieldObj";

		public const string k_ArgKeyFieldObjOpposite = "fieldObjOpposite";

		public const string k_ArgKeyAvatar = "avatar";

		public const string k_ArgKeyAvatarOpposite = "avatarOpposite";

		private readonly string k_ELabelRoot3D;

		private readonly string k_ELabelFieldLocator;

		private readonly string k_ELabelScreenTouchButton;

		private readonly string k_ELabelBadgeLocator;

		private bool m_IsPeriod;

		private int m_ItemId;

		private int m_ItemCategory;

		private Dictionary<string, object> m_FieldArgs;

		private int m_ItemNum;

		private TextMeshProUGUI m_ItemNumText;

		private TextMeshProUGUI m_ItemNameText;

		private TextMeshProUGUI m_ItemDescText;

		private TextMeshProUGUI m_ItemCategoryText;

		private SelectionButton m_CancelButton;

		private Character2D chara;

		private ItemPreview2D itemPreview;

		private Transform m_RootField;

		private Transform m_Root3D;

		private BgPreview m_BgActor;

		private Vector2 m_DragStartVec;

		private GameObject currentWallpaperGo;

		private GameObject m_BadgeLocator;

		private CameraSettings fieldCameraSettings;

		private CameraSettings fieldPartsCameraSettings;

		private CameraSettings avatarBaseCameraSettings;

		private float x_AxisMax;

		private float x_AxisMin;

		private float y_AxisMax;

		private float y_AxisMin;

		private const float m_MoveAmountDirectionalKey = 5f;

		private const float m_MoveAmountAnalogKey = 5f;

		private float m_MoveAmountTouch;

		private const float m_MoveAmountTouchField = 20f;

		private const float m_MoveAmountTouchParts = 20f;

		private bool isInitialized;

		private bool m_ItemEffectVisible;

		private RootIconType m_ItemIconType;

		protected override Type[] textIds => null;

		private void ApplaySettings(Camera camera, CameraSettings cameraSettings)
		{
		}

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void InitMateController()
		{
		}

		private void InitCameraController()
		{
		}

		private void BindItem()
		{
		}

		private void BindItemIconRoot(GameObject itemIconRoot, bool visible, bool isPeriod, int itemCategory, int itemId)
		{
		}

		private void BindTag()
		{
		}

		private void InitMateSettings()
		{
		}

		private void PlayMateMotion()
		{
		}

		private void BindField(Dictionary<string, object> fieldArgs)
		{
		}

		private void CreateField(Dictionary<string, object> fieldArgs)
		{
		}

		private void CreateFieldParts()
		{
		}

		private void LodPrefab(string prefPath, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imageW = -1f, float imageH = -1f)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public override bool OnBack()
		{
			return false;
		}

		private IEnumerator WallPaperBack()
		{
			return null;
		}

		private void MoveCamera(Vector3 movePos)
		{
		}

		private void OnDrag(SelectionItem.DragStatus dragStatus, Vector2 vec)
		{
		}

		private void OnInputKeyUp()
		{
		}

		private void OnInputKeyDown()
		{
		}

		private void OnInputKeyLeft()
		{
		}

		private void OnInputKeyRight()
		{
		}

		private void OnInputAnalogKey(Vector2 input)
		{
		}
	}
}
