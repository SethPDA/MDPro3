using System.Collections.Generic;
using UnityEngine;

public class InAppBilling : MonoBehaviour
{
	public delegate void Func();

	private const string version = "0.5.20230216rc0";

	public const int SUCCESS = 0;

	public const int ERR_REQUIRE_AGE = -1;

	public const int ERR_INVALID_RECEIPT = -2;

	public const int ERR_BAD_REQUEST = -3;

	public const int ERR_ALREADY_FINISHED = -4;

	public const int ERR_SERVER = -5;

	public const int ERR_USER_CANNOT_BUY = -6;

	public const int ERR_MAINTENANCE = -7;

	public const int ERR_NOT_ENOUGH_POINT = -8;

	public const int ERR_BAD_USER = -9;

	public const int ERR_PURCHASE_CANCELED = -13;

	public const int ERR_NO_SUBSCRIPTIONS = -14;

	public const int ERR_VOIDED_PURCHASE = -15;

	public const int ERR_PURCHASE_PENDING = -16;

	[HideInInspector]
	public string base64EncodedPublicKey;

	public bool debuggable;

	private static Queue<Func> queue;

	private string decode(string str)
	{
		return null;
	}

	private void Awake()
	{
	}

	public static void RunOnMainThread(Func f)
	{
	}

	private void Update()
	{
	}
}
