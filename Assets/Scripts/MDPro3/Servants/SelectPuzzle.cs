using MDPro3.UI;
using MDPro3.UI.PropertyOverrider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3
{
    public class SelectPuzzle : Servant
    {
        [Header("Select Puzzle")]
        public Scrollbar leftScrollBar;
        public Scrollbar rightScrollBar;
        public RectTransform rightContent;

        [HideInInspector] public string currentPuzzle;
        [HideInInspector] public SelectionToggle_Puzzle lastPuzzleItem;
        public SuperScrollView superScrollView;
        private List<string[]> tasks = new List<string[]>();
        private List<Puzzle> puzzles;

        #region Servant

        public override void Initialize()
        {
            depth = 1;
            showLine = false;
            returnServant = Program.instance.menu;
            base.Initialize();
            GetPuzzles();
            Print();

            StartCoroutine(Program.instance.texture_.SetCommonShopButtonMaterial(Manager.GetElement<Image>("ButtonOut"), false));
            StartCoroutine(Program.instance.texture_.SetCommonShopButtonMaterial(Manager.GetElement<Image>("ButtonHover"), true));
        }

        protected override void ApplyShowArrangement(int preDepth)
        {
            base.ApplyShowArrangement(preDepth);
            RefreshItems();
        }

        public override void SelectLastSelectable()
        {
            EventSystem.current.SetSelectedGameObject(lastPuzzleItem.gameObject);
        }

        public override void PerFrameFunction()
        {
            if(!showing) return;
            if(NeedResponseInput())
            {
                if (UserInput.MouseRightDown || UserInput.WasCancelPressed)
                    OnReturn();
                if(UserInput.LeftScrollWheel.y != 0f)
                    leftScrollBar.value = Mathf.Clamp01(leftScrollBar.value + UserInput.LeftScrollWheel.y * 2f * Time.unscaledDeltaTime);
                if (UserInput.RightScrollWheel.y != 0f)
                {
                    var rightWheelHeight = rightContent.rect.height;
                    rightScrollBar.value = Mathf.Clamp01(rightScrollBar.value + UserInput.RightScrollWheel.y * 500f * Time.unscaledDeltaTime / rightWheelHeight);
                }
            }
        }

        public override void OnExit()
        {
            if(Program.exitOnReturn)
                Program.GameQuit();
            else
                Program.instance.ShiftToServant(returnServant);
        }

        #endregion

        private IEnumerator SelectZero()
        {
            if(superScrollView == null || superScrollView.items.Count == 0)
                yield break;

            var item0 = superScrollView.items[0].gameObject.GetComponent<SelectionToggle_Puzzle>();
            while (!item0.refreshed)
                yield return null;
            item0.SetToggleOn();
            yield return new WaitForSecondsRealtime(2f);
            if (!showing)
                transform.GetChild(0).gameObject.SetActive(false);
        }

        public struct Puzzle
        {
            public string name;
            public string firstCard;
            public string description;
            public string solution;
        }

        void GetPuzzles()
        {
            puzzles = new List<Puzzle>();
            if (!Directory.Exists(Program.puzzlePath))
                Directory.CreateDirectory(Program.puzzlePath);
            FileInfo[] fileInfos = new DirectoryInfo(Program.puzzlePath).GetFiles("*.lua");
            foreach (FileInfo fileInfo in fileInfos)
            {
                string text = File.ReadAllText(fileInfo.FullName);
                string st = text.Replace("\r", "");
                string[] lines = st.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                string card = "0";
                int messageStart = 0;
                int messageEnd = 0;
                int solutionStart = 0;
                int solutionEnd = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("Debug.AddCard(") && card == "0")
                        card = lines[i].Replace("Debug.AddCard(", "").Split(',')[0];
                    else if (lines[i].StartsWith("--[[message"))
                        messageStart = i + 1;
                    else if (lines[i].StartsWith("Solution:"))
                        solutionStart = i;
                    else if (lines[i].StartsWith("]]"))
                    {
                        if (messageEnd == 0)
                            messageEnd = i;
                        else
                            solutionEnd = i;
                    }
                }
                string description = "";
                string solution = "";
                if (messageStart != 0 && messageEnd != 0)
                    for (int i = messageStart; i < messageEnd; i++)
                        description += lines[i] + "\r\n";
                if (solutionStart != 0 && solutionEnd != 0)
                    for (int i = solutionStart; i < solutionEnd; i++)
                        solution += lines[i] + "\r\n";
                description = description.Replace("\r\n\t\r\n\t", "\r\n\t");
                Puzzle puzzle = new Puzzle
                {
                    name = fileInfo.Name.Replace(".lua", ""),
                    firstCard = card,
                    description = description,
                    solution = solution,
                };
                puzzles.Add(puzzle);
            }
        }

        public void Print()
        {
            superScrollView?.Clear();
            tasks.Clear();
            transform.GetChild(0).gameObject.SetActive(true);

            for (int i = 0; i < puzzles.Count; i++)
            {
                string[] task = new string[]
                {
                i.ToString(),
                puzzles[i].name,
                puzzles[i].firstCard,
                puzzles[i].description,
                puzzles[i].solution
                };
                tasks.Add(task);
            }
            var handle = Addressables.LoadAssetAsync<GameObject>("ItemPuzzle");
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
                StartCoroutine(SelectZero());
            };
        }

        void ItemOnListRefresh(string[] task, GameObject item)
        {
            var handler = item.GetComponent<SelectionToggle_Puzzle>();
            Puzzle puzzle = new()
            {
                name = task[1],
                firstCard = task[2],
                description = task[3],
                solution = task[4],
            };
            handler.puzzle = puzzle;
            handler.Refresh();
        }
        private PercyOCG percy;

        public void OnStartPuzzle()
        {
            StartPuzzle(currentPuzzle);
        }
        public void StartPuzzle(string puzzle)
        {
            if (percy != null)
                percy.Dispose();
            percy = new PercyOCG();
            percy.StartPuzzle(puzzle + ".lua");
        }

        private void RefreshItems()
        {
            var scrollRect = Manager.GetElement<ScrollRect>("ScrollRect");
            for (int i = 0; i < scrollRect.content.childCount; i++)
                scrollRect.content.GetChild(i).GetComponent<SelectionToggle_Puzzle>().Refresh();
        }

        public void SelectLastPuzzleItem()
        {
            UserInput.NextSelectionIsAxis = true;
            SelectLastSelectable();
        }
    }
}
