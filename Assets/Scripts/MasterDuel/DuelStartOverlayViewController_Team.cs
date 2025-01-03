using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

public class DuelStartOverlayViewController_Team : BaseMenuViewController
{
	private class TeamInfo
	{
		public readonly object info;

		public readonly int teamNameMrk;

		public readonly int userNum;

		public readonly Dictionary<string, object> membersInfo;

		public TeamInfo(object info, int teamNameMrk, int userNum, Dictionary<string, object> membersInfo)
		{
		}
	}

	public static readonly string PREFAB_PATH;

	private bool isFinish;

	private readonly string E_TweenFinish;

	private readonly string E_RootPlayer;

	private readonly string E_RootRival;

	private readonly string E_TextTeamName;

	private readonly string E_RootProfile;

	private readonly string E_ImageIcon;

	private readonly string E_PlatformPlayerIcon;

	private readonly string E_PlatformPlayerNameGroup;

	private ElementObjectManager playerEom;

	private ElementObjectManager rivalEom;

	private GameObject tweenFinish;

	[SerializeField]
	private int MAX_MEMBERS;

	public override void NotificationStackEntry()
	{
	}

	protected override void OnCreatedView()
	{
	}

	private void DispTeam(int myid, ElementObjectManager teamEom, bool isPlayerTeam)
	{
	}

	private void InitTeam()
	{
	}

	private TeamInfo SetTeamInfo(object teamInfo)
	{
		return null;
	}

	private void SetTeam(ElementObjectManager eom, TeamInfo teamInfo, bool isPlayerTeam)
	{
	}

	public GameObject GetHideObject()
	{
		return null;
	}

	public void Start()
	{
	}

	public void Update()
	{
	}
}
