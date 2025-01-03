using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.UI;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.Net;
using TMPro;
using UnityEngine.EventSystems;
using static MDPro3.UI.ChatPanel;

namespace MDPro3
{
    public class Room : Servant
    {
        [Header("Room")]
        private List<SelectionButton_RoomPlayer> roomPlayers;

        public static uint lfList;
        public static byte rule;
        public static byte mode;
        public static bool noCheckDeck;
        public static bool noShuffleDeck;
        public static int startLp = 8000;
        public static byte startHand;
        public static byte drawCount;
        public static short timeLimit = 180;
        public static int observerCount;
        public static int selfType;
        public static bool isHost;
        public static bool needSide;
        public static bool joinWithReconnect;
        public static bool sideWaitingObserver;
        public static bool fromSolo;
        public static bool soloLockHand;
        public static bool fromLocalHost;
        public static int coreShowing = 0;
        public class Player
        {
            public string name = "";
            public bool ready;
        }
        public static Player[] players = new Player[32];

        Deck deck;

        public bool duelEnded;

        #region Servant
        public override void Initialize()
        {
            depth = 2;
            showLine = false;
            returnServant = Program.instance.online;
            base.Initialize();
            roomPlayers = new List<SelectionButton_RoomPlayer>()
            {
                Manager.GetElement<SelectionButton_RoomPlayer>("ButtonPlayer0"),
                Manager.GetElement<SelectionButton_RoomPlayer>("ButtonPlayer1"),
                Manager.GetElement<SelectionButton_RoomPlayer>("ButtonPlayer2"),
                Manager.GetElement<SelectionButton_RoomPlayer>("ButtonPlayer3")
            };

            transform.GetChild(0).gameObject.SetActive(false);
        }
        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            coreShowing = 0;
            Program.instance.ui_.chatPanel.Show(false);
            Program.instance.ocgcore.handler = Handler;

             var deckName = Config.Get("DeckInUse", "@ui");
            if (File.Exists(Program.deckPath + deckName + Program.ydkExpansion))
                deck = new Deck(Program.deckPath + deckName + Program.ydkExpansion);
            else
            {
                deck = null;
                deckName = InterString.Get("请点击此处选择卡组");
            }
            Manager.GetElement<SelectionButton_DeckSelector>("DeckSelector").SetDeck(deck, deckName);
            Realize();
        }
        protected override void ApplyHideArrangement(int preDepth)
        {
            Program.instance.ui_.chatPanel.Hide();
            base.ApplyHideArrangement(preDepth);
        }
        public override void OnExit()
        {
            if (fromSolo)
                returnServant = Program.instance.solo;
            else
            {
                returnServant = Program.instance.online;
                if (fromLocalHost)
                    YgoServer.StopServer();
            }
            base.OnExit();
            Program.instance.ocgcore.CloseConnection();
        }
        public override void SelectLastSelectable()
        {
            var selected = EventSystem.current.currentSelectedGameObject;
            if (selected == null || selected != Selected)
            {
                if(Selected != null && Selected.gameObject.activeInHierarchy)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonToDuel"));
            }
        }

        protected override bool NeedResponseInput()
        {
            if (Program.instance.ui_.chatPanel.input.isFocused)
                return false;
            return base.NeedResponseInput();
        }
        #endregion

        public void SelectMiddleSelectableFromRight()
        {
            if (!showing)
                return;
            UserInput.NextSelectionIsAxis = true;

            if (Manager.GetElement("ButtonStart").activeInHierarchy)
                EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonStart"));
            else
                EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonToWatch"));
        }

        public void OnReady()
        {
            if (players[selfType] == null)
                return;
            if (players[selfType].ready)
                TcpHelper.CtosMessage_HsNotReady();
            else
            {
                if (File.Exists("Deck/" + Config.Get("DeckInUse", "") + Program.ydkExpansion))
                {
                    TcpHelper.CtosMessage_UpdateDeck(new Deck(Program.deckPath + Config.Get("DeckInUse", "") + Program.ydkExpansion));
                    TcpHelper.CtosMessage_HsReady();
                }
                else
                    MessageManager.Cast(InterString.Get("请先选择有效的卡组。"));
            }
        }

        public void Handler(byte[] buffer)
        {
            TcpHelper.CtosMessage_Response(buffer);
        }

