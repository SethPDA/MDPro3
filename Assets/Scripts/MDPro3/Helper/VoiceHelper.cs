using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using MDPro3.YGOSharp.OCGWrapper.Enums;
using MDPro3.YGOSharp;
using static MDPro3.VoiceController;
using MDPro3.Utility;

namespace MDPro3
{
    public static class VoiceHelper
    {
        public const string voicePath = "Sound/Voice/";
        public const string customVoicePath = "Sound/CustomVoice/";
        public const string jsonPath = "Data/locales/";

        public static string language = Language.SimplifiedChinese;
        public const string defaultCharacter = "0001";
        public static string hero;
        public static string rival;

        static VoicesData heroVoices;
        static LinesData heroLines;
        static VoicesData rivalVoices;
        static LinesData rivalLines;

        static bool ignoreNextChaining;
        public static bool ignoreNextPendulumSummon;
        static bool lastVoiceIsRelease;

        public struct VoiceData
        {
            public string name;
            public int num;
            public bool me;
            public bool wait;
            public float delay;
        }

        static void Reset()
        {
            ignoreNextChaining = false;
            ignoreNextPendulumSummon = false;
            lastVoiceIsRelease = false;
        }

        public static void Load()
        {
            var condition = Program.instance.ocgcore.condition;
            var chara = Config.Get(condition + "Character0", defaultCharacter);
            var configLanguage = Language.GetConfig();

            if(language != configLanguage || hero != chara)
            { 
                hero = chara;
                var dataPath = jsonPath + Language.Japanese + "/voice/V" + hero + ".json";
                var txt = File.ReadAllText(dataPath);
                heroVoices = JsonConvert.DeserializeObject<VoicesData>(txt);

                dataPath = jsonPath + configLanguage + "/voice/SN" + hero + ".json";
                txt = File.ReadAllText(dataPath);
                heroLines = JsonConvert.DeserializeObject<LinesData>(txt);
            }

            chara = Config.Get(condition + "Character1", defaultCharacter);
            if(language != configLanguage || rival != chara)
            {
                rival = chara;
                var dataPath = jsonPath + Language.Japanese + "/voice/V" + rival + ".json";
                var txt = File.ReadAllText(dataPath);
                rivalVoices = JsonConvert.DeserializeObject<VoicesData>(txt);

                dataPath = jsonPath + configLanguage + "/voice/SN" + rival + ".json";
                txt = File.ReadAllText(dataPath);
                rivalLines = JsonConvert.DeserializeObject<LinesData>(txt);
            }
            language = configLanguage;
        }
        public static void ExportAllCardsNotFound()
        {
            var ids = new List<int>();

            var folder = jsonPath + Language.SimplifiedChinese + "/voice/";
            var jsons = Directory.GetFiles(folder);
            var vjsons = new List<string>();
            foreach (var json in jsons)
            {
                var fileName = Path.GetFileName(json);
                if(fileName.StartsWith("V"))
                    vjsons.Add(json);
            }

            foreach(var v in vjsons)
            {
                var data = JsonConvert.DeserializeObject<VoicesData>(File.ReadAllText(v));
                var cardEntries = data.GetEntryWithCard();
                foreach(var entry in cardEntries)
                {
                    if (entry == null)
                        continue;
                    foreach(var value in entry.rawKvp.Values)
                    {
                        if (value.cards == null)
                            continue;

                        foreach(var card in value.cards)
                        {
                            if(!ids.Contains(card))
                                ids.Add(card);
                        }
                    }
                }
            }

            var text = string.Empty;
            foreach (var id in ids)
            {
                if(!Cid2Ydk.HaveCid(id))
                    text += id + "\r\n";
            }
            File.WriteAllText("Data/Duel Links Ids.txt", text);
        }

