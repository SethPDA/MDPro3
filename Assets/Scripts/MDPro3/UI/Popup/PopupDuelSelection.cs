using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI 
{
    public class PopupDuelSelection : PopupDuel
    {
        [Header("Popup Duel Select Reference")]
        public ScrollRect scrollRect;
        public GameObject item;
        public RectTransform baseRect;
        public List<int> responses;

        public override void InitializeSelections()
        {
            base.InitializeSelections();
            Program.instance.currentServant.returnAction = null;
            for (int i = 1; i < selections.Count; i++)
            {
                GameObject newSelection = Instantiate(item);
                newSelection.transform.SetParent(scrollRect.content, false);
                newSelection.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = selections[i];
                newSelection.transform.GetChild(0).name = responses[i - 1].ToString();
                newSelection.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                {
                    string selected = UnityEngine.EventSystems.EventSystem.current.
                        currentSelectedGameObject.name;
                    if (selected != "-233")
                    {
                        var binaryMaster = new BinaryMaster();
                        binaryMaster.writer.Write(int.Parse(selected));
                        Program.instance.ocgcore.SendReturn(binaryMaster.Get());
                    }
                    Hide();
                });
                newSelection.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -20 - 90 * (i - 1));
            }
            scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x, 25 + (selections.Count - 1) * 90);
            baseRect.sizeDelta = new Vector2(baseRect.sizeDelta.x,
                scrollRect.content.sizeDelta.y + 50 > 800 ?
                800 :
                scrollRect.content.sizeDelta.y + 50
                );
        }
    }

}

