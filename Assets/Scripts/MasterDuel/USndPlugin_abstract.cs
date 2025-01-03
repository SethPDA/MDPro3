public abstract class USndPlugin_abstract
{
	public abstract void Init();

	public abstract void Delete();

	public abstract bool IsMusicPlaying();

	public abstract bool IsOtherAudioPlaying();

	public abstract bool IsSpeaker();

	public abstract bool IsMannerMode();

	public abstract void SetAudioFocus();
}
