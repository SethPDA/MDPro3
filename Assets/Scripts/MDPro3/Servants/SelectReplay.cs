using DG.Tweening;
using MDPro3.UI;
using MDPro3.UI.PropertyOverrider;
using Percy;
using SevenZip.Compression.LZMA;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using GameMessage = MDPro3.YGOSharp.OCGWrapper.Enums.GameMessage;

namespace MDPro3
{
    public class SelectReplay : Servant
    {
        [Header("SelectReplay")]
        [SerializeField] private RectTransform overviewContent;
        [SerializeField] private Scrollbar scrollBar;

        [HideInInspector] public SelectionToggle_Replay lastSelectedReplayItem;
        public SuperScrollView superScrollView;
        private PercyOCG percy;
        private Dictionary<string, YRP> cachedYRPs = new ();

        #region Servant
        public override void Initialize()
        {
            depth = 1;
            showLine = false;
            returnServant = Program.instance.menu;
            base.Initialize();
            transform.GetChild(0).gameObject.SetActive(false);
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            Print();
        }

        protected override void ApplyHideArrangement(int nextDepth)
        {
            base.ApplyHideArrangement(nextDepth);
            DOTween.To(v => { }, 0, 0, transitionTime).OnComplete(() =>
            {
                superScrollView.Clear();
            });
        }

        public override void PerFrameFunction()
        {
            if (!showing) return;
            if (NeedResponseInput())
            {
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();
                if (UserInput.RightScrollWheel.y != 0f)
                {
                    scrollBar.value = Mathf.Clamp01(scrollBar.value + UserInput.RightScrollWheel.y * 1000f * Time.unscaledDeltaTime / overviewContent.rect.height);
                }
            }
        }

        public override void OnExit()
        {
            if (Program.exitOnReturn)
                Program.GameQuit();
            else
                Program.instance.ShiftToServant(returnServant);
        }

