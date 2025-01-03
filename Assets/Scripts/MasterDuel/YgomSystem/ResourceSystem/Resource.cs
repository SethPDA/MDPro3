using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.ResourceSystem
{
	public class Resource
	{
		public enum Type
		{
			None = 0,
			BuiltIn = 1,
			AssetBundle = 2,
			Binary = 3,
			Network = 4,
			StreamingAssets = 5,
			StreamingBinary = 6,
			LocalFile = 7,
			StreaminFile = 8,
			PlayAssetDelivery = 9
		}

		public struct HandlerData
		{
			public string path;

			public ResourceManager.RequestCompleteHandler handler;

			//public HandlerData(string _path, ResourceManager.RequestCompleteHandler _handler)
			//{
			//}

			public void Call()
			{
			}
		}

		public delegate void CancelHandler(Resource res);

		public delegate void UnloadHandler(Resource res);

		private List<HandlerData> handlerList;

		private CancelHandler cancelHandler;

		private UnloadHandler unloadHandler;

		public List<HandlerData> CompleteHandlerList => null;

		public Type ResType
		{
			[CompilerGenerated]
			get
			{
				return default(Type);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int RefCount
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

		public UnityEngine.Object[] Assets
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

		public byte[] Bytes
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

		public bool Cancel
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

		public bool Error
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

		public bool Done
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

		public bool Busy
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

		public bool Retry
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

		public System.Type SystemType
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

		public string LoadPath
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

		public bool DisableErrorNotify
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

		public ResourceManager.ReqType queueId
		{
			[CompilerGenerated]
			get
			{
				return default(ResourceManager.ReqType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool needMaterialRebuild
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

		public void AddHandler(string path, ResourceManager.RequestCompleteHandler handler)
		{
		}

		public void CallHandler()
		{
		}

		public void ClearHandler()
		{
		}

		public void AddCancelHandler(CancelHandler handler)
		{
		}

		public void RemoveCancelHandler(CancelHandler handler)
		{
		}

		public void CallCancel()
		{
		}

		public void AddUnloadHandler(UnloadHandler handler)
		{
		}

		public void RemoveUnloadHandler(UnloadHandler handler)
		{
		}

		public void CallUnload()
		{
		}
	}
}
