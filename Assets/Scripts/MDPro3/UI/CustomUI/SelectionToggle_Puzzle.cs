using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_Puzzle : SelectionToggle_ScrollRectItem
    {
        public SelectPuzzle.Puzzle puzzle;

        public override void Refresh()
        {
            base.Refresh();
            Manager.GetElement<TextMeshProUGUI>("Title").text = puzzle.name;

            Manager.GetElement("NumBadge").SetActive(!Config.GetBool(Program.puzzlePath + puzzle.name + "_Enter", false));
            Manager.GetElement("TextClear").SetActive(Config.GetBool(Program.puzzlePath + puzzle.name + "_Clear", false));
        }

        protected override IEnumerator RefreshAsync()
        {
            refreshed = false;
            while (TextureManager.container == null)
                yield return null;

            var face = Manager.GetElement<RawImage>("Image");
            face.texture = TextureManager.container.black.texture;
            var task = TextureManager.LoadArtAsync(int.Parse(puzzle.firstCard), true);
            while (!task.IsCompleted)
                yield return null;
            face.texture = task.Result;

            enumerator = null;
            refreshed = true;
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();

            var description = Program.instance.puzzle.Manager.GetElement<TextMeshProUGUI>("TextOverview");
            Program.instance.puzzle.superScrollView.selected = index;
            description.text = puzzle.description + "\r\n" + puzzle.solution;
            description.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            var cardImage = Program.instance.puzzle.Manager.GetElement<RawImage>("CardImage");
            cardImage.texture = Manager.GetElement<RawImage>("Image").texture;
            Program.instance.puzzle.currentPuzzle = Program.puzzlePath + puzzle.name;
            Program.instance.puzzle.lastPuzzleItem = this;
        }

        protected override void CallSubmitEvent()
        {
            base.CallSubmitEvent();
            Program.instance.puzzle.OnStartPuzzle();
        }

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);

            if (eventData.moveDir == MoveDirection.Right)
            {
                UserInput.NextSelectionIsAxis = true;
                EventSystem.current.SetSelectedGameObject(Program.instance.puzzle.Manager.GetElement("ButtonEnter"));
            }
        }
    }
}