        public override void SelectLastSelectable()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedReplayItem.gameObject);
        }

        #endregion

        public void SelecLastReplayItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelectable();
        }

        private void SelectZero()
        {
            var item0 = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Replay>();
            item0.SetToggleOn();
            lastSelectedReplayItem = item0;
        }

        public void Print(/*string search = ""*/)
        {
            superScrollView?.Clear();

            if (!Directory.Exists(Program.replayPath))
                Directory.CreateDirectory(Program.replayPath);
            var fileInfos = new DirectoryInfo(Program.replayPath).GetFiles();
            if (sortByName)
                Array.Sort(fileInfos, Tools.CompareName);
            else
                Array.Sort(fileInfos, Tools.CompareTime);

            List<string[]> tasks = new List<string[]>();
            int count = 0;
            for (int i = 0; i < fileInfos.Length; i++)
            {
                if (fileInfos[i].Name.EndsWith(Program.yrp3dExpansion))
                {
                    var task = new string[] { count.ToString(), fileInfos[i].Name.Replace(Program.yrp3dExpansion, string.Empty) };
                    tasks.Add(task);
                    count++;
                }
                else if (fileInfos[i].Name.EndsWith(Program.yrpExpansion))
                {
                    var task = new string[] { count.ToString(), fileInfos[i].Name };
                    tasks.Add(task);
                    count++;
                }
            }

            var handle = Addressables.LoadAssetAsync<GameObject>("ItemReplay");
            handle.Completed += (result) =>
            {
                var itemHeight = PropertyOverrider.NeedMobileLayout() ? 180f : 150f;
                float topPadding = PropertyOverrider.NeedMobileLayout() ? 148f : 134f;
                float space = itemHeight - (PropertyOverrider.NeedMobileLayout() ? 152f : 122f);
                float bottomPadding = (PropertyOverrider.NeedMobileLayout() ? 64f : 54f) - space;
                superScrollView = new SuperScrollView(
                        1,
                        700,
                        itemHeight,
                        topPadding,
                        bottomPadding,
                        result.Result,
                        ItemOnListRefresh,
                        Manager.GetElement<ScrollRect>("ScrollRect"));
                superScrollView.Print(tasks);
                if (tasks.Count > 0)
                    SelectZero();
            };
        }

        private void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Replay>();
            handler.index = int.Parse(task[0]);
            handler.replayName = task[1];
            handler.Refresh();
        }

        public void KF_Replay(string name, bool god = false)
        {
            string fileName = Program.replayPath + name + (name.EndsWith(Program.yrpExpansion) ? string.Empty : Program.yrp3dExpansion);
            if (!File.Exists(fileName))
            {
                fileName = fileName.Replace(Program.yrp3dExpansion, Program.yrpExpansion);
                if (!File.Exists(fileName))
                    return;
            }
            bool yrp3d = fileName.Length > 6 && fileName.ToLower().Substring(fileName.Length - 6, 6) == Program.yrp3dExpansion;
            try
            {
                if (yrp3d)
                {
                    if (god)
                    {
                        MessageManager.Cast(InterString.Get("您正在观看旧版的回放（上帝视角），不保证稳定性。"));
                        percy?.Dispose();
                        percy = new PercyOCG();
                        var replays = GetYRPBuffer(fileName);
                        var collections = TcpHelper.GetPackages(percy.ygopro.GetYRP3dBuffer(GetYRP(replays[replays.Count - 1])));
                        PushCollection(collections);
                    }
                    else
                    {
                        var collection = TcpHelper.ReadPackagesInRecord(fileName);
                        PushCollection(collection);
                    }
                }
                else
                {
                    MessageManager.Cast(InterString.Get("您正在观看旧版的回放（上帝视角），不保证稳定性。"));
                    percy?.Dispose();
                    percy = new PercyOCG();
                    var collections = TcpHelper.GetPackages(percy.ygopro.GetYRP3dBuffer(GetYRP(File.ReadAllBytes(fileName))));
                    PushCollection(collections);
                }
            }
            catch
            {
                MessageManager.Cast(InterString.Get("回放没有录制完整。"));
            }
        }
        private List<byte[]> GetYRPBuffer(string path)
        {
            if (path.EndsWith(Program.yrpExpansion))
                return new List<byte[]>() { File.ReadAllBytes(path) };
            var returnValue = new List<byte[]>();
            try
            {
                var collection = TcpHelper.ReadPackagesInRecord(path);
                foreach (var item in collection)
                    if (item.Function == (int)GameMessage.sibyl_replay)
                    {
                        var replay = item.Data.reader.ReadToEnd();
                        // TODO: don't include other replays
                        returnValue.Add(replay);
                    }
            }
            catch (Exception e) { Debug.LogError(e); }
            return returnValue;
        }

        private YRP GetYRP(byte[] buffer)
        {
            var returnValue = new YRP();
            try
            {
                var reader = new BinaryReader(new MemoryStream(buffer));
                returnValue.ID = reader.ReadInt32();
                returnValue.Version = reader.ReadInt32();
                returnValue.Flag = reader.ReadInt32();
                returnValue.Seed = reader.ReadUInt32();
                returnValue.DataSize = reader.ReadInt32();
                returnValue.Hash = reader.ReadInt32();
                returnValue.Props = reader.ReadBytes(8);
                var raw = reader.ReadToEnd();
                if ((returnValue.Flag & 0x1) > 0)
                {
                    var lzma = new Decoder();
                    lzma.SetDecoderProperties(returnValue.Props);
                    var decompressed = new MemoryStream();
                    lzma.Code(new MemoryStream(raw), decompressed, raw.LongLength, returnValue.DataSize, null);
                    raw = decompressed.ToArray();
                }

                reader = new BinaryReader(new MemoryStream(raw));
                if ((returnValue.Flag & 0x2) > 0)
                {
                    Room.mode = 2;
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData[0].name = reader.ReadUnicode(20);
                    returnValue.playerData[1].name = reader.ReadUnicode(20);
                    returnValue.playerData[2].name = reader.ReadUnicode(20);
                    returnValue.playerData[3].name = reader.ReadUnicode(20);
                    returnValue.StartLp = reader.ReadInt32();
                    returnValue.StartHand = reader.ReadInt32();
                    returnValue.DrawCount = reader.ReadInt32();
                    returnValue.opt = reader.ReadInt32();
                    Program.instance.ocgcore.MasterRule = returnValue.opt >> 16;
                    for (var i = 0; i < 4; i++)
                    {
                        var count = reader.ReadInt32();
                        for (var i2 = 0; i2 < count; i2++) returnValue.playerData[i].main.Add(reader.ReadInt32());
                        count = reader.ReadInt32();
                        for (var i2 = 0; i2 < count; i2++) returnValue.playerData[i].extra.Add(reader.ReadInt32());
                    }
                }
                else
                {
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData.Add(new YRP.PlayerData());
                    returnValue.playerData[0].name = reader.ReadUnicode(20);
                    returnValue.playerData[1].name = reader.ReadUnicode(20);
                    returnValue.StartLp = reader.ReadInt32();
                    returnValue.StartHand = reader.ReadInt32();
                    returnValue.DrawCount = reader.ReadInt32();
                    returnValue.opt = reader.ReadInt32();
                    Program.instance.ocgcore.MasterRule = returnValue.opt >> 16;
                    for (var i = 0; i < 2; i++)
                    {
                        var count = reader.ReadInt32();
                        for (var i2 = 0; i2 < count; i2++) returnValue.playerData[i].main.Add(reader.ReadInt32());
                        count = reader.ReadInt32();
                        for (var i2 = 0; i2 < count; i2++) returnValue.playerData[i].extra.Add(reader.ReadInt32());
                    }
                }
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                    returnValue.gameData.Add(reader.ReadBytes(reader.ReadByte()));
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }

            return returnValue;
        }

        public YRP CacheYRP(string replay)
        {
            if (cachedYRPs.ContainsKey(replay))
                return cachedYRPs[replay];
            YRP yrp;
            if (File.Exists(Program.replayPath + replay))
                yrp = GetYRP(File.ReadAllBytes(Program.replayPath + replay));
            else
            {
                var buffer = GetYRPBuffer(Program.replayPath + replay + Program.yrp3dExpansion);
                if (buffer.Count == 0)
                    yrp = null;
                else
                    yrp = GetYRP(buffer[0]);
            }
            if (yrp != null)
                cachedYRPs.Add(replay, yrp);
            return yrp;
        }

        void PushCollection(List<Package> collection)
        {
            Program.instance.ocgcore.returnServant = Program.instance.replay;
            Program.instance.ocgcore.handler = a => { };
            Program.instance.ocgcore.name_0 = Config.Get("ReplayPlayerName0", "@ui");
            Program.instance.ocgcore.name_0_tag = Config.Get("ReplayPlayerName0Tag", "@ui");
            Program.instance.ocgcore.name_0_c = Program.instance.ocgcore.name_0;
            Program.instance.ocgcore.name_1 = Config.Get("ReplayPlayerName1", "@ui");
            Program.instance.ocgcore.name_1_tag = Config.Get("ReplayPlayerName1Tag", "@ui");
            Program.instance.ocgcore.name_1_c = Program.instance.ocgcore.name_1;
            Program.instance.ocgcore.timeLimit = 240;
            Program.instance.ocgcore.lpLimit = 8000;
            Program.instance.ocgcore.isFirst = true;
            //Program.instance.ocgcore.inAI = false;
            Program.instance.ocgcore.condition = OcgCore.Condition.Replay;
            Program.instance.ShiftToServant(Program.instance.ocgcore);
            Program.instance.ocgcore.FlushPackages(collection);
        }

        public void OnRename()
        {
            var selections = new List<string>()
            {
                InterString.Get("请输入新的回放名称"),
                superScrollView.items[superScrollView.selected].args[1].Replace(Program.yrpExpansion, string.Empty)
            };
            UIManager.ShowPopupInput(selections, ReplayRename, null, TmpInputValidation.ValidationType.Path);
        }

        void ReplayRename(string newName)
        {
            string replay = superScrollView.items[superScrollView.selected].args[1];
            if (replay.EndsWith(Program.yrpExpansion))
                File.Move(Program.replayPath + replay, Program.replayPath + newName + Program.yrpExpansion);
            else
                File.Move(Program.replayPath + replay + Program.yrp3dExpansion, Program.replayPath + newName + Program.yrp3dExpansion);
            Print();
        }

        public void OnPlay()
        {
            Program.instance.replay.KF_Replay(superScrollView.items[superScrollView.selected].args[1]);
        }
        public void OnGod()
        {
            Program.instance.replay.KF_Replay(superScrollView.items[superScrollView.selected].args[1], true);
        }
        public void OnDelete()
        {
            var replay = superScrollView.items[superScrollView.selected].args[1];
            if (File.Exists(Program.replayPath + replay))
                File.Delete(Program.replayPath + replay);
            else
                File.Delete(Program.replayPath + replay + Program.yrp3dExpansion);
            MessageManager.Cast(InterString.Get("已删除回放「[?]」。", replay));
            Print();
        }

        bool sortByName = true;
        public void OnSort()
        {
            sortByName = !sortByName;
            if (sortByName)
                Manager.GetElement<SelectionButton>("ButtonSort").SetButtonText(InterString.Get("名称排序"));
            else
                Manager.GetElement<SelectionButton>("ButtonSort").SetButtonText(InterString.Get("时间排序"));

            Print();
        }
        public void OnDeck(int player)
        {
            var replay = superScrollView.items[superScrollView.selected].args[1];
            var yrp = cachedYRPs[replay];
            replay = replay.Replace(Program.yrpExpansion, string.Empty);

            var deckName = replay +"_" + yrp.playerData[player].name;
            var deck = new MDPro3.YGOSharp.Deck(yrp.playerData[player].main, yrp.playerData[player].extra, new List<int>());
            Program.instance.editDeck.SwitchCondition(EditDeck.Condition.ReplayDeck, deckName, deck);
            Program.instance.ShiftToServant(Program.instance.editDeck);
        }
    }
}
