using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using MDPro3.YGOSharp;
using MDPro3.UI;
using MDPro3.UI.PropertyOverrider;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine.EventSystems;

namespace MDPro3
{
    public class MateView : Servant
    {
        [Header("MateView")]
        public TMP_InputField inputField;

        static List<int> crossDuelMates = new List<int>();
        static List<Card> cards = new List<Card>();
        List<string[]> tasks = new List<string[]>();

        public SuperScrollView superScrollView;
        [HideInInspector] public SelectionToggle_Mate lastSelectedMateItem;
        Camera targetCamera;

        static Mate mate;

        Vector2 clickInPosition;
        Vector3 mateAngel;
        Vector3 matePosition;
        float oSize;
        float clickInTime;
        bool clickInLeft;
        bool clickInRight;

        #region Servant
        public override void Initialize()
        {
            depth = 1;
            showLine = false;
            returnServant = Program.instance.menu;
            base.Initialize();
            targetCamera = Program.instance.camera_.cameraDuelOverlay2D;
            inputField.onEndEdit.AddListener(Print);
#if UNITY_ANDROID
            var files = Directory.GetFiles(Program.root + "CrossDuel", "*.bundle");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Replace(".bundle", "");
                crossDuelMates.Add(int.Parse(fileName));
            }
#endif
            Load();
            LoadSeData();
        }
        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            Program.instance.camera_.light.gameObject.SetActive(true);
            Program.instance.camera_.light.transform.GetChild(0).localEulerAngles = new Vector3(123f, -28f, -40f);
            Program.instance.camera_.light.transform.GetChild(1).localEulerAngles = new Vector3(-80f, -140f, 0f);
            CameraManager.DuelOverlay2DPlus();
            CameraReset();
            AudioManager.PlayBGM("BGM_OUT_TUTORIAL_2", 0.5f);
            UserInput.SetMoveRepeatRate(0.05f);
        }
        protected override void ApplyHideArrangement(int preDepth)
        {
            base.ApplyHideArrangement(preDepth);
            CameraManager.DuelOverlay2DMinus();
            Program.instance.camera_.light.gameObject.SetActive(false);
            Program.instance.camera_.light.transform.GetChild(0).localEulerAngles = new Vector3(96f, -28f, -40f);
            Program.instance.camera_.light.transform.GetChild(1).localEulerAngles = new Vector3(-15f, -45f, 0f);
            if (mate != null)
                Destroy(mate.gameObject);
            AudioManager.ResetSESource();
            AudioManager.PlaySE("SE_MENU_CANCEL");
            AudioManager.PlayBGM("BGM_MENU_01");
            UserInput.SetMoveRepeatRate(0.1f);
        }
        public override void PerFrameFunction()
        {
            if (!showing) return;
            if(NeedResponseInput())
            {
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();
                if (UserInput.WasGamepadButtonWestPressed)
                    inputField.ActivateInputField();
                if (mate == null)
                    return;

                if (UserInput.WasGamepadButtonNorthPressed)
                    OnMateTap();

                var leftOffset = (PropertyOverrider.NeedMobileLayout() ? 532f : 432f) * Screen.height / 1080f;

                if (UserInput.MouseLeftDown && UserInput.MousePos.x > leftOffset)
                {
                    var widthOffset = Screen.width - leftOffset;

                    if (UserInput.MousePos.x > leftOffset + widthOffset / 2f)
                    {
                        clickInRight = true;
                        clickInTime = Time.time;
                        mateAngel = mate.transform.eulerAngles;
                        clickInPosition = UserInput.MousePos;
                        oSize = targetCamera.orthographicSize;
                    }
                    else
                    {
                        clickInLeft = true;
                        clickInTime = Time.time;
                        clickInPosition = UserInput.MousePos;
                        matePosition = mate.transform.position;
                    }
                }
                if (UserInput.MouseLeftPressing && clickInLeft)
                {
                    var x = matePosition.x + (clickInPosition.x - UserInput.MousePos.x) * 0.01f;
                    var y = matePosition.y + (UserInput.MousePos.y - clickInPosition.y) * 0.02f;
                    if (x > 10) x = 10;
                    if (x < -10) x = -10;
                    if (y > 0) y = 0;
                    if (y < -20) y = -20;
                    mate.transform.position = new Vector3(x, y, matePosition.z);
                }
                if (UserInput.MouseLeftPressing && clickInRight)
                {
                    mate.transform.eulerAngles = mateAngel +
                        new Vector3(0, (clickInPosition.x - UserInput.MousePos.x) * 0.2f, 0);
                    var size = oSize + (clickInPosition.y - UserInput.MousePos.y) * 0.01f;
                    if (size < 5) size = 5;
                    if (size > 20) size = 20;
                    targetCamera.orthographicSize = size;
                    targetCamera.transform.localPosition = new Vector3(0, size * 0.95f, 200);
                }
                if (UserInput.MouseLeftUp && (clickInLeft || clickInRight))
                {
                    clickInLeft = false;
                    clickInRight = false;
                    if ((Time.time - clickInTime) < 0.2f)
                    {
                        mate.Play(Mate.MateAction.Tap);
                        mate.ActiveCamera(Mate.MateAction.Tap, targetCamera.gameObject.layer);
                    }
                }

                if(UserInput.LeftScrollWheel != Vector2.zero)
                {
                    var x = mate.transform.position.x - UserInput.LeftScrollWheel.x * Time.unscaledDeltaTime * 50f;
                    if (x > 10) x = 10f;
                    if (x < -10) x = -10;
                    var y = mate.transform.position.y + UserInput.LeftScrollWheel.y * Time.unscaledDeltaTime * 50f;
                    if (y > 0) y = 0;
                    if (y < -20) y = -20;
                    mate.transform.position = new Vector3(x, y, mate.transform.position.z);
                }
                if(UserInput.RightScrollWheel != Vector2.zero)
                {
                    var x = UserInput.RightScrollWheel.x * Time.unscaledDeltaTime * 200f;
                    mate.transform.Rotate(Vector3.up, -x);

                    if(Mathf.Abs( UserInput.RightScrollWheel.y) > 0.3f)
                    {
                        var size = targetCamera.orthographicSize - UserInput.RightScrollWheel.y * Time.unscaledDeltaTime * 30f;
                        if (size < 5) size = 5;
                        if (size > 20) size = 20;
                        targetCamera.orthographicSize = size;
                        targetCamera.transform.localPosition = new Vector3(0, size * 0.95f, 200);
                    }
                }
            }
        }
        protected override bool NeedResponseInput()
        {
            if (inputField.isFocused)
                return false;
            return base.NeedResponseInput();
        }
        public override void SelectLastSelectable()
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedMateItem.gameObject);
        }
        #endregion

        public void SelectLastMateItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelectable();
        }
        public void Load()
        {
            cards.Clear();
            for (int i = 0; i < crossDuelMates.Count; i++)
            {
                var card = CardsManager.Get(crossDuelMates[i], true);
                if (card.Id == 0)
                {
                    card.Id = crossDuelMates[i];
                    card.Name = GetRushDuelMateName(crossDuelMates[i]);
                }
                cards.Add(card);
            }
            cards.Sort(CardsManager.ComparisonOfCard());
            DOTween.To(v => { }, 0, 0, 0.1f).OnComplete(() =>
            {

            });
            Print();
        }
        public void Print(string search = "")
        {
            superScrollView?.Clear();
            tasks.Clear();
            foreach (var card in cards)
            {
                if (card.Name.Contains(search))
                {
                    string[] task = new string[] { card.Id.ToString(), card.Name };
                    tasks.Add(task);
                }
            }
            foreach (var mate in Program.items.mates)
            {
                if ((!string.IsNullOrEmpty(mate.name) && mate.name.Contains(search)))
                {
                    string[] task = new string[] { mate.id.ToString(), mate.name };
                    tasks.Add(task);
                }
            }
            var handle = Addressables.LoadAssetAsync<GameObject>("ItemMate");
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
                    Manager.GetElement<ScrollRect>("ScrollRect"),
                    4);
                superScrollView.Print(tasks);
                if (superScrollView.items.Count > 0)
                    lastSelectedMateItem = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Mate>();
                if (showing)
                {
                    if (Cursor.lockState == CursorLockMode.Locked)
                        SelectLastSelectable();
                }
                else
                    transform.GetChild(0).gameObject.SetActive(false);
            };
        }

        public void OnMateTap()
        {
            if (mate == null)
                return;
            mate.Play(Mate.MateAction.Tap);
        }

        void CameraReset()
        {
            targetCamera.transform.localPosition =
                new Vector3(0, 20 * 0.95f, 200);
            targetCamera.transform.localEulerAngles =
                new Vector3(0, 180, 0);
            targetCamera.orthographicSize = 20;
        }

        public void ViewMate(int code)
        {
            if (mate != null)
            {
                if (mate.code == code)
                    return;
                else
                    Destroy(mate.gameObject);
            }
            StartCoroutine(LoadMateAsync(code));
        }

        IEnumerator LoadMateAsync(int code)
        {
            var ie = ABLoader.LoadMateAsync(code);
            StartCoroutine(ie);
            while (ie.MoveNext())
                yield return null;
            mate = ie.Current;
            Tools.ChangeLayer(mate.gameObject, targetCamera.gameObject.layer);
            yield return new WaitForSeconds(0.1f);
            AudioManager.ResetSESource();
            mate.gameObject.SetActive(true);
            mate.Play(Mate.MateAction.Entry);
            mate.ActiveCamera(Mate.MateAction.Entry, targetCamera.gameObject.layer);
            CameraReset();
        }

        void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Mate>();
            handler.code = int.Parse(task[0]);
            handler.mateName = task[1];
            handler.Refresh();
        }

        public static string GetRushDuelMateName(int code)
        {
            switch (code)
            {
                case 120105001:
                    return InterString.Get("七星道魔术师");
                case 120105010:
                    return InterString.Get("落单使魔");
                case 120110001:
                    return InterString.Get("连击龙 齿车戒龙");
                case 120110006:
                    return InterString.Get("双刃龙");
                case 120110010:
                    return InterString.Get("掌上小龙");
                case 120115001:
                    return InterString.Get("七星道魔女");
                case 120120018:
                    return InterString.Get("耳语妖精");
                case 120120025:
                    return InterString.Get("龙队翻盘击球手");
                case 120120024:
                    return InterString.Get("龙队布局投球手");
                case 120120029:
                    return InterString.Get("魔将 雅灭鲁拉");
                case 120120003:
                    return InterString.Get("古之守护龟");
                case 120130016:
                    return InterString.Get("七星道法师");
                case 120130026:
                    return InterString.Get("斗将 难得斯");
                case 120140023:
                    return InterString.Get("王家魔族·骨肉皮");
                case 120145014:
                    return InterString.Get("火星心少女");
                case 120150002:
                    return InterString.Get("超魔机神 大霸道王");
                case 120155019:
                    return InterString.Get("祭神 莫多丽娜");
                default:
                    return string.Empty;
            }
        }


        #region CrossDuel Se Label Data
        public struct CrossDuelSeLabelData
        {
            public string name;
            public string label1;
            public float start1;
            public string label2;
            public float start2;
            public string label3;
            public float start3;
        }
        static List<CrossDuelSeLabelData> cdSeData = new List<CrossDuelSeLabelData>();

        void LoadSeData()
        {
            var handle = Addressables.LoadAssetAsync<TextAsset>("EffectSeLabelData");
            handle.Completed += (result) =>
            {
                var content = handle.Result.text;
                var lines = Regex.Split(content, "\r\n");
                for(int i = 1; i < lines.Length; i++)
                {
                    var splits = lines[i].Split(',');
                    if (splits.Length == 7)
                    {
                        var seData = new CrossDuelSeLabelData();
                        seData.name = splits[0];
                        seData.label1 = splits[1];
                        if (string.IsNullOrEmpty(splits[2]))
                            seData.start1 = 0;
                        else
                            seData.start1 = float.Parse(splits[2]);
                        seData.label2 = splits[3];
                        if (string.IsNullOrEmpty(splits[4]))
                            seData.start2 = 0;
                        else
                            seData.start2 = float.Parse(splits[4]);
                        seData.label3 = splits[5];
                        if (string.IsNullOrEmpty(splits[6]))
                            seData.start3 = 0;
                        else
                            seData.start3 = float.Parse(splits[6]);
                        cdSeData.Add(seData);
                    }
                }
            };
        }

        public static void PlayCrossDuelSe(string name)
        {
            CrossDuelSeLabelData data = new CrossDuelSeLabelData();
            bool found = false;
            foreach(var seData in cdSeData)
                if (seData.name == name)
                {
                    data = seData;
                    found = true;
                }
            if (!found)
                return;
            if (!string.IsNullOrEmpty(data.label1))
            {
                DOTween.To(v => { }, 0, 0, data.start1).OnComplete(() =>
                {
                    AudioManager.PlaySE(data.label1.ToUpper());
                });
            }
            if (!string.IsNullOrEmpty(data.label2))
            {
                DOTween.To(v => { }, 0, 0, data.start2).OnComplete(() =>
                {
                    AudioManager.PlaySE(data.label2.ToUpper());
                });
            }
            if (!string.IsNullOrEmpty(data.label3))
            {
                DOTween.To(v => { }, 0, 0, data.start3).OnComplete(() =>
                {
                    AudioManager.PlaySE(data.label3.ToUpper());
                });
            }
        }

        #endregion
    }
}
