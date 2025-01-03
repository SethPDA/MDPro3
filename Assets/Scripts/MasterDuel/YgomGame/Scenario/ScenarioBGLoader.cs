using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.Effect;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Scenario
{
	[DisallowMultipleComponent]
	public class ScenarioBGLoader : MonoBehaviour
	{
		private class RequestData
		{
			public Action<BgGeneratedResource> callback;

			public GameObject owner;

			public RequestData(GameObject owner, Action<BgGeneratedResource> callback)
			{
			}
		}

		public class BgGeneratedResource
		{
			public ElementObjectManager eom
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

			public int renderTextureId
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

			public Sprite createdSprite
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

			public Texture renderTexture
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

			public SpriteRenderer spriteRenderer
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

			public SpriteScaler spriteScaler
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

			public LabeledPlayableController labeledPlayableController
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

			public Transform rootTran
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

			public Transform scalerTran
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

			public Transform shakePosTran
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

			public Transform movePosTran
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

			public static BgGeneratedResource Create(GameObject gameObject)
			{
				return null;
			}

			public static BgGeneratedResource Create(Sprite sprite)
			{
				return null;
			}

			public static BgGeneratedResource Create(Texture2D texture2D)
			{
				return null;
			}

			public BgGeneratedResource(GameObject originGob)
			{
			}

			public void OnCreatedRenderTexture(int rtId, RenderTexture renderTexture)
			{
			}

			public void Release()
			{
			}
		}

		private ScenarioBGActor.Setting m_BGSetting;

		private Dictionary<string, List<RequestData>> m_Requests;

		private Dictionary<string, BgGeneratedResource> m_BgResourceMap;

		private Dictionary<string, List<GameObject>> m_ReferencedOwnerMap;

		public void Initialize(ScenarioBGActor.Setting bgSetting)
		{
		}

		public void LoadBG(GameObject owner, string path, Action<BgGeneratedResource> onFinish)
		{
		}

		public Texture TryGetLoadedBgTexture(GameObject owner, string path)
		{
			return null;
		}

		private void OnLoadedBgAsset(GameObject owner, string loadedPath)
		{
		}

		private void CreateBgRenderTexture(GameObject owner, string path, BgGeneratedResource bgGeneratedResource)
		{
		}

		private void OnCreatedRenderTexture(string path, BgGeneratedResource bgGeneratedResource, int rtId, RenderTexture renderTexture, Texture2D texture)
		{
		}

		private void OnCompleteRequest(string path, BgGeneratedResource bgGeneratedResource)
		{
		}

		public void ReleaseBg(GameObject owner, string path)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
