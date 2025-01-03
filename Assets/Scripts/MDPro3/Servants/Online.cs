using System;
using MDPro3.UI;
using MDPro3.YGOSharp;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using TMPro;
using MDPro3.UI.PropertyOverrider;
using UnityEngine.EventSystems;
using MDPro3.Net;
using YgomSystem.ElementSystem;

namespace MDPro3
{
    public class Online : Servant
    {
        [Header("Online")]
        [SerializeField] private GameObject PageLegacy;
        [SerializeField] private GameObject PageHost;
        [SerializeField] private GameObject PageMyCard;

        [Header("Legacy")]
        public SelectionToggle_Address lastSelectedAddressItem;
        public TMP_InputField inputName;
        public TMP_InputField inputHost;
        public TMP_InputField inputPort;
        public TMP_InputField inputPassword;

        [Header("Local Server")]
        public TMP_InputField inputTime;
        public TMP_InputField inputLP;
        public TMP_InputField inputHand;
        public TMP_InputField inputDraw;

        [Header("My Card")]
        public GameObject goMyCardLogin;
        public GameObject goMyCardFunctions;
        public SelectionToggle_Watch lastSelectedWatchItem;

        public TMP_InputField inputMyCardAccount;
        public TMP_InputField inputMyCardPassword;
        public TMP_InputField inputDuelist;

        public WatchListHandler watchListHandler;

        public struct HostAddress
        {
            public string name;
            public string host;
            public string port;
            public string password;
        }

        SuperScrollView superScrollView;
        private List<string[]> tasks = new List<string[]>();

        readonly string savePath = "Data/hosts.conf";
        public List<HostAddress> addresses = new List<HostAddress>();

        #region Servant
        public override void Initialize()
        {
            depth = 1;
            showLine = true;
            returnServant = Program.instance.menu;
            inputName.onEndEdit.AddListener(OnNameChange);
            inputHost.onEndEdit.AddListener(OnHostChange);
            inputPort.onEndEdit.AddListener(OnPortChange);
            inputPassword.onEndEdit.AddListener(OnPasswordChange);
            base.Initialize();
            Manager.GetElement<SelectionToggle>("ToggleLegacy").SetToggleOn();
            LoadHostAddress();
            TryTokenIn();

            transform.GetChild(0).gameObject.SetActive(false);
        }
        protected override void ApplyShowArrangement(int preDepth)
        {
            if (Program.exitOnReturn)
            {
                Program.GameQuit();
                return;
            }

            base.ApplyShowArrangement(preDepth);
            inputName.text = Config.Get("DuelPlayerName0", "@ui");
            inputHost.text = Config.Get("Host", "s1.ygo233.com");
            inputPort.text = Config.Get("Port", "233");
            inputPassword.text = Config.Get("Password", "@ui");
            RefreshDeckSelector();
            StartCoroutine(RefreshMyCardAssets());
        }

        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            Config.Save();
            Save();
        }

        public override void SelectLastSelectable()
        {
            if (!showing)
                return;
            if (PageLegacy.activeInHierarchy)
            {
                if(Selected != null && Selected.gameObject.activeInHierarchy)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonJoin"));
            }
            else if(PageHost.activeInHierarchy)
            {
                if (Selected != null && Selected.gameObject.activeInHierarchy)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonCreate"));
            }
            else if(goMyCardLogin.activeInHierarchy)
            {
                if (Selected != null && Selected.gameObject.activeInHierarchy)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonLogin"));
            }
            else if (goMyCardFunctions.activeInHierarchy)
            {
                if (Selected != null && Selected.gameObject.activeInHierarchy)
                    EventSystem.current.SetSelectedGameObject(Selected.gameObject);
                else
                    EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonAMatch"));
            }
        }

        protected override bool NeedResponseInput()
        {
            if(!showing)
                return false;
            if(inTransition)
                return false;

            if (PageLegacy.activeInHierarchy)
            {
                if(inputName.isFocused)
                    return false;
                if(inputHost.isFocused)
                    return false;
                if(inputPort.isFocused)
                    return false;
                if(inputPassword.isFocused)
                    return false;
            }
            else if (PageHost.activeInHierarchy)
            {
                if(inputTime.isFocused)
                    return false;
                if(inputLP.isFocused)
                    return false;
                if(inputHand.isFocused)
                    return false;
                if(inputDraw.isFocused)
                    return false;
            }
            else if (goMyCardLogin.activeInHierarchy)
            {
                if (inputMyCardAccount.isFocused)
                    return false;
                if(inputMyCardPassword.isFocused)
                    return false;
            }
            else if (goMyCardFunctions.activeInHierarchy)
            {
                if (inputDuelist.isFocused)
                    return false;
            }

            return base.NeedResponseInput();
        }

