using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class StructureDeckSelectViewController : BaseMenuViewController
	{
		[Serializable]
		public class DeckCaseImageData
		{
			public int _caseIconNumber;

			public Sprite _deckSprite;

			public Sprite _openedDeckSprite;

			public Sprite[] _monsterSprites;
		}

		protected const string k_ArgKeyStructureDeckIds = "sdid";

		private const string k_ArgKeyBeforeNextViewEvent = "BeforeNextViewEvent";

		protected readonly string k_ELabelTitleText;

		private readonly string k_ELabelDeckTemplate;

		private const string TWEEN_SELECT_LABEL = "select";

		private const string TWEEN_DESELECT_LABEL = "deselect";

		private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

		[SerializeField]
		private ElementObjectManager m_PrefabUI;

		protected ElementObjectManager m_UI;

		private ElementObjectManager m_DeckTemplate;

		private int[] m_StructureDeckIds;

		private SelectionItem[] m_StructureDeckItems;

		private int m_DefaultSelectIdx;

		private Action _callback;

		[SerializeField]
		private List<DeckCaseImageData> _deckCaseSpriteDataList;

		private Dictionary<int, int> _cacheStructureIdToIconNimberMap;

		private bool _isDeckSelectDisabled;

		protected override Type[] textIds => null;

		private bool isMobile => false;

		public static void GotoFirstStructDeckSelection(bool restore = false)
		{
		}

		private DeckCaseImageData GetDeckCaseSpriteData(int structureId)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void OnClickDeck(int clickedIdx)
		{
		}

		protected virtual void OnSelectedDeck(int structureDeckId)
		{
		}

		protected IEnumerator OpenStructureDeckBrowser(int structureDeckId)
		{
			return null;
		}
	}
}
