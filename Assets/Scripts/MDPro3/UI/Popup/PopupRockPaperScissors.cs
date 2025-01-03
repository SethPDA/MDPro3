using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI 
{
    public class PopupRockPaperScissors : PopupBase
    {
        [Header("Popup Rock Paper Scissors Reference")]
        public Button rock;
        public Button paper;
        public Button scissors;

        private void Start()
        {
            rock.onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(2); Hide(); });
            paper.onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(3); Hide(); });
            scissors.onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(1); Hide(); });
            StartCoroutine(LoadAsync());
        }

        IEnumerator LoadAsync()
        {
            var task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Rock.png");
            while(!task.IsCompleted)
                yield return null;
            rock.GetComponent<RawImage>().texture = task.Result;
            rock.GetComponent<RawImage>().color = Color.white;

            task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Paper.png");
            while (!task.IsCompleted)
                yield return null;
            paper.GetComponent<RawImage>().texture = task.Result;
            paper.GetComponent<RawImage>().color = Color.white;

            task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Scissors.png");
            while (!task.IsCompleted)
                yield return null;
            scissors.GetComponent<RawImage>().texture = task.Result;
            scissors.GetComponent<RawImage>().color = Color.white;
        }
    }
}

