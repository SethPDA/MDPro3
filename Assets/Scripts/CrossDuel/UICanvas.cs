using UnityEngine;

[DisallowMultipleComponent]
public class UICanvas : MonoBehaviour
{
	private void Start()
	{
	}

	protected virtual Camera GetCamera()
	{
		return null;
	}

	protected virtual Camera GetSelfCamera()
	{
		return null;
	}
}
