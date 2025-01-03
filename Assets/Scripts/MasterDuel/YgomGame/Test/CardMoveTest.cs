using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Test
{
	public class CardMoveTest : ViewController
	{
		private enum PlayStatus
		{
			Idle = 0,
			Load = 1,
			SummonEffect = 2,
			MonsterCutin = 3,
			CardMove = 4
		}

		[SerializeField]
		private GameObject prefabUI;

		[SerializeField]
		private CardMoveMotionSetting motionSetting;

		[SerializeField]
		private GameObject prefabCard;

		[SerializeField]
		private GameObject prefabFieldMatNear;

		[SerializeField]
		private GameObject prefabFieldMatFar;

		private ElementObjectManager ui;

		private SharedDefinition.Location fromPlayer;

		private int fromPos;

		private bool fromIsAttack;

		private SharedDefinition.Location toPlayer;

		private int toPos;

		private bool toIsAttack;

		private EffectTaskCardMove.LandingType landingType;

		private EffectTaskCardMove.SummonEffectType summonEffectType;

		private bool isStrong;

		private bool isSummonEffect;

		private int cardID;

		private int matCardID;

		private int matCardNum;

		private int tunerLevel;

		private int materialLevel;

		private int tunerNum;

		private DuelEffectPool effectPool;

		private ElementObjectManager matNear;

		private ElementObjectManager matFar;

		private GameObject root;

		private GameObject card;

		private ChainedBezierMotion motion;

		private Vector3 fromPosition;

		private Vector3 toPosition;

		private Quaternion fromRotation;

		private Quaternion toRotation;

		private Vector3 fromScale;

		private Vector3 toScale;

		private SummonEffectBase summonEffect;

		private PlayStatus playStatus;

		private float time;

		public override void NotificationStackEntry()
		{
		}

		private void SetFromPlayer(int v)
		{
		}

		private void SetToPlayer(int v)
		{
		}

		private void SetFromPosition(int v)
		{
		}

		private void SetToPosition(int v)
		{
		}

		private void SetLandingType(int v)
		{
		}

		private void SetSummonEffectType(int v)
		{
		}

		private void SetFromIsAttack(int v)
		{
		}

		private void SetToIsAttack(int v)
		{
		}

		private void SetIsStrongSummon(int v)
		{
		}

		private void SetIsSummonEffect(int v)
		{
		}

		private void SetDestCardID(string v)
		{
		}

		private void SetMatCardID(string v)
		{
		}

		private void SetMatCardNum(string v)
		{
		}

		private void SetTunerLevel(string v)
		{
		}

		private void SetMaterialLevel(string v)
		{
		}

		private void SetTunerNum(string v)
		{
		}

		private void SetupMenu()
		{
		}

		private void Play()
		{
		}

		private (Vector3, Quaternion, Vector3) GetTrans(SharedDefinition.Location location, int position)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		private void Update()
		{
		}

		private void SetCardTransform(float time)
		{
		}
	}
}
