using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class ListCardBase : MonoBehaviour
	{
		private ListCardBaseData m_CardData;

		private ElementObjectManager m_EOManager;

		private RawImage m_CardPicture;

		private SelectionButton m_Sbtn;

		public int cardid => 0;

		public SelectionButton sbtn => null;

		private void InitComponent()
		{
		}

		public void Initialize(UnityAction onSelected, UnityAction onClick)
		{
		}

		public void SetData(ListCardBaseData data)
		{
		}
	}
}
