using UnityEngine;

public class SafeAreaAdjuster : MonoBehaviour
{
	[SerializeField]
	private RectTransform m_targetNode;

	[SerializeField]
	private bool m_isOffVerticalSafearea;

	[SerializeField]
	private bool m_isOffHorizontalSafearea;

	private bool m_needRefreshSafeArea;

	public RectTransform targetNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void RefreshSafeArea()
	{
	}

	private void ApplySafeArea(Rect area, RectTransform target)
	{
	}

	public static Rect GetSafeArea()
	{
		return default(Rect);
	}
}
