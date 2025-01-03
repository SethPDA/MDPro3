using UnityEngine;
using UnityEngine.Events;

public class OnDestroyAction : MonoBehaviour
{
	protected UnityAction onDestroy;

	public void SetDestroyAction(UnityAction onDestroy)
	{
	}

	private void OnDestroy()
	{
	}
}
