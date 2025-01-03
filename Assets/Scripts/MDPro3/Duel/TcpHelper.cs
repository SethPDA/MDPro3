using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using MDPro3.YGOSharp;
using MDPro3.YGOSharp.Network.Enums;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.Net;
using System.Net;

namespace MDPro3
{
    public static class TcpHelper
    {
        public static TcpClient tcpClient;
        private static NetworkStream networkStream;
        public static bool canJoin = true;
        public static bool onDisConnected;
        private static readonly List<byte[]> datas = new List<byte[]>();
        private static readonly object locker = new object();
        public static Deck deck;
        public static List<string> deckStrings = new List<string>();
        public static string lastRecordName = "";
        public static List<Package> packagesInRecord = new List<Package>();

        private static readonly Queue<Package> messageQueue = new Queue<Package>();
        static Thread senderThread;
        static Thread linkThread;

        public static int version = 0x1361;

        public static string joinedAddress;
        public static string joinedPort;
        public static string joinedPassword;


        public static bool LinkStart(string ipString, string name, string portString, string pswString, bool local, Action doWhenSuccess)
        {
            if(!canJoin)
                return false;

            linkThread?.Abort();

            canJoin = false;
            linkThread = new Thread(() => 
            {
                bool joined = false;
                if (local)
                {
                    while (YgoServer.ServerRunning() && !joined)
                    {
                        try
                        {
                            joined = Join(ipString, name, portString, pswString, doWhenSuccess);
                        }
                        catch (Exception ex)
                        {
                            Debug.LogException(ex);
                            joined = false;
                        }
                        Thread.Sleep(100);
                    }
                }
                else
                {
                    Join(ipString, name, portString, pswString, doWhenSuccess);
                }
                canJoin = true;
            });
            linkThread.Start();
            return true;
        }

        private static bool Join(string ipString, string name, string portString, string pswString, Action doWhenSuccess)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                onDisConnected = true;
                return false;
            }

