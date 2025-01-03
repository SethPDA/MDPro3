using UnityEngine;
using YgomSystem.UI;

namespace YgomGame
{
	public class TitleOverlayBGController : MonoBehaviour
	{
		private const string FadeInLabel = "In";

		private const string FadeOutLabel = "Out";

		private GameObject m_bgRoot;

		private TweenSpriteColor m_fadeInTween;

		private TweenSpriteColor m_fadeOutTween;

		private SpriteRenderer m_spriteRenderer;

		private ParticleSystem[] m_particleSystems;

		private ParticleSystem.Particle[] m_particleWorkBuf;

		private static void log(string msg)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void updateParticlesAlpha()
		{
		}

		private void onFinishFadeOut()
		{
		}

		public void StartFadeIn()
		{
		}

		public void StartFadeOut()
		{
		}

		public void Release()
		{
		}
	}
}
