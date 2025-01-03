namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCaptureState
	{
		private bool mIsCapturing;

		private VideoCaptureMode mCaptureMode;

		private VideoQualityLevel mQualityLevel;

		private bool mIsOverlayVisible;

		private bool mIsPaused;

		public bool IsCapturing => false;

		public VideoCaptureMode CaptureMode => default(VideoCaptureMode);

		public VideoQualityLevel QualityLevel => default(VideoQualityLevel);

		public bool IsOverlayVisible => false;

		public bool IsPaused => false;

		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