        public void OnSelectAI()
        {
            if (RoomIsFull())
            {
                MessageManager.Cast(InterString.Get("房间已满，无法继续添加AI。"));
            }
            else
            {
                Program.instance.solo.SwitchCondition(Solo.Condition.ForRoom);
                Program.instance.ShiftToServant(Program.instance.solo);
            }
        }

        private bool RoomIsFull()
        {
            int playerSeats = 2;
            if (mode == 2)
                playerSeats = 4;

            for (int i = 0; i < playerSeats; i++)
                if (players[i] == null)
                    return false;
            return true;
        }


        public void OnToDuel()
        {
            TcpHelper.CtosMessage_HsToDuelist();
        }
        public void OnToObserver()
        {
            TcpHelper.CtosMessage_HsToObserver();
        }
        public void OnStart()
        {
            TcpHelper.CtosMessage_HsStart();
        }

        public void OnSelectDeck()
        {
            if (players[selfType] != null && players[selfType].ready)
            {
                MessageManager.Cast(InterString.Get("请先取消准备，再选择卡组。"));
                return;
            }
            Program.instance.selectDeck.SwitchCondition(SelectDeck.Condition.ForDuel);
            Program.instance.ShiftToServant(Program.instance.selectDeck);
        }

        public void OnKick(int player)
        {
            TcpHelper.CtosMessage_HsKick(player);
        }

        private void Realize()
        {
            var roomInfo = string.Empty;
            var rn = "\r\n";
            if (fromLocalHost)
            {
                foreach(var ip in Tools.GetLocalIPv4())
                    roomInfo += InterString.Get("本机地址：") + ip + rn;
                roomInfo += InterString.Get("端口：") + "7911" + rn;
            }
            roomInfo += StringHelper.GetUnsafe(1227) + StringHelper.GetUnsafe(1244 + mode) + rn;//决斗模式：
            roomInfo += StringHelper.GetUnsafe(1236) + StringHelper.GetUnsafe(1259 + Program.instance.ocgcore.MasterRule) + rn;//规则：
            roomInfo += StringHelper.GetUnsafe(1225) + StringHelper.GetUnsafe(1481 + rule) + rn;//卡片允许：
            roomInfo += StringHelper.GetUnsafe(1226) + BanlistManager.GetName(lfList) + rn;//禁限卡表
            roomInfo += StringHelper.GetUnsafe(1231) + startLp + rn;//初始基本分：
            roomInfo += StringHelper.GetUnsafe(1232) + startHand + rn;//初始手卡数：
            roomInfo += StringHelper.GetUnsafe(1233) + drawCount + rn;//每回合抽卡：
            roomInfo += StringHelper.GetUnsafe(1237) + timeLimit + rn;//每回合时间：
            roomInfo += StringHelper.GetUnsafe(1253) + observerCount + rn;//当前观战人数：
            if (noCheckDeck) roomInfo += StringHelper.GetUnsafe(1229) + rn;//不检查卡组
            if (noShuffleDeck) roomInfo += StringHelper.GetUnsafe(1230);//不洗切卡组
            Manager.GetElement<TextMeshProUGUI>("RoomInfo").text = roomInfo;

            if (!Appearance.loaded)
                return;

            for (int i = 0; i < 4; i++)
            {
                if (players[i] == null)
                    roomPlayers[i].gameObject.SetActive(false);
                else
                {
                    roomPlayers[i].gameObject.SetActive(true);
                    roomPlayers[i].SetButtonText(players[i].name);
                    roomPlayers[i].SetReadyIcon(players[i].ready);
                    roomPlayers[i].SetButtonTextColor(selfType == i ? Color.cyan : Color.white);

                    var position = GetPlayerPositon(i);
                    switch (position)
                    {
                        case PlayerPosition.Me:
                            roomPlayers[i].GetAvatar().material = Appearance.duelFrameMat0;
                            roomPlayers[i].GetAvatar().sprite = Appearance.duelFace0;
                            break;
                        case PlayerPosition.MyTag:
                            roomPlayers[i].GetAvatar().material = Appearance.duelFrameMat0Tag;
                            roomPlayers[i].GetAvatar().sprite = Appearance.duelFace0Tag;
                            break;
                        case PlayerPosition.Op:
                            roomPlayers[i].GetAvatar().material = Appearance.duelFrameMat1;
                            roomPlayers[i].GetAvatar().sprite = Appearance.duelFace1;
                            break;
                        case PlayerPosition.OpTag:
                            roomPlayers[i].GetAvatar().material = Appearance.duelFrameMat1Tag;
                            roomPlayers[i].GetAvatar().sprite = Appearance.duelFace1Tag;
                            break;
                        case PlayerPosition.WatchMe:
                            roomPlayers[i].GetAvatar().material = Appearance.watchFrameMat0;
                            roomPlayers[i].GetAvatar().sprite = Appearance.watchFace0;
                            break;
                        case PlayerPosition.WatchMyTag:
                            roomPlayers[i].GetAvatar().material = Appearance.watchFrameMat0Tag;
                            roomPlayers[i].GetAvatar().sprite = Appearance.watchFace0Tag;
                            break;
                        case PlayerPosition.WatchOp:
                            roomPlayers[i].GetAvatar().material = Appearance.watchFrameMat1;
                            roomPlayers[i].GetAvatar().sprite = Appearance.watchFace1;
                            break;
                        case PlayerPosition.WatchOpTag:
                            roomPlayers[i].GetAvatar().material = Appearance.watchFrameMat1Tag;
                            roomPlayers[i].GetAvatar().sprite = Appearance.watchFace1Tag;
                            break;
                    }
                }
            }
            if (isHost)
            {
                Manager.GetElement("ButtonStart").SetActive(true);
                Manager.GetElement("ButtonAddBot").SetActive(true);
            }
            else
            {
                Manager.GetElement("ButtonStart").SetActive(false);
                Manager.GetElement("ButtonAddBot").SetActive(false);
            }

            if (fromSolo)
                Manager.GetElement("ButtonAddBot").SetActive(false);

            if (selfType == 7)
                Manager.GetElement("ButtonReady").SetActive(false);
            else
                Manager.GetElement("ButtonReady").SetActive(true);

            SelectLastSelectable();
        }

