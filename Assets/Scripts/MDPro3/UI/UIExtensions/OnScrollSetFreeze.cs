using System.Collections;
using UnityEngine;

public class OnScrollSetFreeze : MonoBehaviour
{
    public static bool Freeze;

    private Coroutine coroutine;
    public void SetFreeze()
    {
        if(coroutine != null)
            StopCoroutine(coroutine);
        coroutine = StartCoroutine(SetFreezeAsync());
    }

    private IEnumerator SetFreezeAsync()
    {
        Freeze = true;
        yield return null;
        yield return null;
        Freeze = false;
    }
}
