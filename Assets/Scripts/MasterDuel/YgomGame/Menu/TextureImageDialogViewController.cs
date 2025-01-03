using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class TextureImageDialogViewController : TweenViewController, IBokeSupported
	{
		public const string ARGKEY_TEXTURE = "texture";

		public const string ARGKEY_WIDTH = "width";

		public const string ARGKEY_HEIGHT = "height";

		public const string ARGKEY_ANIM_ROT = "rotateAnim";

		public const string ARGKEY_ANIM_POS = "positionAnim";

		public const string ARGKEY_BGCOLOR = "bgcolor";

		public const string ARGKEY_VOFS = "vofs";

		public const string ARGKEY_CAPTION = "caption";

		[SerializeField]
		private MDText caption;

		private const string PREFAB_NAME = "TextureImageDialog";

		public RawImage rawImage;

		public static void Push(Dictionary<string, object> args)
		{
		}

		public static void PushProtector(int sid, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		private void Start()
		{
		}

		public void OnPushed()
		{
		}
	}
}
