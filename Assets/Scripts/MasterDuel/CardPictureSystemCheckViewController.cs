using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

public class CardPictureSystemCheckViewController : ViewController, IGenericScrollViewSupport
{
	private enum Mode
	{
		Card = 0,
		Illust = 1
	}

	private bool m_Start;

	private GenericScrollView m_Gsv;

	private ElementObjectManager m_RootEom;

	private ElementObjectManager m_CommonRootEom;

	private ElementObjectManager m_CardRootEom;

	private ElementObjectManager m_IllustRootEom;

	private ElementObjectManager m_RandomScrollSliderEom;

	private ElementObjectManager m_SimpleScrollSliderEom;

	private List<int> m_DataList;

	private Button m_IllustModeButton;

	private Button m_CardModeButton;

	private Mode m_Mode;

	private Slider m_RandomScrollSlider;

	private Slider m_SimpleScrollSlider;

	private void Start()
	{
	}

	private void OnReady()
	{
	}

	private void Update()
	{
	}

	private void OnSelectMode(Mode mode)
	{
	}

	private float GetSimpleScrollValue()
	{
		return 0f;
	}

	private float GetRandomScrollValue()
	{
		return 0f;
	}

	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	public void OnItemInitialize(GameObject gob)
	{
	}

	public void OnGsvStanby()
	{
	}
}