            try
            {
                Debug.LogFormat("Try Address: {0}, Port: {1}, Password: {2}", ipString, portString, pswString);

                tcpClient = new TcpClientWithTimeout(ipString, int.Parse(portString), 3000).Connect();
                networkStream = tcpClient.GetStream();
                var t = new Thread(Receiver);
                t.Start();
                messageQueue.Clear();
                InitializeSender();
                CtosMessage_PlayerInfo(name);
                CtosMessage_JoinGame(pswString);
                joinedAddress = ipString;
                joinedPort = portString;
                joinedPassword = pswString;
                Program.instance.ocgcore.mycardDuel = joinedAddress == MyCard.duelUrl;
                doWhenSuccess?.Invoke();

                Debug.LogFormat("Joind Address: {0}, Port: {1}, Password: {2}", joinedAddress, joinedPort, joinedPassword);
                return true;
            }
            catch (Exception e)
            {
                //MessageManager.messageFromSubString = "JoinError: " + e;
                return false;
            }
        }
        public static void InitializeSender()
        {
            try
            {
                senderThread?.Abort();
                senderThread = new Thread(Sender)
                {
                    IsBackground = true
                };
                senderThread.Start();
            }
            catch
            {
                if (Program.instance.solo.showing)
                    MessageManager.messageFromSubString = InterString.Get("端口被占用， 请尝试修改端口后再尝试。端口号应大于0，小于65535。");
            }
        }

        public static void Receiver()
        {
            try
            {
                while (tcpClient != null
                    && networkStream != null
                    && tcpClient.Connected
                    && Program.Running
                    && !Program.instance.room.duelEnded)
                {
                    var data = SocketMaster.ReadPacket(networkStream);
                    AddDateJumoLine(data);
                }
                onDisConnected = true;
            }
            catch
            {
                onDisConnected = true;
            }
        }

        public static void AddDateJumoLine(byte[] data)
        {
            Monitor.Enter(datas);
            try
            {
                datas.Add(data);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
            Monitor.Exit(datas);
        }

        public static void PerFrameFunction()
        {
            if (datas.Count > 0)
                if (Monitor.TryEnter(datas))
                {
                    for (var i = 0; i < datas.Count; i++)
                        try
                        {
                            var memoryStream = new MemoryStream(datas[i]);
                            var r = new BinaryReader(memoryStream);
                            var ms = (StocMessage)r.ReadByte();
                            switch (ms)
                            {
                                case StocMessage.GameMsg:
                                    Program.instance.room.StocMessage_GameMsg(r);
                                    var p = new Package();
                                    p.Function = r.ReadByte();
                                    p.Data = new BinaryMaster(r.ReadToEnd());
                                    Program.instance.ocgcore.AddPackage(p);
                                    break;
                                case StocMessage.ErrorMsg:
                                    Program.instance.room.StocMessage_ErrorMsg(r);
                                    break;
                                case StocMessage.SelectHand:
                                    Program.instance.room.StocMessage_SelectHand(r);
                                    break;
                                case StocMessage.SelectTp:
                                    Program.instance.room.StocMessage_SelectTp(r);
                                    break;
                                case StocMessage.HandResult:
                                    Program.instance.room.StocMessage_HandResult(r);
                                    break;
                                case StocMessage.TpResult:
                                    Program.instance.room.StocMessage_TpResult(r);
                                    break;
                                case StocMessage.ChangeSide:
                                    Program.instance.room.StocMessage_ChangeSide(r);
                                    break;
                                case StocMessage.WaitingSide:
                                    Program.instance.room.StocMessage_WaitingSide(r);
                                    break;
                                case StocMessage.DeckCount:
                                    Program.instance.room.StocMessage_DeckCount(r);
                                    break;
                                case StocMessage.CreateGame:
                                    Program.instance.room.StocMessage_CreateGame(r);
                                    break;
                                case StocMessage.JoinGame:
                                    Program.instance.room.StocMessage_JoinGame(r);
                                    break;
                                case StocMessage.TypeChange:
                                    Program.instance.room.StocMessage_TypeChange(r);
                                    break;
                                case StocMessage.LeaveGame:
                                    Program.instance.room.StocMessage_LeaveGame(r);
                                    break;
                                case StocMessage.DuelStart:
                                    Program.instance.room.StocMessage_DuelStart(r);
                                    break;
                                case StocMessage.DuelEnd:
                                    Program.instance.room.StocMessage_DuelEnd(r);
                                    break;
                                case StocMessage.Replay:
                                    Program.instance.room.StocMessage_Replay(r);
                                    break;
                                case StocMessage.TimeLimit:
                                    Program.instance.ocgcore.StocMessage_TimeLimit(r);
                                    break;
                                case StocMessage.Chat:
                                    Program.instance.room.StocMessage_Chat(r);
                                    break;
                                case StocMessage.HsPlayerEnter:
                                    Program.instance.room.StocMessage_HsPlayerEnter(r);
                                    break;
                                case StocMessage.HsPlayerChange:
                                    Program.instance.room.StocMessage_HsPlayerChange(r);
                                    break;
                                case StocMessage.HsWatchChange:
                                    Program.instance.room.StocMessage_HsWatchChange(r);
                                    break;
                                case StocMessage.TeammateSurrender:
                                    Program.instance.ocgcore.StocMessage_TeammateSurrender();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            // Program.DEBUGLOG(e);
                        }

                    datas.Clear();
                    Monitor.Exit(datas);
                }

            if (onDisConnected)
            {
                if (tcpClient != null && tcpClient.Connected)
                {
                    try
                    {
                        tcpClient.Client.Shutdown(0);
                        tcpClient.Close();
                    }
                    catch { }
                }
                onDisConnected = false;
                tcpClient = null;
                canJoin = true;
                if (Program.instance.ocgcore.showing)
                {
                    Program.instance.ocgcore.ForceMSquit();
                    MessageManager.Cast(InterString.Get("对方已离开游戏，您现在可以离开。"));
                }
                else if (Program.instance.editDeck.showing)
                {
                    MessageManager.Cast(InterString.Get("对方已离开游戏，您现在可以离开。"));
                    Program.instance.ShiftToServant(Program.instance.online);
                }
                else if (!Program.instance.online.showing && !Program.instance.solo.showing)
                {
                    MessageManager.Cast(InterString.Get("连接被断开。"));
                    if (Program.instance.room.showing)
                        Program.instance.room.OnExit();
                }
            }
        }

        public static void Send(Package message)
        {
            lock (locker)
            {
                messageQueue.Enqueue(message);
            }
        }

        private static void Sender()
        {
            while (tcpClient != null && tcpClient.Connected)
            {
                senderThread.Join(100);
                Package currentMessage;
                lock (locker)
                {
                    if (messageQueue.Count == 0)
                    {
                        continue;
                    }
                    currentMessage = messageQueue.Dequeue();
                }
                try
                {
                    var data = currentMessage.Data.Get();
                    using (MemoryStream memstream = new MemoryStream())
                    {
                        using (BinaryWriter b = new BinaryWriter(memstream))
                        {
                            b.Write(BitConverter.GetBytes((short)(data.Length + 1)), 0, 2);
                            b.Write(BitConverter.GetBytes((byte)currentMessage.Function), 0, 1);
                            b.Write(data, 0, data.Length);
                        }
                        byte[] s = memstream.ToArray();
                        try
                        {
                            tcpClient.Client.Send(s);
                        }
                        catch (SocketException ex)
                        {
                            Debug.LogError($"Failed to send data: {ex.Message}");
                            onDisConnected = true;
                            break;
                        }
                    }
                }
                catch
                {
                    onDisConnected = true;
                    break;
                }
            }
        }

        #region CtosMessage
        public static void CtosMessage_Response(byte[] response)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.Response;
            message.Data.writer.Write(response);
            Send(message);
        }

        public static void CtosMessage_UpdateDeck(Deck deckFor)
        {
            if (deckFor.Main.Count == 0)
                return;
            deckStrings.Clear();
            deck = deckFor;
            var message = new Package();
            message.Function = (int)CtosMessage.UpdateDeck;
            message.Data.writer.Write(deckFor.Main.Count + deckFor.Extra.Count);
            message.Data.writer.Write(deckFor.Side.Count);
            for (var i = 0; i < deckFor.Main.Count; i++)
            {
                message.Data.writer.Write(deckFor.Main[i]);
                var c = CardsManager.Get(deckFor.Main[i]);
                deckStrings.Add(c.Name);
            }

            for (var i = 0; i < deckFor.Extra.Count; i++) message.Data.writer.Write(deckFor.Extra[i]);
            for (var i = 0; i < deckFor.Side.Count; i++) message.Data.writer.Write(deckFor.Side[i]);
            Send(message);
        }

        public static void CtosMessage_HandResult(int res)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HandResult;
            message.Data.writer.Write((byte)res);
            Send(message);
        }

        public static void CtosMessage_TpResult(bool tp)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.TpResult;
            if (tp)
                message.Data.writer.Write((byte)1);
            else
                message.Data.writer.Write((byte)0);
            Send(message);
        }

        public static void CtosMessage_PlayerInfo(string name)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.PlayerInfo;
            message.Data.writer.WriteUnicode(name, 20);
            Send(message);
        }

        public static void CtosMessage_CreateGame()
        {
        }

        public static void CtosMessage_JoinGame(string psw)
        {
            deckStrings.Clear();
            var message = new Package();
            message.Function = (int)CtosMessage.JoinGame;
            message.Data.writer.Write((short)Config.ClientVersion);
            message.Data.writer.Write((byte)204);
            message.Data.writer.Write((byte)204);
            message.Data.writer.Write(0);
            message.Data.writer.WriteUnicode(psw, 20);
            Send(message);
        }

        public static void CtosMessage_LeaveGame()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.LeaveGame;
            Send(message);
        }

        public static void CtosMessage_Surrender()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.Surrender;
            Send(message);
        }

        public static void CtosMessage_TimeConfirm()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.TimeConfirm;
            Send(message);
        }

        public static void CtosMessage_Chat(string str)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.Chat;
            message.Data.writer.WriteUnicode(str, str.Length + 1);
            Send(message);
        }

        public static void CtosMessage_HsToDuelist()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsToDuelist;
            Send(message);
        }

        public static void CtosMessage_HsToObserver()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsToObserver;
            Send(message);
        }

        public static void CtosMessage_HsReady()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsReady;
            Send(message);
        }

        public static void CtosMessage_HsNotReady()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsNotReady;
            Send(message);
        }

        public static void CtosMessage_HsKick(int pos)
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsKick;
            message.Data.writer.Write((byte)pos);
            Send(message);
        }

        public static void CtosMessage_HsStart()
        {
            var message = new Package();
            message.Function = (int)CtosMessage.HsStart;
            Send(message);
        }
        #endregion

        public static List<Package> ReadPackagesInRecord(string path)
        {
            List<Package> re = null;
            try
            {
                re = GetPackages(File.ReadAllBytes(path));
            }
            catch (Exception e)
            {
                re = new List<Package>();
                Debug.Log(e);
            }

            return re;
        }

        public static List<Package> GetPackages(byte[] buffer)
        {
            var re = new List<Package>();
            try
            {
                BinaryReader reader;
                using (reader = new BinaryReader(new MemoryStream(buffer)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        var p = new Package();
                        p.Function = reader.ReadByte();
                        p.Data = new BinaryMaster(reader.ReadBytes((int)reader.ReadUInt32()));
                        re.Add(p);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
            return re;
        }

        public static void SaveRecord(string replayName)
        {
            try
            {
                if (packagesInRecord.Count > 10)
                {
                    var write = false;
                    var i = 0;
                    var startI = 0;
                    foreach (var item in packagesInRecord)
                    {
                        i++;
                        try
                        {
                            if (item.Function == (int)GameMessage.Start)
                            {
                                write = true;
                                startI = i;
                            }

                            if (item.Function == (int)GameMessage.ReloadField)
                            {
                                write = true;
                                startI = i;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Log(e);
                        }
                    }
                    if (write)
                    {
                        if (startI > packagesInRecord.Count)
                            startI = packagesInRecord.Count;
                        packagesInRecord.Insert(startI, Program.instance.ocgcore.GetNamePacket());
                        if (File.Exists(Program.replayPath + replayName + Program.yrp3dExpansion))
                            File.Delete(Program.replayPath + replayName + Program.yrp3dExpansion);
                        var stream = File.Create(Program.replayPath + replayName + Program.yrp3dExpansion);
                        var writer = new BinaryWriter(stream);
                        int k = 0;
                        for (int j = startI - 1; j < packagesInRecord.Count; j++)
                        {
                            k++;
                            writer.Write((byte)packagesInRecord[j].Function);
                            writer.Write((uint)packagesInRecord[j].Data.GetLength());
                            writer.Write(packagesInRecord[j].Data.Get());
                        }
                        stream.Flush();
                        writer.Close();
                        stream.Close();
                        if (Program.instance.ocgcore.duelEnded)
                            packagesInRecord.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }

        public static void AddRecordLine(Package p)
        {
            if (Program.instance.ocgcore.condition != OcgCore.Condition.Replay)
                packagesInRecord.Add(p);
        }

        public static bool IsPortAvailable(int port)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    // 尝试绑定端口
                    socket.Bind(new IPEndPoint(IPAddress.Loopback, port));
                    return true; // 成功绑定，端口可用
                }
            }
            catch (SocketException)
            {
                return false; // 绑定失败，端口被占用
            }
        }
    }

    public class Package
    {
        public BinaryMaster Data;
        public int Function;

        public Package()
        {
            Function = (int)CtosMessage.Response;
            Data = new BinaryMaster();
        }
    }

    public class BinaryMaster
    {
        private MemoryStream memstream;
        public BinaryReader reader;
        public BinaryWriter writer;

        public BinaryMaster(byte[] raw = null)
        {
            if (raw == null)
                memstream = new MemoryStream();
            else
                memstream = new MemoryStream(raw);
            reader = new BinaryReader(memstream);
            writer = new BinaryWriter(memstream);
        }

        public void Set(byte[] raw)
        {
            memstream = new MemoryStream(raw);
            reader = new BinaryReader(memstream);
            writer = new BinaryWriter(memstream);
        }

        public byte[] Get()
        {
            var bytes = memstream.ToArray();
            return bytes;
        }

        public int GetLength()
        {
            return (int)memstream.Length;
        }

        public override string ToString()
        {
            var return_value = "";
            var bytes = Get();
            for (var i = 0; i < bytes.Length; i++)
            {
                return_value += ((int)bytes[i]).ToString();
                if (i < bytes.Length - 1) return_value += ",";
            }

            return return_value;
        }
    }

    public static class BinaryExtensions
    {
        public static void WriteUnicode(this BinaryWriter writer, string text, int len)
        {
            try
            {
                var unicode = Encoding.Unicode.GetBytes(text);
                var result = new byte[len * 2];
                for (var i = 0; i < result.Length; i++) result[i] = 204;
                var max = len * 2 - 2;
                Array.Copy(unicode, result, unicode.Length > max ? max : unicode.Length);
                result[unicode.Length] = 0;
                result[unicode.Length + 1] = 0;
                writer.Write(result);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }

        public static string ReadUnicode(this BinaryReader reader, int len)
        {
            var unicode = reader.ReadBytes(len * 2);
            var text = Encoding.Unicode.GetString(unicode);
            text = text.Substring(0, text.IndexOf('\0'));
            return text;
        }

        public static string ReadALLUnicode(this BinaryReader reader)
        {
            var unicode = reader.ReadToEnd();
            var text = Encoding.Unicode.GetString(unicode);
            text = text.Substring(0, text.IndexOf('\0'));
            return text;
        }

        public static byte[] ReadToEnd(this BinaryReader reader)
        {
            return reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
        }

        public static GPS ReadGPS(this BinaryReader reader)
        {
            var a = new GPS();
            a.controller = (uint)Program.instance.ocgcore.LocalPlayer(reader.ReadByte());
            a.location = reader.ReadByte();
            a.sequence = reader.ReadByte();
            a.position = reader.ReadByte();
            return a;
        }

        public static GPS ReadShortGPS(this BinaryReader reader)
        {
            var a = new GPS();
            a.controller = (uint)Program.instance.ocgcore.LocalPlayer(reader.ReadByte());
            a.location = reader.ReadByte();
            a.sequence = reader.ReadByte();
            a.position = (int)CardPosition.FaceUpAttack;
            return a;
        }

        public static void ReadCardData(this BinaryReader r, GameCard cardTemp = null)
        {
            var cardToRefresh = cardTemp;
            var flag = r.ReadInt32();
            var code = 0;
            var gps = new GPS();

            if ((flag & (int)Query.Code) != 0)
                code = r.ReadInt32();
            if ((flag & (int)Query.Position) != 0)
            {
                gps = r.ReadGPS();
                cardToRefresh = Program.instance.ocgcore.GCS_Get(gps);
            }


            if (cardToRefresh == null)
            {
                //if(code != 0)
                //    Debug.Log("TcpHelper未找到：" + CardsManager.Get(code).Name);
                return;
            }

            var data = cardToRefresh.GetData();

            if ((flag & (int)Query.Code) != 0)
                if (data.Id != code)
                {
                    data = CardsManager.Get(code);
                    data.Id = code;
                }
            if ((flag & (int)Query.Position) != 0) cardToRefresh.p = gps;
            if (data.Id > 0)
                if ((cardToRefresh.p.location & (uint)CardLocation.Hand) > 0)
                    if (cardToRefresh.p.controller == 1)
                        cardToRefresh.p.position = (int)CardPosition.FaceUpAttack;

            if ((flag & (int)Query.Alias) != 0)
                data.Alias = r.ReadInt32();
            if ((flag & (int)Query.Type) != 0)
                data.Type = r.ReadInt32();

            var l1 = 0;
            if ((flag & (int)Query.Level) != 0) l1 = r.ReadInt32();
            var l2 = 0;
            if ((flag & (int)Query.Rank) != 0) l2 = r.ReadInt32();

            if ((flag & (int)Query.Attribute) != 0)
                data.Attribute = r.ReadInt32();
            if ((flag & (int)Query.Race) != 0)
                data.Race = r.ReadInt32();
            if ((flag & (int)Query.Attack) != 0)
                data.Attack = r.ReadInt32();
            if ((flag & (int)Query.Defence) != 0)
                data.Defense = r.ReadInt32();
            if ((flag & (int)Query.BaseAttack) != 0)
                data.rAttack = r.ReadInt32();
            if ((flag & (int)Query.BaseDefence) != 0)
                data.rDefense = r.ReadInt32();
            if ((flag & (int)Query.Reason) != 0)
                data.Reason = r.ReadInt32();
            if ((flag & (int)Query.ReasonCard) != 0)
                data.ReasonCard = r.ReadInt32();
            if ((flag & (int)Query.EquipCard) != 0)
                cardToRefresh.AddTarget(Program.instance.ocgcore.GCS_Get(r.ReadGPS()));
            if ((flag & (int)Query.TargetCard) != 0)
            {
                var count = r.ReadInt32();
                for (var i = 0; i < count; ++i)
                    cardToRefresh.AddTarget(Program.instance.ocgcore.GCS_Get(r.ReadGPS()));
            }

            if ((flag & (int)Query.OverlayCard) != 0)
            {
                var overs = Program.instance.ocgcore.GCS_GetOverlays(cardToRefresh);
                var count = r.ReadInt32();
                for (var i = 0; i < count; ++i)
                    if (i < overs.Count)
                        overs[i].SetCode(r.ReadInt32());
                    else
                        r.ReadInt32();
            }
            if ((flag & (int)Query.Counters) != 0)
            {
                var count = r.ReadInt32();
                for (var i = 0; i < count; ++i)
                    r.ReadInt32();
            }

            if ((flag & (int)Query.Owner) != 0)
                r.ReadInt32();
            if ((flag & (int)Query.Status) != 0)
            {
                var status = r.ReadInt32();
                cardToRefresh.Disabled = (status & 0x0001) == 0x0001;
                cardToRefresh.SemiNomiSummoned = (status & 0x0008) == 0x0008;
            }

            if ((flag & (int)Query.LScale) != 0)
                data.LScale = r.ReadInt32();
            if ((flag & (int)Query.RScale) != 0)
                data.RScale = r.ReadInt32();
            var l3 = 0;
            if ((flag & (int)Query.Link) != 0)
            {
                l3 = r.ReadInt32(); //link value
                data.LinkMarker = r.ReadInt32();
            }

            if ((flag & (int)Query.Level) != 0 || (flag & (int)Query.Rank) != 0 || (flag & (int)Query.Link) != 0)
            {
                if (l1 > l2)
                    data.Level = l1;
                else
                    data.Level = l2;
                if (l3 > data.Level)
                    data.Level = l3;
            }
            cardToRefresh.SetData(data);
        }
    }

    public class SocketMaster
    {
        private static byte[] ReadFull(NetworkStream stream, int length)
        {
            var buf = new byte[length];
            var rlen = 0;
            while (rlen < buf.Length)
            {
                var currentLength = stream.Read(buf, rlen, buf.Length - rlen);
                rlen += currentLength;
                if (currentLength == 0)
                {
                    TcpHelper.onDisConnected = true;
                    break;
                }
            }
            return buf;
        }

        public static byte[] ReadPacket(NetworkStream stream)
        {
            var hdr = ReadFull(stream, 2);
            var plen = BitConverter.ToUInt16(hdr, 0);
            var buf = ReadFull(stream, plen);
            return buf;
        }
    }

    public class TcpClientWithTimeout
    {
        protected string _hostname;
        protected int _port;
        protected int _timeout_milliseconds;
        protected bool connected;
        protected TcpClient connection;
        protected Exception exception;

        public TcpClientWithTimeout(string hostname, int port, int timeout_milliseconds)
        {
            _hostname = hostname;
            _port = port;
            _timeout_milliseconds = timeout_milliseconds;
        }

        public TcpClient Connect()
        {
            // kick off the thread that tries to connect
            connected = false;
            exception = null;
            var thread = new Thread(BeginConnect);
            thread.IsBackground = true; // 作为后台线程处理
                                        // 不会占用机器太长的时间
            thread.Start();

            // 等待如下的时间
            thread.Join(_timeout_milliseconds);

            if (connected)
            {
                // 如果成功就返回TcpClient对象
                thread.Abort();
                return connection;
            }

            if (exception != null)
            {
                // 如果失败就抛出错误
                thread.Abort();
                TcpHelper.onDisConnected = true;
                throw exception;
            }

            // 同样地抛出错误
            thread.Abort();
            var message = string.Format("TcpClient connection to {0}:{1} timed out",
                _hostname, _port);
            TcpHelper.onDisConnected = true;
            throw new TimeoutException(message);
        }

        protected void BeginConnect()
        {
            try
            {
                connection = new TcpClient(_hostname, _port);
                // 标记成功，返回调用者
                connected = true;
            }
            catch (Exception ex)
            {
                // 标记失败
                exception = ex;
            }
        }



    }


}