        public static List<VoiceData> GetVoiceDatas(Package p)
        {
            var core = Program.instance.ocgcore;
            Load();

            var returnValue = new List<VoiceData>();
            var r = p.Data.reader;
            r.BaseStream.Seek(0, 0);

            VoiceData data;
            VoiceData data2;
            VoiceData data3;
            VoiceData data4;
            VoicesData target;
            VoicesData target2;
            SimpleVoiceData simple;

            int category;
            int subCategory;
            int subInCase;
            int patternIndex;

            int player;
            int code;
            int value;
            int count;
            uint reason;
            bool fromHand;
            bool isMe;
            int leadingState;

            int heroCode = int.Parse(hero);
            int rivalCode = int.Parse(rival);

            Package nextPack;
            Card c;
            GameCard card;
            GPS gps;
            GPS from;
            GPS to;

            //if ((GameMessage)p.Function != GameMessage.UpdateData
            //    && (GameMessage)p.Function != GameMessage.UpdateCard
            //    )
            //    Debug.Log((GameMessage)p.Function);

            if((GameMessage)p.Function != GameMessage.Move
                && (GameMessage)p.Function != GameMessage.UpdateCard
                && (GameMessage)p.Function != GameMessage.UpdateData
                )
            {
                lastVoiceIsRelease = false;
            }

            try
            {
                switch ((GameMessage)p.Function)
                {
                    case GameMessage.Start:
                        Reset();
                        data = new VoiceData();
                        data.name = GetVoiceByDuelist(heroVoices.BeforeDuel, heroVoices.BeforeDuelSp, rivalCode);
                        
                        data.num = GetVoiceNum(heroVoices, data.name);
                        data.me = true;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);
                        
                        data2 = new VoiceData();
                        data2.name = GetVoiceByDuelist(rivalVoices.BeforeDuel, rivalVoices.BeforeDuelSp, heroCode);
                        data2.num = GetVoiceNum(rivalVoices, data2.name);
                        data2.me = false;
                        data2.wait = true;
                        data2.delay = 0f;
                        returnValue.Add(data2);

                        data3 = new VoiceData();
                        data3.name = Tools.GetRandomDictionaryElement(heroVoices.DuelStart.rawKvp).Value.shortName;
                        data3.num = GetVoiceNum(heroVoices, data3.name);
                        data3.me = true;
                        data3.wait = false;
                        data3.delay = 1f;
                        returnValue.Add(data3);

                        data4 = new VoiceData();
                        data4.name = Tools.GetRandomDictionaryElement(rivalVoices.DuelStart.rawKvp).Value.shortName;
                        data4.num = GetVoiceNum(rivalVoices, data4.name);
                        data4.me = false;
                        data4.wait = true;
                        data4.delay = 0f;
                        returnValue.Add(data4);

                        break;
                    case GameMessage.ReloadField:
                        Reset();
                        break;
                    case GameMessage.Win:
                        player = core.LocalPlayer(r.ReadByte());
                        if (player == 2)
                            break;

                        if(player == 0)
                        {
                            target = heroVoices;
                            target2 = rivalVoices;
                        }
                        else
                        {
                            target = rivalVoices;
                            target2 = heroVoices;
                        }

                        data = new VoiceData();
                        data.name = GetVoiceByDuelist(target.Win, target.WinSp, player == 0 ? rivalCode : heroCode);
                        data.num = GetVoiceNum(target, data.name);
                        data.me = player == 0;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);

                        data2 = new VoiceData();
                        data2.name = GetVoiceByDuelist(target2.Lose, target2.LoseSp, player == 0 ? heroCode : rivalCode);
                        data2.num = GetVoiceNum(target2, data2.name);
                        data2.me = !data.me;
                        data2.wait = true;
                        data2.delay = 0f;
                        returnValue.Add(data2);

                        break;
                    case GameMessage.NewTurn:
                        if (core.turns == 0)
                            break;
                        target = core.myTurn ? rivalVoices : heroVoices;
                        leadingState = core.myTurn ? LeadingStateOfRival() : LeadingStateOfPlayer();

                        data = new VoiceData();
                        data.name = GetVoiceBySituation(target.TurnStart, leadingState);
                        data.num = GetVoiceNum(target, data.name);
                        data.me = !core.myTurn;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);
                        break;
                    case GameMessage.NewPhase:
                        var ph = r.ReadUInt16();
                        if (ph != 0x08 && ph != 0x0200)
                            break;

                        target = core.myTurn ? heroVoices : rivalVoices;
                        data = new VoiceData();
                        if (ph == 0x08)//Battle
                            data.name = Tools.GetRandomDictionaryElement(target.BattleStart.rawKvp).Value.shortName;
                        else if (ph == 0x200)//End
                        {
                            leadingState = core.myTurn ? LeadingStateOfPlayer() : LeadingStateOfRival();
                            data.name = GetVoiceBySituation(target.TurnEnd, leadingState);
                        }

                        data.num = GetVoiceNum(target, data.name);
                        data.me = core.myTurn;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);

                        break;
                    case GameMessage.PosChange:

                        nextPack = core.GetNextPackage();
                        if (nextPack == null)
                            break;
                        //nextPack.Data.reader.BaseStream.Seek(0, 0);
                        if ((GameMessage)nextPack.Function != GameMessage.Chaining)
                            break;
                        code = r.ReadInt32();
                        from = r.ReadGPS();

                        target = from.controller == 0 ? heroVoices : rivalVoices;
                        if (NeedBeforeCardEffect(from.controller == 0))
                            returnValue.Add(GetBeforeCardEffectData(target, from.controller == 0));

