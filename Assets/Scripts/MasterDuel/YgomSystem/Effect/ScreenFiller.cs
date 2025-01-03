using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.Effect
{
	public class ScreenFiller : MonoBehaviour
	{
		private ElementObjectManager elements;

		private SpriteRenderer fillSprite;

		private static ScreenFiller instance;

		private float time;

		private float fadeTime;

		private const float DefaultFadeTime = 0.2f;

		private Color startColor;

		private Color targetColor;

		private bool isLock;

		public void Initialize()
		{
		}

		public void SetSpriteColor(Color color)
		{
		}

		public void StartFade(Color targetColor, float fadeTime = 0.2f)
		{
		}

		private void UpdateFade(bool force = false)
		{
		}

		private void SetLock(bool isLock)
		{
		}

		public static void SetFillColor(Color color)
		{
		}

		public static void StartFillFade(Color color, float fadeTime = 0.2f)
		{
		}

		public static void SetFillLock(bool isLock)
		{
		}

		private void CheckEnabled()
		{
		}

		private void Update()
		{
		}
	}
}
