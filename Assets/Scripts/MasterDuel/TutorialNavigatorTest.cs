using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

public class TutorialNavigatorTest : MonoBehaviour
{
	private const string MSG_STACK_BTN_LABEL = "Stack";

	private const string STACK_MSG_AREA_TEXT_LABEL = "StackMsg";

	[SerializeField]
	private float _centerMsgDelay;

	private ElementObjectManager _eoManager;

	private ElementObjectManager _inputFieldMgr;

	private ExtendedInputField _inputField;

	private MDText _stackMsgText;

	private IList<string> _messages;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void PushMessage(string message)
	{
	}

	private void ClearMessages()
	{
	}
}
