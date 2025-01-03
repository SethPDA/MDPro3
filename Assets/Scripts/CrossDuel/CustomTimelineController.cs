using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using DG.Tweening;
using UnityEngine;

namespace Willow
{
	public class CustomTimelineController : TimelineController
	{
		[Serializable]
		public class DataReferenceTarget
		{
			public int m_exposedNameHashCode;

			public string m_targetName;

			public GameObject m_targetObject;

			public DataReferenceTarget(PropertyName prop, string targetName, GameObject targetObject = null)
			{
			}
		}

		private class TaskSe
		{
			public float time
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string key
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

			public TaskSe()
			{
			}

			public TaskSe(float time, string key)
			{
			}
		}

		[SerializeField]
		private CinemachineVirtualCamera m_vcam;

		[SerializeField]
		private TimelineReplacer m_replacer;

		[SerializeField]
		private CinemachineBrain m_camera;

		[SerializeField]
		private GameObject m_chara;

		[SerializeField]
		private Transform m_moveTarget;

		[SerializeField]
		private Transform m_moveStart;

		[SerializeField]
		private Transform m_moveEnd;

		private bool m_init;

		private Transform[] m_children;

		private Tween m_tween;

		private Tween m_tweenFinish;

		private List<int> m_soundIds;

		private float m_perticleLifespan;

		private List<GameObject> m_listCleanUp;

		private Dictionary<string, GameObject> m_dicReplacePrefab;

		private List<TaskSe> m_listTaskSe;

		private Transform[] children => null;

		public CinemachineVirtualCamera mainVcam
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isCharaSamePotision
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

		public bool isFinishOff
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

		public bool isSoundSeOff
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

		public Action<GameObject> callbackInstantiatePrefab
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

		public Action<GameObject, string> callbackInstantiatePrefabWithParentName
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

		public float perticleLifespan
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<GameObject> listCleanUp => null;

		public TimelineReplacer checkReplacer
		{
			get { return m_replacer; }
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void CleanUp()
		{
		}

		protected override void Finish(bool isEndCall = true)
		{
		}

		private void SetPosition()
		{
		}

		public void SetBindObject()
		{
		}

		public void SetBindObject(GameObject bindChara, CinemachineBrain camera = null, Transform moveTarget = null, Transform moveStart = null, Transform moveEnd = null)
		{
		}

		public override void Play(Action endCall, float speed = 1f, double startTimePosition = 0.0)
		{
		}

		public void PlayBlendVcam(Action endCall, float speed = 1f, double startTimePosition = 0.0)
		{
		}

		public override void Stop(bool isEndTime = true, bool isEndCall = true)
		{
		}

		public void SetReplacePrefab(string parentObjectName, GameObject replacePrefab)
		{
		}

		public GameObject GetReplacePrefab(string parentObjectName)
		{
			return null;
		}

		public void ClearReplacePrefab()
		{
		}

		private void SetSoundSe()
		{
		}

		public void StopSoundSe(float fadeTime = 1f)
		{
		}
	}
}
