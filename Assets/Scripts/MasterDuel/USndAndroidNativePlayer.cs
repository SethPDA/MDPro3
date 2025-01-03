using UnityEngine;

public class USndAndroidNativePlayer
{
	private static USndAndroidNativePlayer player;

	private static AndroidJavaObject plugin;

	public static void Initialize(int maxNum)
	{
	}

	public static void Terminate()
	{
	}

	public static int LoadData(string saveName, string className, string funcName)
	{
		return 0;
	}

	public static int Play(int soundId, float volume, float rate)
	{
		return 0;
	}

	public static void Stop(int streamId)
	{
	}

	public static void Unload(int soundId)
	{
	}
}
