using System;
using System.Threading.Tasks;
using UnityEngine;


namespace MDPro3.Utility
{
    public static class TaskUtility
    {
        private static readonly int DeltaTime = 16;

        public static async Task WaitWhile(Func<bool> condition)
        {
            while(condition() && Application.isPlaying)
            {
                await Task.Delay(DeltaTime);
            }
        }

        public static async Task WaitUntil(Func<bool> condition)
        {
            while (!condition() && Application.isPlaying)
            {
                await Task.Delay(DeltaTime);
            }
        }

        public static async Task WaitOneFrame()
        {
            await Task.Delay(DeltaTime);
        }
    }
}
