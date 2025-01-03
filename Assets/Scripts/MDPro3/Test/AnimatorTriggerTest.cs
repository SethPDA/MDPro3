using UnityEngine;

public class AnimatorTriggerTest : MonoBehaviour
{
    public string trigger;
    public bool test;

    private void Update()
    {
        if (test)
        {
            test = false;
            Test();
        }
    }

    void Test()
    {
        var controller = GetComponent<Animator>();
        if(controller != null)
        {
            controller.SetTrigger(trigger);
        }
    }
}