        public override void PerFrameFunction()
        {
            if (!showing) return;
            if (!NeedResponseInput())
                return;

            if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                OnReturn();

            if (UserInput.WasLeftShoulderPressed)
                Manager.GetElement<SelectionToggle_Online>("ToggleLegacy").OnLeftSelection();
            if (UserInput.WasRightShoulderPressed)
                Manager.GetElement<SelectionToggle_Online>("ToggleLegacy").OnRightSelection();
        }

        #endregion

        #region Legacy
        void LoadHostAddress()
        {
            if (!File.Exists(savePath))
                return;
            var txtString = File.ReadAllText(savePath);
            var lines = txtString.Replace("\r", "").Split('\n');
            for (var i = 0; i < lines.Length; i++)
            {
                var mats = Regex.Split(lines[i], " ");
                var address = new HostAddress();
                if (mats.Length >= 3)
                {
                    address.name = mats[0];
                    address.host = mats[1];
                    address.port = mats[2];
                    address.password = string.Empty;
                    if (mats.Length > 3)
                        address.password = mats[3];
                    addresses.Add(address);
                }
            }
            Print();
        }
        public void Save()
        {
            var content = "";
            foreach (var address in addresses)
            {
                content += address.name + " ";
                content += address.host + " ";
                content += address.port + " ";
                content += address.password + " \r\n";
            }
            File.WriteAllText(savePath, content);
        }
        public void Print(string search = "")
        {
            superScrollView?.Clear();
            tasks.Clear();
            foreach (var address in addresses)
            {
                if (address.name.Contains(search))
                {
                    string[] task = new string[] { address.name, address.host, address.port, address.password };
                    tasks.Add(task);
                }
            }
            var handle = Addressables.LoadAssetAsync<GameObject>("ItemAddress");
            handle.Completed += (result) =>
            {
                var itemWidth = PropertyOverrider.NeedMobileLayout() ? 460f : 360f;
                var itemHeight = PropertyOverrider.NeedMobileLayout() ? 80f : 40f;

                superScrollView = new SuperScrollView(
                    1,
                    itemWidth,
                    itemHeight,
                    0,
                    0,
                    result.Result,
                    ItemOnListRefresh,
                    Manager.GetElement<ScrollRect>("ScrollRect"));
                superScrollView.Print(tasks);
                if (superScrollView.items.Count > 0)
                    lastSelectedAddressItem = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Address>();
            };
        }