        private void ShowOcgCore()
        {
            if(coreShowing == 0)
                coreShowing = 1;
            if (Program.instance.ocgcore.showing)
                return;
            if (mode != 2)
            {
                if (selfType == 7)
                {
                    Program.instance.ocgcore.name_0 = GetPlayerName(0);
                    Program.instance.ocgcore.name_1 = GetPlayerName(1);
                }
                else
                {
                    Program.instance.ocgcore.name_0 = GetPlayerName(selfType);
                    Program.instance.ocgcore.name_1 = GetPlayerName(1 - selfType);
                }
                Program.instance.ocgcore.name_0_c = Program.instance.ocgcore.name_0;
                Program.instance.ocgcore.name_1_c = Program.instance.ocgcore.name_1;
                Program.instance.ocgcore.name_0_tag = "---";
                Program.instance.ocgcore.name_1_tag = "---";
            }
            else
            {
                if (selfType == 7)
                {
                    Program.instance.ocgcore.name_0 = GetPlayerName(0);
                    Program.instance.ocgcore.name_0_tag = GetPlayerName(1);
                    Program.instance.ocgcore.name_1 = GetPlayerName(2);
                    Program.instance.ocgcore.name_1_tag = GetPlayerName(3);
                }
                else
                {
                    int op = 0;
                    int opTag = 0;
                    switch (selfType)
                    {
                        case 0:
                        case 1:
                            op = 2;
                            opTag = 3;
                            break;
                        case 2:
                        case 3:
                            op = 0;
                            opTag = 1;
                            break;
                    }
                    Program.instance.ocgcore.name_0 = GetPlayerName((selfType == 0 || selfType == 2) ? selfType : selfType - 1);
                    Program.instance.ocgcore.name_0_tag = GetPlayerName((selfType == 0 || selfType == 2) ? selfType + 1 : selfType);
                    Program.instance.ocgcore.name_1 = GetPlayerName(op);
                    Program.instance.ocgcore.name_1_tag = GetPlayerName(opTag);
                }
            }
            Program.instance.ocgcore.timeLimit = timeLimit;
            Program.instance.ocgcore.lpLimit = startLp;
            if(fromSolo)
                Program.instance.ocgcore.returnServant = Program.instance.solo;
            else
                Program.instance.ocgcore.returnServant = Program.instance.online;
            if (selfType == 7)
                Program.instance.ocgcore.condition = OcgCore.Condition.Watch;
            else
                Program.instance.ocgcore.condition = OcgCore.Condition.Duel;
            Program.instance.ocgcore.inAi = false;
            Program.instance.ShiftToServant(Program.instance.ocgcore);
        }

