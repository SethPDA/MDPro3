using DG.Tweening;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenPositionTo : Tween
	{
		private RectTransform rtrans;

		private Vector3 from;

		[SerializeField]
		public Vector3 to;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}


		Vector3 startPosition;
        private void Start()
        {
            startPosition = transform.localPosition;
			PlayDIY();
        }

		void PlayDIY()
		{
            transform.localPosition = startPosition;
            GetComponent<Transform>().DOLocalMove(to, duration).SetEase(GetDGTweenEase(easing)).OnComplete(() => 
			{ 
				if(style == Style.Loop)
				{
					PlayDIY();
				}
			});
		}
    }
}
