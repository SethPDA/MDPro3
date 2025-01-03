using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu.Common
{
	public class PublicDeckCaseWidget : ElementWidgetBase
	{
		private int m_caseID;

		private int m_pickupCard;

		private Image m_deckImage;

		private RawImage m_cardImage;

		private const string openTweenLabel = "select";

		private const string closeTweenLabel = "deselect";

		public static readonly string prefabResourcePath;

		public int caseID => 0;

		public int pickupCard => 0;

		private void setCardImage(int id, bool addProgress)
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

		public PublicDeckCaseWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public PublicDeckCaseWidget Binding(int caseId, int pickupCard)
		{
			return null;
		}

		public void ChangeCardImage(int id)
		{
		}

		public static GameObject LoadPrefabFromResource()
		{
			return null;
		}
	}
}
