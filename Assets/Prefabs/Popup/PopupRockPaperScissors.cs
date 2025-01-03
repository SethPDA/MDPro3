using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.Popup
{
    public class PopupRockPaperScissors : Popup
    {

        protected override void Initialize()
        {
            base.Initialize();
            cancelCallHide = false;
            Manager.GetElement<Button>("RockButton").onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(2); Hide(); });
            Manager.GetElement<Button>("PaperButton").onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(3); Hide(); });
            Manager.GetElement<Button>("ScissorsButton").onClick.AddListener(() => { TcpHelper.CtosMessage_HandResult(1); Hide(); });
        }

        private void Start()
        {
            StartCoroutine(LoadAsync());
        }

        private IEnumerator LoadAsync()
        {
            var task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Rock.png");
            while (!task.IsCompleted)
                yield return null;
            if (task.Result != null)
            {
                var rock = Manager.GetElement<RawImage>("RockButton");
                rock.texture = task.Result;
                rock.color = Color.white;
            }

            task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Paper.png");
            while (!task.IsCompleted)
                yield return null;
            if (task.Result != null)
            {
                var paper = Manager.GetElement<RawImage>("PaperButton");
                paper.texture = task.Result;
                paper.color = Color.white;
            }

            task = TextureManager.LoadPicFromFileAsync(Program.diyPath + "Scissors.png");
            while (!task.IsCompleted)
                yield return null;
            if (task.Result != null)
            {
                var scissors = Manager.GetElement<RawImage>("ScissorsButton");
                scissors.texture = task.Result;
                scissors.color = Color.white;
            }
        }
    }
}

