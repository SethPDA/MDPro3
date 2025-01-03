namespace MDPro3.YGOSharp.Network.Enums
{
    public enum CtosMessage
    {
        Response = 0x1,
        UpdateDeck = 0x2,
        HandResult = 0x3,
        TpResult = 0x4,
        PlayerInfo = 0x10,
        CreateGame = 0x11,
        JoinGame = 0x12,
        LeaveGame = 0x13,
        Surrender = 0x14,
        TimeConfirm = 0x15,
        Chat = 0x16,
        HsToDuelist = 0x20,
        HsToObserver = 0x21,
        HsReady = 0x22,
        HsNotReady = 0x23,
        HsKick = 0x24,
        HsStart = 0x25
    }

    public enum PlayerChange
    {
        Observe = 0x8,
        Ready = 0x9,
        NotReady = 0xA,
        Leave = 0xB
    }
    public enum GameState
    {
        Lobby = 0,
        Hand = 1,
        Starting = 2,
        Duel = 3,
        End = 4,
        Side = 5
    }
    public enum PlayerState
    {
        None = 0,
        Response = 1
    }
    public enum PlayerType
    {
        Undefined = -1,
        Player1 = 0,
        Player2 = 1,
        Player3 = 2,
        Player4 = 3,
        Player5 = 4,
        Player6 = 5,
        Observer = 7,
        Host = 0x10,
        Red = 11,
        Green = 12,
        Blue = 13,
        BabyBlue = 14,
        Pink = 15,
        Yellow = 16,
        White = 17,
        Gray = 18
    }

    public enum StocMessage
    {
        GameMsg = 0x1,
        ErrorMsg = 0x2,
        SelectHand = 0x3,
        SelectTp = 0x4,
        HandResult = 0x5,
        TpResult = 0x6,
        ChangeSide = 0x7,
        WaitingSide = 0x8,
        DeckCount = 0x9,
        CreateGame = 0x11,
        JoinGame = 0x12,
        TypeChange = 0x13,
        LeaveGame = 0x14,
        DuelStart = 0x15,
        DuelEnd = 0x16,
        Replay = 0x17,
        TimeLimit = 0x18,
        Chat = 0x19,
        HsPlayerEnter = 0x20,
        HsPlayerChange = 0x21,
        HsWatchChange = 0x22,
        TeammateSurrender = 0x23
    }

}
