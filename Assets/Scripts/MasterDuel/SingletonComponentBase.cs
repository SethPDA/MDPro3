using UnityEngine;
using UnityEngine.Events;

public abstract class SingletonComponentBase<T> : MonoBehaviour where T : SingletonComponentBase<T>
{
	private static T _Instance;

	public static bool IsReady;

	protected static T m_Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected static bool m_IsAlive => false;

	protected static void CreateInstance()
	{
	}

	protected static void CreateInstanceAsync(string path, UnityAction onFinish = null, Transform parent = null)
	{
	}

	public static void Release()
	{
	}

	protected abstract void Initialize();

	protected abstract void Terminate();
}