        void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Address>();
            handler.addressName = task[0];
            handler.addressHost = task[1];
            handler.addressPort = task[2];
            handler.addressPassword = task[3];
            handler.Refresh();
        }


        public void OnSaveAddress()
        {
            var title = InterString.Get("请输入预设名称");
            var selections = new List<string>()
        {
            InterString.Get("请输入预设名称"),
            string.Empty
        };
            UIManager.ShowPopupInput(selections, AddAddress, null, TmpInputValidation.ValidationType.NoSpace);
        }
        private void AddAddress(string name)
        {
            var address = new HostAddress();
            address.name = name;
            address.host = inputHost.text;
            address.port = inputPort.text;
            address.password = inputPassword.text;
            foreach (var add in addresses)
            {
                if (add.name == name)
                {
                    addresses.Remove(add);
                    break;
                }
            }
            addresses.Add(address);
            Save();
            Print();
        }
        void OnNameChange(string name)
        {
            Config.Set("DuelPlayerName0", name == "" ? "@ui" : name);
            Config.Save();
        }
        public void OnHostChange(string host)
        {
            Config.Set("Host", host);
            Config.Save();
        }
        public void OnPortChange(string port)
        {

            Config.Set("Port", port);
            Config.Save();
        }
        public void OnPasswordChange(string password)
        {
            Config.Set("Password", password == "" ? "@ui" : password);
            Config.Save();
        }

        public void Join()
        {
            KF_OnlineGame(inputName.text, inputHost.text, inputPort.text, inputPassword.text);
        }
        public void KF_OnlineGame(string name, string ip, string port, string password)
        {
            if (name == "")
            {
                MessageManager.Cast(InterString.Get("用户名不能为空。"));
                return;
            }

            if (ip == "" || port == "")
            {
                MessageManager.Cast(InterString.Get("主机地址和端口不能为空。"));
                return;
            }
            Room.fromSolo = false;
            Room.fromLocalHost = false;
            TcpHelper.LinkStart(ip, Config.Get("DuelPlayerName0", "@ui"), port, password, false, null);
        }
        public void SelectLastAddressItem()
        {
            if(lastSelectedAddressItem != null)
            {
                UserInput.NextSelectionIsAxis = true;
                EventSystem.current.SetSelectedGameObject(lastSelectedAddressItem.gameObject);
            }
        }
        #endregion

        #region Local Host
        public void CreateServer()
        {
            int port = 7911;
            while (!TcpHelper.IsPortAvailable(port))
            {
                port++;
            }

            string args = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                port.ToString(),
                BanlistManager.GetIndexByName(serverSelections[1]),
                GetPoolCodeByName(serverSelections[2]),
                GetModeCodeByName(serverSelections[3]),
                "F",
                serverSelections[4],
                serverSelections[5],
                serverSelections[7],
                serverSelections[8],
                serverSelections[9],
                serverSelections[6],
                "0"
                );
            Room.fromSolo = false;
            Room.fromLocalHost = true;
            YgoServer.StartServer(args);
            TcpHelper.LinkStart("127.0.0.1", Config.Get("DuelPlayerName0", "@ui"), port.ToString(), "", true, null);
        }

        string GetPoolCodeByName(string pool)
        {
            for (int i = 1481; i < 1487; i++)
            {
                if (StringHelper.GetUnsafe(i) == pool)
                    return (i - 1481).ToString();
            }
            return "5";
        }
        string GetModeCodeByName(string mode)
        {
            for (int i = 1244; i < 1247; i++)
            {
                if (StringHelper.GetUnsafe(i) == mode)
                    return (i - 1244).ToString();
            }
            return "0";
        }

        public List<string> serverSelections;
        public static bool severSelectionsInitialized;

        public void OnServer()
        {
            if (!severSelectionsInitialized)
            {
                serverSelections = new List<string>()
                {
                    InterString.Get("创建主机"),
                    BanlistManager.Banlists[0].Name,
                    StringHelper.GetUnsafe(1481),
                    StringHelper.GetUnsafe(1244),
                    "F",
                    "F",
                    "180",
                    "8000",
                    "5",
                    "1"
                };
                severSelectionsInitialized = true;
            }
            UIManager.ShowPopupServer(serverSelections);
        }
        public void LocalHostInitialize()
        {
            Manager.GetElement<SelectionButton>("ButtonLFList").SetButtonText(BanlistManager.Banlists[0].Name);
            Manager.GetElement<SelectionButton>("ButtonPool").SetButtonText(StringHelper.GetUnsafe(1481));
            Manager.GetElement<SelectionButton>("ButtonMode").SetButtonText(StringHelper.GetUnsafe(1244));
            Manager.GetElement<SelectionToggle>("ToggleCheck").SetToggleOff();
            Manager.GetElement<SelectionToggle>("ToggleShuffle").SetToggleOff();
            inputTime.text = "180";
            inputLP.text = "8000";
            inputHand.text = "5";
            inputDraw.text = "1";
        }

        public void OnLocalHostCreate()
        {
            serverSelections = GetSelections();
            CreateServer();
        }

        List<string> GetSelections()
        {
            return new List<string>()
            {
                InterString.Get("创建主机"),
                Manager.GetElement<SelectionButton>("ButtonLFList").GetButtonText(),
                Manager.GetElement<SelectionButton>("ButtonPool").GetButtonText(),
                Manager.GetElement<SelectionButton>("ButtonMode").GetButtonText(),
                Manager.GetElement<SelectionToggle>("ToggleCheck").isOn ? "T" : "F",
                Manager.GetElement<SelectionToggle>("ToggleShuffle").isOn ? "T" : "F",
                inputTime.text == string.Empty ? "0" : inputTime.text,
                inputLP.text == string.Empty ? "8000" : inputLP.text,
                inputHand.text == string.Empty ? "5" : inputHand.text,
                inputDraw.text == string.Empty ? "1" : inputDraw.text
            };
        }

        public void OnLflist()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("禁限卡表"),
                string.Empty
            };
            foreach (var list in BanlistManager.Banlists)
                selections.Add(list.Name);
            UIManager.ShowPopupSelection(selections, ChangeBanlist, null);
        }
        void ChangeBanlist()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            Manager.GetElement<SelectionButton>("ButtonLFList").SetButtonText(selected);
        }

        public void OnPool()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("卡片允许"),
                string.Empty
            };
            for (int i = 1481; i < 1487; i++)
                selections.Add(StringHelper.GetUnsafe(i));
            UIManager.ShowPopupSelection(selections, ChangePool, null);
        }
        void ChangePool()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            Manager.GetElement<SelectionButton>("ButtonPool").SetButtonText(selected);
        }
        public void OnMode()
        {
            List<string> selections = new List<string>
            {
                InterString.Get("决斗模式"),
                string.Empty
            };
            for (int i = 1244; i < 1247; i++)
                selections.Add(StringHelper.GetUnsafe(i));
            UIManager.ShowPopupSelection(selections, ChangeMode, null);
        }
        void ChangeMode()
        {
            string selected = EventSystem.current.
                currentSelectedGameObject.GetComponent<SelectionButton>().GetButtonText();
            Manager.GetElement<SelectionButton>("ButtonMode").SetButtonText(selected);
        }

        #endregion

        #region MyCard

        public void SelectMyCardDefaultButton()
        {
            UserInput.NextSelectionIsAxis = true;
            EventSystem.current.SetSelectedGameObject(Manager.GetElement("ButtonAMatch"));
        }

        public void SelectDeckSelector()
        {
            UserInput.NextSelectionIsAxis = true;
            EventSystem.current.SetSelectedGameObject(Manager.GetElement("DeckSelector"));
        }

        public void SelectLastWatchItem()
        {
            if(lastSelectedWatchItem != null)
            {
                UserInput.NextSelectionIsAxis = true;
                EventSystem.current.SetSelectedGameObject(lastSelectedWatchItem.gameObject);
            }
        }

        public void OnMyCardRegister()
        {
            Application.OpenURL("https://accounts.moecube.com/signup");
        }

        public void OnMyCardLogin()
        {
            if (string.IsNullOrEmpty(inputMyCardAccount.text))
            {
                MessageManager.Cast(InterString.Get("账号不能为空"));
                return;
            }
            if (string.IsNullOrEmpty(inputMyCardPassword.text) || inputMyCardPassword.text.Length < 6)
            {
                MessageManager.Cast(InterString.Get("密码不能少于6位"));
                return;
            }

            StartCoroutine(MyCardLoginAsync());
        }

        IEnumerator MyCardLoginAsync()
        {
            goMyCardLogin.SetActive(false);
            var task = MyCard.Login(inputMyCardAccount.text, inputMyCardPassword.text);
            while(!task.IsCompleted)
                yield return null;
            if (task.Result.user.id == 0)
            {
                MessageManager.Cast(InterString.Get("登录失败：") + task.Result.user.username);
                goMyCardLogin.SetActive(true);
                yield break;
            }
            Config.Set("MyCardToken", task.Result.token);
            Config.Save();
            DoWhenLoginSuccess();
        }

        private void TryTokenIn()
        {
            StartCoroutine(TryTokenInAsync());
        }

        IEnumerator TryTokenInAsync()
        {
            var token = Config.Get("MyCardToken", Config.stringNo);
            if(token == Config.stringNo)
            {
                goMyCardLogin.SetActive(true);
                goMyCardFunctions.SetActive(false);
                yield break;
            }
            var task = MyCard.TokenIn(token);
            while (!task.IsCompleted)
                yield return null;

            if (task.Result.user.id == 0)
            {
                MessageManager.Cast(InterString.Get("MyCard登录失败。"));
                goMyCardLogin.SetActive(true);
                goMyCardFunctions.SetActive(false);
                yield break;
            }
            DoWhenLoginSuccess();
        }

        void DoWhenLoginSuccess()
        {
            goMyCardLogin.SetActive(false);
            MyCard.ConnectToAthleticWatchListWebSocket();
            StartCoroutine(RefreshMyCardAssets());
            StartCoroutine(SyncDecks());
        }

        IEnumerator RefreshMyCardAssets()
        {
            if (MyCard.account == null || MyCard.account.user == null)
                yield break;

            Manager.GetElement<TextMeshProUGUI>("TextUserName").text = MyCard.account.user.name;

            var task = MyCard.GetExp();
            while (!task.IsCompleted)
                yield return null;
            Manager.GetElement<TextMeshProUGUI>("TextExpValue").text = task.Result.exp.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextDPValue").text = task.Result.pt.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextAthleticWinValue").text = task.Result.athletic_win.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextAthleticWinRatioValue").text = task.Result.athletic_wl_ratio + "%";
            Manager.GetElement<TextMeshProUGUI>("TextAthleticRankValue").text = task.Result.arena_rank.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextEntertainCountValue").text = task.Result.entertain_all.ToString();
            Manager.GetElement<TextMeshProUGUI>("TextEntertainRankValue").text = task.Result.exp_rank.ToString();

            while (!Appearance.loaded)
                yield return null;
            Manager.GetElement<RawImage>("RawImageAvatar").material = Appearance.duelFrameMat0;

            if (MyCard.avatar == null)
            {
                var avatarTask = Tools.DownloadImageAsync(MyCard.account.user.avatar);
                while (!avatarTask.IsCompleted)
                    yield return null;
                MyCard.avatar = avatarTask.Result;
                Manager.GetElement<RawImage>("RawImageAvatar").texture = MyCard.avatar;
            }

            goMyCardFunctions.SetActive(true);

            while (TextureManager.container == null)
                yield return null;

            var rankSprites = TextureManager.container.GetRankSprites(task.Result.pt);
            Manager.GetElement<Image>("IconBG").sprite = rankSprites[0];
            Manager.GetElement<Image>("IconRank").sprite = rankSprites[1];
            Manager.GetElement<Image>("IconTier1").sprite = rankSprites[2];
            Manager.GetElement<Image>("IconTier2").sprite = rankSprites[3];
            Manager.GetElement<Image>("IconTier3").sprite = rankSprites[4];
        }

        void RefreshDeckSelector()
        {
            var deckSelector = Manager.GetElement<SelectionButton_DeckSelector>("DeckSelector");
            if (OnlineDeck.decks == null || OnlineDeck.decks.Length == 0)
            {
                deckSelector.SetDeck(null, InterString.Get("未选中有效卡组"));
                return;
            }

            var configDeck = Config.Get("DeckInUse", "@ui");
            bool found = false;
            foreach (var deck in OnlineDeck.decks)
            {
                if (deck.deckName == configDeck)
                {
                    found = true;
                    deckSelector.SetDeck(new Deck(deck.deckYdk, string.Empty, string.Empty), deck.deckName);
                    break;
                }
            }
            if (!found)
            {
                deckSelector.SetDeck(null, InterString.Get("未选中有效卡组"));
            }
        }

        public void OnExitLogin()
        {
            List<string> tasks = new List<string>()
            {
                InterString.Get("退出登录"),
                InterString.Get("是否确认退出登录？"),
                InterString.Get("确认"),
                InterString.Get("取消")
            };
            UIManager.ShowPopupYesOrNo(tasks, ExitLogin, null);
        }

        void ExitLogin()
        {
            Config.Set("MyCardToken", Config.stringNo);
            Config.Save();
            MyCard.account = null;
            MyCard.CloseAthleticWatchListWebSocket();

            goMyCardFunctions.SetActive(false);
            goMyCardLogin.SetActive(true);
            inputMyCardAccount.text = string.Empty;
            inputMyCardPassword.text = string.Empty;
        }

        public void OnDeckSelect()
        {
            Program.instance.selectDeck.SwitchCondition(SelectDeck.Condition.MyCard);
            Program.instance.ShiftToServant(Program.instance.selectDeck);
        }

        public void OnEntertainMatch()
        {
            if(entertainMatch == null)
            {
                StartCoroutine(entertainMatch = EntertainMatchAsync());
                if(athleticMatch != null)
                {
                    StopCoroutine(athleticMatch);
                    athleticMatch = null;
                }
                Manager.GetElement<SelectionButton>("ButtonAMatch").SetButtonText(InterString.Get("竞技匹配"));
            }
            else
            {
                Manager.GetElement<SelectionButton>("ButtonEMatch").SetButtonText(InterString.Get("娱乐匹配"));
                StopCoroutine(entertainMatch);
                entertainMatch = null;
            }
        }
        public void OnAthleticMatch()
        {
            if (athleticMatch == null)
            {
                StartCoroutine(athleticMatch = AthleticMatchAsync());
                if (entertainMatch != null)
                {
                    StopCoroutine(entertainMatch);
                    entertainMatch = null;
                }
                Manager.GetElement<SelectionButton>("ButtonEMatch").SetButtonText(InterString.Get("娱乐匹配"));
            }
            else
            {
                Manager.GetElement<SelectionButton>("ButtonAMatch").SetButtonText(InterString.Get("竞技匹配"));
                StopCoroutine(athleticMatch);
                athleticMatch = null;
            }
        }

        public static IEnumerator entertainMatch;
        public static IEnumerator athleticMatch;

        IEnumerator EntertainMatchAsync()
        {
            var task = MyCard.GetMatchInfo("entertain");
            var startTime = DateTime.Now;

            while(!task.IsCompleted)
            {
                var elapsedTimeInSeconds = (DateTime.Now - startTime).TotalSeconds;
                int minutes = (int)Math.Floor(elapsedTimeInSeconds / 60);
                int seconds = (int)(elapsedTimeInSeconds % 60);
                Manager.GetElement<SelectionButton>("ButtonEMatch").SetButtonText($"{minutes:D2}:{seconds:D2}");
                yield return new WaitForSeconds(0.5f);
            }

            if(task.Result != null)
            {
                Manager.GetElement<SelectionButton>("ButtonEMatch").SetButtonText(InterString.Get("娱乐匹配"));
                TcpHelper.LinkStart(task.Result.address, MyCard.account.user.username, task.Result.port.ToString(), task.Result.password, false, null);
            }
            else
            {
                Manager.GetElement<SelectionButton>("ButtonEMatch").SetButtonText(InterString.Get("匹配失败"));
            }
            entertainMatch = null;
        }
        IEnumerator AthleticMatchAsync()
        {
            var task = MyCard.GetMatchInfo("athletic");
            var startTime = DateTime.Now;

            while (!task.IsCompleted)
            {
                var elapsedTimeInSeconds = (DateTime.Now - startTime).TotalSeconds;
                int minutes = (int)Math.Floor(elapsedTimeInSeconds / 60);
                int seconds = (int)(elapsedTimeInSeconds % 60);
                Manager.GetElement<SelectionButton>("ButtonAMatch").SetButtonText($"{minutes:D2}:{seconds:D2}");
                yield return new WaitForSeconds(0.5f);
            }

            if (task.Result != null)
            {
                Manager.GetElement<SelectionButton>("ButtonAMatch").SetButtonText(InterString.Get("竞技匹配"));
                TcpHelper.LinkStart(task.Result.address, MyCard.account.user.username, task.Result.port.ToString(), task.Result.password, false, null);
            }
            else
            {
                Manager.GetElement<SelectionButton>("ButtonAMatch").SetButtonText(InterString.Get("匹配失败"));
            }
            athleticMatch = null;
        }

        IEnumerator SyncDecks()
        {
            if(OnlineDeck.decks == null)
            {
                MessageManager.Cast(InterString.Get("同步卡组失败。"));
                yield break;
            }

            var deckFiles = Directory.GetFiles(Program.deckPath, "*.ydk");
            var decks = new List<Deck>();
            foreach(var deckPath in deckFiles)
                decks.Add(new Deck(deckPath));

            var decksNeedUpload = new Dictionary<string, Deck>();//没在服务器找到对应的deckId的本地卡组
            var decksNeedUpdateToServer= new Dictionary<string, Deck>();//找到deckId但本地时间大于服务器时间五秒以上的卡组
            var decksNeedUpdateFromServer = new Dictionary<string, Deck>();//找到deckId但本地时间小于服务器时间五秒以上的卡组
            var localFoundedIds = new List<string>();

            for (int i = 0; i < decks.Count; i++)
            {
                var deckName = Path.GetFileNameWithoutExtension(deckFiles[i]);

                if (decks[i].userId != MyCard.account.user.id.ToString())
                {
                    decksNeedUpload.Add(deckName, decks[i]);
                    continue;
                }

                bool deckIdFound = false;
                bool deleted = false;
                foreach(var od in OnlineDeck.decks)
                {
                    if (od.deckId == decks[i].deckId)
                    {
                        if (od.isDelete)
                        {
                            Debug.LogFormat("Deck Delete: [{0}]", deckName);
                            File.Delete(deckFiles[i]);
                            deleted = true;
                        }
                        else
                        {
                            deckIdFound = true;
                            localFoundedIds.Add(od.deckId);
                            var fileInfo = new FileInfo(deckFiles[i]);
                            var serverTime = od.GetUpdateTime();
                            var diff = serverTime - fileInfo.LastWriteTime;
                            //Debug.LogFormat("{0}({1}): {2}-{3}={4}", od.deckName, od.deckId, serverTime, fileInfo.LastWriteTime, diff.TotalSeconds);

                            if (diff.TotalSeconds > 5f || diff.TotalSeconds < -5f)
                            {
                                if (fileInfo.LastWriteTime > serverTime)
                                    decksNeedUpdateToServer.Add(deckName, decks[i]);
                                else
                                    decksNeedUpdateFromServer.Add(deckName, decks[i]);
                            }
                        }
                        break;
                    }
                }
                if (!deckIdFound && !deleted)
                    decksNeedUpload.Add(deckName, decks[i]);
            }

            //上传已经有Id的本地较新卡组
            foreach (var deck in decksNeedUpdateToServer)
            {
                Debug.LogFormat("卡组[{0}]需要更新上传。", deck.Key);

                var task = OnlineDeck.SyncDeck(deck.Value.deckId, deck.Key, deck.Value, false);
                while (!task.IsCompleted)
                    yield return null;
            }
            //更新已经有Id的本地较旧卡组
            foreach (var deck in decksNeedUpdateFromServer)
            {
                Debug.LogFormat("卡组[{0}]需要更新。", deck.Key);

                var od = OnlineDeck.GetByID(deck.Value.deckId);
                var oldPath = Program.deckPath + deck.Key + Program.ydkExpansion;
                if(oldPath != od.deckName)
                    File.Delete(oldPath);
                var newPath = Program.deckPath + od.deckName + Program.ydkExpansion;
                File.WriteAllText(newPath, od.deckYdk);
                File.SetLastWriteTime(newPath, od.GetUpdateTime());
            }

            //上传没有Id的本地卡组
            if(decksNeedUpload.Count > 0)
            {
                var decksToUp = new List<Deck>();
                var deckNames = new List<string>();
                foreach (var deck in decksNeedUpload)
                {
                    var info = string.Format("卡组[{0}]需要上传：{1}。", deck.Key, deck.Value.deckId);
                    Debug.Log(info);

                    deckNames.Add(deck.Key);
                    decksToUp.Add(deck.Value);
                }
                var task2 = OnlineDeck.UploadDecks(decksToUp, deckNames);
                while (!task2.IsCompleted)
                    yield return null;
            }

            //下载本地ID不存在的服务器卡组
            List<OnlineDeck.OnlineDeckData> odtd = new List<OnlineDeck.OnlineDeckData>();
            foreach(var od in OnlineDeck.decks)
                if(!od.isDelete)
                    if (!localFoundedIds.Contains(od.deckId))
                        odtd.Add(od);
            foreach(var deck in odtd)
            {
                Debug.LogFormat("卡组[{0}]需要下载。{1}", deck.deckName, deck.isDelete);

                var d = new Deck(deck.deckYdk, string.Empty, string.Empty);
                d.userId = MyCard.account.user.id.ToString();
                d.deckId = deck.deckId;
                d.Save(deck.deckName, deck.GetUpdateTime());
            }

#if UNITY_EDITOR
            MessageManager.Cast("Deck Sync Finished.");
#endif
        }

        public void SetWatchRooms(List<MyCardRoom> rooms)
        {
            watchListHandler.SetRooms(rooms);
        }
        public void CreateWatchRoom(MyCardRoom room)
        {
            watchListHandler.CreateRoom(room);
        }
        public void UpdateWatchRoom(MyCardRoom room)
        {
            watchListHandler.UpdateRoom(room);
        }
        public void DeleteWatchRoom(string roomId)
        {
            watchListHandler.DeleteRoom(roomId);
        }
        public void ClearWatchList()
        {
            watchListHandler.Clear();
        }

        #endregion
    }
}
