using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.Prize.TurnOverPrize
{
	public class TurnOverPrizeViewerViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class InfoBehaviour : IBehaviour
		{
			private const string k_ELabel_PackImage = "PackImage";

			private readonly TurnOverPrizeViewerViewController m_Owner;

			private List<string> m_InfoSheetEntries;

			public InfoBehaviour(TurnOverPrizeViewerViewController owner)
			{
			}

			public void NotificationStackEntry()
			{
			}

			public void NotificationStackRemove()
			{
			}

			public void OnCreatedView()
			{
			}

			public void OnStart()
			{
			}

			private void OnClick(int dataIdx)
			{
			}
		}

		private class ResultBehaviour : IBehaviour
		{
			private const string k_ELabel_CardImage = "CardImage";

			private const string k_ELabel_PackImage = "PackImage";

			private const string k_TLabelPackDefault = "Default";

			private const string k_TLabelPackShadow = "Shadow";

			private readonly TurnOverPrizeViewerViewController m_Owner;

			private List<int> m_CardDetailMrks;

			private List<int> m_CardDetailStyles;

			private Dictionary<int, int> m_CardDetailPosMap;

			public ResultBehaviour(TurnOverPrizeViewerViewController owner)
			{
			}

			public void NotificationStackEntry()
			{
			}

			public void NotificationStackRemove()
			{
			}

			public void OnCreatedView()
			{
			}

			public void OnStart()
			{
			}

			public void PackToDefault(Image packImage)
			{
			}

			public void PackToShadow(Image packImage)
			{
			}

			private void OnClick(int dataIdx)
			{
			}
		}

		private interface IBehaviour
		{
			void NotificationStackEntry();

			void OnCreatedView();

			void OnStart();

			void NotificationStackRemove();
		}

		public enum Mode
		{
			Info = 0,
			Result = 1
		}

		private const string k_VCPath = "Prize/TurnOverPrize/TurnOverPrizeViewer";

		private const string k_ArgKeyPrizeId = "prizeId";

		private const string k_ArgKeyMode = "mode";

		private const string k_VLabel_Info = "InfoView";

		private const string k_VLabel_Result = "ResultView";

		private const string k_ELabelPackGroup = "PackGroup";

		private const string k_ELabelPackGroup_Template = "Template";

		private const string k_ELabelPackGroup_LocaterFormat = "Locater{0}";

		private Sprite m_CoverSprite;

		private int m_ShopId;

		private List<object> m_PrizeDatas;

		private IBehaviour m_Behaviour;

		private ElementObjectManager[] m_Entities;

		protected override Type[] textIds => null;

		public static void OpenAsInfo(int prizeId = 1)
		{
		}

		public static void OpenAsResult(int prizeId = 1)
		{
		}

		private static void InnerOpen(Mode mode, int prizeId, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void CreateEntities()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
