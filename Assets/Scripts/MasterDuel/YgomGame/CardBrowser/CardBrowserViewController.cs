using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardBrowser
{
	public class CardBrowserViewController : BaseMenuViewController, IBokeSupported
	{
		private class CardContext
		{
			public readonly int mrk;

			public readonly int styleId;

			public string cardBottomText;

			public CardContext(int mrk, int styleId)
			{
			}
		}

		private class CardDetailWidget
		{
			private readonly string k_ELabelBackButton;

			private readonly string k_ELabelCardNameText;

			private readonly string k_ELabelDescText;

			private readonly string k_ELabelPendulumDescText;

			private readonly string k_ELabelCardNameScroll;

			private readonly string k_ELabelDescScroll;

			private readonly string k_ELabelDescPendulumScroll;

			private readonly string k_ELabelRelativeCardButton;

			private readonly string k_ELabelCardBottomText;

			public readonly ElementObjectManager eom;

			public readonly CardInfoDetail cardInfoDetail;

			public readonly RubyTextGX cardNameText;

			public readonly TextMeshProUGUI descText;

			public readonly TextMeshProUGUI pendulumDescText;

			public readonly ScrollRect nameScrollRect;

			public readonly ScrollRect descScrollRect;

			public readonly ScrollRect pendulumDescScrollRect;

			public readonly TMP_Text cardBottomText;

			public readonly SelectionButton relativeCardButton;

			public int idx;

			public Selector selector => null;

			public GameObject bg => null;

			public GameObject headerArea => null;

			public GameObject backButton => null;

			public CardDetailWidget(CardInfoDetail cardInfoDetail)
			{
			}

			public void ResetScrollPos()
			{
			}
		}

		private const string k_ArgKeyStartIdx = "startIdx";

		private const string k_ArgKeyMrks = "mrks";

		private const string k_ArgKeyStyleIds = "styleIds";

		private const string k_ArgKeyRegulationId = "regulationId";

		private const string k_ArgKeyPrefab = "prefab";

		private const string k_ArgKeyOpenOnContent = "openContent";

		private const string k_ArgKeyOnCreatedViewCallBack = "DownloadCallBack";

		internal const string k_ArgKeySwap = "swap";

		internal const string k_ArgKey_SkipSwapTransition = "SkipSwapTransition";

		internal const string k_ArgRequestCardInfo = "requestCardInfo";

		internal const string k_ArgShowReleasedDate = "showReleasedDate";

		internal const string k_ArgShowRelativeCard = "showRelativeCard";

		private readonly string k_ELabelCloseButton;

		private readonly string k_ELabelPrevButton;

		private readonly string k_ELabelNextButton;

		private readonly string k_ELabelScrollView;

		private List<CardContext> m_CardContexts;

		private int m_RegulationId;

		private SelectionButton m_PrevButton;

		private SelectionButton m_NextButton;

		private bool m_IsReady;

		private bool m_Aborted;

		private bool downloadPrefab;

		private SnapContentManager m_SnapContentManager;

		private Dictionary<GameObject, CardDetailWidget> m_EntityMap;

		private List<CardInfoDetail> m_RentedCardInfoDetails;

		private bool m_Dirty;

		private bool IsValidIdx(int idx)
		{
			return false;
		}

		private bool IsEnablePrev()
		{
			return false;
		}

		private bool IsEnableNext()
		{
			return false;
		}

		public static void OpenDL(int mrk, int styleid = 1, int regulationId = -1, Action action = null)
		{
		}

		public static void Open(int mrk, int styleid = 1, int regulationId = -1, Dictionary<string, object> args = null)
		{
		}

		public static void Open(int idx, IReadOnlyList<int> mrks, IReadOnlyList<int> styleIds = null, int regulationId = -1, Dictionary<string, object> args = null)
		{
		}

		public static void Open(int idx, List<object> mrks, List<object> styleIds = null, int regulationId = -1, Dictionary<string, object> args = null)
		{
		}

		public static void Open2DL(int idx, List<object> mrks, List<object> styleIds = null, int regulationId = -1, Action action = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator InitializeContent(Action onComplete)
		{
			return null;
		}

		private void Start()
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnCreatedEntity(GameObject entity)
		{
		}

		private void OnSetEntity(GameObject entity, int idx)
		{
		}

		private void OnScrollValueChanged(Vector2 normalize)
		{
		}

		private bool ToNextPage()
		{
			return false;
		}

		private bool ToPrevPage()
		{
			return false;
		}

		private void OnClickNext()
		{
		}

		private void OnClickPrev()
		{
		}

		private void OnPageChanged()
		{
		}
	}
}
