using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomSystem.ResourceSystem
{
	public class ResTypeChecker : IResTypeChecker
	{
		private class CheckFileTypeParam
		{
			public int Result
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

			public string Path
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool isStreaming
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private class CheckFileTypeThread : PooledThreadBase
		{
			protected override bool ExecThread(object parameter)
			{
				return false;
			}

			private bool CheckFromLocalFileSystem(CheckFileTypeParam param)
			{
				return false;
			}

			private bool CheckFromFileStream(CheckFileTypeParam param)
			{
				return false;
			}
		}

		private CheckFileTypeParam[] threadParam;

		private CheckFileTypeThread[] threads;

		private List<IResTypeChecker> m_checkList;

		public void Initialize()
		{
		}

		public void Destroy()
		{
		}

		public void ClearCache()
		{
		}

		public ResTypeData GetResType(string path)
		{
			return null;
		}

		public ResTypeData GetResTypeSimpleCheck(string path)
		{
			return null;
		}

		private void UpdateResType(Resource res)
		{
		}

		public IEnumerator CheckFileTypeAsync(Resource res, ResourceManager.ReqType queueId)
		{
			return null;
		}

		private IEnumerator checkFileAssetBundleAsync(int id, string path, bool isStreamingAssets = false, Action<bool> callback = null)
		{
			return null;
		}
	}
}
