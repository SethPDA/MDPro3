using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenSpriteColor : Tween
	{
		[ColorLabelString]
		[SerializeField]
		public string fromLabel;

		[SerializeField]
		public Color from;

		[ColorLabelString]
		[SerializeField]
		public string toLabel;

		[SerializeField]
		public Color to;

		public bool isOverride;

		public bool isRecusive;

		private List<KeyValuePair<SpriteRenderer, Color>> childGraps;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}

		SpriteRenderer m_spriteRenderer;
        private void OnEnable()
        {
            m_spriteRenderer = GetComponent<SpriteRenderer>();
			TweenColor();
        }

		void TweenColor()
		{
			m_spriteRenderer.color = from;
			m_spriteRenderer.DOColor(to, duration).SetEase(GetDGTweenEase(easing)).OnComplete(() =>
			{
				if (style.ToString().Contains("Loop"))
				{
                    m_spriteRenderer.DOColor(from, duration).SetEase(GetDGTweenEase(easing)).OnComplete(() =>
                    {
                        if (style.ToString().Contains("Loop"))
                        {
                            TweenColor();
                        }
                    });
                }
            });
		}


    }
}
