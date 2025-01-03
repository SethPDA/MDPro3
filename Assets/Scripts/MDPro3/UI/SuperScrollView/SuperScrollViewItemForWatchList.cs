using MDPro3;
using MDPro3.Net;
using MDPro3.UI;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SuperScrollViewItemForWatchList : SuperScrollViewItem
{
    public Text textPlayerName0;
    public Text textPlayerName1;
    public RawImage avatarPlayer0;
    public RawImage avatarPlayer1;
    public Button button;

    public string roomId;
    public string roomTitile;
    public string player0Name;
    public string player1Name;
    public MyCardRoomOptions options = new();

    public string arena;

    IEnumerator refreshEnumerator;

    private void OnEnable()
    {
        if(refreshEnumerator != null)
            StartCoroutine(refreshEnumerator);
    }

    public override void Refresh()
    {
        base.Refresh();

        textPlayerName0.text = player0Name;
        textPlayerName1.text = player1Name;

        if (refreshEnumerator != null)
            StopCoroutine(refreshEnumerator);
        if (gameObject.activeInHierarchy)
            StartCoroutine(refreshEnumerator = RefreshAsync());
        else
            refreshEnumerator = RefreshAsync();
    }

    IEnumerator RefreshAsync()
    {
        while(!Appearance.loaded)
            yield return null;

        avatarPlayer0.texture = Appearance.defaultFace0.texture;
        avatarPlayer1.texture = Appearance.defaultFace1.texture;

        var load = MyCard.GetAvatarAsync(player0Name);
        while (!load.IsCompleted)
            yield return null;
        if (load.Result != null)
            avatarPlayer0.texture = load.Result;

        load = MyCard.GetAvatarAsync(player1Name);
        while (!load.IsCompleted)
            yield return null;
        if (load.Result != null)
            avatarPlayer1.texture = load.Result;

        refreshEnumerator = null;
    }

    public override void OnClick()
    {
        base.OnClick();
        var password = MyCard.GetJoinRoomPassword(options, roomId, MyCard.account.user.id);

        TcpHelper.LinkStart(MyCard.duelUrl, MyCard.account.user.username, MyCard.athleticPort.ToString(), password, false, null);
    }

}
