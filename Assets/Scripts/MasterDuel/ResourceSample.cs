using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ResourceSample : MonoBehaviour
{
	[SerializeField]
	private string m_loadPath;

	[SerializeField]
	private string m_loadAsyncPath;

	[SerializeField]
	private string m_loadRawImageAsyncPath;

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private Image m_asyncImage;

	[SerializeField]
	private RawImage m_rawImage;

	[SerializeField]
	private Button m_clickButton;

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	private IEnumerator yLoadAsync()
	{
		return null;
	}
}
