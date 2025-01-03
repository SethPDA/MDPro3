using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem
{
	public class ScrollViewAutoScroll : MonoBehaviour
	{
		private enum ScrollViewDirection
		{
			Horizontal = 0,
			Vertical = 1
		}

		private enum Step
		{
			BeginIdleStep = 0,
			ScrollStep = 1,
			EndIdleStep = 2
		}

		[SerializeField]
		private float m_ScrollSpeed;

		[SerializeField]
		private float m_WaitTimeBegin;

		[SerializeField]
		private float m_WaitTimeEnd;

		private ScrollViewDirection m_Direction;

		private Coroutine m_UpdateScrollCoroutine;

		private ScrollRect m_ScrollRect;

		private RectTransform m_ContentRT;

		private float m_DeltaTime;

		private Step m_Step;

		private Rect lastRect;

		private void Awake()
		{
			m_ScrollRect = GetComponent<ScrollRect>();
			m_ContentRT = m_ScrollRect.content;
		}
        private void OnEnable()
        {
			ResetScroll();
        }

        private void OnDisable()
        {
            if (m_UpdateScrollCoroutine != null)
            {
                StopCoroutine(m_UpdateScrollCoroutine);
                m_UpdateScrollCoroutine = null;
            }
        }

        public void ResetScroll()
		{
            if (m_UpdateScrollCoroutine != null)
            {
                StopCoroutine(m_UpdateScrollCoroutine);
            }
            lastRect = m_ContentRT.rect;
            m_ScrollRect.normalizedPosition = new Vector2(0f, 1f);
            m_UpdateScrollCoroutine = StartCoroutine(ScrollRoutine());
        }

		private void Update()
		{
			if (m_ContentRT.rect != lastRect)
				ResetScroll();
        }

		private void BeginIdleProcess()
		{
		}

		private void ScrollProcess()
		{
		}

		private void EndIdleProcess()
		{
		}

        private IEnumerator ScrollRoutine()
        {
            yield return new WaitForSeconds(m_WaitTimeBegin);

            float startTime = Time.time;
            float duration = (m_ScrollRect.content.rect.width - m_ScrollRect.viewport.rect.width) / (m_ScrollSpeed * 50f);
            duration = Mathf.Max(duration, (m_ScrollRect.content.rect.height - m_ScrollRect.viewport.rect.height) / (m_ScrollSpeed * 50f));

            while (Time.time - startTime < duration)
            {
                float progress = (Time.time - startTime) / duration;
                m_ScrollRect.normalizedPosition = Vector2.Lerp(new Vector2(0f, 1f), new Vector2(1f, 0f), progress);
                yield return null;
            }

            yield return new WaitForSeconds(m_WaitTimeEnd);
            ResetScroll();
        }
    }
}