using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Dialog.CommonDialog;

namespace YgomGame.Mission
{
	public class BulkRecieveContext
	{
		public class RecievableContext
		{
			public readonly Dictionary<int, Dictionary<int, List<int>>> recieveMap;

			public int length
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Clear()
			{
			}
		}

		public class ResultContext
		{
			public Dictionary<string, object> goalItems;

			public List<object> totalItems
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isSendPresent
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isReceived => false;

			public void Clear()
			{
			}

			public void Import(Dictionary<string, object> resultData)
			{
			}

			public EntryItemListData.Context SearchGoalItemContext(MissionContext missionCtx, int goalPos)
			{
				return null;
			}
		}

		private readonly Dictionary<TabContext, RecievableContext> m_RecievableContextMap;

		public readonly ResultContext resultContext;

		public int GetRecievableLength()
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void Import(IReadOnlyList<TabContext> tabCtxts)
		{
		}

		public (List<int>, List<int>, List<int>) ExportReq(TabContext tabContext)
		{
			return default((List<int>, List<int>, List<int>));
		}
	}
}
