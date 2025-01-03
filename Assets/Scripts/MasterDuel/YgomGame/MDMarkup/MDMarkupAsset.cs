using System;
using System.Runtime.CompilerServices;

namespace YgomGame.MDMarkup
{
	public class MDMarkupAsset
	{
		private IMDMarkupContainer m_Container;

		private int m_LoadingCnt;

		private Action m_OnLoadCompleteCallback;

		public int invalidPos
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isValidData => false;

		public IMDMarkupContainer container => null;

		public static MDMarkupAsset CreateByJson(string json)
		{
			return null;
		}

		public static MDMarkupAsset CraeteInstanceByContainer(IMDMarkupContainer container)
		{
			return null;
		}

		public static MDMarkupAsset CreateInstance(MDMarkupDef.ContainerType containerType)
		{
			return null;
		}

		public void ImportJson(string json)
		{
		}

		public void Preload(Action onLoadCompleteCallback)
		{
		}

		private void OnCheckLoadComplete()
		{
		}
	}
}
