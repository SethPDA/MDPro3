using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.Card
{
	public class CardModel : MonoBehaviour
	{
		private static UnityEngine.Object m_modelSrc;

		private int styleId;

		private int sleeveId;

		private static Quaternion rotationBase;

		private static readonly string cardModelResPath;

		public const float thickness = 0.05f;

		public static readonly Vector3 size;

		public int cardId
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

		public CardRoot.ModelType modelType
		{
			[CompilerGenerated]
			get
			{
				return default(CardRoot.ModelType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static UnityEngine.Object modelSrc => null;

		public bool isTerminated
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

		public bool loadingFront
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

		public bool loadingBack => false;

		public GameObject frontModel
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

		public GameObject backModel
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

		public GameObject sideModel
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

		public MeshRenderer frontRenderer
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

		public MeshRenderer backRenderer
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

		public MeshRenderer sideRenderer
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

		public Quaternion currentRotation => default(Quaternion);

		public static (CardModel, GameObject) CreateAsync(Transform parent, int cardId, int sleeveId, int rareId, Action<CardModel> onFinished = null)
		{
			return default((CardModel, GameObject));
		}

		public void StartLoadTexture(int cardId, int sleeveId, int styleID, Action<CardModel> onFinished = null)
		{
		}

		public static CardModel AddComponent(GameObject go)
		{
			return null;
		}

		public void Terminate()
		{
		}

		public void SetCardTexAsync(int cardId, int styleID, Action<CardModel> onLoaded = null)
		{
		}

		public void SetCardTexAsync(MeshRenderer target, int cardId, int rareId, Action<CardModel> onLoaded = null, bool force = false)
		{
		}

		public void CrearContents()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void Initialize()
		{
		}

		private IEnumerator LoadTexturesProcess(int cardId, int sleeveId, int styleID, Action<CardModel> onFinished)
		{
			return null;
		}

		public void SetBackInsight(bool insight)
		{
		}

		public void SetRotation(Quaternion rotation)
		{
		}

		public void SetFrontColor(Color color)
		{
		}

		public void SetBackColor(Color color)
		{
		}

		public void SetModelType(CardRoot.ModelType modelType)
		{
		}
	}
}