        #region STOC
        public void StocMessage_GameMsg(BinaryReader r)
        {
            ShowOcgCore();
            var p = new Package();
            p.Function = r.ReadByte();
            p.Data = new BinaryMaster(r.ReadToEnd());
            Program.instance.ocgcore.AddPackage(p);
        }

        public void StocMessage_ErrorMsg(BinaryReader r)
        {
            int msg = r.ReadByte();
            r.ReadByte();
            r.ReadByte();
            r.ReadByte();
            var code = r.ReadInt32();
            switch (msg)
            {
                case 1:
                    switch (code)
                    {
                        case 0:
                            MessageManager.Cast(StringHelper.GetUnsafe(1403));
                            break;
                        case 1:
                            MessageManager.Cast(StringHelper.GetUnsafe(1404));
                            break;
                        case 2:
                            MessageManager.Cast(StringHelper.GetUnsafe(1405));
                            break;
                    }
                    break;
                case 2:
                    var flag = code >> 28;
                    code &= 0xFFFFFFF;
                    var cardName = CardsManager.Get(code).Name;
                    List<string> tasks = new List<string>() { StringHelper.GetUnsafe(1406) };
                    var task = "";
                    switch (flag)
                    {
                        case 1:
                            task = StringHelper.GetUnsafe(1407);//「%ls」的数量不符合当前禁限卡表设定。
                            var replace = new Regex("%ls");
                            task = replace.Replace(task, cardName);
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            task = StringHelper.GetUnsafe(1411 + flag);
                            replace = new Regex("%ls");
                            task = replace.Replace(task, cardName);
                            if(flag == 4)
                            {
                                replace = new Regex("%d");
                                task = replace.Replace(task, code.ToString());
                            }
                            break;
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            task = StringHelper.GetUnsafe(1411 + flag);
                            replace = new Regex("%d");
                            var target = "";
                            if (flag == 6)
                                target = deck.Main.Count.ToString();
                            else if (flag == 7)
                                target = deck.Extra.Count.ToString();
                            else if (flag == 8)
                                target = deck.Side.Count.ToString();
                            task = replace.Replace(task, target);
                            break;
                        default:
                            task = StringHelper.GetUnsafe(1406);
                            break;
                    }
                    //task = task.Replace("(%d)", "");
                    tasks.Add(task);
                    UIManager.ShowPopupConfirm(tasks);
                    break;
                case 3:
                    tasks = new List<string>()
                    {
                        StringHelper.GetUnsafe(1408),
                        StringHelper.GetUnsafe(1410),
                    };
                    UIManager.ShowPopupConfirm(tasks);
                    break;
                case 4:
                    Debug.Log("ERROR 4: " + code);
                    break;
            }
        }
        public void StocMessage_SelectHand(BinaryReader r)
        {
            if (soloLockHand || Config.Get("AutoRPS", "0") == "0")
            {
                var handle = Addressables.InstantiateAsync("PopupRockPaperScissors");
                handle.Completed += (result) =>
                {
                    result.Result.transform.SetParent(Program.instance.ui_.popup, false);
                    var popupRPS = result.Result.GetComponent<UI.Popup.PopupRockPaperScissors>();
                    popupRPS.args = new List<string> { InterString.Get("猜拳") };
                    popupRPS.Show();
                };
            }
            else
                TcpHelper.CtosMessage_HandResult(Random.Range(1, 4));
        }

        public void StocMessage_SelectTp(BinaryReader r)
        {
            List<string> selections = new List<string>
            {
                Program.instance.currentServant == Program.instance.room ?
                InterString.Get("猜拳获胜") :
                InterString.Get("选择先后手"),
                InterString.Get("选择是否由我方先手？"),
                InterString.Get("先攻"),
                InterString.Get("后攻")
            };
            UIManager.ShowPopupYesOrNo(selections, () => { GoFirst(true); }, () => { GoFirst(false); });
        }

        private void GoFirst(bool first)
        {
            TcpHelper.CtosMessage_TpResult(first);
        }

