using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class MateCaptureCreator : MonoBehaviour
	{
		public class Request
		{
			public GameObject owner;

			public Action<RenderTexture> callback;

			public Request(GameObject owner, Action<RenderTexture> callback)
			{
			}
		}

		public class Cache
		{
			public MateCaptureContext context;

			public RenderTexture renderTexture;

			public List<GameObject> referer;

			public int renderTextureId;

			public int refererCnt => 0;

			public Cache(MateCaptureContext context, RenderTexture renderTexture, int renderTextureId)
			{
			}

			public RenderTexture AssignRef(GameObject owner)
			{
				return null;
			}

			public void Release()
			{
			}
		}

		public class CreateSequncer
		{
			public MateCaptureContext context;

			public List<Request> requests;

			private int m_RenderTextureId;

			private RenderTexture m_RenderTexture;

			private IEnumerator m_ProgressSeq;

			private GameObject m_MateLocator;

			public RenderTexture renderTexture => null;

			public int renderTextureId => 0;

			public void Start()
			{
			}

			public bool Progress()
			{
				return false;
			}

			private IEnumerator yProgress()
			{
				return null;
			}

			public void Abort()
			{
			}

			public void Release(bool isRenderTexture = true)
			{
			}
		}

		private static MateCaptureCreator s_InstanceCache;

		private List<CreateSequncer> m_Sequencers;

		private List<CreateSequncer> m_CompletedSequencers;

		private List<Cache> m_Caches;

		private static MateCaptureCreator s_Instance => null;

		public static void GetMateCapture(GameObject owner, MateCaptureContext context, Action<RenderTexture> callback)
		{
		}

		public static void RereaseMateCapture(GameObject owner)
		{
		}

		private void Update()
		{
		}
	}
}
