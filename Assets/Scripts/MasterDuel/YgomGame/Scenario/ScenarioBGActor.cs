using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Scenario
{
	[DisallowMultipleComponent]
	public class ScenarioBGActor : MonoBehaviour
	{
		public class Setting
		{
			public ElementObjectManager titlePref;

			[NonSerialized]
			public Vector2Int bgRenderSize;
		}

		private RawImage m_RawImageCache;

		private string m_BgPath;

		private bool m_LoadingBg;

		private bool m_IsError;

		private ScenarioBGLoader.BgGeneratedResource m_BgGeneratedResource;

		private Vector3 m_ScreenMinPos;

		private Vector3 m_ScreenMaxPos;

		private float m_ScreenScale;

		private Vector3 m_OffsetScale;

		private bool m_Capture;

		private Setting m_BgSetting;

		private ScenarioBGLoader m_BGLoader;

		private readonly Vector3 m_ShakerCenter;

		public object renderTarget => null;

		public RawImage rawImage => null;

		public bool isReady => false;

		public bool isError => false;

		public bool isExists => false;

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Vector3 offsetScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float screenScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 spritePos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public GameObject shakeTarget => null;

		public LabeledPlayableController labeledPlayableController => null;

		public void SetTitleText(string title)
		{
		}

		public void Initialize(Setting bgSetting, ScenarioBGLoader bgLoader)
		{
		}

		private void LateUpdate()
		{
		}

		public void LoadBg(string bgPath)
		{
		}

		public void CaptureBg(ScenarioBGActor source)
		{
		}

		public void ReleaseBg()
		{
		}

		private Vector3 CalcScreenDiffMin()
		{
			return default(Vector3);
		}

		private Vector3 CalcScreenDiffMax()
		{
			return default(Vector3);
		}

		private void AdjustPositionInScreen()
		{
		}

		public Vector3 CalcDirectionalPos(int direction)
		{
			return default(Vector3);
		}
	}
}