                        data = new VoiceData();
                        data.name = GetVoiceBySubCategory(target.CardEffect, (int)CardEffectSub.Reverse, (int)CardEffectSub.Reverse, 0);
                        data.num = GetVoiceNum(target, data.name);
                        data.me = from.controller == 0;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);

                        simple = GetCardEffectSubCategory(nextPack.Data.reader, false);

                        data2 = new VoiceData();
                        data2.name = GetVoiceBySubCategory(target.CardEffect, simple.subCategory, (int)CardEffectSub.Magic, 0);
                        data2.num = GetVoiceNum(target, data2.name);
                        data2.me = data.me;
                        data2.wait = true;
                        data2.delay = 0f;
                        returnValue.Add(data2);
                        ignoreNextChaining = true;

                        break;
                    case GameMessage.Move:
                        code = r.ReadInt32();
                        from = r.ReadGPS();
                        to = r.ReadGPS();
                        reason = r.ReadUInt32();
                        card = core.GCS_Get(from);
                        if (card == null)
                        {
                            //Todo;
                            break;
                        }
                        c = card.GetData();

                        nextPack = core.GetNextPackage();
                        if (nextPack == null)
                            break;
                        nextPack.Data.reader.BaseStream.Seek(0, 0);

                        category = 0;
                        subCategory = 0;
                        subInCase = 0;
                        patternIndex = 0;

                        fromHand = false;
                        isMe = to.controller == 0;

                        if ((reason & (uint)CardReason.RELEASE) > 0 
                            && card.GetData().HasType(CardType.Monster))
                        {
                            if (lastVoiceIsRelease)
                                break;
                            category = (int)Category.Summon;
                            subCategory = (int)SummonSub.Release;
                            subInCase = subCategory;
                            lastVoiceIsRelease = true;
                        }
                        else
                            lastVoiceIsRelease = false;

                        if((GameMessage)nextPack.Function == GameMessage.Summoning)
                        {
                            code = nextPack.Data.reader.ReadInt32();

                            category = (int)Category.Summon;
                            subCategory = (int)SummonSub.Normal;

                            isMe = from.controller == 0;
                            target = isMe ? heroVoices : rivalVoices;
                            data = GetVoiceByCard(isMe ? heroVoices : rivalVoices, target.MainMonsterSummon, code, 0, isMe);
                            if (data.name != string.Empty)
                            {
                                returnValue.Add(data);
                                break;
                            }

                            returnValue.Add(GetBeforeSummonData(target, isMe));
                        }

                        if ((GameMessage)nextPack.Function == GameMessage.SpSummoning)
                        {
                            code = nextPack.Data.reader.ReadInt32();
                            c = CardsManager.Get(code);

                            category = (int)Category.Summon;
                            subCategory = (int)SummonSub.Special;
                            subInCase = subCategory;
                            if (core.materialCards.Count > 0)
                            {
                                patternIndex = -1;

                                if (c.HasType(CardType.Link))
                                    subCategory = (int)SummonSub.Link;
                                else if (c.HasType(CardType.Fusion))
                                    subCategory = (int)SummonSub.Fusion;
                                else if (c.HasType(CardType.Synchro))
                                    subCategory = (int)SummonSub.Sync;
                                else if (c.HasType(CardType.Xyz))
                                    subCategory = (int)SummonSub.Xyz;
                                else if (c.HasType(CardType.Ritual))
                                    subCategory = (int)SummonSub.Ritual;
                            }
                            else if (core.log.psum)
                            {
                                if (ignoreNextPendulumSummon)
                                    break;
                                subCategory = (int)SummonSub.Pendulum;
                            }

                            if ((from.location & (uint)CardLocation.Hand) > 0 
                                && subCategory == (int)SummonSub.Special)
                            {
                                fromHand = true;
                                isMe = from.controller == 0;
                            }

                            target = isMe ? heroVoices : rivalVoices;

                            if(subCategory != (int)SummonSub.Special)
                            {
                                data = GetVoiceByCard(isMe ? heroVoices : rivalVoices, target.BeforeMainSummon, code, 0, isMe);
                                if (data.name != string.Empty)
                                    returnValue.Add(data);
                            }

                            data2 = GetVoiceByCard(isMe ? heroVoices : rivalVoices, target.MainMonsterSummon, code, 0, isMe);
                            if (data2.name != string.Empty)
                            {
                                if (subCategory != (int)SummonSub.Special && returnValue.Count == 0)
                                {
                                    var voiceShortName = GetVoiceBySubCategory(target.Summon, subCategory, (int)SummonSub.Special, 1, true);
                                    if(voiceShortName != null)
                                    {
                                        data = new VoiceData();
                                        data.name = voiceShortName;
                                        data.num = GetVoiceNum(target, data.name);
                                        data.me = isMe;
                                        data.wait = true;
                                        data.delay = 0f;
                                        returnValue.Add(data);
                                    }
                                }

                                returnValue.Add(data2);
                                break;
                            }
                        }

                        if ((GameMessage)nextPack.Function == GameMessage.Set)
                        {
                            category = (int)Category.CardSet;
                            if ((to.location & (uint)CardLocation.MonsterZone) > 0)
                                subCategory = (int)CardSetSub.Monster;
                            else
                                subCategory = (int)CardSetSub.MagicTrap;
                            subInCase = subCategory;
                        }

                        if ((GameMessage)nextPack.Function == GameMessage.Chaining)
                        {
                            if ((to.location & (uint)CardLocation.Onfield) == 0)
                                break;
                            ignoreNextChaining = true;

                            code = nextPack.Data.reader.ReadInt32();
                            gps = nextPack.Data.reader.ReadGPS();

                            target = gps.controller == 0 ? heroVoices : rivalVoices;
                            data = GetVoiceByCard(target, target.MainMonsterEffect, code, 0, gps.controller == 0);
                            if (data.name != string.Empty)
                            {
                                returnValue.Add(data);
                                break;
                            }
                            data = GetVoiceByCard(target, target.MainMagicTrap, code, 0, gps.controller == 0);
                            if (data.name != string.Empty)
                            {
                                returnValue.Add(data);
                                break;
                            }

                            if ((from.location & (uint)CardLocation.Hand) > 0)
                            {
                                fromHand = true;
                                isMe = from.controller == 0;
                            }

                            if (NeedBeforeCardEffect(from.controller == 0))
                                returnValue.Add(GetBeforeCardEffectData(isMe ? heroVoices : rivalVoices, from.controller == 0));

                            simple = GetCardEffectSubCategory(nextPack.Data.reader, fromHand);
                            category = simple.category;
                            subCategory = simple.subCategory;
                            subInCase = (int)CardEffectSub.Magic;
                            if (subCategory == (int)CardEffectSub.PendulumScale)
                                fromHand = false;
                        }

                        target = isMe ? heroVoices : rivalVoices;

                        if (category == 0)
                            break;

                        if (fromHand)
                        {
                            data = new VoiceData();
                            data.name = GetVoiceBySubCategory(target.CardEffect, (int)CardEffectSub.FromHand, (int)CardEffectSub.FromHand, 0);
                            data.num = GetVoiceNum(target, data.name);
                            data.me = from.controller == 0;
                            data.wait = true;
                            data.delay = 0f;
                            returnValue.Add(data);
                        }

                        data2 = new VoiceData();
                        data2.name = GetVoiceBySubCategory(target.GetCategoryEntry((Category)category), subCategory, subInCase, patternIndex);
                        data2.num = GetVoiceNum(target, data2.name);
                        data2.me = from.controller == 0;
                        data2.wait = true;
                        data2.delay = 0f;
                        returnValue.Add(data2);

                        break;
                    case GameMessage.Chaining:
                        if (ignoreNextChaining)
                        {
                            ignoreNextChaining = false;
                            break;
                        }

                        code = r.ReadInt32();
                        gps = r.ReadGPS();

                        simple = GetCardEffectSubCategory(r, false);
                        target = simple.isMe ? heroVoices : rivalVoices;

                        if (NeedBeforeCardEffect(simple.isMe))
                            returnValue.Add(GetBeforeCardEffectData(target, simple.isMe));

                        data = GetVoiceByCard(target, target.MainMonsterEffect, code, 0, simple.isMe);
                        if (data.name != string.Empty)
                        {
                            returnValue.Add(data);
                            break;
                        }
                        data = GetVoiceByCard(target, target.MainMagicTrap, code, 0, simple.isMe);
                        if (data.name != string.Empty)
                        {
                            returnValue.Add(data);
                            break;
                        }

                        if (simple.inHand)
                        {
                            data2 = new VoiceData();
                            data2.name = GetVoiceBySubCategory(target.CardEffect, (int)CardEffectSub.FromHand, (int)CardEffectSub.FromHand, 0);
                            data2.num = GetVoiceNum(target, data2.name);
                            data2.me = simple.isMe;
                            data2.wait = true;
                            data2.delay = 0f;
                            returnValue.Add(data2);
                        }

                        data3 = new VoiceData();
                        data3.name = GetVoiceBySubCategory(target.CardEffect, simple.subCategory, (int)CardEffectSub.Magic, 0);
                        data3.num = GetVoiceNum(target, data3.name);
                        data3.me = simple.isMe;
                        data3.wait = true;
                        data3.delay = 0f;
                        returnValue.Add(data3);

                        break;
                    case GameMessage.Draw:
                        if (core.phase != DuelPhase.Draw)
                            break;
                        if (core.turns < 2)
                            break;
                        player = core.LocalPlayer(r.ReadByte());

                        target = player == 0 ? heroVoices : rivalVoices;
                        leadingState = player == 0 ? LeadingStateOfPlayer() : LeadingStateOfRival();

                        data = new VoiceData();
                        data.name = GetVoiceBySituation(target.Draw, leadingState);
                        data.num = GetVoiceNum(target, data.name);
                        data.me = player == 0;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);
                        break;
                    case GameMessage.Damage:
                        player = core.LocalPlayer(r.ReadByte());
                        value = r.ReadInt32();
                        target = player == 0 ? heroVoices : rivalVoices;
                        if (value >= (player == 0 ? core.life0 : core.life1))
                        {
                            returnValue.Add(GetFinishDamageVoiceData(target, player == 0));
                            break;
                        }
                        data = new VoiceData();
                        if (DamageIsBig(value))
                            data.name = Tools.GetRandomDictionaryElement(target.BigDamage.rawKvp).Value.shortName;
                        else
                            data.name = Tools.GetRandomDictionaryElement(target.Damage.rawKvp).Value.shortName;
                        data.num = GetVoiceNum(target, data.name);
                        data.me = player == 0;
                        data.wait = false;
                        data.delay = 0f;
                        returnValue.Add(data);

                        break;
                    case GameMessage.LpUpdate:
                        player = core.LocalPlayer(r.ReadByte());
                        value = r.ReadInt32();
                        target = player == 0 ? heroVoices : rivalVoices;
                        if (value == 0)
                        {
                            returnValue.Add(GetFinishDamageVoiceData(target, player == 0));
                            break;
                        }

                        value = (player == 0 ? core.life0 : core.life1) - value;
                        if (value <= 0)
                            break;

                        data = new VoiceData();
                        if (DamageIsBig(value))
                            data.name = Tools.GetRandomDictionaryElement(target.BigDamage.rawKvp).Value.shortName;
                        else
                            data.name = Tools.GetRandomDictionaryElement(target.Damage.rawKvp).Value.shortName;
                        data.num = GetVoiceNum(target, data.name);
                        data.me = player == 0;
                        data.wait = false;
                        data.delay = 0f;
                        returnValue.Add(data);

                        break;
                    case GameMessage.PayLpCost:
                        player = core.LocalPlayer(r.ReadByte());
                        value = r.ReadInt32();

                        target = player == 0 ? heroVoices : rivalVoices;

                        data = new VoiceData();
                        data.name = Tools.GetRandomDictionaryElement(target.CostDamage.rawKvp).Value.shortName;
                        data.num = GetVoiceNum(target, data.name);
                        data.me = player == 0;
                        data.wait = false;
                        data.delay = 0f;
                        returnValue.Add(data);

                        break;
                    case GameMessage.Attack:
                        from = r.ReadGPS();
                        to = r.ReadGPS();

                        var attackCard = core.GCS_Get(from);
                        if (attackCard == null)
                            break;

                        bool directAttack = false;
                        value = 0;
                        var attackedCard = core.GCS_Get(to);
                        if(attackedCard == null)
                        {
                            directAttack = true;
                            value = attackCard.GetData().Attack;
                        }
                        else
                        {
                            if((attackedCard.p.position & (uint)CardPosition.Attack) > 0)
                                value = attackCard.GetData().Attack - attackedCard.GetData().Attack;
                        }

                        bool finalBlow = value >= (from.controller == 0 ? core.life1 : core.life0);
                        target = from.controller == 0 ? heroVoices : rivalVoices;

                        data = new VoiceData();
                        data.name = Tools.GetRandomDictionaryElement(finalBlow ? target.BeforeAttackFinish.rawKvp : target.BeforeAttackNormal.rawKvp).Value.shortName;
                        data.num = GetVoiceNum(target, data.name);
                        data.me = from.controller == 0;
                        data.wait = true;
                        data.delay = 0f;
                        returnValue.Add(data);

                        data2 = new VoiceData();
                        data2.name = Tools.GetRandomDictionaryElement(directAttack ? target.DirectAttack.rawKvp : target.Attack.rawKvp).Value.shortName;
                        data2.num = GetVoiceNum(target, data2.name);
                        data2.me = data.me;
                        data2.wait = true;
                        data2.delay = 0f;
                        returnValue.Add(data2);

                        break;
                    case GameMessage.TossCoin:
                        break;
                    case GameMessage.TossDice:
                        break;
                    case GameMessage.BecomeTarget:
                        count = r.ReadByte();

                        bool psum = false;
                        for(int i = 0; i < count; i++)
                        {
                            gps = r.ReadGPS();
                            card = core.GCS_Get(gps);
                            if (card == null)
                                break;

                            int cardsBeTarget = core.cardsBeTarget.Count + 1;

                            if (core.phase == DuelPhase.Main1 || core.phase == DuelPhase.Main2)
                                if (core.cardsInChain.Count == 0)
                                    if (cardsBeTarget == 2)
                                        if (core.cardsBeTarget.Count == 1 && core.cardsBeTarget[0].InPendulumZone())
                                            if (card.InPendulumZone())
                                                if (core.cardsBeTarget[0].p.controller == card.p.controller)
                                                    psum = true;
                        }

                        if (!psum)
                            break;

                        target = core.myTurn ? heroVoices : rivalVoices;

                        data = new VoiceData();
                        data.name = GetVoiceBySubCategory(target.Summon, (int)SummonSub.Pendulum, (int)SummonSub.Pendulum, 1, true);
                        if (data.name == null)
                            break;

                        data.num = GetVoiceNum(target, data.name);
                        data.me = core.myTurn;
                        data.wait = false;
                        data.delay = 0f;
                        returnValue.Add(data);
                        ignoreNextPendulumSummon = true;

                        break;
                }
            }
            catch(Exception e) 
            { 
                Debug.LogError(e);
            }


            return returnValue;
        }

        public static List<string>[] GetVoicePaths(List<VoiceData> data)
        {
            var returnValue = new List<string>[data.Count];
            for(int i = 0; i < data.Count; i++)
                returnValue[i] = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].num; j++)
                {
                    var path = voicePath + data[i].name[..5] + Program.slash + data[i].name + "_" + j + ".ogg";
                    returnValue[i].Add(path);
                }
            }

            return returnValue;
        }

        public static LineInfo GetLine(string name, bool me)
        {
            if (heroLines == null || rivalLines == null)
                return null;

            var target = me ? heroLines : rivalLines;
            if(target.info.TryGetValue(name, out var line))
                return line;
            else if((!me ? heroLines : rivalLines).info.TryGetValue(name, out var line2))
                return line2;
            else
                return null;
        }

        static bool DataHaveVoice(VoiceInfoEntry entry, int sub, int patternIndex)
        {
            if(entry == null) 
                return false;

            foreach (var e in entry.rawKvp)
                if (e.Value.subCategoryIndex == sub)
                    if (e.Value.patternIndex == patternIndex)
                        return true;
            return false;
        }
        static string GetVoiceBySubCategory(VoiceInfoEntry entry, int sub, int subInCase, int patternIndex, bool patternRestrict = false)
        {
            var tempStrings = new List<string>();

            foreach(var e in entry.rawKvp)
                if (e.Value.subCategoryIndex == sub)
                {
                    if(e.Value.patternIndex == patternIndex)
                        return e.Value.shortName;
                    else
                        tempStrings.Add(e.Value.shortName);
                }
            if(tempStrings.Count == 0)
                foreach (var e in entry.rawKvp)
                    if (e.Value.subCategoryIndex == subInCase)
                    {
                        if (e.Value.patternIndex == patternIndex)
                            return e.Value.shortName;
                        else
                            tempStrings.Add(e.Value.shortName);
                    }

            if (patternRestrict)
                return null;

            if(tempStrings.Count > 0)
                return tempStrings[UnityEngine.Random.Range(0, tempStrings.Count)];
            Debug.LogErrorFormat("Did not find Subcategory {0}-{1} in {2}", sub, subInCase, entry.rawKvp.First().Key[..8]);
            return null;
        }

        static string GetVoiceBySituation(VoiceInfoEntry entry, int situation)
        {
            var returnValue = Tools.GetRandomDictionaryElement(entry.rawKvp).Value.shortName;
            var tempStrings = new List<string>();
            foreach (var e in entry.rawKvp)
                if(e.Value.situations != null && e.Value.situations.Length > 0)
                    if (Array.IndexOf(e.Value.situations, situation) > 0)
                        tempStrings.Add(e.Value.shortName);
            if (tempStrings.Count > 0)
                returnValue = tempStrings[UnityEngine.Random.Range(0, tempStrings.Count)];
            return returnValue;
        }

        static string GetVoiceByDuelist(VoiceInfoEntry entry, VoiceInfoEntry entrySp, int duelist)
        {
            var returnValue = Tools.GetRandomDictionaryElement(entry.rawKvp).Value.shortName;
            if (entrySp == null)
                return returnValue;
            var tempStrings = new List<string>();
            foreach (var e in entrySp.rawKvp)
                for (var i = 0; i < e.Value.duelists.Length; i++)
                    if (Convert.ToInt32(e.Value.duelists[i]) == duelist)
                        tempStrings.Add(e.Value.shortName);
            if (tempStrings.Count > 0)
                returnValue = tempStrings[UnityEngine.Random.Range(0, tempStrings.Count)];
            return returnValue;
        }

        static int GetVoiceNum(VoicesData target, string key)
        {
            if(key == null)
            {
                Debug.LogWarning("String key for GetVoiceNum is null. ");
                return 1;
            }

            if (target.NumVoices.TryGetValue(key, out var numVoices))
                return numVoices;
            else
            {
                Debug.LogFormat("Did not Find NumVoices \'{0}\' in {1} ", key, target.BeforeDuel.rawKvp.First().Key[..5]);
                return 1;
            }
        }

        static bool DamageIsBig(int damage)
        {
            if (damage >= 2000)
                return true;
            else
                return false;
        }

        static VoiceData GetFinishDamageVoiceData(VoicesData target, bool isMe)
        {
            var data = new VoiceData();
            data.name = Tools.GetRandomDictionaryElement(target.FinishDamage.rawKvp).Value.shortName;
            data.num = GetVoiceNum(target, data.name);
            data.me = isMe;
            data.wait = false;
            data.delay = 0;
            return data;
        }
        
        static bool NeedBeforeCardEffect(bool isMe)
        {
            if(Program.instance.ocgcore.cardsInChain.Count == 0)
                return false;
            if ((Program.instance.ocgcore.cardsInChain[^1].p.controller == 0) == isMe)
                return false;
            else
                return true;
        }

        static VoiceData GetBeforeCardEffectData(VoicesData target, bool isMe)
        {
            var data = new VoiceData();
            data.name = Tools.GetRandomDictionaryElement(target.BeforeCardEffect.rawKvp).Value.shortName;
            data.num = GetVoiceNum(target, data.name);
            data.me = isMe;
            data.wait = true;
            data.delay = 0;
            return data;
        }

        static VoiceData GetBeforeSummonData(VoicesData target, bool isMe)
        {
            var data = new VoiceData();
            data.name = Tools.GetRandomDictionaryElement(target.BeforeSummon.rawKvp).Value.shortName;
            data.num = GetVoiceNum(target, data.name);
            data.me = isMe;
            data.wait = true;
            data.delay = 0;
            return data;
        }

        public class SimpleVoiceData
        {
            public int category;
            public int subCategory;
            public bool isMe;
            public bool inHand;
        }

        static SimpleVoiceData GetCardEffectSubCategory(BinaryReader r, bool fromHand)
        {
            var returnValue = new SimpleVoiceData();
            returnValue.category = (int)Category.CardEffect;
            returnValue.subCategory = (int)CardEffectSub.General;

            r.BaseStream.Seek(0, 0);
            var code = r.ReadInt32();
            var gps = r.ReadGPS();
            returnValue.isMe = gps.controller == 0;
            returnValue.inHand = (gps.location & (uint)CardLocation.Hand) > 0;

            var c = CardsManager.Get(code);
            
            if (GameCard.InPendulumZoneIf(gps, code) && fromHand)
                returnValue.subCategory = (int)CardEffectSub.PendulumScale;
            else if (GameCard.InPendulumZoneIf(gps, code))
                returnValue.subCategory = (int)CardEffectSub.PendulumEffect;
            else if (c.HasType(CardType.Monster))
                returnValue.subCategory = (int)CardEffectSub.MonsterEffect;

            if ((gps.location & (uint)CardLocation.MonsterZone) == 0)
            {
                if (c.HasType(CardType.Spell))
                {
                    returnValue.subCategory = (int)CardEffectSub.Magic;
                    if (c.HasType(CardType.QuickPlay))
                        returnValue.subCategory = (int)CardEffectSub.QuickPlayMagic;
                    if (c.HasType(CardType.Continuous))
                        returnValue.subCategory = (int)CardEffectSub.PermanentMagic;
                    if (c.HasType(CardType.Equip))
                        returnValue.subCategory = (int)CardEffectSub.EquipMagic;
                    if (c.HasType(CardType.Ritual))
                        returnValue.subCategory = (int)CardEffectSub.RitualMagic;
                    if (c.HasType(CardType.Field))
                        returnValue.subCategory = (int)CardEffectSub.FieldMagic;
                }
                if (c.HasType(CardType.Trap))
                {
                    returnValue.subCategory = (int)CardEffectSub.Trap;
                    if (c.HasType(CardType.Continuous))
                        returnValue.subCategory = (int)CardEffectSub.PermanentTrap;
                    if (c.HasType(CardType.Counter))
                        returnValue.subCategory = (int)CardEffectSub.CounterTrap;
                }
            }
            return returnValue;
        }

        static VoiceData GetVoiceByCard(VoicesData target, VoiceInfoEntry entry, int card, int engineparam, bool isMe)
        {
            var returnValue = new VoiceData();
            returnValue.name = string.Empty;

            if(entry == null)
                return returnValue;
            card = GetCidDefaultAltCard(card);
            var cid = Cid2Ydk.GetCID(card);
            if (cid == card)
                return returnValue;

            var tempStrings = new List<string>();
            foreach(var value in entry.rawKvp.Values)
            {
                if (value.cards == null)
                    continue;
                if (value.cards.Contains(cid))
                {
                    tempStrings.Add(value.shortName);
                    if (value.engineparams != null && value.engineparams.Contains(engineparam))
                    {
                        tempStrings.Clear();
                        tempStrings.Add(value.shortName);
                        break;
                    }
                }
            }
            if(tempStrings.Count > 0)
                returnValue.name = tempStrings[UnityEngine.Random.Range(0, tempStrings.Count)];
            if(returnValue.name != string.Empty)
            {
                returnValue.num = GetVoiceNum(target, returnValue.name);
                returnValue.me = isMe;
                returnValue.wait = true;
                returnValue.delay = 0f;
            }

            return returnValue;
        }

        static int GetCidDefaultAltCard(int card)
        {
            var data = CardsManager.Get(card);
            if (card == 89631139 || data.Alias == 89631139)//ÇàÑÛ°×Áú
                return 89631141;
            if (card == 46986414 || data.Alias == 46986414)//ºÚÄ§ÊõÊ¦
                return 46986417;
            return card;
        }

        //0 
        //1 wining
        //2 losing
        static int LeadingStateOfPlayer()
        {
            var core = Program.instance.ocgcore;

            if (core.life0 >= core.lpLimit / 2)
            {
                if (core.life1 < core.lpLimit / 2)
                    return 1;
            }
            else
            {
                if (core.life1 >= core.lpLimit / 2)
                    return 2;

                if (core.life0 >= core.lpLimit / 4 && core.life1 < core.lpLimit / 4)
                    return 1;

                if (core.life0 < core.lpLimit / 4)
                    return 2;
            }
            return 0;
        }

        static int LeadingStateOfRival()
        {
            var core = Program.instance.ocgcore;
            if (core.life1 >= core.lpLimit / 2)
            {
                if (core.life0 < core.lpLimit / 2)
                    return 1;
            }
            else
            {
                if (core.life0 >= core.lpLimit / 2)
                    return 2;

                if (core.life1 >= core.lpLimit / 4 && core.life0 < core.lpLimit / 4)
                    return 1;

                if (core.life1 < core.lpLimit / 4)
                    return 2;
            }
            return 0;
        }


    }

    [Serializable]
    public class VoiceInfo
    {
        public string fullName;
        public string shortName;
        public string voiceIdx;
        public int[] cards;
        public object[] duelists;
        public int[] skills;
        public int[] situations;
        public int[] engineparams;
        public object groupingKeys;
        public int subCategoryIndex;
        public int patternIndex;
    }

    [Serializable]
    public class VoiceInfoEntry
    {
        public Dictionary<string, VoiceInfo> rawKvp;
    }

    [Serializable]
    public class VoicesData
    {
        public int DummyFlag;
        public Dictionary<string, int> NumVoices;
        public int labelver;
        public VoiceInfoEntry BeforeDuel;
        public VoiceInfoEntry BeforeDuelSp;
        public VoiceInfoEntry DuelStart;
        public VoiceInfoEntry TurnStart;
        [JsonProperty("TurnStart.01")]
        public VoiceInfoEntry TurnStart01;
        public VoiceInfoEntry Draw;
        [JsonProperty("Draw.01")]
        public VoiceInfoEntry Draw01;
        public VoiceInfoEntry DestinyDraw;
        public VoiceInfoEntry BeforeCardEffect;
        public VoiceInfoEntry CardEffect;
        public VoiceInfoEntry MainMagicTrap;//
        public VoiceInfoEntry MainMonsterEffect;//
        public VoiceInfoEntry BeforeSummon;
        public VoiceInfoEntry Summon;
        public VoiceInfoEntry None;
        public VoiceInfoEntry MainMonsterSummon;//
        public VoiceInfoEntry BattleStart;
        public VoiceInfoEntry BeforeAttackNormal;
        public VoiceInfoEntry BeforeAttackFinish;
        public VoiceInfoEntry Attack;
        public VoiceInfoEntry DirectAttack;
        public VoiceInfoEntry MainMonsterAttack;//
        public VoiceInfoEntry CardSet;
        public VoiceInfoEntry TurnEnd;
        public VoiceInfoEntry Damage;
        public VoiceInfoEntry FinishDamage;
        public VoiceInfoEntry CostDamage;
        public VoiceInfoEntry BigDamage;
        public VoiceInfoEntry AfterDamage;
        public VoiceInfoEntry AfterBigDamage;
        public VoiceInfoEntry Win;
        public VoiceInfoEntry WinSp;
        public VoiceInfoEntry Lose;
        public VoiceInfoEntry LoseSp;
        public VoiceInfoEntry Taunt;
        public VoiceInfoEntry Surprise;
        public VoiceInfoEntry Title;
        public VoiceInfoEntry Skill;
        public VoiceInfoEntry Chat;
        public VoiceInfoEntry CharaChange;
        public VoiceInfoEntry SwitchToPartner;
        public VoiceInfoEntry BeforeMainSummon;//
        public VoiceInfoEntry RidingDuelStart;
        public VoiceInfoEntry CoinTossOfMagicTrap;
        public VoiceInfoEntry CoinTossOfMonster;
        public VoiceInfoEntry BeforeDimensionDuel;
        public VoiceInfoEntry DimensionDuelStart;
        public VoiceInfoEntry Transformation;
        public VoiceInfoEntry ActionDuelStart;
        public VoiceInfoEntry ActionCard;
        public VoiceInfoEntry BeforeMainReincarnationSummon;//
        public VoiceInfoEntry MainMonsterReincarnationSummon;//
        public VoiceInfoEntry RushDuelStart;
        public VoiceInfoEntry RidingRushDuelStart;

        public VoiceInfoEntry GetCategoryEntry(Category category)
        {
            switch(category)
            {
                case Category.BeforeDuel:
                    return BeforeDuel;
                case Category.DuelStart:
                    return DuelStart;
                case Category.TurnStart:
                    return TurnStart;
                case Category.Draw:
                    return Draw;
                case Category.DestinyDraw:
                    return DestinyDraw;
                case Category.BeforeCardEffect:
                    return BeforeCardEffect;
                case Category.CardEffect:
                    return CardEffect;
                case Category.MainMagicTrap:
                    return MainMagicTrap;
                case Category.MainMonsterEffect:
                    return MainMonsterEffect;
                case Category.BeforeSummon:
                    return BeforeSummon;
                case Category.Summon:
                    return Summon;
                case Category.None:
                    return None;
                case Category.MainMonsterSummon:
                    return MainMonsterSummon;
                case Category.BattleStart:
                    return BattleStart;
                case Category.BeforeAttackNormal:
                    return BeforeAttackNormal;
                case Category.BeforeAttackFinish:
                    return BeforeAttackFinish;
                case Category.Attack:
                    return Attack;
                case Category.DirectAttack:
                    return DirectAttack;
                case Category.MainMonsterAttack:
                    return MainMonsterAttack;
                case Category.CardSet:
                    return CardSet;
                case Category.TurnEnd:
                    return TurnEnd;
                case Category.Damage:
                    return Damage;
                case Category.FinishDamage:
                    return FinishDamage;
                case Category.CostDamage:
                    return CostDamage;
                case Category.BigDamage:
                    return BigDamage;
                case Category.AfterDamage:
                    return AfterDamage;
                case Category.AfterBigDamage:
                    return AfterBigDamage;
                case Category.Win:
                    return Win;
                case Category.Lose:
                    return Lose;
                case Category.Taunt:
                    return Taunt;
                case Category.Surprise:
                    return Surprise;
                case Category.Title:
                    return Title;
                case Category.Skill:
                    return Skill;
                case Category.Chat:
                    return Chat;
                case Category.CharaChange:
                    return CharaChange;
                case Category.SwitchToPartner:
                    return SwitchToPartner;
                case Category.BeforeMainSummon:
                    return BeforeMainSummon;
                case Category.RidingDuelStart:
                    return RidingDuelStart;
                case Category.CoinTossOfMagicTrap:
                    return CoinTossOfMagicTrap;
                case Category.CoinTossOfMonster:
                    return CoinTossOfMonster;
                case Category.BeforeDimensionDuel:
                    return BeforeDimensionDuel;
                case Category.DimensionDuelStart:
                    return DimensionDuelStart;
                case Category.Transformation:
                    return Transformation;
                case Category.ActionDuelStart:
                    return ActionDuelStart;
                case Category.ActionCard:
                    return ActionCard;
                case Category.BeforeMainReincarnationSummon:
                    return BeforeMainReincarnationSummon;
                case Category.MainMonsterReincarnationSummon:
                    return MainMonsterReincarnationSummon;
                case Category.RushDuelStart:
                    return RushDuelStart;
                case Category.RidingRushDuelStart:
                    return RidingRushDuelStart;

                default: 
                    return null;

            }
        }

        public List<VoiceInfoEntry> GetEntryWithCard()
        {
            var returnValue = new List<VoiceInfoEntry>() 
            { 
                MainMagicTrap,
                MainMonsterEffect,
                MainMonsterSummon,
                MainMonsterAttack,
                BeforeMainSummon,
                BeforeMainReincarnationSummon,
                MainMonsterReincarnationSummon
            };
            return returnValue;
        }
    }


    [Serializable]
    public class LineInfo
    {
        public int face;
        public int frame;
        public int cutin;
        public int[] card;
        public int[] duelist;
        public string text;
    }

    [Serializable]
    public class LinesData
    {
        public string _GRP_;
        public string _LNG_;
        public Dictionary<string, LineInfo> info;
    }
}