        public void StocMessage_HandResult(BinaryReader r)
        {
            if (selfType == 7)
                return;

            int meResult = r.ReadByte();
            int opResult = r.ReadByte();
            if (meResult == opResult)
                MessageManager.Cast(InterString.Get("猜拳平局。"));
            else if (meResult == 1 && opResult == 2
                || meResult == 2 && opResult == 3
                || meResult == 3 && opResult == 1)
                MessageManager.Cast(InterString.Get("猜拳落败。"));
        }

        public void StocMessage_TpResult(BinaryReader r)
        {
        }

        public void StocMessage_ChangeSide(BinaryReader r)
        {
            needSide = true;
            if (Program.instance.ocgcore.condition != OcgCore.Condition.Duel || joinWithReconnect)
                Program.instance.ocgcore.OnDuelResultConfirmed();
        }

        public void StocMessage_WaitingSide(BinaryReader r)
        {
            sideWaitingObserver = true;
            MessageManager.Cast(InterString.Get("请耐心等待双方玩家更换副卡组。"));
        }

        public void StocMessage_DeckCount(BinaryReader r)
        {
        }

        public void StocMessage_CreateGame(BinaryReader r)
        {
        }

        public void StocMessage_JoinGame(BinaryReader r)
        {
            lfList = r.ReadUInt32();
            rule = r.ReadByte();
            mode = r.ReadByte();
            Program.instance.ocgcore.MasterRule = r.ReadChar();
            noCheckDeck = r.ReadBoolean();
            noShuffleDeck = r.ReadBoolean();
            r.ReadByte();
            r.ReadByte();
            r.ReadByte();
            startLp = r.ReadInt32();
            startHand = r.ReadByte();
            drawCount = r.ReadByte();
            timeLimit = r.ReadInt16();

            for (int i = 0; i < 4; i++)
                players[i] = null;
            Program.instance.ShiftToServant(Program.instance.room);
        }

        public void StocMessage_TypeChange(BinaryReader r)
        {
            int type = r.ReadByte();
            selfType = type & 0xF;
            isHost = ((type >> 4) & 0xF) != 0;
            if (selfType < 4 && players[selfType] != null)
                players[selfType].ready = false;
            Realize();
        }

        public void StocMessage_LeaveGame(BinaryReader r)
        {
        }

        public void StocMessage_DuelStart(BinaryReader r)
        {
            needSide = false;
            joinWithReconnect = true;
            if (Program.instance.editDeck.showing)
            {
                Program.instance.editDeck.Hide(0);
                MessageManager.Cast(InterString.Get("更换副卡组成功，请等待对手更换副卡组。"));
            }

            if (showing)
                Hide(0);
        }
        public void StocMessage_DuelEnd(BinaryReader r)
        {
            duelEnded = true;
            Program.instance.ocgcore.ForceMSquit();
        }

        public void StocMessage_Replay(BinaryReader r)
        {
            var data = r.ReadToEnd();
            var p = new Package();
            p.Function = (int)GameMessage.sibyl_replay;
            p.Data.writer.Write(data);
            TcpHelper.AddRecordLine(p);
        }

        public void StocMessage_Chat(BinaryReader r)
        {

            int player = r.ReadInt16();
            var length = r.BaseStream.Length - 3;
            var content = r.ReadUnicode((int)length);
            //Debug.Log("StocMessage_Chat: " + player + "-" + content);

            Program.instance.ui_.chatPanel.AddChatItem(player, content);
        }

        public void StocMessage_HsPlayerEnter(BinaryReader r)
        {
            AudioManager.PlaySE("SE_ROOM_SITDOWN");
            var name = r.ReadUnicode(20);
            var pos = r.ReadByte() & 3;
            var player = new Player();
            player.name = name;
            player.ready = false;
            players[pos] = player;
            Realize();
        }

        public void StocMessage_HsPlayerChange(BinaryReader r)
        {
            int status = r.ReadByte();
            var pos = (status >> 4) & 0xF;
            var state = status & 0xF;
            if (pos < 4)
            {
                if (state < 8)
                {
                    players[state] = players[pos];
                    players[pos] = null;
                }
                if (state == 0x9)
                    players[pos].ready = true;
                if (state == 0xA)
                    players[pos].ready = false;
                if (state == 0xB)
                    players[pos] = null;
                if (state == 0x8)
                {
                    players[pos] = null;
                    observerCount++;
                }
                Realize();
            }
        }

        public void StocMessage_HsWatchChange(BinaryReader r)
        {
            observerCount = r.ReadUInt16();
            Realize();
        }
        #endregion
    }
}
