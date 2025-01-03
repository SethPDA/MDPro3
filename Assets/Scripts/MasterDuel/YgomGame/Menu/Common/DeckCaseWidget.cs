using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu.Common
{
	public class DeckCaseWidget : ElementWidgetBase
	{
		private int m_caseID;

		private int m_protectorId;

		private string m_deckName;

		private int[] m_pickupCards;

		private int[] m_pickupDecos;

		private Image m_deckImage;

		private Image m_deckOpenedImage;

		private RawImage[] m_cardImages;

		private ExtendedTextMeshProUGUI m_nameText;

		private const string openTweenLabel = "select";

		private const string closeTweenLabel = "deselect";

		public static readonly string prefabResourcePath;

		public Image image => null;

		public int caseID => 0;

		public int protectorId => 0;

		public string deckName => null;

		public int[] pickupCards => null;

		public int[] pickupDecos => null;

		private void setCardImage(int index, int id, int decoration, bool addProgress)
		{
		}

		private void setAnimation(bool isOpen, bool immediate = false)
		{
		}

		private void playTweenEndOfLabel(GameObject target, string label)
		{
		}

		private static void traverseTweenTree(GameObject target, string label, Action<Tween> action, bool recursive)
		{
		}

		public DeckCaseWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public DeckCaseWidget Binding(int caseId, int protectorId, string deckName, int[] pickupCards_, int[] pickupDecos_, bool opened, bool isLarge = false, bool isDestroyTweens = false)
		{
			return null;
		}

		public void ChangeCardImage(int index, int id, int decoration)
		{
		}

		public void ChangeDeckName(string name)
		{
		}

		public void ChangeDeckCaseImage(int caseId)
		{
		}

		public void ChangeProtectorImage(int protectorId)
		{
		}

		public void SetOpen(bool immediate = false)
		{
		}

		public void SetClose(bool immediate = false)
		{
		}

		public static GameObject LoadPrefabFromResource()
		{
			return null;
		}
	}
}
