using Meisui.Random;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Percy
{
    internal class Deck
    {
        public List<int> Main = new List<int>();
        public List<int> Extra = new List<int>();
        public List<int> Side = new List<int>();
    }
    internal class Package
    {
        public BinaryMaster Data;
        public int Fuction;

        public Package()
        {
            Fuction = 0;
            Data = new BinaryMaster();
        }
    }

    internal class BinaryMaster
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

    internal enum GameMessage
    {
        Retry = 1,
        Hint = 2,
        Waiting = 3,
        Start = 4,
        Win = 5,
        UpdateData = 6,
        UpdateCard = 7,
        RequestDeck = 8,
        SelectBattleCmd = 10,
        SelectIdleCmd = 11,
        SelectEffectYn = 12,
        SelectYesNo = 13,
        SelectOption = 14,
        SelectCard = 15,
        SelectChain = 16,
        SelectPlace = 18,
        SelectPosition = 19,
        SelectTribute = 20,
        SortChain = 21,
        SelectCounter = 22,
        SelectSum = 23,
        SelectDisfield = 24,
        SortCard = 25,
        SelectUnselectCard = 26,
        ConfirmDecktop = 30,
        ConfirmCards = 31,
        ShuffleDeck = 32,
        ShuffleHand = 33,
        RefreshDeck = 34,
        SwapGraveDeck = 35,
        ShuffleSetCard = 36,
        ReverseDeck = 37,
        DeckTop = 38,
        ShuffleExtra = 39,
        NewTurn = 40,
        NewPhase = 41,
        ConfirmExtratop = 42,
        Move = 50,
        PosChange = 53,
        Set = 54,
        Swap = 55,
        FieldDisabled = 56,
        Summoning = 60,
        Summoned = 61,
        SpSummoning = 62,
        SpSummoned = 63,
        FlipSummoning = 64,
        FlipSummoned = 65,
        Chaining = 70,
        Chained = 71,
        ChainSolving = 72,
        ChainSolved = 73,
        ChainEnd = 74,
        ChainNegated = 75,
        ChainDisabled = 76,
        CardSelected = 80,
        RandomSelected = 81,
        BecomeTarget = 83,
        Draw = 90,
        Damage = 91,
        Recover = 92,
        Equip = 93,
        LpUpdate = 94,
        Unequip = 95,
        CardTarget = 96,
        CancelTarget = 97,
        PayLpCost = 100,
        AddCounter = 101,
        RemoveCounter = 102,
        Attack = 110,
        Battle = 111,
        AttackDiabled = 112,
        DamageStepStart = 113,
        DamageStepEnd = 114,
        MissedEffect = 120,
        BeChainTarget = 121,
        CreateRelation = 122,
        ReleaseRelation = 123,
        TossCoin = 130,
        TossDice = 131,
        RockPaperScissors = 132,
        HandResult = 133,
        AnnounceRace = 140,
        AnnounceAttrib = 141,
        AnnounceCard = 142,
        AnnounceNumber = 143,
        CardHint = 160,
        TagSwap = 161,
        ReloadField = 162,
        AiName = 163,
        ShowHint = 164,
        PlayerHint = 165,
        MatchKill = 170,
        CustomMsg = 180,
        DuelWinner = 200
    }
    internal enum CardLocation
    {
        Deck = 0x01,
        Hand = 0x02,
        MonsterZone = 0x04,
        SpellZone = 0x08,
        Grave = 0x10,
        Removed = 0x20,
        Extra = 0x40,
        Overlay = 0x80,
        Onfield = 0x0C
    }
    internal enum CardPosition
    {
        FaceUpAttack = 0x1,
        FaceDownAttack = 0x2,
        FaceUpDefence = 0x4,
        FaceDownDefence = 0x8,
        FaceUp = 0x5,
        FaceDown = 0xA,
        Attack = 0x3,
        Defence = 0xC
    }
    internal enum CardReason
    {
        DESTROY = 0x1,
        RELEASE = 0x2,
        TEMPORARY = 0x4,
        MATERIAL = 0x8,
        SUMMON = 0x10,
        BATTLE = 0x20,
        EFFECT = 0x40,
        COST = 0x80,
        ADJUST = 0x100,
        LOST_TARGET = 0x200,
        RULE = 0x400,
        SPSUMMON = 0x800,
        DISSUMMON = 0x1000,
        FLIP = 0x2000,
        DISCARD = 0x4000,
        RDAMAGE = 0x8000,
        RRECOVER = 0x10000,
        RETURN = 0x20000,
        FUSION = 0x40000,
        SYNCHRO = 0x80000,
        RITUAL = 0x100000,
        XYZ = 0x200000,
        REPLACE = 0x1000000,
        DRAW = 0x2000000,
        REDIRECT = 0x4000000
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CardData
    {
        public int Code;
        public int Alias;
        public fixed short Setcode[16];
        public int Type;
        public int Level;
        public int Attribute;
        public int Race;
        public int Attack;
        public int Defense;
        public int LScale;
        public int RScale;
        public int LinkMarker;

        public void ConvertLongToSetCode(long value)
        {
            Setcode[0] = (short)(value & 0xFFFF);
            Setcode[1] = (short)((value >> 16) & 0xFFFF);
            Setcode[2] = (short)((value >> 32) & 0xFFFF);
            Setcode[3] = (short)((value >> 48) & 0xFFFF);
        }
    }
    public struct ScriptData
    {
        public IntPtr buffer;
        public int len;
    }

    internal static unsafe class Dll
    {
        private static Ygopro.CardHandler card_handler;
        private static Ygopro.ScriptHandler script_handler;
        private static Ygopro.ChatHandler chat_handler;
        private static readonly byte[] _buffer_2 = new byte[256];

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr ScriptReader(string scriptName, int* len);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint CardReader(uint code, CardData* pData);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint MessageHandler(IntPtr pDuel, uint messageType);

        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void set_card_reader(CardReader f);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void set_message_handler(MessageHandler f);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void set_script_reader(ScriptReader f);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr create_duel(uint seed);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void start_duel(IntPtr pduel, int options);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_ai_going_first_second(IntPtr pduel, IntPtr deckname);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int set_player_going_first_second(IntPtr pduel, int first, IntPtr deckname);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_ai_id(IntPtr pduel, int playerid);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void end_duel(IntPtr pduel);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_player_info(IntPtr pduel, int playerid, int lp, int startcount, int drawcount);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void new_card(IntPtr pduel, uint code, byte owner, byte playerid, byte location, byte sequence, byte position);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void new_tag_card(IntPtr pduel, uint code, byte owner, byte location);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int process(IntPtr pduel);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_message(IntPtr pduel, IntPtr buf);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        //public static extern void get_log_message(IntPtr pduel, IntPtr buf);
        public static extern void get_log_message(IntPtr pduel, byte[] buf);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_responseb(IntPtr pduel, IntPtr buf);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_responsei(IntPtr pduel, uint value);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int query_card(IntPtr pduel, byte playerid, byte location, byte sequence, int queryFlag, IntPtr buf, int useCache);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int query_field_count(IntPtr pduel, byte playerid, byte location);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int query_field_card(IntPtr pduel, byte playerid, byte location, int queryFlag, IntPtr buf, int useCache);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int query_field_info(IntPtr pduel, IntPtr buf);
        [DllImport("ocgcore", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int preload_script(IntPtr pduel, IntPtr script, int len);

        public static void Set_card_api(Ygopro.CardHandler h)
        {
            card_handler = h;
            set_card_reader(OnCardReader);
        }
        public static void Set_script_api(Ygopro.ScriptHandler h)
        {
            script_handler = h;
            set_script_reader(OnScriptHandler);
        }
        public static void Set_chat_api(Ygopro.ChatHandler h)
        {
            chat_handler = h;
            set_message_handler(OnMessageHandler);
        }

        [MonoPInvokeCallback]
        private static IntPtr OnScriptHandler(string scriptName, int* len)
        {
            var ret = script_handler(scriptName);
            *len = ret.len;
            return ret.buffer;
        }
        [MonoPInvokeCallback]
        private static uint OnCardReader(uint code, CardData* pData)
        {
            *pData = card_handler(code);
            return code;
        }

        [MonoPInvokeCallback]
        private static uint OnMessageHandler(IntPtr pDuel, uint messageType)
        {
            get_log_message(pDuel, _buffer_2);
            var message = Encoding.UTF8.GetString(_buffer_2).TrimEnd('\0');
            chat_handler(message);
            return 0;
        }
    }

    public class Ygopro
    {
        public static string HintInGame = "PercyAI Pro2Team 1033.D";
        private BinaryReader currentReader;
        private BinaryWriter currentWriter;
        private bool end;
        private bool err;
        public static bool isFirst = true;

        public delegate CardData CardHandler(long code);
        public delegate ScriptData ScriptHandler(string name);
        public delegate void ChatHandler(string str);
        private readonly ChatHandler cast;
        public Action<string> m_log;

        private readonly IntPtr _buffer = Marshal.AllocHGlobal(4096);
        private IntPtr duel;
        private Action<byte[]> sendToPlayer;
        private bool godMode;

        public Ygopro(Action<byte[]> HowToSendBufferToPlayer, CardHandler HowToReadCard, ScriptHandler HowToReadScript, ChatHandler HowToShowLog)
        {
            sendToPlayer = HowToSendBufferToPlayer;
            Dll.Set_card_api(HowToReadCard);
            Dll.Set_script_api(HowToReadScript);
            Dll.Set_chat_api(HowToShowLog);
            cast = HowToShowLog;
            var ran = new System.Random(Environment.TickCount);
            duel = Dll.create_duel((uint)ran.Next(100, 99999));
        }
        public void Dispose()
        {
            Dll.end_duel(duel);
            var ran = new System.Random(Environment.TickCount);
            duel = Dll.create_duel((uint)ran.Next(100, 99999));
        }

        private void DebugLog(string obj)
        {
            m_log?.Invoke(obj);
        }

        private int Move(int length, bool erase = false)
        {
            var returnValue = 0;
            if (length > 0)
                if (currentReader != null)
                    if (currentWriter != null)
                        try
                        {
                            var readed = currentReader.ReadBytes(length);
                            if (readed.Length > 0) returnValue = readed[0];
                            if (erase)
                                for (var i = 0; i < length; i++)
                                    currentWriter.Write((byte)0);
                            else
                                currentWriter.Write(readed);
                        }
                        catch
                        {
                        }
            return returnValue;
        }
        private void Flush()
        {
            sendToPlayer(((MemoryStream)currentWriter.BaseStream).ToArray());
        }
        private int LocalPlayer(int p)
        {
            if (isFirst)
                return p;
            return 1 - p;
        }
        private void Refresh()
        {
            if (godMode)
            {
                RefreshMonsters(0);
                RefreshMonsters(1);
                RefreshSpells(0);
                RefreshSpells(1);
                RefreshHand(0);
                RefreshHand(1);
                RefreshGrave(0);
                RefreshGrave(1);
                RefreshExtra(0);
                RefreshExtra(1);
                RefreshDeck(0);
                RefreshDeck(1);
                RefreshRemoved(0);
                RefreshRemoved(1);
            }
            else
            {
                if (isFirst)
                {
                    RefreshMonsters(0);
                    RefreshMonsters(1);
                    RefreshSpells(0);
                    RefreshSpells(1);
                    RefreshGrave(0);
                    RefreshGrave(1);
                    RefreshHand(0);
                    RefreshExtra(0);
                    RefreshRemoved(0);
                }
                else
                {
                    RefreshMonsters(0);
                    RefreshMonsters(1);
                    RefreshSpells(0);
                    RefreshSpells(1);
                    RefreshGrave(0);
                    RefreshGrave(1);
                    RefreshHand(1);
                    RefreshExtra(1);
                    RefreshRemoved(1);
                }
            }
        }
        private byte[] QueryFieldCard(int player, CardLocation location, int flag, bool useCache)
        {
            var len = Dll.query_field_card(duel, (byte)player, (byte)location, flag, _buffer, useCache ? 1 : 0);
            var result = new byte[len];
            Marshal.Copy(_buffer, result, 0, len);
            return result;
        }
        private void RefreshMonsters(int player, int flag = 0x81fff | 0x10000)
        {
            var result = QueryFieldCard(player, CardLocation.MonsterZone, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.MonsterZone);

            var ms = new MemoryStream(result);
            var reader = new BinaryReader(ms);
            for (var i = 0; i < 7; i++)
            {
                var len = reader.ReadInt32();
                if (len == 4)
                {
                    binary.writer.Write(4);
                    continue;
                }

                var raw = reader.ReadBytes(len - 4);
                if ((raw[11] & (int)CardPosition.FaceDown) != 0 && godMode == false && LocalPlayer(player) != 0)
                {
                    binary.writer.Write(8);
                    binary.writer.Write(0);
                }
                else
                {
                    binary.writer.Write(len);
                    binary.writer.Write(raw);
                }
            }
            sendToPlayer(binary.Get());
        }
        private void RefreshSpells(int player, int flag = 0x681fff)
        {
            var result = QueryFieldCard(player, CardLocation.SpellZone, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.SpellZone);

            var ms = new MemoryStream(result);
            var reader = new BinaryReader(ms);
            for (var i = 0; i < 8; i++)
            {
                var len = reader.ReadInt32();
                if (len == 4)
                {
                    binary.writer.Write(4);
                    continue;
                }

                var raw = reader.ReadBytes(len - 4);
                if ((raw[11] & (int)CardPosition.FaceDown) != 0 && godMode == false && LocalPlayer(player) != 0)
                {
                    binary.writer.Write(8);
                    binary.writer.Write(0);
                }
                else
                {
                    binary.writer.Write(len);
                    binary.writer.Write(raw);
                }
            }
            sendToPlayer(binary.Get());
        }
        private void RefreshHand(int player, int flag = 0x181fff)
        {
            var result = QueryFieldCard(player, CardLocation.Hand, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.Hand);
            binary.writer.Write(result);
            sendToPlayer(binary.Get());
        }
        private void RefreshGrave(int player, int flag = 0x81fff)
        {
            var result = QueryFieldCard(player, CardLocation.Grave, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.Grave);
            binary.writer.Write(result);
            sendToPlayer(binary.Get());
        }
        private void RefreshDeck(int player, int flag = 0x81fff)
        {
            var result = QueryFieldCard(player, CardLocation.Deck, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.Deck);
            binary.writer.Write(result);
            sendToPlayer(binary.Get());
        }
        private void RefreshExtra(int player, int flag = 0x81fff)
        {
            var result = QueryFieldCard(player, CardLocation.Extra, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.Extra);
            binary.writer.Write(result);
            sendToPlayer(binary.Get());
        }
        private void RefreshRemoved(int player, int flag = 0x81fff)
        {
            var result = QueryFieldCard(player, CardLocation.Removed, flag, false);
            var binary = new BinaryMaster();
            binary.writer.Write((byte)GameMessage.UpdateData);
            binary.writer.Write((byte)player);
            binary.writer.Write((byte)CardLocation.Removed);
            binary.writer.Write(result);
            sendToPlayer(binary.Get());
        }
        private bool Analyse(BinaryReader reader)
        {
            var returnValue = false;
            currentReader = reader;
            var me = new MemoryStream();
            currentWriter = new BinaryWriter(me);
            var player = 0;
            var count = 0;
            var mes = (GameMessage)Move(1);
            switch (mes)
            {
                case GameMessage.Retry:
                    returnValue = true;
                    err = true;
                    //end = true;
                    break;
                case GameMessage.Hint:
                    Move(6);
                    break;
                case GameMessage.Waiting:
                    break;
                case GameMessage.Start:
                    break;
                case GameMessage.Win:
                    Move(2);
                    returnValue = true;
                    end = true;
                    break;
                case GameMessage.UpdateData:
                    break;
                case GameMessage.UpdateCard:
                    break;
                case GameMessage.RequestDeck:
                    break;
                case GameMessage.SelectBattleCmd:
                    Move(1);
                    Move(Move(1) * 11);
                    Move(Move(1) * 8 + 2);
                    returnValue = true;
                    break;
                case GameMessage.SelectIdleCmd:
                    Move(1);
                    Move(Move(1) * 7);
                    Move(Move(1) * 7);
                    Move(Move(1) * 7);
                    Move(Move(1) * 7);
                    Move(Move(1) * 7);
                    Move(Move(1) * 11 + 3);
                    returnValue = true;
                    break;
                case GameMessage.SelectEffectYn:
                    Move(13);
                    returnValue = true;
                    break;
                case GameMessage.SelectYesNo:
                    Move(5);
                    returnValue = true;
                    break;
                case GameMessage.SelectOption:
                    Move(1);
                    Move(Move(1) * 4);
                    returnValue = true;
                    break;
                case GameMessage.SelectTribute:
                case GameMessage.SelectCard:
                    player = Move(1);
                    Move(3);
                    count = Move(1);
                    for (var i = 0; i < count; i++)
                    {
                        var code = currentReader.ReadInt32();
                        int p = currentReader.ReadByte();
                        currentWriter.Write(p == player ? code : 0);
                        currentWriter.Write((byte)p);
                        Move(3);
                    }

                    returnValue = true;
                    break;
                case GameMessage.SelectUnselectCard:
                    player = Move(1);
                    var buttonok = Move(1);
                    Move(3);
                    var count1 = Move(1);
                    for (var i = 0; i < count1; i++)
                    {
                        var code = currentReader.ReadInt32();
                        int p = currentReader.ReadByte();
                        currentWriter.Write(p == player ? code : 0);
                        currentWriter.Write((byte)p);
                        Move(3);
                    }

                    var count2 = Move(1);
                    for (var i = 0; i < count2; i++)
                    {
                        var code = currentReader.ReadInt32();
                        int p = currentReader.ReadByte();
                        currentWriter.Write(p == player ? code : 0);
                        currentWriter.Write((byte)p);
                        Move(3);
                    }

                    returnValue = true;
                    break;
                case GameMessage.SelectChain:
                    Move(1);
                    count = Move(1);
                    Move(1);
                    Move(1);
                    Move(4);
                    Move(4);
                    for (var i = 0; i < count; i++)
                    {
                        Move(1);
                        Move(4);
                        Move(4);
                        Move(4);
                    }

                    returnValue = true;
                    break;
                case GameMessage.SelectDisfield:
                case GameMessage.SelectPlace:
                case GameMessage.SelectPosition:
                    Move(6);
                    returnValue = true;
                    break;
                case GameMessage.SelectCounter:
                    Move(5);
                    Move(Move(1) * 9);
                    returnValue = true;
                    break;
                case GameMessage.SelectSum:
                    Move(8);
                    Move(Move(1) * 11);
                    Move(Move(1) * 11);
                    returnValue = true;
                    break;
                case GameMessage.SortChain:
                case GameMessage.SortCard:
                    Move(1);
                    Move(Move(1) * 7);
                    returnValue = true;
                    break;
                case GameMessage.ConfirmDecktop:
                    Move(1);
                    Move(Move(1) * 7);
                    break;
                case GameMessage.ConfirmCards:
                    Move(1);
                    Move(Move(1) * 7);
                    break;
                case GameMessage.RefreshDeck:
                case GameMessage.ShuffleDeck:
                    Move(1);
                    break;
                case GameMessage.ShuffleHand:
                    Move(1);
                    Move(Move(1) * 4);
                    break;
                case GameMessage.SwapGraveDeck:
                    Move(1);
                    break;
                case GameMessage.ShuffleSetCard:
                    Move(1);
                    Move(Move(1) * 8);
                    break;
                case GameMessage.ReverseDeck:
                    break;
                case GameMessage.DeckTop:
                    Move(6);
                    break;
                case GameMessage.NewTurn:
                    Move(1);
                    break;
                case GameMessage.NewPhase:
                    Move(2);
                    break;
                case GameMessage.Move:
                    var raw = currentReader.ReadBytes(16);
                    int pc = raw[4];
                    int pl = raw[5];
                    int cc = raw[8];
                    int cl = raw[9];
                    int cs = raw[10];
                    int cp = raw[11];


                    if (!Convert.ToBoolean(cl & ((int)CardLocation.Grave + (int)CardLocation.Overlay)) &&
                        Convert.ToBoolean(cl & ((int)CardLocation.Deck + (int)CardLocation.Hand))
                        || Convert.ToBoolean(cp & (int)CardPosition.FaceDown))
                    {
                        raw[0] = 0;
                        raw[1] = 0;
                        raw[2] = 0;
                        raw[3] = 0;
                    }
                    currentWriter.Write(raw);
                    break;
                case GameMessage.PosChange:
                    Move(9);
                    break;
                case GameMessage.Set:
                    Move(4, true);
                    Move(4);
                    break;
                case GameMessage.Swap:
                    Move(16);
                    break;
                case GameMessage.FieldDisabled:
                    Move(4);
                    break;
                case GameMessage.Summoning:
                    Move(8);
                    break;
                case GameMessage.Summoned:
                    break;
                case GameMessage.SpSummoning:
                    Move(8);
                    break;
                case GameMessage.SpSummoned:
                    break;
                case GameMessage.FlipSummoning:
                    Move(8);
                    break;
                case GameMessage.FlipSummoned:
                    break;
                case GameMessage.Chaining:
                    Move(16);
                    break;
                case GameMessage.Chained:
                    Move(1);
                    break;
                case GameMessage.ChainSolving:
                    Move(1);
                    break;
                case GameMessage.ChainSolved:
                    Move(1);
                    break;
                case GameMessage.ChainEnd:
                    break;
                case GameMessage.ChainNegated:
                case GameMessage.ChainDisabled:
                    Move(1);
                    break;
                case GameMessage.CardSelected:
                    Move(1);
                    Move(Move(1) * 4);
                    break;
                case GameMessage.RandomSelected:
                    Move(1);
                    Move(Move(1) * 4);
                    break;
                case GameMessage.BecomeTarget:
                    Move(Move(1) * 4);
                    break;
                case GameMessage.Draw:
                    player = Move(1);
                    count = Move(1);
                    for (var i = 0; i < count; i++)
                    {
                        var code = currentReader.ReadInt32() & 0x7fffffff;
                        if (isFirst)
                        {
                            if (player == 0)
                                currentWriter.Write(code);
                            else
                                currentWriter.Write(0);
                        }
                        else
                        {
                            if (player == 0)
                                currentWriter.Write(0);
                            else
                                currentWriter.Write(code);
                        }
                    }

                    break;
                case GameMessage.PayLpCost:
                case GameMessage.LpUpdate:
                case GameMessage.Damage:
                case GameMessage.Recover:
                    Move(5);
                    break;
                case GameMessage.Equip:
                    Move(8);
                    break;
                case GameMessage.Unequip:
                    Move(4);
                    break;
                case GameMessage.CardTarget:
                case GameMessage.CancelTarget:
                    Move(8);
                    break;
                case GameMessage.AddCounter:
                case GameMessage.RemoveCounter:
                    Move(7);
                    break;
                case GameMessage.Attack:
                    Move(8);
                    break;
                case GameMessage.Battle:
                    Move(26);
                    break;
                case GameMessage.AttackDiabled:
                    break;
                case GameMessage.DamageStepStart:
                    break;
                case GameMessage.DamageStepEnd:
                    break;
                case GameMessage.MissedEffect:
                    Move(8);
                    break;
                case GameMessage.BeChainTarget:
                    break;
                case GameMessage.CreateRelation:
                    break;
                case GameMessage.ReleaseRelation:
                    break;
                case GameMessage.TossCoin:
                case GameMessage.TossDice:
                    Move(1);
                    Move(Move(1));
                    break;
                case GameMessage.AnnounceRace:
                    Move(6);
                    returnValue = true;
                    break;
                case GameMessage.AnnounceAttrib:
                    Move(6);
                    returnValue = true;
                    break;
                case GameMessage.AnnounceCard:
                case GameMessage.AnnounceNumber:
                    Move(1);
                    Move(Move(1) * 4);
                    returnValue = true;
                    break;
                case GameMessage.CardHint:
                    Move(9);
                    break;
                case GameMessage.TagSwap:
                    player = Move(1);
                    Move(1);
                    var ecount = Move(1);
                    Move(1);
                    var hcount = Move(1);
                    Move(4);
                    for (var i = 0; i < hcount + ecount; i++)
                    {
                        var code = currentReader.ReadUInt32();
                        if ((code & 0x80000000) != 0)
                            currentWriter.Write(code);
                        else
                            currentWriter.Write(0);
                    }

                    break;
                case GameMessage.ReloadField:
                    Move(1);
                    for (var i_ = 0; i_ < 2; i_++)
                    {
                        Move(4);
                        for (var i = 0; i < 7; i++)
                        {
                            var val = Move(1);
                            if (val > 0) Move(2);
                        }

                        for (var i = 0; i < 8; i++)
                        {
                            var val = Move(1);
                            if (val > 0) Move(1);
                        }

                        Move(1);
                        Move(1);
                        Move(1);
                        Move(1);
                        Move(1);
                        Move(1);
                        Move(Move(1) * 15);
                    }

                    break;
                case GameMessage.AiName:
                    var length = currentReader.ReadUInt16();
                    currentWriter.Write(length);
                    Move(length + 1);
                    break;
                case GameMessage.ShowHint:
                    var length2 = currentReader.ReadUInt16();
                    currentWriter.Write(length2);
                    Move(length2 + 1);
                    break;
                case GameMessage.PlayerHint:
                    Move(6);
                    break;
                case GameMessage.MatchKill:
                    Move(4);
                    break;
                case GameMessage.CustomMsg:
                    break;
                case GameMessage.DuelWinner:
                    break;
                default:
                    returnValue = true;
                    break;
            }

            Flush();
            switch (mes)
            {
                case GameMessage.RefreshDeck:
                case GameMessage.SwapGraveDeck:
                case GameMessage.ShuffleSetCard:
                case GameMessage.ShuffleDeck:
                case GameMessage.ShuffleHand:
                case GameMessage.ReverseDeck:
                case GameMessage.DeckTop:
                case GameMessage.Summoned:
                case GameMessage.SpSummoned:
                case GameMessage.FlipSummoned:
                case GameMessage.ChainSolved:
                case GameMessage.ChainEnd:
                case GameMessage.ChainNegated:
                case GameMessage.ChainDisabled:
                case GameMessage.Battle:
                case GameMessage.DamageStepEnd:
                case GameMessage.TagSwap:
                case GameMessage.ReloadField:
                case GameMessage.Draw:
                case GameMessage.Set:
                    Refresh();
                    break;
            }

            DebugLog(mes + (returnValue
                ? " Wating Buffer:\n" + BitConverter.ToString(((MemoryStream)currentWriter.BaseStream).ToArray())
                : ""));
            return returnValue;
        }
        private void Process()
        {
            while (true)
            {
                var result = Dll.process(duel);
                var len = result & 0xFFFF;
                if (len > 0)
                {
                    var arr = new byte[4096];
                    Dll.get_message(duel, _buffer);
                    Marshal.Copy(_buffer, arr, 0, 4096);
                    var breakOut = false;
                    var stream = new MemoryStream(arr);
                    var reader = new BinaryReader(stream);
                    while (stream.Position < len)
                        //log("Analyse");
                        breakOut = Analyse(reader);
                    if (breakOut) break;
                }
            }
        }


        private IntPtr GetPtrString(string path)
        {
            var s = Encoding.UTF8.GetBytes(path);
            var list = s.ToList();
            list.Add(0);
            s = list.ToArray();
            var ptrFileName = Marshal.AllocHGlobal(s.Length);
            Marshal.Copy(s, 0, ptrFileName, s.Length);
            return ptrFileName;
        }
        private Deck FromYDKtoDeck(string path)
        {
            var deck = new Deck();
            try
            {
                var text = File.ReadAllText(path);
                var st = text.Replace("\r", "");
                var lines = st.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                var flag = -1;
                foreach (var line in lines)
                    if (line == "#main")
                    {
                        flag = 1;
                    }
                    else if (line == "#extra")
                    {
                        flag = 2;
                    }
                    else if (line == "!side")
                    {
                        flag = 3;
                    }
                    else
                    {
                        var code = 0;
                        try
                        {
                            code = int.Parse(line);
                        }
                        catch (Exception)
                        {
                        }

                        if (code > 100)
                            switch (flag)
                            {
                                case 1:
                                    {
                                        deck.Main.Add(code);
                                    }
                                    break;
                                case 2:
                                    {
                                        deck.Extra.Add(code);
                                    }
                                    break;
                                case 3:
                                    {
                                        deck.Side.Add(code);
                                    }
                                    break;
                            }
                    }
            }
            catch
            {
            }

            return deck;
        }

        private void AddDeck(Deck deck, int playerId, bool random)
        {
            if (random)
            {
                var seed = new System.Random();
                for (var i = 0; i < deck.Main.Count; i++)
                {
                    var random_index = seed.Next() % deck.Main.Count;
                    var t = deck.Main[i];
                    deck.Main[i] = deck.Main[random_index];
                    deck.Main[random_index] = t;
                }
            }
            for (var i = deck.Main.Count - 1; i >= 0; i--)
                Dll.new_card(duel, (uint)deck.Main[i],
                    (byte)playerId, (byte)playerId, (byte)CardLocation.Deck, 0, (byte)CardPosition.FaceDownDefence);
            for (var i = 0; i < deck.Extra.Count; i++)
                Dll.new_card(duel, (uint)deck.Extra[i],
                    (byte)playerId, (byte)playerId, (byte)CardLocation.Extra, 0,
                    (byte)CardPosition.FaceDownDefence);
        }
        private void AddDeckFromFile(string playerDek, int playerId, bool random)
        {
            AddDeck(FromYDKtoDeck(playerDek), playerId, random);
        }

        public bool StartPuzzle(string path)
        {
            godMode = true;
            isFirst = true;
            Dll.set_player_info(duel, 0, 8000, 5, 1);
            Dll.set_player_info(duel, 1, 8000, 5, 1);
            var result = Dll.preload_script(duel, GetPtrString(path), 0);
            if (result == 0) return false;
            Dll.start_duel(duel, 0);
            Refresh();
            new Thread(Process).Start();
            return true;
        }
        public void Response(byte[] resp)
        {
            if (resp.Length > 64) return;
            var buf = Marshal.AllocHGlobal(64);
            Marshal.Copy(resp, 0, buf, resp.Length);
            Dll.set_responseb(duel, buf);
            Marshal.FreeHGlobal(buf);
            new Thread(Process).Start();
        }

        private BinaryWriter yrp3dbuilder;
        private void SendToYrp(byte[] buffer)
        {
            yrp3dbuilder.Write(buffer[0]);
            yrp3dbuilder.Write(buffer.Length - 1);
            for (var i = 1; i < buffer.Length; i++) yrp3dbuilder.Write(buffer[i]);
        }
        public byte[] GetYRP3dBuffer(YRP yrp)
        {
            var tempS = sendToPlayer;
            sendToPlayer = SendToYrp;
            var stream = new MemoryStream();
            yrp3dbuilder = new BinaryWriter(stream);
            sendToPlayer(yrp.GetNamePacket());
            Dll.end_duel(duel);
            var mtrnd = new MersenneTwister(yrp.Seed);
            duel = Dll.create_duel(mtrnd.genrand_Int32());
            godMode = true;
            isFirst = true;
            Dll.set_player_info(duel, 0, yrp.StartLp, yrp.StartHand, yrp.DrawCount);
            Dll.set_player_info(duel, 1, yrp.StartLp, yrp.StartHand, yrp.DrawCount);
            if (yrp.playerData.Count == 4)
            {
                foreach (var item in yrp.playerData[0].main)
                    Dll.new_card(duel, (uint)item, 0, 0, (byte)CardLocation.Deck, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[0].extra)
                    Dll.new_card(duel, (uint)item, 0, 0, (byte)CardLocation.Extra, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[1].main)
                    Dll.new_tag_card(duel, (uint)item, 0, (byte)CardLocation.Deck);
                foreach (var item in yrp.playerData[1].extra)
                    Dll.new_tag_card(duel, (uint)item, 0, (byte)CardLocation.Extra);

                foreach (var item in yrp.playerData[2].main)
                    Dll.new_card(duel, (uint)item, 1, 1, (byte)CardLocation.Deck, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[2].extra)
                    Dll.new_card(duel, (uint)item, 1, 1, (byte)CardLocation.Extra, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[3].main)
                    Dll.new_tag_card(duel, (uint)item, 1, (byte)CardLocation.Deck);
                foreach (var item in yrp.playerData[3].extra)
                    Dll.new_tag_card(duel, (uint)item, 1, (byte)CardLocation.Extra);
            }
            else
            {
                foreach (var item in yrp.playerData[0].main)
                    Dll.new_card(duel, (uint)item, 0, 0, (byte)CardLocation.Deck, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[0].extra)
                    Dll.new_card(duel, (uint)item, 0, 0, (byte)CardLocation.Extra, 0,
                        (byte)CardPosition.FaceDownDefence);

                foreach (var item in yrp.playerData[1].main)
                    Dll.new_card(duel, (uint)item, 1, 1, (byte)CardLocation.Deck, 0,
                        (byte)CardPosition.FaceDownDefence);
                foreach (var item in yrp.playerData[1].extra)
                    Dll.new_card(duel, (uint)item, 1, 1, (byte)CardLocation.Extra, 0,
                        (byte)CardPosition.FaceDownDefence);
            }

            var master = new BinaryMaster();
            master.writer.Write((char)GameMessage.Start);
            master.writer.Write((byte)0);
            master.writer.Write((byte)(yrp.opt >> 16));
            master.writer.Write(yrp.StartLp);
            master.writer.Write(yrp.StartLp);
            master.writer.Write((ushort)Dll.query_field_count(duel, 0, 0x1));
            master.writer.Write((ushort)Dll.query_field_count(duel, 0, 0x40));
            master.writer.Write((ushort)Dll.query_field_count(duel, 1, 0x1));
            master.writer.Write((ushort)Dll.query_field_count(duel, 1, 0x40));
            sendToPlayer(master.Get());
            Dll.start_duel(duel, yrp.opt);
            Refresh();
            end = false;
            err = false;
            try
            {
                while (true)
                {
                    //log("process");
                    Process();
                    if (yrp.gameData.Count == 0) break;
                    if (yrp.gameData[0].Length > 64) break;
                    var buf = Marshal.AllocHGlobal(64);
                    Marshal.Copy(yrp.gameData[0], 0, buf, yrp.gameData[0].Length);
                    Dll.set_responseb(duel, buf);
                    Marshal.FreeHGlobal(buf);
                    DebugLog("Push:  " + BitConverter.ToString(yrp.gameData[0]));
                    yrp.gameData.RemoveAt(0);
                    if (end) break;
                }
            }
            catch (Exception)
            {
            }

            if (err)
                if (cast != null)
                    cast("Error Occurred.");

            Dispose();
            sendToPlayer = tempS;
            yrp3dbuilder.Close();
            stream.Close();
            return stream.ToArray();
        }
    }

    public class YRP
    {
        public long DataSize = 0;
        public int DrawCount = 0;
        public int Flag = 0;
        public List<byte[]> gameData = new List<byte[]>();
        public int Hash = 0;
        public int ID = 0;
        public int opt = 0;
        public List<PlayerData> playerData = new List<PlayerData>();
        public byte[] Props = new byte[8];
        public uint Seed = 0;
        public int StartHand = 0;
        public int StartLp = 0;
        public int Version = 0;
        public class PlayerData
        {
            public string name;
            public List<int> main = new List<int>();
            public List<int> extra = new List<int>();
        }

        public byte[] GetNamePacket()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);
            if (playerData.Count == 4)
            {
                WriteUnicode(writer, playerData[0].name, 50);
                WriteUnicode(writer, playerData[1].name, 50);
                WriteUnicode(writer, playerData[0].name, 50);
                WriteUnicode(writer, playerData[2].name, 50);
                WriteUnicode(writer, playerData[3].name, 50);
                WriteUnicode(writer, playerData[2].name, 50);
            }
            else
            {
                WriteUnicode(writer, playerData[0].name, 50);
                WriteUnicode(writer, playerData[0].name, 50);
                WriteUnicode(writer, playerData[0].name, 50);
                WriteUnicode(writer, playerData[1].name, 50);
                WriteUnicode(writer, playerData[1].name, 50);
                WriteUnicode(writer, playerData[1].name, 50);
            }

            writer.Write(opt >> 16);
            var Rwriter = new BinaryWriter(new MemoryStream());
            Rwriter.Write((byte)MDPro3.YGOSharp.OCGWrapper.Enums.GameMessage.sibyl_name);
            Rwriter.Write(stream.ToArray());
            return ((MemoryStream)Rwriter.BaseStream).ToArray();
        }

        private void WriteUnicode(BinaryWriter writer, string text, int len)
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
    }
    internal class MonoPInvokeCallbackAttribute : Attribute
    {
        public MonoPInvokeCallbackAttribute() { }
    }

}