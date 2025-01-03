using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu
{
	public class QRCodeCreator : MonoBehaviour
	{
		private readonly string k_ElabelQRCodeImage;

		private readonly string k_ElabelTextURL;

		private readonly string k_ElabelURLButton;

		[SerializeField]
		private string clientWorkPath;

		private ElementObjectManager m_RootEom;

		private RawImage m_QRCodeImage;

		private TextMeshProUGUI m_TextURL;

		private Button m_URLButton;

		private void Awake()
		{
		}
	}
}
