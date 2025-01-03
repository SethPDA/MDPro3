namespace YgomSystem.UI
{
	public class PlatformTypeVisibleIcon : PlatformVisibleIconBase
	{
		public enum PlatformFlags
		{
			Console_Pad = 1,
			Console_Point = 2,
			Mobile = 4,
			PC_Pad = 8,
			PC_Point = 0x10
		}

		[EnumFlags]
		public PlatformFlags platformFlags;

		protected override bool IsDispPlatform()
		{
			return false;
		}
	}
}
