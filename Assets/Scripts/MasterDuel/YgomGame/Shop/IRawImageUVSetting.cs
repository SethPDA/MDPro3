using UnityEngine.UI;

namespace YgomGame.Shop
{
	public interface IRawImageUVSetting
	{
		void ImportRawImage(RawImage rawImage);

		void ExportRawImage(RawImage rawImage);
	}
}
