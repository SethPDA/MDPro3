using System.Text;
//using Steamworks;
using UnityEngine;

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	protected static bool s_EverInitialized;

	protected static SteamManager s_instance;

	protected bool m_bInitialized;

	//protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	protected static SteamManager Instance => null;

	public static bool Initialized => false;

	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	private static void InitOnPlayMode()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Update()
	{
	}
}
