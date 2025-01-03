using System;
using System.Collections;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class ResourceLoadRequest : MonoBehaviour//, IAsyncProgressContent
	{
		private string m_Path;

		private string m_AssetContainerLabel;

		private bool m_Immediate;

		private bool m_Hold;

		private bool m_DisabledErrorNotify;

		private uint m_Crc;

		private IEnumerator m_Loadroutine;

		private Action<ResourceLoadRequest> m_OnFinishCallback;

		public bool isExistsAssetContainerLabel => false;

		public bool isValidAsset => false;

		private bool YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EIsDone()
		{
			return false;
		}

		private void YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EProgressUpdate()
		{
		}

		public Type CheckResourceType(params Type[] checkTypes)
		{
			return null;
		}

		public bool TryGetAssetSize(out Vector2 size)
		{
			size = default(Vector2);
			return false;
		}

		public static void Load(GameObject owner, string resourcePath, bool async = true, Action<ResourceLoadRequest> onFinishCallback = null, bool hold = false, bool disabledErrorNotify = false)
		{
		}

		private void Load()
		{
		}

		private IEnumerator yLoad()
		{
			return null;
		}

		private void OnFinish()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
