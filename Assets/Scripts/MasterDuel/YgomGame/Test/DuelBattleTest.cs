using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Test
{
	public class DuelBattleTest : ViewController
	{
		private enum ZoneType
		{
			Main = 0,
			Ex = 1
		}

		[SerializeField]
		private CameraViewSetting cameraViewSetting;

		[SerializeField]
		private AttackMotionSetting battleRunMotionSetting;

		[SerializeField]
		private Transform objectsParent;

		[SerializeField]
		private Transform duelObjectsParent;

		[SerializeField]
		private GameObject cardPrefab;

		[SerializeField]
		private GameObject nearFieldPrefab;

		[SerializeField]
		private GameObject farFieldPrefab;

		[SerializeField]
		private float matOffset;

		[SerializeField]
		private ElementObjectManager ui;

		private GameObject nearMat;

		private GameObject farMat;

		private DuelEffectPool effectPool;

		private SharedDefinition.Location fromLocation;

		private ZoneType fromZone;

		private int fromPosition;

		private SharedDefinition.Location toLocation;

		private ZoneType toZone;

		private int toPosition;

		private GameObject motionCard;

		private GameObject targetCard;

		private EffectTaskBattleRun.AttackType attackType;

		private Content.Attribute attribute;

		private Util.AttackLevel attackLevel;

		private int motionIndex;

		private bool guard;

		private bool directAttack;

		private bool isLethal;

		private LethalEffect.EffectType effectType;

		private bool reqStart;

		private AttackMotionSetting.MotionInfo motionInfo;

		private bool isPlaying;

		private float currentTime;

		private int playMotionIndex;

		private Vector3 originPosition;

		private Vector3 targetPosition;

		private Quaternion originRotation;

		private Quaternion targetRotation;

		private SimpleEffect moveTrail;

		private bool isStart;

		private bool isTrail;

		private bool isAttack;

		private bool isHit;

		private bool isShoot;

		private ChainedBezierMotion chaindBezierMotion;

		private ChainedBezierMotion shootMotion;

		private SimpleEffect shootEffect;

		private Vector3 shootOriginPosition;

		private Vector3 shootTargetPosition;

		private Quaternion shootOriginRotation;

		private Quaternion shootTargetRotation;

		private EffectTaskBattleRun.AttackEffectInfo attackEffectInfo;

		public List<GameObject> cards
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

		public void Start()
		{
		}

		private void Update()
		{
		}

		private void SetupObjects()
		{
		}

		private GameObject CreateCard(Transform parent)
		{
			return null;
		}

		private void ClearObjects()
		{
		}

		private void StartMotionTest()
		{
		}

		private Transform GetZone(SharedDefinition.Location location, ZoneType zone_type, int position)
		{
			return null;
		}

		private Transform GetHand(SharedDefinition.Location location)
		{
			return null;
		}

		private void UpdateMotionTest()
		{
		}

		private void PlayTrailEffect()
		{
		}

		private void PlayAttackEffect()
		{
		}

		private void PlayHitEffect()
		{
		}

		private void PlayShootEffect()
		{
		}

		private void SetCardLayer(int layer)
		{
		}
	}
}
