using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.UI
{
	public class BindingSpriteContainer : Binding, IAsyncProgressContent
	{
		[SerializeField]
		private string spriteContainerPath;

		[SerializeField]
		private string spriteLabel;

		[SerializeField]
		public bool immediate;

		[SerializeField]
		public bool showloading;

		private uint crc;

		[SerializeField]
		public string SpriteContainerPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[SerializeField]
		public string SpriteLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public override void OnRebind()
		{
		}

		public override bool OnBinding()
		{
			return false;
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}
	}
}
