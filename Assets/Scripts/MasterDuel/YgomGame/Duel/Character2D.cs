using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Duel
{
	public class Character2D : MonoBehaviour
	{
		[SerializeField]
		public RawImage rawImg;

		private static readonly string Character2DPrefabPath;

		private bool isInitialized;

		private bool IsDestroyed;

		private Character chara;

		private int renderTextureId;

		private bool autoCameraOnOff;

		private Coroutine soundCheckCroutine;

		private static GameObject mateCreateLocatorCache;

		public bool IsInitialized => false;

		public Character character => null;

		public Animator animator => null;

		private static GameObject mateCreateLocator => null;

		private static void Create(Transform parent, Action<Character2D> onFinish = null)
		{
		}

		public static void Create(int avatarId, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, Action<Character2D> onFinish = null, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f)
		{
		}

		public static void Create(int avatarId, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, int renderTexW = 256, int renderTexH = 256, Action<Character2D> onFinish = null, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f)
		{
		}

		private void Initialize(int avatarId, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, Action onFinish = null, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f)
		{
		}

		private IEnumerator OnFinishCoroutine(int id, Action onFinish = null)
		{
			return null;
		}

		public GameObject GetModelInstance()
		{
			return null;
		}

		public void PlayMotion(AvatarMotionSetting.MotionID motion)
		{
		}

		public bool HasMotion(AvatarMotionSetting.MotionID motion)
		{
			return false;
		}

		public void StopMotionSe(float fade = -1f)
		{
		}

		public void SetEnableSe(bool flg)
		{
		}

		public void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void SetAutoCameraOnOff(bool flg)
		{
		}
	}
}
