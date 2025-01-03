using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public interface IFadeSupported
	{
		Color FadeColor(ViewController.TransitionType type);

		SystemProgress.ProgressType FadeType(ViewController.TransitionType type);
	}
}
