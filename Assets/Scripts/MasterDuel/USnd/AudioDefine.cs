namespace USnd
{
	public class AudioDefine
	{
		public enum INSTANCE_STATUS
		{
			STOP = 0,
			STOP_SOON = 1,
			PREPARE = 2,
			PLAY = 3,
			PAUSE = 4,
			PAUSE_SOON = 5
		}

		public enum LOAD_XML_STATUS
		{
			STANDBY = 0,
			LOADING = 1,
			FINISH = 2,
			ERROR = 3
		}

		public enum LOAD_JSON_STATUS
		{
			STANDBY = 0,
			LOADING = 1,
			FINISH = 2,
			ERROR = 3
		}

		public static readonly int DEFAULT_SAMPLE_RATE;

		public static readonly bool ANDROID_MANNER_MODE_MUTE;

		public static readonly float DEFAULT_VOLUME;

		public static readonly float DEFAULT_PAN;

		public static readonly int DEFAULT_PITCH;

		public static readonly int DEFAULT_FADE;

		public static readonly int INSTANCE_ID_ERROR;

		public static readonly float VOLUME_MAX;

		public static readonly float VOLUME_MIN;

		public static readonly float PAN_LEFT;

		public static readonly float PAN_RIGHT;

		public static readonly float PAN_CENTER;

		public static readonly int PITCH_MAX;

		public static readonly int PITCH_MIN;

		public static readonly int PITCH_NORMAL;

		public static readonly int TABLE_UPPER_VERSION;

		public static readonly int TABLE_LOWER_VERSION;

		public static readonly int TABLE_ADD_IS_ANDROID_NATIVE_VERSION;

		public static readonly int TABLE_ADD_INTERVAL_VERSION;

		public static readonly int LIST_CAPACITY;

		public static readonly float[] PITCH_VALUES;
	}
}
