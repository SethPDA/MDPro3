using UnityEngine;

public class USndPlugin : MonoBehaviour
{
	public static bool isSetAudioFocus;

	private static USndPlugin_abstract plugin;

	public static void Init(string objName, string funcName)
	{
	}

	public static void UpdateAndroidMusicStatus()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public static bool IsMusicPlaying()
	{
		return false;
	}

	public static bool IsOtherAudioPlaying()
	{
		return false;
	}

	public static bool IsSpeaker()
	{
		return false;
	}

	public static bool IsMannerMode()
	{
		return false;
	}

	public static void SetAudioFocus()
	{
	}
}
